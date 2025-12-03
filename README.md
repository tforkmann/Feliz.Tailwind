# Feliz.Tailwind [![NuGet](https://img.shields.io/nuget/v/Feliz.Tailwind.svg?style=flat-square)](https://www.nuget.org/packages/Feliz.Tailwind/)

Feliz wrapper for [Tailwind](https://Tailwind.com/) TailwindCSS component library

## Installation (manual)
If you want to install this package manually, use usual NuGet package command

    Install-Package Feliz.Tailwind

or using [Paket](http://fsprojects.github.io/Paket/getting-started.html)

    paket add Feliz.Tailwind

## Documentation

### Available Modifiers

Feliz.Tailwind provides type-safe wrappers for Tailwind CSS utility classes. Here are all available modifier types:

#### Layout

| Type | Description | Example |
|------|-------------|---------|
| `display` | Display utilities | `display.flex`, `display.grid`, `display.hidden`, `display.block` |
| `position` | Position utilities | `position.absolute`, `position.relative`, `position.sticky`, `position.fixed'` |
| `visibility` | Visibility utilities | `visibility.visible`, `visibility.invisible` |
| `overflow` | Overflow utilities | `overflow.overflowAuto`, `overflow.overflowHidden`, `overflow.overflowScroll` |
| `zIndex` | Z-Index utilities | `zIndex.z0`, `zIndex.z10`, `zIndex.z50`, `zIndex.zAuto` |

#### Flexbox & Grid

| Type | Description | Example |
|------|-------------|---------|
| `flex` | Flex utilities | `flex.flex`, `flex.flex1`, `flex.flexAuto`, `flex.flexCol` |
| `flexDirection` | Flex direction | `flexDirection.flexRow`, `flexDirection.flexCol` |
| `flexShrink` | Flex shrink | `flexShrink.flexShrink`, `flexShrink.flexShrink0` |
| `flexGrow` | Flex grow | `flexGrow.flexGrow`, `flexGrow.flexGrow0` |
| `justifyContent` | Justify content | `justifyContent.justifyCenter`, `justifyContent.justifyBetween` |
| `justifyItems` | Justify items | `justifyItems.justifyItemsCenter`, `justifyItems.justifyItemsStart` |
| `alignItems` | Align items | `alignItems.itemsCenter`, `alignItems.itemsStart`, `alignItems.itemsStretch` |
| `grid` | Grid utilities | `grid.grid`, `grid.``cols-3``, `grid.``cols-12`` |
| `gap` | Gap utilities | `gap.``gap-4``, `gap.``gap-x-0``, `gap.``gap-y-0`` |

#### Spacing

| Type | Description | Example |
|------|-------------|---------|
| `margin` | Margin utilities | `margin.m4`, `margin.mx2`, `margin.mt0`, `margin.mAuto` |
| `padding` | Padding utilities | `padding.p4`, `padding.px2`, `padding.py6` |

#### Sizing

| Type | Description | Example |
|------|-------------|---------|
| `width` | Width utilities | `width.w64`, `width.wFull`, `width.wScreen`, `width.``w1/2`` |
| `height` | Height utilities | `height.h64`, `height.hFull`, `height.hScreen` |
| `minHeight` | Min height utilities | `minHeight.minHFull`, `minHeight.minHScreen` |
| `maxWidth` | Max width utilities | `maxWidth.wXl`, `maxWidth.w2Xl`, `maxWidth.wFull` |
| `maxHeight` | Max height utilities | `maxHeight.hFull`, `maxHeight.hScreen` |

#### Typography

| Type | Description | Example |
|------|-------------|---------|
| `fontSize` | Font size | `fontSize.textSm`, `fontSize.textLg`, `fontSize.text2Xl` |
| `fontWeight` | Font weight | `fontWeight.fontBold`, `fontWeight.fontMedium`, `fontWeight.fontLight` |
| `textAlign` | Text alignment | `textAlign.left`, `textAlign.center`, `textAlign.right` |
| `textColor` | Text color | `textColor.black`, `textColor.white`, `textColor.blue500` |

#### Backgrounds

| Type | Description | Example |
|------|-------------|---------|
| `backgroundColor` | Background color | `backgroundColor.bgBlue500`, `backgroundColor.bgWhite`, `backgroundColor.bgBlack` |
| `bgOpacity` | Background opacity | `bgOpacity.bgOpacity50`, `bgOpacity.bgOpacity75` |

#### Borders

| Type | Description | Example |
|------|-------------|---------|
| `borderRadius` | Border radius | `borderRadius.rounded`, `borderRadius.roundedLg`, `borderRadius.roundedFull` |
| `borderWidth` | Border width | `borderWidth.borderR`, `borderWidth.borderL`, `borderWidth.borderT` |

#### Effects

| Type | Description | Example |
|------|-------------|---------|
| `boxShadow` | Box shadow | `boxShadow.shadow`, `boxShadow.shadowLg`, `boxShadow.shadowNone` |
| `opacity` | Opacity | `opacity.opacity50`, `opacity.opacity100` |
| `outline` | Outline | `outline.outlineNone`, `outline.outline` |

### Usage Example

```fsharp
open Feliz
open Feliz.Tailwind

let myComponent =
    Html.div [
        prop.className (
            String.concat " " [
                display.flex
                justifyContent.justifyCenter
                alignItems.itemsCenter
                backgroundColor.bgBlue500
                padding.p4
                borderRadius.roundedLg
            ]
        )
        prop.children [
            Html.span [
                prop.className (
                    String.concat " " [
                        textColor.white
                        fontSize.textLg
                        fontWeight.fontBold
                    ]
                )
                prop.text "Hello Tailwind!"
            ]
        ]
    ]
```
