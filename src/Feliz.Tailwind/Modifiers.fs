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
    static member inline m0 = prop.className "mb-2"
    static member inline mx0 = prop.className "mx-0"
    static member inline my0 = prop.className "my-0"
    static member inline mt0 = prop.className "mt-0"
    static member inline mr0 = prop.className "mr-2"
    static member inline mb0 = prop.className "mb-2"
    static member inline ml0 = prop.className "ml-2"
    static member inline mpx = prop.className "m-px"
    static member inline mxpx = prop.className "mx-px"
    static member inline mtpx = prop.className "mt-px"
    static member inline mrpx = prop.className "mr-px"
    static member inline mbpx = prop.className "mb-px"
    static member inline mlpx = prop.className "ml-px"
    static member inline ``m0.5`` = prop.className "m-0.5"
    static member inline ``mx0.5`` = prop.className "mx-0.5"
    static member inline ``my0.5`` = prop.className "my-0.5"
    static member inline ``mt0.5`` = prop.className "mt-0.5"
    static member inline ``mr.5`` = prop.className "mr-0.5"
    static member inline ``mb0.5`` = prop.className "mb-0.5"
    static member inline ``ml0.5`` = prop.className "ml-0.5"
    static member inline m1 = prop.className "m-1"
    static member inline mx1 = prop.className "mx-1"
    static member inline my1 = prop.className "my-1"
    static member inline mt1 = prop.className "mt-1"
    static member inline mr1 = prop.className "mr-1"
    static member inline mb1 = prop.className "mb-1"
    static member inline ml1 = prop.className "ml-1"
    static member inline ``m1.5`` = prop.className "m-1.5"
    static member inline ``mx1.5`` = prop.className "mx-1.5"
    static member inline ``my1.5`` = prop.className "my-1.5"
    static member inline ``mt1.5`` = prop.className "mt-1.5"
    static member inline ``mr1.5`` = prop.className "mr-1.5"
    static member inline ``mb1.5`` = prop.className "mb-1.5"
    static member inline ``ml1.5`` = prop.className "ml-1.5"
    static member inline m2 = prop.className "m-2"
    static member inline mx2 = prop.className "mx-2"
    static member inline my2 = prop.className "my-2"
    static member inline mt2 = prop.className "mt-2"
    static member inline mr2 = prop.className "mr-2"
    static member inline mb2 = prop.className "mb-2"
    static member inline ml2 = prop.className "ml-2"
    static member inline ``m2.5`` = prop.className "m-2.5"
    static member inline ``mx2.5`` = prop.className "mx-2.5"
    static member inline ``my2.5`` = prop.className "my-2.5"
    static member inline ``mt2.5`` = prop.className "mt-2.5"
    static member inline ``mr2.5`` = prop.className "mr-2.5"
    static member inline ``mb2.5`` = prop.className "mb-2.5"
    static member inline ``ml2.5`` = prop.className "ml-2.5"
    static member inline m3 = prop.className "m-3"
    static member inline mx3 = prop.className "mx-3"
    static member inline my3 = prop.className "my-3"
    static member inline mt3 = prop.className "mt-3"
    static member inline mr3 = prop.className "mr-3"
    static member inline mb3 = prop.className "mb-3"
    static member inline ml3 = prop.className "ml-3"
    static member inline ``m3.5`` = prop.className "m-3.5"
    static member inline ``mx3.5`` = prop.className "mx-3.5"
    static member inline ``my3.5`` = prop.className "my-3.5"
    static member inline ``mt3.5`` = prop.className "mt-3.5"
    static member inline ``mr3.5`` = prop.className "mr-3.5"
    static member inline ``mb3.5`` = prop.className "mb-3.5"
    static member inline ``ml3.5`` = prop.className "ml-3.5"
    static member inline m4 = prop.className "m-4"
    static member inline mx4 = prop.className "mx-4"
    static member inline my4 = prop.className "my-4"
    static member inline mt4 = prop.className "mt-4"
    static member inline mr4 = prop.className "mr-4"
    static member inline mb4 = prop.className "mb-4"
    static member inline ml4 = prop.className "ml-4"
    static member inline m5 = prop.className "m-5"
    static member inline mx5 = prop.className "mx-5"
    static member inline my5 = prop.className "my-5"
    static member inline mt5 = prop.className "mt-5"
    static member inline mr5 = prop.className "mr-5"
    static member inline mb5 = prop.className "mb-5"
    static member inline ml5 = prop.className "ml-5"
    static member inline m6 = prop.className "m-6"
    static member inline mx6 = prop.className "mx-6"
    static member inline my6 = prop.className "my-6"
    static member inline mt6 = prop.className "mt-6"
    static member inline mr6 = prop.className "mr-6"
    static member inline mb6 = prop.className "mb-6"
    static member inline ml6 = prop.className "ml-6"
    static member inline m7 = prop.className "m-7"
    static member inline mx7 = prop.className "mx-7"
    static member inline my7 = prop.className "my-7"
    static member inline mt7 = prop.className "mt-7"
    static member inline mr7 = prop.className "mr-7"
    static member inline mb7 = prop.className "mb-7"
    static member inline ml7 = prop.className "ml-7"
    static member inline m8 = prop.className "m-8"
    static member inline mx8 = prop.className "mx-8"
    static member inline my8 = prop.className "my-8"
    static member inline mt8 = prop.className "mt-8"
    static member inline mr8 = prop.className "mr-8"
    static member inline mb8 = prop.className "mb-8"
    static member inline ml8 = prop.className "ml-8"
    static member inline m9 = prop.className "m-9"
    static member inline mx9 = prop.className "mx-9"
    static member inline my9 = prop.className "my-9"
    static member inline mt9 = prop.className "mt-9"
    static member inline mr9 = prop.className "mr-9"
    static member inline mb9 = prop.className "mb-9"
    static member inline ml9 = prop.className "ml-9"
    static member inline m10 = prop.className "m-10"
    static member inline mx10 = prop.className "mx-10"
    static member inline my10 = prop.className "my-10"
    static member inline mt10 = prop.className "mt-10"
    static member inline mr10 = prop.className "mr-10"
    static member inline mb10 = prop.className "mb-10"
    static member inline ml10 = prop.className "ml-10"
    static member inline m11 = prop.className "m-11"
    static member inline mx11 = prop.className "mx-11"
    static member inline my11 = prop.className "my-11"
    static member inline mt11 = prop.className "mt-11"
    static member inline mr11 = prop.className "mr-11"
    static member inline mb11 = prop.className "mb-11"
    static member inline ml11 = prop.className "ml-11"
    static member inline m12 = prop.className "m-12"
    static member inline mx12 = prop.className "mx-12"
    static member inline my12 = prop.className "my-12"
    static member inline mt12 = prop.className "mt-12"
    static member inline mr12 = prop.className "mr-12"
    static member inline mb12 = prop.className "mb-12"
    static member inline ml12 = prop.className "ml-12"
    static member inline m14 = prop.className "m-14"
    static member inline mx14 = prop.className "mx-14"
    static member inline my14 = prop.className "my-14"
    static member inline mt14 = prop.className "mt-14"
    static member inline mr14 = prop.className "mr-14"
    static member inline mb14 = prop.className "mb-14"
    static member inline ml14 = prop.className "ml-14"
    static member inline m16 = prop.className "m-16"
    static member inline mx16 = prop.className "mx-16"
    static member inline my16 = prop.className "my-16"
    static member inline mt16 = prop.className "mt-16"
    static member inline mr16 = prop.className "mr-16"
    static member inline mb16 = prop.className "mb-16"
    static member inline ml16 = prop.className "ml-16"
    static member inline m20 = prop.className "m-20"
    static member inline mx20 = prop.className "mx-20"
    static member inline my20 = prop.className "my-20"
    static member inline mt20 = prop.className "mt-20"
    static member inline mr20 = prop.className "mr-20"
    static member inline mb20 = prop.className "mb-20"
    static member inline ml20 = prop.className "ml-20"
    static member inline m24 = prop.className "m-24"
    static member inline mx24 = prop.className "mx-24"
    static member inline my24 = prop.className "my-24"
    static member inline mt24 = prop.className "mt-24"
    static member inline mr24 = prop.className "mr-24"
    static member inline mb24 = prop.className "mb-24"
    static member inline ml24 = prop.className "ml-24"
    static member inline m28 = prop.className "m-28"
    static member inline mx28 = prop.className "mx-28"
    static member inline my28 = prop.className "my-28"
    static member inline mt28 = prop.className "mt-28"
    static member inline mr28 = prop.className "mr-28"
    static member inline mb28 = prop.className "mb-28"
    static member inline ml28 = prop.className "ml-28"
    static member inline m32 = prop.className "m-32"
    static member inline mx32 = prop.className "mx-32"
    static member inline my32 = prop.className "my-32"
    static member inline mt32 = prop.className "mt-32"
    static member inline mr32 = prop.className "mr-32"
    static member inline mb32 = prop.className "mb-32"
    static member inline ml32 = prop.className "ml-32"
    static member inline m36 = prop.className "m-36"
    static member inline mx36 = prop.className "mx-36"
    static member inline my36 = prop.className "my-36"
    static member inline mt36 = prop.className "mt-36"
    static member inline mr36 = prop.className "mr-36"
    static member inline mb36 = prop.className "mb-36"
    static member inline ml36 = prop.className "ml-36"
    static member inline m40 = prop.className "m-40"
    static member inline mx40 = prop.className "mx-40"
    static member inline my40 = prop.className "my-40"
    static member inline mt40 = prop.className "mt-40"
    static member inline mr40 = prop.className "mr-40"
    static member inline mb40 = prop.className "mb-40"
    static member inline ml40 = prop.className "ml-40"
    static member inline m44 = prop.className "m-44"
    static member inline mx44 = prop.className "mx-44"
    static member inline my44 = prop.className "my-44"
    static member inline mt44 = prop.className "mt-44"
    static member inline mr44 = prop.className "mr-44"
    static member inline mb44 = prop.className "mb-44"
    static member inline ml44 = prop.className "ml-44"
    static member inline m48 = prop.className "m-48"
    static member inline mx48 = prop.className "mx-48"
    static member inline my48 = prop.className "my-48"
    static member inline mt48 = prop.className "mt-48"
    static member inline mr48 = prop.className "mr-48"
    static member inline mb48 = prop.className "mb-48"
    static member inline ml48 = prop.className "ml-48"
    static member inline m52 = prop.className "m-52"
    static member inline mx52 = prop.className "mx-52"
    static member inline my52 = prop.className "my-52"
    static member inline mt52 = prop.className "mt-52"
    static member inline mr52 = prop.className "mr-52"
    static member inline mb52 = prop.className "mb-52"
    static member inline ml52 = prop.className "ml-52"
    static member inline m56 = prop.className "m-56"
    static member inline mx56 = prop.className "mx-56"
    static member inline my56 = prop.className "my-56"
    static member inline mt56 = prop.className "mt-56"
    static member inline mr56 = prop.className "mr-56"
    static member inline mb56 = prop.className "mb-56"
    static member inline ml56 = prop.className "ml-56"
    static member inline m60 = prop.className "m-60"
    static member inline mx60 = prop.className "mx-60"
    static member inline my60 = prop.className "my-60"
    static member inline mt60 = prop.className "mt-60"
    static member inline mr60 = prop.className "mr-60"
    static member inline mb60 = prop.className "mb-60"
    static member inline ml60 = prop.className "ml-60"
    static member inline m64 = prop.className "m-64"
    static member inline mx64 = prop.className "mx-64"
    static member inline my64 = prop.className "my-64"
    static member inline mt64 = prop.className "mt-64"
    static member inline mr64 = prop.className "mr-64"
    static member inline mb64 = prop.className "mb-64"
    static member inline ml64 = prop.className "ml-64"
    static member inline m72 = prop.className "m-72"
    static member inline mx72 = prop.className "mx-72"
    static member inline my72 = prop.className "my-72"
    static member inline mt72 = prop.className "mt-72"
    static member inline mr72 = prop.className "mr-72"
    static member inline mb72 = prop.className "mb-72"
    static member inline ml72 = prop.className "ml-72"
    static member inline m80 = prop.className "m-80"
    static member inline mx80 = prop.className "mx-80"
    static member inline my80 = prop.className "my-80"
    static member inline mt80 = prop.className "mt-80"
    static member inline mr80 = prop.className "mr-80"
    static member inline mb80 = prop.className "mb-80"
    static member inline ml80 = prop.className "ml-80"
    static member inline m96 = prop.className "m-96"
    static member inline mx96 = prop.className "mx-96"
    static member inline my96 = prop.className "my-96"
    static member inline mt96 = prop.className "mt-96"
    static member inline mr96 = prop.className "mr-96"
    static member inline mb96 = prop.className "mb-96"
    static member inline mAuto = prop.className "m-auto"
    static member inline mxAuto = prop.className "mx-auto"
    static member inline myAuto = prop.className "my-auto"
    static member inline mtAuto = prop.className "mt-auto"
    static member inline mrAuto = prop.className "mr-auto"
    static member inline mbAuto = prop.className "mb-auto"


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
type maxHeight =
    static member inline h0 = prop.className "max-h-0"
    static member inline hPx = prop.className "max-h-px"
    static member inline ``h0.5`` = prop.className "max-h-0.5"
    static member inline h1 = prop.className "max-h-1"
    static member inline ``h1.5`` = prop.className "max-h-1.5"
    static member inline h2 = prop.className "max-h-2"
    static member inline ``h2.5`` = prop.className "max-h-2.5"
    static member inline h3 = prop.className "max-h-3"
    static member inline ``h3.5`` = prop.className "max-h-3.5"
    static member inline h4 = prop.className "max-h-4"
    static member inline h5 = prop.className "max-h-5"
    static member inline h6 = prop.className "max-h-5"
    static member inline h7 = prop.className "max-h-7"
    static member inline h8 = prop.className "max-h-8"
    static member inline h9 = prop.className "max-h-9"
    static member inline h10 = prop.className "max-h-10"
    static member inline h11 = prop.className "max-h-11"
    static member inline h12 = prop.className "max-h-12"
    static member inline h14 = prop.className "max-h-14"
    static member inline h16 = prop.className "max-h-16"
    static member inline h20 = prop.className "max-h-20"
    static member inline h24 = prop.className "max-h-24"
    static member inline h28 = prop.className "max-h-28"
    static member inline h32 = prop.className "max-h-32"
    static member inline h36 = prop.className "max-h-36"
    static member inline h40 = prop.className "max-h-40"
    static member inline h44 = prop.className "max-h-44"
    static member inline h48 = prop.className "max-h-48"
    static member inline h52 = prop.className "max-h-52"
    static member inline h56 = prop.className "max-h-56"
    static member inline h60 = prop.className "max-h-60"
    static member inline h64 = prop.className "max-h-64"
    static member inline h72 = prop.className "max-h-72"
    static member inline h80 = prop.className "max-h-80"
    static member inline h96 = prop.className "max-h-96"
    static member inline hFull = prop.className "max-h-full"
    static member inline hScreen = prop.className "max-h-screen"
    static member inline hMin = prop.className "max-h-min"
    static member inline hMax = prop.className "max-h-max"
    static member inline hFit = prop.className "max-h-fit"

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
    static member inline w96 = prop.className "w-96"
    static member inline wAuto = prop.className "w-auto"
    static member inline wMin = prop.className "w-min"
    static member inline wMax = prop.className "w-max"
    static member inline wFit = prop.className "w-fit"
    static member inline wFull = prop.className "w-full"
    static member inline wScreen = prop.className "w-screen"