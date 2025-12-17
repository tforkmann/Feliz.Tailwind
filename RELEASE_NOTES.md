#### 4.0.1 - 2025-12-05
* **Major release with 70+ new Tailwind utility categories**
* Bug fixes:
  - Fixed `textColor` - all colors now have correct hyphens (e.g., `text-slate-50` instead of `text-slate50`)
  - Fixed `margin` - `m0`, `mr0`, `mb0`, `ml0` now correctly output `m-0`, `mr-0`, `mb-0`, `ml-0`
  - Fixed `maxHeight` - `h6` now correctly outputs `max-h-6`
  - Added missing 950 shades to all color utilities
* Typography utilities:
  - `lineHeight` (leading-none, leading-tight, leading-3, etc.)
  - `letterSpacing` (tracking-tighter, tracking-tight, tracking-wide, etc.)
  - `textDecoration` (underline, overline, line-through, no-underline)
  - `textDecorationStyle` (decoration-solid, decoration-double, decoration-dotted, etc.)
  - `textDecorationThickness` (decoration-auto, decoration-0, decoration-1, etc.)
  - `textUnderlineOffset` (underline-offset-auto, underline-offset-0, etc.)
  - `textTransform` (uppercase, lowercase, capitalize, normal-case)
  - `textOverflow` (truncate, text-ellipsis, text-clip)
  - `textWrap` (text-wrap, text-nowrap, text-balance, text-pretty)
  - `whitespace` (whitespace-normal, whitespace-nowrap, whitespace-pre, etc.)
  - `wordBreak` (break-normal, break-words, break-all, break-keep)
  - `hyphens` (hyphens-none, hyphens-manual, hyphens-auto)
  - `fontFamily` (font-sans, font-serif, font-mono)
  - `fontStyle` (italic, not-italic)
  - `fontVariantNumeric` (normal-nums, ordinal, slashed-zero, etc.)
  - `listStyleType` (list-none, list-disc, list-decimal)
  - `listStylePosition` (list-inside, list-outside)
  - `textIndent` (indent-0 through indent-24)
  - `verticalAlign` (align-baseline, align-top, align-middle, etc.)
* Sizing utilities:
  - `minWidth` (min-w-0 through min-w-96, min-w-full, min-w-min, min-w-max, min-w-fit)
  - `aspectRatio` (aspect-auto, aspect-square, aspect-video)
  - `size` (size-0 through size-96, size-auto, size-full, size-min, size-max, size-fit)
* Border utilities:
  - `borderStyle` (border-solid, border-dashed, border-dotted, border-double, border-hidden, border-none)
  - `border` (border, border-0, border-2, border-x, border-y, border-t, border-r, border-b, border-l with sizes)
  - `borderColor` (full color palette with all shades)
  - `divide` (divide-x, divide-y with sizes, divide-solid, divide-dashed, etc.)
  - `ring` (ring, ring-0, ring-1, ring-2, ring-4, ring-8, ring-inset)
  - `ringColor` (full color palette)
  - `ringOffsetWidth` (ring-offset-0 through ring-offset-8)
  - `outlineWidth` (outline-0 through outline-8)
  - `outlineOffset` (outline-offset-0 through outline-offset-8)
* Transform utilities:
  - `scale` (scale-0, scale-50, scale-75, scale-90, scale-95, scale-100, scale-105, scale-110, scale-125, scale-150 with x/y variants)
  - `rotate` (rotate-0, rotate-1, rotate-2, rotate-3, rotate-6, rotate-12, rotate-45, rotate-90, rotate-180 with negative variants)
  - `translate` (translate-x/y-0 through translate-x/y-64, fractional values, negative variants)
  - `skew` (skew-x/y-0 through skew-x/y-12, negative variants)
  - `transformOrigin` (origin-center, origin-top, origin-top-right, etc.)
* Transition and animation utilities:
  - `transition` (transition-none, transition-all, transition, transition-colors, transition-opacity, transition-shadow, transition-transform)
  - `duration` (duration-0, duration-75, duration-100, duration-150, duration-200, duration-300, duration-500, duration-700, duration-1000)
  - `ease` (ease-linear, ease-in, ease-out, ease-in-out)
  - `delay` (delay-0 through delay-1000)
  - `animation` (animate-none, animate-spin, animate-ping, animate-pulse, animate-bounce)
* Filter utilities:
  - `blur` (blur-none, blur-sm, blur, blur-md, blur-lg, blur-xl, blur-2xl, blur-3xl)
  - `brightness` (brightness-0, brightness-50, brightness-75, brightness-90, brightness-95, brightness-100, brightness-105, brightness-110, brightness-125, brightness-150, brightness-200)
  - `contrast` (contrast-0, contrast-50, contrast-75, contrast-100, contrast-125, contrast-150, contrast-200)
  - `grayscale` (grayscale-0, grayscale)
  - `hueRotate` (hue-rotate-0, hue-rotate-15, hue-rotate-30, hue-rotate-60, hue-rotate-90, hue-rotate-180 with negative variants)
  - `invert` (invert-0, invert)
  - `saturate` (saturate-0, saturate-50, saturate-100, saturate-150, saturate-200)
  - `sepia` (sepia-0, sepia)
  - `dropShadow` (drop-shadow-sm, drop-shadow, drop-shadow-md, drop-shadow-lg, drop-shadow-xl, drop-shadow-2xl, drop-shadow-none)
