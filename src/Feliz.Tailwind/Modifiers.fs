namespace Feliz.Tailwind

open Feliz
open Fable.Core

[<Erase>]
type backgroundColor =
    static member inline bgWhite = prop.className "bg-white"
    static member inline bgSlate100 = prop.className "bg-slate-100"
    static member inline bgYellow500 = prop.className "bg-yellow-500"
    static member inline bgGreen100 = prop.className "bg-green-900"

[<Erase>]
type borderRadius =
    /// Border Radius with `rounded-none`
    static member inline roundedNone = prop.className "rounded-none"
    /// Border Radius with `rounded-sm`
    static member inline roundedSm = prop.className "rounded-sm"
    /// Border Radius with `rounded`
    static member inline rounded = prop.className "rounded"
    /// Border Radius with `rounded-md`
    static member inline roundedMd = prop.className "rounded-md"
    /// Border Radius with `rounded-lg`
    static member inline roundedLg = prop.className "rounded-lg"
    /// Border Radius with `rounded-xl`
    static member inline roundedXl = prop.className "rounded-xl"
    /// Border Radius with `rounded-2xl`
    static member inline rounded2Xl = prop.className "rounded-2xl"
    /// Border Radius with `rounded-3xl`
    static member inline rounded3Xl = prop.className "rounded-3xl"
[<Erase>]
type borderWidth =
    /// Border Width with `border-r`
    static member inline borderR = prop.className "border-r"
    /// Border Width with `border-l`
    static member inline borderL = prop.className "border-l"
    /// Border Width with `border-t`
    static member inline borderT = prop.className "border-t"
    /// Border Width with `border-b`
    static member inline borderB = prop.className "border-b"

[<Erase>]
type boxShadow =
    /// Box Shadow with `shadow`
    static member inline shadow = prop.className "shadow"
    /// Box Shadow with `shadow-md`
    static member inline shadowMd = prop.className "shadow-md"
    /// Box Shadow with `shadow-none`
    static member inline shadowNone = prop.className "shadow-none"
[<Erase>]
type display =
    /// Display box with `block`
    static member inline block = prop.className "block"
    /// Display box with `inline-block`
    static member inline inlineBlock = prop.className "inline-block"
    /// Display box with `inline`
    static member inline inline' = prop.className "inline"
    /// Display box with `flex`
    static member inline flex = prop.className "flex"

[<Erase>]
type flex =
    static member inline flex1 = prop.className "flex-1"
    static member inline flexAuto = prop.className "flex-auto"
    static member inline flexInitial = prop.className "flex-initial"
    static member inline flexNone = prop.className "flex-none"

[<Erase>]
type flexDirection =
    static member inline flexRow = prop.className "flex-row"
    static member inline flexRowReserve = prop.className "flex-row-reserve"
    static member inline flexCol = prop.className "flex-col"
    static member inline flexColReserve = prop.className "flex-col-reserve"

[<Erase>]
type fontSize =
    static member inline textXs = prop.className "text-xs"
    static member inline text3Xl = prop.className "text-3xl"
    static member inline text5Xl = prop.className "text-5xl"

[<Erase>]
type fontWeight =
    static member inline fontThin = prop.className "font-thin"
    static member inline fontExtraLight = prop.className "font-extralight"
    static member inline fontLight = prop.className "font-light"
    static member inline fontNormal = prop.className "font-normal"
    static member inline fontMedium = prop.className "font-medium"
    static member inline fontSemibold = prop.className "font-semibold"
    static member inline fontBold = prop.className "font-bold"
    static member inline fontExtraBold = prop.className "font-extrabold"
    static member inline fontBlack = prop.className "font-black"

[<Erase>]
type height =
    static member inline h0 = prop.className "h-0"
    static member inline hFull = prop.className "h-full"
    static member inline hScreen = prop.className "h-screen"

[<Erase>]
type justifyContent =
    static member inline justifyStart = prop.className "justify-start"
    static member inline justifyEnd = prop.className "justify-end"
    static member inline justifyCenter = prop.className "justify-center"
    static member inline justifyBetween = prop.className "justify-between"
    static member inline justifyAround = prop.className "justify-around"
    static member inline justifyEvenly = prop.className "justify-evenly"

[<Erase>]
type margin =
    /// Margin bottom `mb-2` 0.5 rem
    static member inline mb2 = prop.className "mb-2"
    /// Margin top `my-6` 1.5 rem bottom 1.5 rem
    static member inline my6 = prop.className "my-6"
    /// Margin left `ml-2` 0.5 rem
    static member inline ml2 = prop.className "ml-2"

