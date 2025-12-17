open Fake
open Fake.Core
open Fake.IO
open Fake.IO.FileSystemOperators
open Fake.IO.Globbing.Operators
open Fake.Core.TargetOperators
open Fake.DotNet
open System
open System.IO

open BuildHelpers
open BuildTools

initializeContext()

let publishPath = Path.getFullName "publish"
let srcPath = Path.getFullName "src"
let docsSrcPath = srcPath </> "Docs"
let librarySrcPath = srcPath </> "Feliz.Tailwind"
let appPublishPath = publishPath </> "app"
let buildDir = Path.getFullName "build"

// --------------------------------------------------------------------------------------
// Information about the project to be used at NuGet and in AssemblyInfo files
// --------------------------------------------------------------------------------------

let release = ReleaseNotes.load "RELEASE_NOTES.md"

// Git configuration (used for publishing documentation in gh-pages branch)
let gitHome = "https://github.com/tforkmann"
let gitName = "Feliz.Tailwind"

let projectName = "Feliz.Tailwind"

// Targets
let clean proj = [ proj </> "bin"; proj </> "obj" ] |> Shell.cleanDirs

Target.create "Clean" (fun _ ->
    !!"src/**/bin"
    |> Shell.cleanDirs
    !! "src/**/obj/*.nuspec"
    |> Shell.cleanDirs
    Shell.cleanDirs [buildDir; "temp"; "docs/output"; publishPath]
)

Target.create "InstallClient" (fun _ ->
    printfn "Node version:"
    Tools.node "--version" "."
    printfn "Npm version:"
    Tools.npm "--version" "."
    Tools.npm "install" "."
)

Target.create "Build" (fun _ ->
    Tools.dotnet "build -c Release" "src/Feliz.Tailwind"
)

Target.create "Pack" (fun _ ->
    let nugetVersion = release.NugetVersion
    let releaseNotes = (String.toLines release.Notes).Replace(",","").Replace("\"", "\\\"")

    let packCmd = sprintf "pack -c Release -o %s /p:PackageVersion=%s /p:PackageReleaseNotes=\"%s\""
                    buildDir nugetVersion releaseNotes

    Tools.dotnet packCmd "src/Feliz.Tailwind"
)

let getBuildParam = Environment.environVar
let isNullOrWhiteSpace = String.IsNullOrWhiteSpace

let pushPackage _ =
    let nugetCmd fileName key = sprintf "nuget push %s -k %s -s nuget.org" fileName key
    let key =
        match getBuildParam "nugetkey" with
        | s when not (isNullOrWhiteSpace s) -> s
        | _ -> UserInput.getUserPassword "NuGet Key: "
    IO.Directory.GetFiles(buildDir, "*.nupkg", SearchOption.TopDirectoryOnly)
    |> Seq.map Path.GetFileName
    |> Seq.iter (fun fileName ->
        Trace.tracef "fileName %s" fileName
        let cmd = nugetCmd fileName key
        Tools.dotnet cmd buildDir)

Target.create "Push" (fun _ -> pushPackage [] )

Target.create "PublishDocs" (fun _ ->
    Tools.npm "run build" ""
)

Target.create "RunDocs" (fun _ ->
    Tools.npm "run start" "")

let dependencies = [
    "Clean"
        ==> "InstallClient"
        ==> "Build"
        ==> "Pack"
        ==> "Push"

    "InstallClient"
        ==> "PublishDocs"

    "InstallClient"
        ==> "RunDocs"
]

[<EntryPoint>]
let main args = runOrDefault "RunDocs" args