* Backdrop filter utilities:
  - `backdropBlur`, `backdropBrightness`, `backdropContrast`, `backdropGrayscale`, `backdropInvert`, `backdropOpacity`, `backdropSaturate`, `backdropSepia`
* Interactivity utilities:
  - `cursor` (cursor-auto, cursor-default, cursor-pointer, cursor-wait, cursor-text, cursor-move, cursor-help, cursor-not-allowed, cursor-none, and 25+ more)
  - `pointerEvents` (pointer-events-none, pointer-events-auto)
  - `resize` (resize-none, resize, resize-y, resize-x)
  - `userSelect` (select-none, select-text, select-all, select-auto)
  - `touchAction` (touch-auto, touch-none, touch-pan-x, touch-pan-y, touch-manipulation, etc.)
  - `scrollBehavior` (scroll-auto, scroll-smooth)
  - `scrollSnapAlign`, `scrollSnapStop`, `scrollSnapType`
  - `willChange` (will-change-auto, will-change-scroll, will-change-contents, will-change-transform)
  - `appearance` (appearance-none, appearance-auto)
  - `caretColor`, `accentColor`
* SVG utilities:
  - `fill` (fill-none, fill-inherit, fill-current, fill-transparent, fill-black, fill-white, and colors)
  - `stroke` (stroke-none, stroke-inherit, stroke-current, stroke-transparent, stroke-black, stroke-white, and colors)
  - `strokeWidth` (stroke-0, stroke-1, stroke-2)
* Table utilities:
  - `borderCollapse` (border-collapse, border-separate)
  - `borderSpacing` (border-spacing-0 through border-spacing-12, border-spacing-x/y variants)
  - `tableLayout` (table-auto, table-fixed)
  - `captionSide` (caption-top, caption-bottom)
* Layout utilities:
  - `objectFit` (object-contain, object-cover, object-fill, object-none, object-scale-down)
  - `objectPosition` (object-bottom, object-center, object-left, object-right, object-top, etc.)
  - `overscrollBehavior` (overscroll-auto, overscroll-contain, overscroll-none with x/y variants)
  - `columns` (columns-1 through columns-12, columns-auto, columns-xs through columns-3xl)
  - `breakAfter`, `breakBefore`, `breakInside`
  - `boxDecorationBreak` (box-decoration-clone, box-decoration-slice)
  - `boxSizing` (box-border, box-content)
  - `float'` (float-start, float-end, float-right, float-left, float-none)
  - `clear` (clear-start, clear-end, clear-left, clear-right, clear-both, clear-none)
  - `isolation` (isolate, isolation-auto)
* Flexbox and Grid utilities:
  - `flexBasis` (basis-0 through basis-64, basis-auto, basis-full, fractional values)
  - `order` (order-first, order-last, order-none, order-1 through order-12)
  - `alignContent`, `alignSelf`, `justifySelf`
  - `placeContent`, `placeItems`, `placeSelf`
  - `gridAutoFlow` (grid-flow-row, grid-flow-col, grid-flow-dense, etc.)
  - `gridAutoColumns`, `gridAutoRows`
  - `gridRows` (grid-rows-none, grid-rows-1 through grid-rows-12, grid-rows-subgrid)
  - `colStart`, `colEnd`, `rowStart`, `rowEnd`
* Background utilities:
  - `backgroundAttachment` (bg-fixed, bg-local, bg-scroll)
  - `backgroundClip` (bg-clip-border, bg-clip-padding, bg-clip-content, bg-clip-text)
  - `backgroundOrigin` (bg-origin-border, bg-origin-padding, bg-origin-content)
  - `backgroundPosition` (bg-bottom, bg-center, bg-left, bg-right, bg-top, etc.)
  - `backgroundRepeat` (bg-repeat, bg-no-repeat, bg-repeat-x, bg-repeat-y, etc.)
  - `backgroundSize` (bg-auto, bg-cover, bg-contain)
  - `backgroundImage` (bg-none, bg-gradient-to-t, bg-gradient-to-tr, etc.)
  - `gradientColorStops` (from-*, via-*, to-* with colors)
* Effects utilities:
  - `mixBlendMode` (mix-blend-normal, mix-blend-multiply, mix-blend-screen, etc.)
  - `backgroundBlendMode` (bg-blend-normal, bg-blend-multiply, etc.)
* Accessibility utilities:
  - `screenReaders` (sr-only, not-sr-only)
  - `forcedColorAdjust` (forced-color-adjust-auto, forced-color-adjust-none)
* Total utilities increased from ~1100 to ~2000+

#### 3.3.0 - 2025-11-28
* Update package versions in paket.lock for Fable and related dependencies

#### 3.2.0 - 2025-11-27
* Add new documentation pages and components for background color, background opacity, border width, flex utilities, font weight, gap, grid, max/min height/width, outline, text color, and visibility

#### 3.1.0 - 2025-11-26
* Add grid col-span and row-span utilities
* Enhance documentation with new Tailwind utility classes and examples

#### 3.0.0 - 2025-01-01
* Initial public release