[<Erase>]
type maxWidth =
    static member inline w0 = prop.className "max-w-0"
    static member inline wNone = prop.className "max-w-none"
    static member inline wXs = prop.className "max-w-xs"
    static member inline wSm = prop.className "max-w-sm"
    static member inline wMm = prop.className "max-w-md"
    static member inline wLg = prop.className "max-w-lg"
    static member inline wXl = prop.className "max-w-xl"
    static member inline w2Xl = prop.className "max-w-2xl"
    static member inline w3Xl = prop.className "max-w-3xl"
    static member inline w4Xl = prop.className "max-w-4xl"
    static member inline w5Xl = prop.className "max-w-5xl"
    static member inline w6Xl = prop.className "max-w-6xl"
    static member inline w7Xl = prop.className "max-w-7xl"
    static member inline wFull = prop.className "max-w-full"
    static member inline wMin = prop.className "max-w-min"
    static member inline wMax = prop.className "max-w-max"
    static member inline wFit = prop.className "max-w-fit"
    static member inline wProse = prop.className "max-w-prose"
    static member inline wScreenSm = prop.className "max-w-screen-sm"
    static member inline wScreenMd = prop.className "max-w-screen-md"
    static member inline wScreenLg = prop.className "max-w-screen-lg"
    static member inline wScreenXl = prop.className "max-w-screen-xl"
    static member inline wScreen2Xl = prop.className "max-w-screen-2xl"

[<Erase>]
type outline =
    /// Outline `outline-none`
    static member inline outlineNone = prop.className "outline-none"
    /// Outline `outline`
    static member inline outline = prop.className "outline"
    /// Outline `outline-dashed`
    static member inline outlineDashed = prop.className "outline-dashed"
    /// Outline `outline-dotted`
    static member inline outlineDotted = prop.className "outline-dotted"
    /// Outline `outline-double`
    static member inline outlineDouble = prop.className "outline-double"



[<Erase>]
type textColor =
    /// Text color `text-black`
    static member inline black = prop.className "text-black"
    /// Text color `text-blue-600`
    static member inline blue600 = prop.className "text-blue-600"
    /// Text color `text-neutral-50`
    static member inline neutral50 = prop.className "text-neutral-50"



[<Erase>]
type padding =
    /// Padding with `p-0`
    static member inline p0 = prop.className "p-0"
    /// Padding with `p-1`
    static member inline p1 = prop.className "p-1"
    /// Padding with `p-2`
    static member inline p2 = prop.className "p-2"
    /// Padding with `p-3`
    static member inline p3 = prop.className "p-3"
    /// Padding with `p-4`
    static member inline p4 = prop.className "p-4"
    /// Padding with `pt-0`
    static member inline pt0 = prop.className "pt-0"
    /// Padding with `pt-1`
    static member inline pt1 = prop.className "pt-1"
    /// Padding with `pt-2`
    static member inline pt2 = prop.className "pt-2"
    /// Padding with `pt-3`
    static member inline pt3 = prop.className "pt-3"
    /// Padding with `pt-4`
    static member inline pt4 = prop.className "pt-4"
    /// Padding with `pb-2`
    static member inline pb2 = prop.className "pb-2"
    /// Padding with `px-1`
    static member inline px1 = prop.className "px-1"
    /// Padding with `px-2`
    static member inline px2 = prop.className "px-2"
    /// Padding with `px-3`
    static member inline px3 = prop.className "px-3"
    /// Padding with `px-4`
    static member inline px4 = prop.className "px-4"
    /// Padding with `px-5`
    static member inline px5 = prop.className "px-5"
    /// Padding with `py-1`
    static member inline py1 = prop.className "py-1"
    /// Padding with `py-2`
    static member inline py2 = prop.className "py-2"
    /// Padding with `py-3`
    static member inline py3 = prop.className "py-3"
    /// Padding with `py-4`
    static member inline py4 = prop.className "py-4"
    /// Padding with `py-5`
    static member inline py5 = prop.className "py-5"

[<Erase>]
type postion =
    /// Position with `absolute`
    static member inline absolute = prop.className "absolute"
    /// Position with `relative`
    static member inline relative = prop.className "relative"
    /// Position with `sticky`
    static member inline sticky = prop.className "sticky"


[<Erase>]
type width =
    static member inline w0 = prop.className "w-0"
    static member inline w1 = prop.className "w-1"
    static member inline w2 = prop.className "w-2"
    static member inline w3 = prop.className "w-3"
    static member inline w4 = prop.className "w-4"
    static member inline w5 = prop.className "w-5"
    static member inline w6 = prop.className "w-6"
    static member inline w7 = prop.className "w-7"
    static member inline w8 = prop.className "w-8"
    static member inline w9 = prop.className "w-9"
    static member inline w10 = prop.className "w-10"
    static member inline w11 = prop.className "w-11"
    static member inline w12 = prop.className "w-12"
    static member inline w14 = prop.className "w-14"
    static member inline w16 = prop.className "w-16"
    static member inline w20 = prop.className "w-20"
    static member inline w24 = prop.className "w-24"
    static member inline w28 = prop.className "w-28"
    static member inline w32 = prop.className "w-32"
    static member inline w36 = prop.className "w-36"
    static member inline w40 = prop.className "w-40"
    static member inline w44 = prop.className "w-44"
    static member inline w48 = prop.className "w-48"
    static member inline w52 = prop.className "w-52"
    static member inline w56 = prop.className "w-56"
    static member inline w60 = prop.className "w-60"
    static member inline w64 = prop.className "w-64"
    static member inline w72 = prop.className "w-72"
    static member inline w80 = prop.className "w-80"
    static member inline w92 = prop.className "w-92"
    static member inline wAuto = prop.className "w-auto"
    static member inline wMin = prop.className "w-min"
    static member inline wMax = prop.className "w-max"
    static member inline wFit = prop.className "w-fit"
    static member inline wFull = prop.className "w-full"
    static member inline wScreen = prop.className "w-screen"