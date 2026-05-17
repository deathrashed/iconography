---
title: "Iconify Documentation"
description: "All popular icon sets, one framework"
author:
  - "[[Iconify OÜ]]"
source: "https://iconify.design/docs/"
---
Iconify is a set of tools for developers and designers, created to make it easy to work with different icon sets in a consistent way.

It includes:

- Over 275k icons from more than 200 open source icon sets, all cleaned up, optimised and kept up to date.
- Tools for importing, exporting and organising icons.
- Components and plugins to render icons.
- Plugins for UI developers to browse and import icons to design tools.
- Public API to browse, search icon sets and retrieve icon data.

## How to use icons

Iconify ecosystem offers many ways to use icons, for both coders and designers.

To use icons in HTML documents, there are several viable options:

- [SVG + CSS is the preferred solution, if you can use it](https://iconify.design/docs/usage/svg-css/).
- [You can add icons to CSS](https://iconify.design/docs/usage/css/).
- [You can add SVG to HTML](https://iconify.design/docs/usage/svg/).
- [Iconify offers unique components that render icons on demand](https://iconify.design/docs/icon-components/).

For designers, Iconify ecosystem offers several ways to easily import icons in various design tools:

Available options:

- The designers who use Figma can install [Iconify plug-in for Figma](https://iconify.design/docs/design/figma/).
- The designers who use Sketch users can install [Iconify plugin-in for Sketch](https://iconify.design/docs/design/sketch/).
- For other design tools, or if you are experiencing issues with plug-ins listed above, you can copy and paste SVG from one of the sources listed below.

You can browse all available icons and copy code or SVG on the following websites:

- [Iconify icon sets](https://icon-sets.iconify.design/) - official website.
- [Icones](https://icones.js.org/) - alternative website created by Anthony Fu.

Find icon you want, select it, copy code sample or SVG to clipboard, paste it in your project.

See [how to use icons](https://iconify.design/docs/usage/) for more details.

## Icons data

Unlike other projects, Iconify is not a dump of SVG files.

Icons pass strict validation, clean up and optimisation process. Icons are automatically kept up to date.

If you want to use icons with your own components, icon data is available in easy to use format.

In the [icons section of documentation](https://iconify.design/docs/icons/) you will find:

- [Where to get icon data](https://iconify.design/docs/icons/icon-data.html) to use in your projects.
- [Icon clean up and optimisation](https://iconify.design/docs/icons/icon-basics.html): naming rules, types of icons, cleanup process.
- [Icon sets](https://iconify.design/docs/icons/icon-set-basics.html): what are icon sets, data format, naming, how to parse them.
- [How to building a custom icon set](https://iconify.design/docs/icons/custom.html), if you want to use your icons with Iconify ecosystem.

## Libraries

Iconify offers several packages to work with icons.

All packages are JavaScript only. However, formats are rather easy to understand, types are documented, so you can port code to whatever language you are using.

There are 3 main packages:

- Types package (TypeScript) that describe data format.
- Utilities package, which contains reusable helper functions that work in Node and in browser.
- Tools package, which contains tools for importing, exporting icon sets, processing icons. This is a Node.js only package.

### Types

Before using any tools, you need to understand data structures used in Iconify ecosystem.

See [Iconify types documentation](https://iconify.design/docs/types/).

### Utils

[Iconify Utils](https://iconify.design/docs/libraries/utils/) contains reusable functions for:

- reading and parsing icon sets.
- generating SVG, CSS code for icons.

as well as many other helper functions.

This package is designed to work in any environment. It is used by all Iconify packages, including icon components, API, plugins.

### Tools

[Iconify Tools](https://iconify.design/docs/libraries/tools/) is designed to import, export and process icon data.

It is used to maintain available open source icon sets.

This package is designed to work only in Node.js. It is not usable in the browser.

## API

[Iconify API](https://iconify.design/docs/api/) is an open source hosted (or self-hosted) service, indented for developers. It is used to:

- Provide icon data on demand, which made it possible to create [Iconify icon components](https://iconify.design/docs/icon-components/) that load icons on demand.
- [Generate SVG](https://iconify.design/docs/api/svg.html), which developers can link to in HTML or stylesheet.
- [Generate CSS](https://iconify.design/docs/api/css.html) to render icons as background or mask images.
- Provide data for hosted icons, including search functionality. This can be used to create icon pickers and is currently used by [Iconify plug-ins for various UI design tools](https://iconify.design/docs/design/).

[Page 2](https://iconify.design/docs/usage/ "Current Page.")

## How to use icons

How to use icons in your projects?

Iconify ecosystem offers many ways to use icons, for both coders and designers.

## HTML

For using icons in HTML, there are several viable options:

- [SVG + CSS is the preferred solution, if you can use it](https://iconify.design/docs/usage/svg-css/).
- [You can add icons to CSS](https://iconify.design/docs/usage/css/).
- [You can add SVG to HTML](https://iconify.design/docs/usage/svg/).
- [Iconify offers unique components that render icons on demand](https://iconify.design/docs/icon-components/).

### SVG + CSS

SVG + CSS is the preferred solution because it:

- Reduces HTML size.
- Caches icons in CSS.
- Gives you full power of CSS to manipulate icons.

However, due to complexity and poor browser support, implementation is available only for limited number of frameworks.

See [how to use icons as SVG + CSS](https://iconify.design/docs/svg-css/).

### SVG in CSS

How to use icons in CSS:

- Add icon as a background or mask image in CSS.
- Use <span> element in HTML to render it.

Using icons as background images works great for icons with hardcoded palette, such as emojis.

Using icons as mask images, in combination with setting background color to currentColor, allows using monotone icons in CSS. To change icon color, simply change text color.

Example showing icons used as background and mask images (hover to see color change):

See [how to use icons in CSS](https://iconify.design/docs/css/) for various tools and plug-ins that make it easy to add icons to CSS.

### SVG in HTML

Icons can be embedded in HTML as <svg> elements:

svg
```
<svg xmlns="http://www.w3.org/2000/svg" width="1em" height="1em" viewBox="0 0 24 24">
    <path fill="currentColor" d="M12 4a4 4 0 0 1 4 4a4 4 0 0 1-4 4a4 4 0 0 1-4-4a4 4 0 0 1 4-4m0 10c4.42 0 8 1.79 8 4v2H4v-2c0-2.21 3.58-4 8-4Z"/>
</svg>
```

See [how to add SVG to HTML](https://iconify.design/docs/svg/) for various tools and components that make it easy to add icons to HTML.

### Icons on demand

Iconify ecosystem has a unique feature: [Iconify API](https://iconify.design/docs/api/).

It is used by various icon components to [load icon data on demand](https://iconify.design/docs/api/icon-data.html). Iconify icon components only load icon data for icons used on the page visitor is viewing, at run time, instead of bundling icons.

Iconify icon components are perfect for complex projects like theme or website customisers, customisable admin panels or any similar projects, where icons can be customised by user.

Iconify icon components are very easy to use. All a developer has to specify is an icon name:

html
```
<iconify-icon icon="mdi:home"></iconify-icon>
```

See [how to use Iconify icon components](https://iconify.design/docs/icon-components/).

## Design

For designers, Iconify ecosystem offers several ways to easily import icons in various design tools.

Available options:

- The designers who use Figma can install [Iconify plug-in for Figma](https://iconify.design/docs/design/figma/).
- The designers who use Sketch users can install [Iconify plugin-in for Sketch](https://iconify.design/docs/design/sketch/).
- For other design tools, or if you are experiencing issues with plug-ins listed above, you can copy and paste SVG from one of the sources listed below.

### Browse icons

You can browse and search more than 275k open source icons at one of the following websites:

- [Iconify icon sets](https://icon-sets.iconify.design/) - official website.
- [Icones](https://icones.js.org/) - alternative website created by Anthony Fu.

Find icon you want to use, select it, copy SVG to clipboard, paste it to your favorite design tool.

Possible issues:

- Some design tools do not support currentColor. Set icon color to black before copying code sample.
- Almost all image editing software do not support SVG 2 animations. Animated icons will be imported without animations, sometimes rendered weirdly.

[Page 3](https://iconify.design/docs/usage/svg-css/ "Current Page.")

## Using icons as SVG + CSS

SVG + CSS method of rendering icons splits icon in two parts:

- Small SVG that can be embedded in HTML.
- CSS that contains all shapes.

See [rendering icon as SVG + CSS article](https://cyberalien.dev/articles/svg-css).

## Example

This is an example of SVG + CSS icon code.

SVG contains only minimal amount of code, reducing HTML size:


```xml
<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24">
    <path class="mdi-account-box" />
</svg>
```

Each shape has a class name instead of a long shape. CSS has a selector with that class name and shape data:

css
```
.mdi-account-box {
  fill: currentColor;
  d: path(
    "M6 17c0-2 4-3.1 6-3.1s6 1.1 6 3.1v1H6m9-9a3 3 0 0 1-3 3a3 3 0 0 1-3-3a3 3 0 0 1 3-3a3 3 0 0 1 3 3M3 5v14a2 2 0 0 0 2 2h14a2 2 0 0 0 2-2V5a2 2 0 0 0-2-2H5a2 2 0 0 0-2 2"
  );
 }
```

## Advantages

The biggest advantages of SVG+CSS is compactness and caching:

- HTML is as small as possible.
- Actual shapes are in CSS files, which are cached by the browser.

Additionally, you can use the full power of CSS:

- Use CSS variables for colors.
- Change shapes and colors on events, for example when hovering an icon.

### Size comparison

The biggest benefit is with animated icons.

Below are links to source code of exactly the same icon in various formats:

- [Static SVG](https://github.com/cyberalien/line-md/blob/main/svg-static/bell-loop.svg?short_path=bebc22d) - 446 bytes
- [SVG animation](https://github.com/cyberalien/line-md/blob/main/svg/bell-loop.svg?short_path=0d3dc1c) - 1.29 kb
- [CSS animation with embedded style](https://github.com/cyberalien/line-md/blob/main/svg-style/bell-loop.svg?short_path=c681330) - 1.49 kb total (176 bytes SVG + 1.29 kb CSS)

Icon with CSS animations has much smaller file size, which is a huge advantage: 176 bytes vs 1.29 kb!

This comes at cost of increasing CSS file size (by 1.29 KB in this case), but CSS files are usually shared between pages and are cached in browser.

## Disadvantages

There is only one disadvantage of using SVG + CSS: Safari browser support.

### Safari browser

The biggest part of icons is always the path, defined in d property of <path> element.

As shown in example above, in CSS it can be used with path() function.

However, currently the latest version of Safari (26.3) does not support it!

Solution: using components to render icon, detect incompatible browsers and use a different rendering method for those browsers.

## Convert icons

You can convert icons using an online script for [converting SVG to SVG+CSS](https://cyberalien.dev/svg-to-css/).

This converter does not do optimisation and clean up, use it with cleaned up SVGs.

## Icon components

Because currently rendering icon as SVG+CSS requires a fallback for Safari browser, rendering methods are very limited and require JavaScript.

Currently, Iconify provides SVG+CSS solutions for the following frameworks:

- [Vue components](https://iconify.design/docs/vue/)
- [Svelte components](https://iconify.design/docs/svelte/)
- [React components](https://iconify.design/docs/react/)
- [SolidJS components](https://iconify.design/docs/solid/)

Additionally, [Iconify Unplugin](https://github.com/iconify/unplugin-iconify) can render icons on demand for all frameworks listed above.

## Customise icons

If you want to change icon color in a monotone icon, change text color.

If you want to change something else, like a specific color or opacity or stroke-width, you can customise icons using CSS variables.

See [Customising icons with CSS variables](https://iconify.design/docs/css.html) article.

[Page 4](https://iconify.design/docs/usage/svg-css/vue/ "Current Page.")

## Using icons as SVG + CSS in Vue

Iconify provides easy to use components for [rendering icons as SVG + CSS](https://iconify.design/).

These components render:

- SVG + CSS for modern browsers
- Full SVG for Safari browser, loaded on demand from Iconify API

If you want to know more details, see [article on how Safari fallback works](https://cyberalien.dev/articles/safari-svg-path).

## Usage

1. Install a package for an icon set:

```
npm install @iconify-vue/material-symbols
```

2. Import icon in your Vue component:

js
```
import DraftsIcon from "@iconify-vue/material-symbols/drafts";
```

3. Use icon in your code:

xml
```
<DraftsIcon />
```

Replace:

- "material-symbols" with icon set you want to use.
- "drafts" with name of icon from that icon set.
- "DraftsIcon" with component name you want to use (you can use anything).

Browse [Iconify icon sets](https://icon-sets.iconify.design/) to see all available icons.

## Color

Monotone icons use text color for icon, to change icon color, change text color via CSS (inline or in stylesheet):

xml
```
<DraftsIcon style="color: red;" />
```

## Size

Unlike other components, SVG + CSS components do not set icon size. This has advantages and disadvantages.

Disadvantages:

- You need to set size yourself.

Advantages:

- You have full control over icon size.

You can change icon size by:

- Setting width and height properties.
- Using CSS.

### Properties

All icon components support width and height properties.

Value is a string.

You do not need to set both properties. If you set one property, other property will automatically be calculated from icon's width/height ratio.

Examples:

xml
```
<DraftsIcon height="1em" />
<DraftsIcon width="1em" height="1em" />
<DraftsIcon height="24" />
```

### CSS

You can control icon size in CSS, like for any other SVG.

css
```
.drafts-icon {
  width: 1em;
  height: 1em;
 }
```

xml
```
<DraftsIcon class="drafts-icon" />
```

## Fallback component

For browsers that do not support SVG + CSS, these icon components use a fallback component.

Fallback component detects outdated browsers, loads full icon from [Iconify API](https://iconify.design/api/) and renders it instead of small SVG.

Fallback icon is loaded on demand, only for visitors that use outdated browsers. Users with modern browsers will not be loading anything from API.

For Vue, fallback icon component is published in package @iconify/css-vue.

In future, when Safari browser will support path() function for d property, it will not be required, but for now it is bundled with icons.

[Page 5](https://iconify.design/docs/usage/svg-css/svelte/ "Current Page.")

## Using icons as SVG + CSS in Svelte

Iconify provides easy to use components for [rendering icons as SVG + CSS](https://iconify.design/).

These components render:

- SVG + CSS for modern browsers
- Full SVG for Safari browser, loaded on demand from Iconify API

If you want to know more details, see [article on how Safari fallback works](https://cyberalien.dev/articles/safari-svg-path).

## Usage

1. Install a package for an icon set:

```
npm install @iconify-svelte/material-symbols
```

2. Import icon in your Svelte component:

js
```
import DraftsIcon from "@iconify-svelte/material-symbols/drafts";
```

3. Use icon in your code:

xml
```
<DraftsIcon />
```

Replace:

- "material-symbols" with icon set you want to use.
- "drafts" with name of icon from that icon set.
- "DraftsIcon" with component name you want to use (you can use anything).

Browse [Iconify icon sets](https://icon-sets.iconify.design/) to see all available icons.

## Color

Monotone icons use text color for icon, to change icon color, change text color via CSS (inline or in stylesheet):

xml
```
<DraftsIcon style="color: red;" />
```

## Size

Unlike other components, SVG + CSS components do not set icon size. This has advantages and disadvantages.

Disadvantages:

- You need to set size yourself.

Advantages:

- You have full control over icon size.

You can change icon size by:

- Setting width and height properties.
- Using CSS.

### Properties

All icon components support width and height properties.

Value is a string.

You do not need to set both properties. If you set one property, other property will automatically be calculated from icon's width/height ratio.

Examples:

xml
```
<DraftsIcon height="1em" />
<DraftsIcon width="1em" height="1em" />
<DraftsIcon height="24" />
```

### CSS

You can control icon size in CSS, like for any other SVG.

css
```
.drafts-icon {
  width: 1em;
  height: 1em;
 }
```

xml
```
<DraftsIcon class="drafts-icon" />
```

## Fallback component

For browsers that do not support SVG + CSS, these icon components use a fallback component.

Fallback component detects outdated browsers, loads full icon from [Iconify API](https://iconify.design/api/) and renders it instead of small SVG.

Fallback icon is loaded on demand, only for visitors that use outdated browsers. Users with modern browsers will not be loading anything from API.

For Svelte, fallback icon component is published in package @iconify/css-svelte.

In future, when Safari browser will support path() function for d property, it will not be required, but for now it is bundled with icons.

[Page 6](https://iconify.design/docs/usage/svg-css/react/ "Current Page.")

## Using icons as SVG + CSS in React

Iconify provides easy to use components for [rendering icons as SVG + CSS](https://iconify.design/).

These components render:

- SVG + CSS for modern browsers
- Full SVG for Safari browser, loaded on demand from Iconify API

If you want to know more details, see [article on how Safari fallback works](https://cyberalien.dev/articles/safari-svg-path).

## Usage

1. Install a package for an icon set:

```
npm install @iconify-react/material-symbols
```

2. Import icon in your React component:

js
```
import DraftsIcon from "@iconify-react/material-symbols/drafts";
```

3. Use icon in your code:

jsx
```
<DraftsIcon />
```

Replace:

- "material-symbols" with icon set you want to use.
- "drafts" with name of icon from that icon set.
- "DraftsIcon" with component name you want to use (you can use anything).

Browse [Iconify icon sets](https://icon-sets.iconify.design/) to see all available icons.

## Color

Monotone icons use text color for icon, to change icon color, change text color via CSS (inline or in stylesheet):

jsx
```
<DraftsIcon style={{ color: "red" }} />
```

## Size

Unlike other components, SVG + CSS components do not set icon size. This has advantages and disadvantages.

Disadvantages:

- You need to set size yourself.

Advantages:

- You have full control over icon size.

You can change icon size by:

- Setting width and height properties.
- Using CSS.

### Properties

All icon components support width and height properties.

Value is a string.

You do not need to set both properties. If you set one property, other property will automatically be calculated from icon's width/height ratio.

Examples:

jsx
```
<DraftsIcon height="1em" />
<DraftsIcon width="1em" height="1em" />
<DraftsIcon height="24" />
```

### CSS

You can control icon size in CSS, like for any other SVG.

css
```
.drafts-icon {
  width: 1em;
  height: 1em;
 }
```

jsx
```
<DraftsIcon className="drafts-icon" />
```

## Fallback component

For browsers that do not support SVG + CSS, these icon components use a fallback component.

Fallback component detects outdated browsers, loads full icon from [Iconify API](https://iconify.design/api/) and renders it instead of small SVG.

Fallback icon is loaded on demand, only for visitors that use outdated browsers. Users with modern browsers will not be loading anything from API.

For React, fallback icon component is published in package @iconify/css-react.

In future, when Safari browser will support path() function for d property, it will not be required, but for now it is bundled with icons.

[Page 7](https://iconify.design/docs/usage/svg-css/solid/ "Current Page.")

## Using icons as SVG + CSS in SolidJS

Iconify provides easy to use components for [rendering icons as SVG + CSS](https://iconify.design/).

These components render:

- SVG + CSS for modern browsers
- Full SVG for Safari browser, loaded on demand from Iconify API

If you want to know more details, see [article on how Safari fallback works](https://cyberalien.dev/articles/safari-svg-path).

## Usage

1. Install a package for an icon set:

```
npm install @iconify-solid/material-symbols
```

2. Import icon in your SolidJS component:

js
```
import DraftsIcon from "@iconify-solid/material-symbols/drafts";
```

3. Use icon in your code:

jsx
```
<DraftsIcon />
```

Replace:

- "material-symbols" with icon set you want to use.
- "drafts" with name of icon from that icon set.
- "DraftsIcon" with component name you want to use (you can use anything).

Browse [Iconify icon sets](https://icon-sets.iconify.design/) to see all available icons.

## Color

Monotone icons use text color for icon, to change icon color, change text color via CSS (inline or in stylesheet):

xml
```
<DraftsIcon style="color: red;" />
```

## Size

Unlike other components, SVG + CSS components do not set icon size. This has advantages and disadvantages.

Disadvantages:

- You need to set size yourself.

Advantages:

- You have full control over icon size.

You can change icon size by:

- Setting width and height properties.
- Using CSS.

### Properties

All icon components support width and height properties.

Value is a string.

You do not need to set both properties. If you set one property, other property will automatically be calculated from icon's width/height ratio.

Examples:

jsx
```
<DraftsIcon height="1em" />
<DraftsIcon width="1em" height="1em" />
<DraftsIcon height="24" />
```

### CSS

You can control icon size in CSS, like for any other SVG.

css
```
.drafts-icon {
  width: 1em;
  height: 1em;
 }
```

jsx
```
<DraftsIcon class="drafts-icon" />
```

## Fallback component

For browsers that do not support SVG + CSS, these icon components use a fallback component.

Fallback component detects outdated browsers, loads full icon from [Iconify API](https://iconify.design/api/) and renders it instead of small SVG.

Fallback icon is loaded on demand, only for visitors that use outdated browsers. Users with modern browsers will not be loading anything from API.

For SolidJS, fallback icon component is published in package @iconify/css-solid.

In future, when Safari browser will support path() function for d property, it will not be required, but for now it is bundled with icons.

[Page 8](https://iconify.design/docs/usage/svg-css/css.html "Current Page.")

## Customising icons with CSS variables

This applies to all SVG + CSS component packages:

- [@iconify-vue/\* packages](https://iconify.design/docs/vue/) for Vue.
- [@iconify-svelte/\* packages](https://iconify.design/docs/svelte/) for Svelte.
- [@iconify-react/\* packages](https://iconify.design/docs/react/) for React.
- [@iconify-solid/\* packages](https://iconify.design/docs/solid/) for SolidJS.

You can customise icons using CSS variables, without editing icons.

This is done by setting custom CSS variables, which override default values used in icons. See examples below.

## What is customisable?

The following properties can be customised:

- all colors
- stroke width
- opacity

## Variable names

Variables are generated based on icon content (see examples below):

- \--svg-color--{color} for colors, where {color} is color value in lower case without "#"
- \--svg-stroke-width--{stroke} for stroke width, where {stroke} is original stroke width "px" suffix and without dots
- \--svg-opacity--{value} for opacity, where {value} is original value
- \--svg-fill-opacity--{value} for fill-opacity, same as above

Variable names are generated from original value in lower case, replacing:

- All characters other than 0-9 and a-z are replaced with dash
- Leading and trailing dashes are removed, except for when value starts with '-' (negative number)

Examples:

- Color "#F80" becomes "f80"
- Stroke width "1.5px" becomes "1-5px"
- Negative number "-0.5" becomes "-0-5"

## Examples

Usage examples with usable CSS

### Stroke width

Example customising stroke width in [Tabler Icons](https://icon-sets.iconify.design/tabler/):

css
```
svg {
  /* replace 2px stroke width with 1.5px */
  --svg-stroke-width--2px: 1.5px;
 }
```

### Opacity

Example customising opacity in two tone [Google Material Icons](https://icon-sets.iconify.design/ic/):

css
```
svg {
  /* replace 0.3 with 0.5 */
  --svg-opacity--0-3: 0.5;
 }
```

Example customising opacity in two tone [IconaMoon](https://icon-sets.iconify.design/iconamoon/):

css
```
svg {
  /* replace 0.15 with 0.4 */
  --svg-opacity--0-16: 0.4;
 }
```

### Colors

Example customising colors in [Freehand color icons](https://icon-sets.iconify.design/streamline-freehand-color/):

css
```
svg {
  /* replace blue color */
  --svg-color--0c6fff: red;
  /* replace black color */
  --svg-color--020202: currentColor;
 }
```

This does not apply to currentColor used in monotone icons.

To change currentColor, simply change text color:

css
```
svg {
  color: red;
 }
```

## Icon specific variables

To customise icon, first you need to know what colors, opacity and stroke-width values are used in that specific icon.

Most icon sets are consistent, icons in one icon set usually use the same value, however, that is not always the case.

### Inspect icon

Where to see actual variables used in a specific icon?

Currently the only way is to inspect icon in browser or editor.

Soon you will be able to do that on [Iconify icon sets website](https://icon-sets.iconify.design/).

[Page 9](https://iconify.design/docs/usage/css/ "Current Page.")

## How to use icons in CSS

Using icons in CSS is easy: set icon as background or mask image, use simple <span> element in HTML to render icon.

[Skip to list of available tools](#tools) if you want to skip long explanation of how it all works.

## Advantages

There are advantages and disadvantages of using SVG in CSS over [using SVG in HTML](https://iconify.design/svg/).

Advantages:

- No repeating. Only one entry for each icon.
- No deep DOM tree.
- Can use icons from untrusted sources because if there are any scripts in SVG, they are not executed.

However, it also has disadvantages:

- You cannot target elements inside icons, such as changing stroke-width.
- Cannot use animated icons, except for ones with indefinite looping animations. See below.

## How icons are rendered

There are two types of icons:

- Icons with hardcoded palette.
- Monotone icons that change color.

You can use both types in CSS.

### Icons with palette

Icons with hardcoded palette can be rendered as background images:

html
```
<span class="background-demo"></span>
<span class="background-demo background-demo--2"></span>
```

css
```
.background-demo {
    /* Add dimensions to span */
    display: inline-block;
    width: 32px;
    height: 32px;
    /* Add background image */
    background-image: url('https://api.iconify.design/fluent-emoji-flat/alarm-clock.svg');
    background-repeat: no-repeat;
    background-size: 100% 100%;
 }

.background-demo--2 {
    background-image: url('https://api.iconify.design/fluent-emoji-flat/memo.svg');
 }
```

#### Rendering as content

Icons with hardcoded palette can also be rendered as content of pseudo-elements.

It is similar to using icons as background images, but with a difference: icon's size cannot be controlled with CSS. You need to set width and height in SVG in pixels.

html
```
<span class="content-demo"></span>
<span class="content-demo content-demo--2"></span>
```

css
```
.content-demo::after {
    content: url('https://api.iconify.design/bi/bell-fill.svg?height=32&color=gray');
 }

.content-demo--2::after {
    content: url('https://api.iconify.design/fluent-emoji-flat/memo.svg?height=32');
 }
```

There are no clear advantages of rendering icons as content of pseudo-elements instead of background images.

### Monotone icons

Monotone icons can be rendered as mask images with background color set to currentColor:

html
```
<span class="mask-demo"></span>
<span class="mask-demo"></span>
<span class="mask-demo mask-demo--2"></span>
<span class="mask-demo mask-demo--2"></span>
<span class="mask-demo mask-demo--3"></span>
<span class="mask-demo mask-demo--3"></span>
```

css
```
.mask-demo {
    /* Add dimensions to span */
    display: inline-block;
    width: 32px;
    height: 32px;
    /* Add background color */
    background-color: currentColor;
    /* Add mask image, use variable to reduce duplication */
    --svg: url('https://api.iconify.design/bi/bell-fill.svg');
    -webkit-mask-image: var(--svg);
    mask-image: var(--svg);
    -webkit-mask-repeat: no-repeat;
    mask-repeat: no-repeat;
    -webkit-mask-size: 100% 100%;
    mask-size: 100% 100%;
 }

.mask-demo--2 {
    --svg: url('https://api.iconify.design/carbon/edit-off.svg');
 }

.mask-demo--3 {
    --svg: url('https://api.iconify.design/carbon/humidity.svg');
 }
```

Using currentColor as background color makes it easy to change icon color by changing text color.

## Tools

How to generate CSS for icons in the Iconify ecosystem?

There are several ways to do it:

- You can use [Iconify API to generate CSS](https://iconify.design/docs/no-code/) without writing any code.
- If you are using Tailwind CSS, you can use [Iconify plugin for Tailwind CSS](https://iconify.design/docs/tailwind/).
- If you are using UnoCSS, it has a [built-in preset for icons](https://iconify.design/docs/unocss/).
- You can use [Iconify Utils to generate CSS](https://iconify.design/docs/utils/).

## Custom plugin

Want to build a custom plugin that generates CSS?

[Iconify Utils](https://iconify.design/docs/libraries/utils/) package includes all functions you need. Process of generating CSS is simple:

- Locate icon set file.
- Read it and parse JSON.
- Use [getIconsCSS()](https://iconify.design/docs/libraries/utils/get-icons-css.html "getIconsCSS() documentation") or [getIconCSS()](https://iconify.design/docs/libraries/utils/get-icon-css.html "getIconCSS() documentation") functions to generate CSS.

Code samples that should help you:

- See [Iconify Utils documentation for CSS](https://iconify.design/docs/utils/).
- See [getIconsCSS()](https://iconify.design/docs/libraries/utils/get-icons-css.html "getIconsCSS() documentation") or [getIconCSS()](https://iconify.design/docs/libraries/utils/get-icon-css.html "getIconCSS() documentation").
- Source code for [Iconify for Tailwind CSS](https://github.com/iconify/iconify/tree/main/plugins/tailwind).

## Animated icons

Animated icons should not be used in CSS.

Issue is animation timers.

It would be reasonable to expect animation to start when icon is rendered, but that is not the case in CSS.

In CSS for background and mask images, animation timer starts the first time icon is rendered, then the same timer is used for all instances of icon. Animation timer cannot be reset.

[Page 10](https://iconify.design/docs/usage/css/no-code/ "Current Page.")

## CSS for icons without coding

You can generate CSS for icons without writing any code, using Iconify API.

If you would rather generate CSS programmatically, [consider using Iconify Utils](https://iconify.design/utils/).

## API

Iconify API is an open source hosted (or self-hosted) service for developers. Public Iconify API servers host over 275,000 icons from more than 200 open source icon sets.

Public API is available at https://api.iconify.design.

Among other features, it can generate CSS for icons. Query for CSS is /{prefix}.css?icons={icons}, where:

- "{prefix}" is icon set prefix. To generate CSS for icons from multiple icon sets, send separate queries for each icon set.
- "{icons}" is list of icon names, separated by comma.

## Usage

Getting CSS is easy:

- In your browser, create URL for Iconify API with the correct list of icons, as described above (see examples below).
- Select all generated CSS, copy it to clipboard, paste it to a.css file.

To use those icons in HTML, use <span> elements with 2 class names: class name for the icon set, class name for the icon.

html
```
<span class="icon--mdi-light icon--mdi-light--alert-circle"></span>
```

There is a bit of duplication in class names, as both the icon set and the icon contain the same first part. You can change it with options. See below.

## Examples

[/mdi-light.css?icons=alert-circle,circle,help-circle](https://api.iconify.design/mdi-light.css?icons=alert-circle,circle,help-circle):

css
```
.icon--mdi-light {
    display: inline-block;
    width: 1em;
    height: 1em;
    background-color: currentColor;
    -webkit-mask: no-repeat center / 100%;
    mask: no-repeat center / 100%;
    -webkit-mask-image: var(--svg);
    mask-image: var(--svg);
 }

.icon--mdi-light--alert-circle {
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cpath fill='black' d='M11.5 3a9.5 9.5 0 0 1 9.5 9.5a9.5 9.5 0 0 1-9.5 9.5A9.5 9.5 0 0 1 2 12.5A9.5 9.5 0 0 1 11.5 3m0 1A8.5 8.5 0 0 0 3 12.5a8.5 8.5 0 0 0 8.5 8.5a8.5 8.5 0 0 0 8.5-8.5A8.5 8.5 0 0 0 11.5 4M11 17v-2h1v2h-1m0-4V8h1v5h-1Z'/%3E%3C/svg%3E");
 }

.icon--mdi-light--circle {
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cpath fill='black' d='M11.5 3a9.5 9.5 0 0 1 9.5 9.5a9.5 9.5 0 0 1-9.5 9.5A9.5 9.5 0 0 1 2 12.5A9.5 9.5 0 0 1 11.5 3m0 1A8.5 8.5 0 0 0 3 12.5a8.5 8.5 0 0 0 8.5 8.5a8.5 8.5 0 0 0 8.5-8.5A8.5 8.5 0 0 0 11.5 4Z'/%3E%3C/svg%3E");
 }

.icon--mdi-light--help-circle {
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cpath fill='black' d='M11.5 4A8.5 8.5 0 0 0 3 12.5a8.5 8.5 0 0 0 8.5 8.5a8.5 8.5 0 0 0 8.5-8.5A8.5 8.5 0 0 0 11.5 4m0-1a9.5 9.5 0 0 1 9.5 9.5a9.5 9.5 0 0 1-9.5 9.5A9.5 9.5 0 0 1 2 12.5A9.5 9.5 0 0 1 11.5 3M11 17h1v2h-1v-2m.5-11A3.5 3.5 0 0 1 15 9.5c0 .9-.7 1.5-1.44 2.18l-.93.9c-.59.67-.66 1.95-.63 2.39V15h-1c0-.05-.1-1.96.87-3.08l1.03-.99c.6-.53 1.1-.98 1.1-1.43A2.5 2.5 0 0 0 11.5 7A2.5 2.5 0 0 0 9 9.5H8A3.5 3.5 0 0 1 11.5 6Z'/%3E%3C/svg%3E");
 }
```

[/openmoji.css?icons=axe,balance-scale](https://api.iconify.design/openmoji.css?icons=axe,balance-scale):

css
```
.icon--openmoji {
    display: inline-block;
    width: 1em;
    height: 1em;
    background: no-repeat center / 100%;
 }

.icon--openmoji--axe {
    background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 72 72' width='72' height='72'%3E%3Cpath fill='%239b9b9a' d='m7.95 17.47l18.13-4.237s.217 2.51.541 4.237a19.196 19.196 0 0 0 3.561 6.474c.756.54-7.482 11.88-10.24 12.42c-4.92.954-13.4-18.33-11.99-18.89z'/%3E%3Cpath fill='%23a57939' d='M36.41 23.25c-1.189.792-2.352.923-1.771 2.228a7.128 7.128 0 0 1 .434 1.297c.501 2.172 1.503 3.675 5.345 5.847c3.412 1.929 10.38 15.58 11.9 18.61a2.94 2.94 0 0 1 .31 1.257l.13 5.842a2.963 2.963 0 0 0 .663 1.803l1.863 2.293a2.963 2.963 0 0 0 4.132.46l3.502-2.757a2.963 2.963 0 0 0 .703-3.86l-21.27-35.2c-.873-1.445-.81-1.416-2.215-.48z'/%3E%3Crect width='13.63' height='13.53' x='14.18' y='24.84' fill='%23d0cfce' rx='2.359' ry='2.359' transform='rotate(-30)'/%3E%3Cg fill='none' stroke='%23000' stroke-linecap='round' stroke-linejoin='round' stroke-width='2'%3E%3Cpath d='M34.66 24.76c-.04.204-.002.45.138.767a7.1 7.1 0 0 1 .432 1.29c.499 2.163 1.495 3.659 5.317 5.82c3.394 1.919 10.32 15.51 11.83 18.53c.195.388.3.816.31 1.25l.128 5.815a2.95 2.95 0 0 0 .66 1.794l1.852 2.283a2.946 2.946 0 0 0 4.11.457l3.483-2.744a2.95 2.95 0 0 0 .7-3.842L42.48 21.44c-.315-.52-.525-.808-.732-.918'/%3E%3Crect width='13.56' height='13.46' x='14.32' y='25.04' rx='2.359' ry='2.359' transform='rotate(-30.014) skewX(-.028)'/%3E%3Cpath d='m31.02 24.98l-9.465 11.24c-3.463 4.049-17.14-17.64-12.65-19.27l17.34-3.026'/%3E%3C/g%3E%3C/svg%3E");
 }

.icon--openmoji--balance-scale {
    background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 72 72' width='72' height='72'%3E%3Cpath fill='%239B9B9A' d='M48.063 62.92c0-3.314-5.597-6-12.5-6s-12.5 2.686-12.5 6h25z'/%3E%3Cpath fill='%23D0CFCE' d='M24.9 46.966c0 2.193-2.198 3.972-4.91 3.972s-4.91-1.779-4.91-3.972h9.82zm33-.041c0 2.194-2.198 3.972-4.91 3.972s-4.91-1.778-4.91-3.972h9.82z'/%3E%3Cpath fill='none' stroke='%23000' stroke-linecap='round' stroke-linejoin='round' stroke-miterlimit='10' stroke-width='2' d='M16 25.17c2.666 0 8.954-5.334 20-5.334s14.667 4 20 5.334m-20-1.264v28'/%3E%3Ccircle cx='36' cy='13.895' r='3'/%3E%3Cpath fill='none' stroke='%23000' stroke-linecap='round' stroke-linejoin='round' stroke-miterlimit='10' stroke-width='2' d='M48 61.906c0-3.313-5.596-6-12.5-6s-12.5 2.687-12.5 6m3-16a6 6 0 0 1-12 0h12zm-6-18l-5 18h10zm0 0v18m39 0a6 6 0 0 1-12 0h12zm-6-18l-5 18h10zm0 0v18'/%3E%3C/svg%3E");
 }
```

[/mdi.css?icons=account-box,account-cash,account,home](https://api.iconify.design/mdi.css?icons=account-box,account-cash,account,home):

css
```
.icon--mdi {
    display: inline-block;
    width: 1em;
    height: 1em;
    background-color: currentColor;
    -webkit-mask: no-repeat center / 100%;
    mask: no-repeat center / 100%;
    -webkit-mask-image: var(--svg);
    mask-image: var(--svg);
 }

.icon--mdi--account-box {
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cpath fill='black' d='M6 17c0-2 4-3.1 6-3.1s6 1.1 6 3.1v1H6m9-9a3 3 0 0 1-3 3a3 3 0 0 1-3-3a3 3 0 0 1 3-3a3 3 0 0 1 3 3M3 5v14a2 2 0 0 0 2 2h14a2 2 0 0 0 2-2V5a2 2 0 0 0-2-2H5a2 2 0 0 0-2 2Z'/%3E%3C/svg%3E");
 }

.icon--mdi--account-cash {
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cpath fill='black' d='M11 8c0 2.21-1.79 4-4 4s-4-1.79-4-4s1.79-4 4-4s4 1.79 4 4m0 6.72V20H0v-2c0-2.21 3.13-4 7-4c1.5 0 2.87.27 4 .72M24 20H13V3h11v17m-8-8.5a2.5 2.5 0 0 1 5 0a2.5 2.5 0 0 1-5 0M22 7a2 2 0 0 1-2-2h-3c0 1.11-.89 2-2 2v9a2 2 0 0 1 2 2h3c0-1.1.9-2 2-2V7Z'/%3E%3C/svg%3E");
 }

.icon--mdi--account {
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cpath fill='black' d='M12 4a4 4 0 0 1 4 4a4 4 0 0 1-4 4a4 4 0 0 1-4-4a4 4 0 0 1 4-4m0 10c4.42 0 8 1.79 8 4v2H4v-2c0-2.21 3.58-4 8-4Z'/%3E%3C/svg%3E");
 }

.icon--mdi--home {
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cpath fill='black' d='M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5Z'/%3E%3C/svg%3E");
 }
```

## Options

API query has optional params that you can use to get different results.

See [API query documentation](https://iconify.design/docs/api/css.html) for more details.

[Page 11](https://iconify.design/docs/usage/css/tailwind/ "Current Page.")

## Iconify for Tailwind CSS

Iconify plugin for Tailwind CSS makes it easy to use icons in Tailwind CSS.

You can use [over 275,000 open source icons](https://iconify.design/docs/icons/icon-data.html) and custom icons with minimal code.

## Plugins

There are separate plugins for Tailwind 3 and Tailwind 4.

Tailwind 3 plugin is also usable with Tailwind 4, but requires creating a configuration file.

Follow one of these links for documentation:

- [Documentation for Tailwind 4 plugin](https://iconify.design/docs/tailwind4/)
- [Documentation for Tailwind 3 plugin](https://iconify.design/docs/tailwind3/)

[Page 12](https://iconify.design/docs/usage/css/tailwind/tailwind4/ "Current Page.")

## Iconify for Tailwind CSS

Iconify plugin for Tailwind CSS makes it easy to use icons in Tailwind CSS.

You can use [over 275,000 open source icons](https://iconify.design/docs/icons/icon-data.html) and custom icons with minimal code.

## Plugins

This documentation covers plugin for Tailwind 4.

For an older Tailwind 3 plugin, see [Tailwind 3 plugin documentation](https://iconify.design/tailwind3/). It works with Tailwind 4 too, currently has more options than new plugin, but requires creating a config file.

## Installation

To install plugin, add @iconify/tailwind4 as dev dependency:

```
npm i -D @iconify/tailwind4
```

Plugin does not include icons. You need to add icon sets you want to use.

To add all open source icon sets, add @iconify/json as dev dependency:

```
npm i -D @iconify/json
```

You can also install only icon sets that you want to use by installing @iconify-json/{prefix} dependencies (where "{prefix}" is icon set prefix), such as @iconify-json/mdi-light.

See [icon data documentation](https://iconify.design/docs/icons/icon-data.html).

## Basic usage

Add this to your CSS:

css
```
@plugin "@iconify/tailwind4";
```

To use icons, add dynamic selector for icon, such as

html
```
<span class="icon-[mdi-light--home]"></span>
```

Browse or search icons at [Iconify icon sets website](https://icon-sets.iconify.design/solar/), click icon you want to use, in code options select "CSS" -> "Tailwind CSS" and copy code.

### Options

Plugin supports several options:

- prefix to set custom icon prefix instead of "icon".
- scale to set default icon size. If you do not set icon size, it will have height of "1em".

Example of configuration:

css
```
@plugin "@iconify/tailwind4" {
  prefix: "iconify";
  scale: 1.2;
 }
```

### Custom icons

Plugin supports custom icons and icon sets via icon-sets option.

See [custom icons](https://iconify.design/docs/custom-icons.html) documentation.

### Clean selectors

There are actually 2 plugins in one:

- Plugin for dynamic selectors, such as in code example above
- Plugin for clean selectors

Plugin for clean selectors uses a cleaner syntax for icons, but requires adding a configuration:

html
```
<span class="iconify mdi-light--home"></span>
<span class="iconify-color vscode-icons--file-type-tailwind"></span>
```

What configuration is required?

You need to specify what icon sets you want to render.

This is done by setting list of prefixes:

css
```
@plugin "@iconify/tailwind4" {
  prefixes: mdi-light, vscode-icons;
 }
```

### Extra class name

Each icon has 2 class names:

- Class name for icon, such as "mdi-light--home".
- Class name for rendering mode: "iconify" or "iconify-color" (can be configured).

All icons share same rules, except for image URL.

To avoid duplication, common rules were split into utility classes. Additionally, this allows you to choose how icon is rendered:

- "iconify" renders an icon as a mask image, so icon uses same color as text. To change icon color, change text color. This is used for icons without hardcoded palette.
- "iconify-color" renders an icon as a background image. This is used for icons with hardcoded palette.

#### Why is config required?

Why is it needed?

Tailwind CSS works by finding class names in your code and rendering CSS for those class names.

When working with dynamic class names, such as "icon-\[mdi-light--home\]", Tailwind CSS finds all such class names and passes them to a plugin to generate CSS. That means plugin knows which icons are used and loads only required icons.

However, when using plain class names, such as "mdi-light--home", Tailwind CSS requires a plugin to generate CSS for all possible class names first, before finding class names in your project, then it removes unused class names. That means plugin must generate CSS for every single icon that might exist.

Generating CSS for every single icon is not a fast process. With over 275,000 icons available, it might take a lot of time. Then Tailwind CSS keeps it all in memory, which might cause Tailwind CSS to run out of memory. To avoid that, you must specify list of icon sets you want to use.

[Page 13](https://iconify.design/docs/usage/css/tailwind/tailwind4/size-color.html "Current Page.")

## Changing icon size and color in Iconify for Tailwind CSS

This documentation explains how to change icon size and color for [Iconify plugin for Tailwind CSS 4](https://iconify.design/docs/).

## Icon color

There are two types of icons:

- Icons with hardcoded palette.
- Monotone icons.

See [how monotone icons work in CSS](https://iconify.design/#monotone) (html syntax in linked tutorial is different - tutorial is not specific to this plugin).

### Dynamic selectors

When using dynamic selectors plugin, it automatically sets rendering mode for each icon. You cannot control it.

- Icons with hardcoded palette will be rendered as background images, keeping icon's color.
- Monotone icons will be rendered as mask images, so icon is rendered with text color.

For example, "icon-\[mdi-light--home\]" will be rendered as a mask image because that icon is a monotone icon.

### Clean selectors

When using clean selectors, you need to specify how you want icon to be rendered by adding either:

- "iconify" class name to render icon as a mask image, so icon is rendered with text color.
- "iconify-color" class name to render icon as a background image.

#### Setting a default rendering mode

Optionally you can set one of these modes as default. The following code allows you to skip adding the "iconify" class when using any icon from the `mdi` icon set.

css
```
[class*="mdi--"]:not([class*="iconify-color"]) {
    @apply iconify;
  }
```

#### Monotone icons

To change the color of monotone icons, render them as mask images and change text color:

html
```
<span class="iconify mdi-light--home text-blue-600"></span>
```

#### Icons with palette

Icons with hardcoded palette currently cannot be customised.

html
```
<span class="iconify-color twemoji--winking-face"></span>
```

Custom colors are possible though if you use [plugin for Tailwind CSS 3](https://iconify.design/iconify/customise.html). It uses JavaScript for configuration, which opens a lot more possibilities than CSS configuration Tailwind CSS 4.

## Icon size

By default, icons are rendered as 1em x 1em square.

To change icon size, you can change font size:

html
```
<span class="iconify mdi-light--home text-2xl"></span>
```

Because common selectors, which contain size, are treated as Tailwind components, you can also set width/height to resize icon:

html
```
<span class="iconify mdi-light--home w-12 h-12"></span>
```

Make sure width and height are identical (see square option below). Some browsers (Safari) fail to keep proportions when using SVG as a mask image, so using different width and height values might result in unexpected user experience for some users.

Additionally, you can change default size by using scale option.

### Non-square icons

By default, all icons are rendered as square icons. This makes it easy to resize icons.

However, if you want to render non-square icons as is, you can disable this behavior by changing option square to false:

css
```
@plugin "@iconify/tailwind4" {
  square: false;
 }
```

However, be aware that this might make resizing icon a bit more complex. If you are setting width and height, make sure width/height ratio matches icon's ratio.

### Scaling icon

Option scale changes default icon size from 1em.

The following configuration

css
```
@plugin "@iconify/tailwind4" {
  scale: 1.2;
 }
```

changes default size to 1.2em x 1.2em square.

You can use font size to further resize icons, like in the example above, but icons will be 1.2 times bigger.

[Page 14](https://iconify.design/docs/usage/css/tailwind/tailwind4/custom-icons.html "Current Page.")

## Custom icons in Iconify for Tailwind CSS

This documentation explains how to use [Iconify plugin for Tailwind CSS 4](https://iconify.design/docs/) with custom icons.

## Loader options

There are two methods of loading icon sets:

- Loading a pre-parsed icon set in [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") format.
- Loading all icons in a folder.

Syntax is similar:

css
```
@plugin "@iconify/tailwind4" {
  icon-sets: from-json(test, "./icon-sets/test.json"), from-folder(test2, "./icon-sets/svgs");
 }
```

Add option icon-sets to plugin config in CSS, with comma separated sets of options.

## Loading from JSON file

Loading from JSON file is faster because there is no clean up to do, so if you can, load icon sets from a JSON file.

File must be in [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") format, which can be created with [Iconify Tools](https://iconify.design/docs/libraries/tools/).

To add an icon set to config, add from-json() function to icon-sets option, with two values:

- Icon set prefix
- Path to.json file, relative to project's root directory

## Loading from folder

Loading from folder makes it easy to use existing icons without pre-parsing them.

To add a folder with icons to config, add from-folder() function to icon-sets option, with two values:

- Icon set prefix
- Path to folder, relative to project's root directory

You can load icons from multiple folders by adding multiple entries with different prefixes to icon-sets option.

### Clean up

Icons loaded from folder are cleaned up and optimised.

If you do not want this, pre-parse icons, export them as [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") file and load.json file instead.

How icons are handled:

- All names are cleaned up: converted to lower case with dash as separator.
- Icon palette is checked. If icon has more than one color, it is treated as a colored icon and rendered as background image. If icon has one color, it is treated as a monotone icon and rendered as a mask image.

## Examples

Examples of configuration:

css
```
@plugin "@iconify/tailwind4" {
  icon-sets: from-json(test, "./icon-sets/test.json"), from-folder(test2, "./assets/svg");
 }

@plugin "@iconify/tailwind4" {
  prefix: "square-icon";
  square: true;
  icon-sets: from-folder(test3, "./assets/svg");
 }
```

[Page 15](https://iconify.design/docs/usage/css/tailwind/tailwind3/ "Current Page.")

## Iconify for Tailwind CSS

Iconify plugin for Tailwind CSS makes it easy to use icons in Tailwind CSS.

You can use [over 275,000 open source icons](https://iconify.design/docs/icons/icon-data.html) and custom icons with minimal code.

## Tailwind CSS version

This documentation covers plugins for Tailwind 3.

For a newer Tailwind 4 plugin, see [Tailwind 4 plugin documentation](https://iconify.design/tailwind4/).

However, Tailwind 3 plugins can be used with Tailwind 4 too, but you need to create a configuration file.

## Plugins

There are several plugins available, they use different syntax, have different options.

There are 2 main plugins:

- [addDynamicIconSelectors()](https://iconify.design/docs/usage/css/tailwind/dynamic/ "addDynamicIconSelectors() documentation")
- [addIconSelectors()](https://iconify.design/docs/usage/css/tailwind/iconify/ "addIconSelectors() documentation")

Plugins use different syntax, have different options.

For example, here is syntax to use icon mdi-light:home in HTML:

html
```
<span class="icon-[mdi-light--home]"></span>
```

html
```
<span class="iconify mdi-light--home"></span>
<span class="iconify-color vscode-icons--file-type-tailwind"></span>
```

### Installation

To install plugins, add @iconify/tailwind as dev dependency:

```
npm i -D @iconify/tailwind
```

Then you need to configure it.

#### Tailwind 3 configuration

For Tailwind CSS 3, open tailwind.config.js, import [addIconSelectors](https://iconify.design/docs/usage/css/tailwind/iconify/ "addIconSelectors() documentation") (main plugin) or [addDynamicIconSelectors](https://iconify.design/docs/usage/css/tailwind/dynamic/ "addDynamicIconSelectors() documentation") (dynamic selectors) from @iconify/tailwind and add it to a list of plugins.

Example tailwind.config.js with [addIconSelectors()](https://iconify.design/docs/usage/css/tailwind/iconify/ "addIconSelectors() documentation") plugin:

js
```
const { addIconSelectors } = require("@iconify/tailwind");

/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./src/*.html"],
  plugins: [
    // Iconify plugin for clean selectors, requires writing a list of icon sets to load
    // Icons usage in HTML:
    //  <span class="iconify mdi-light--home"></span>
    //  <span class="iconify-color vscode-icons--file-type-tailwind"></span>
    addIconSelectors(["mdi-light", "vscode-icons"]),
  ],
 };
```

Example tailwind.config.js with [addDynamicIconSelectors()](https://iconify.design/docs/usage/css/tailwind/dynamic/ "addDynamicIconSelectors() documentation") plugin:

js
```
const { addDynamicIconSelectors } = require("@iconify/tailwind");

/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./src/*.html"],
  plugins: [
    // Iconify plugin for dynamic selectors, configuration is not required
    // Icons usage in HTML:
    //  <span class="i-[mdi-light--home]"></span>
    addDynamicIconSelectors(),
  ],
 };
```

#### Tailwind 4 config

For Tailwind 4, you need to create a new file, for example, icons.mjs with configuration:

js
```
import { addDynamicIconSelectors } from "@iconify/tailwind";

export default addDynamicIconSelectors();
```

Then in your CSS file import that plugin:

css
```
@plugin './icons.mjs';
```

All code samples in documentation are for Tailwind CSS 3.

Tailwind CSS 4 configuration is similar, except that instead of adding plugin to plugins property of Tailwind configuration, you need to export it as a default export.

This requires basic understanding of how modules and exports work.

### Icon sets

Plugin does not include icons. You need to add icon sets you want to use.

To add all open source icon sets, add @iconify/json as dev dependency:

```
npm i -D @iconify/json
```

You can also install only icon sets that you want to use by installing @iconify-json/{prefix} dependencies (where "{prefix}" is icon set prefix), such as @iconify-json/mdi-light.

See [icon data documentation](https://iconify.design/docs/icons/icon-data.html).

#### Custom icon sets

Plugins also work with custom icon sets, see detailed documentation below.

## Usage

For more details, see documentation for each plugin:

- [addIconSelectors() plugin documentation](https://iconify.design/iconify/).
- [addDynamicIconSelectors() plugin documentation](https://iconify.design/dynamic/).

[Page 16](https://iconify.design/docs/usage/css/tailwind/iconify/ "Current Page.")

## Using Iconify plugin for Tailwind CSS

[Iconify plugin for Tailwind CSS package](https://iconify.design/) has several plugins. This documentation covers addIconSelectors plugin.

This plugin for Tailwind 3, which can also be used with Tailwind 4 but requires creating a config file.

For newer Tailwind 4 plugin, see [Tailwind 4 plugin documentation](https://iconify.design/tailwind4/).

## The Difference

What makes this plugin different from [addDynamicIconSelectors()](https://iconify.design/docs/usage/css/tailwind/dynamic/ "addDynamicIconSelectors() documentation")?

- More compact CSS, reusing common code.
- Cleaner icon names.
- You can use the same icon as mask or background image.

Downsides:

- Requires configuration. You must list icon sets you want to use.

## HTML

To add icon to HTML, all you have to do is create a <span> element with two class names:

- Class name to render icon as background or mask image.
- Class name with icon name (CSS contains icon data).

Examples:

html
```
<span class="iconify ph--alarm-duotone"></span>
<span class="iconify-color fluent-emoji-flat--alarm-clock"></span>
<span class="iconify carbon--edit-off"></span>
```

Why two class names? To reduce duplication and make CSS much smaller. One class has only icon data, another reusable class tells the browser how to render that icon data.

### Icon class names

Each rendered icon shares most of its rules with other icons. By splitting those rules into separate classes, CSS becomes much smaller.

#### Icon name selector

Icon name selector sets icon data. Syntax is "{prefix}--{name}", where "{prefix}" is icon set prefix, "{name}" is icon name. Syntax can be easily changed in [plugin options](https://iconify.design/docs/prefixes.html).

CSS generated by plugin for an icon:

css
```
.mdi-light--home {
  --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cpath fill='black' d='m16 8.41l-4.5-4.5L4.41 11H6v8h3v-6h5v6h3v-8h1.59L17 9.41V6h-1zM2 12l9.5-9.5L15 6V5h3v4l3 3h-3v8h-5v-6h-3v6H5v-8z'/%3E%3C/svg%3E");
 }
```

#### Iconify selector

Icon can be rendered as either background image or mask image.

Mask image renders icon in text color. See [how monotone icons work in CSS](https://iconify.design/#monotone). To render icon as a mask image, add "iconify" selector.

Background image renders icon in color that is set in icon (should be used for things like emojis that have hardcoded palette). To render icon as a background image, add "iconify-color" selector.

Selectors can be easily changed in [plugin options](https://iconify.design/docs/prefixes.html).

CSS generated by plugin for reusable selectors:

css
```
.iconify {
  display: inline-block;
  width: 1em;
  height: 1em;
  background-color: currentColor;
  -webkit-mask-image: var(--svg);
  mask-image: var(--svg);
  -webkit-mask-repeat: no-repeat;
  mask-repeat: no-repeat;
  -webkit-mask-size: 100% 100%;
  mask-size: 100% 100%;
 }

.iconify-color {
  display: inline-block;
  width: 1em;
  height: 1em;
  background-image: var(--svg);
  background-repeat: no-repeat;
  background-size: 100% 100%;
 }
```

### Color and size

To change icon color and size, use color and size class names like you would for any text:

html
```
<span class="iconify ph--alarm-duotone text-red-600 text-2xl"></span>
```

You can also resize an icon using width and height:

html
```
<span class="iconify-color twemoji--cat-face w-12 h-12"></span>
```

Make sure width and height are the same because some browsers (Safari) fail to keep proportions when using SVG as a mask image.

If you set option square to false, icons are not square, and you are using custom width and height classes, make sure width/height ratio matches icon's width/height ratio.

See [size documentation](https://iconify.design/docs/size-color.html#custom).

## Usage

To add plugin to Tailwind CSS, you need to open tailwind.config.js, import addIconSelectors from @iconify/tailwind and add it to a list of plugins.

### Basic usage

js
```
const { addIconSelectors } = require("@iconify/tailwind");

/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./src/*.html"],
  plugins: [
    // Iconify plugin, requires writing list of icon sets to load
    addIconSelectors(["mdi", "mdi-light"]),
  ],
 };
```

Parameter to addIconSelectors is an array of icon sets you want to use.

To avoid generating too many icons, which would take a huge amount of time, you need to tell plugin which icon sets you want to use.

Entry can be an icon set prefix or [a custom icon set](https://iconify.design/docs/prefixes.html).

#### Size and color

See [size and color documentation](https://iconify.design/docs/size-color.html).

### Advanced usage

The plugin also accepts an object with options as parameter.

The only required option is prefixes, which is a list of prefixes, same as an array in the example above.

js
```
const { addIconSelectors } = require("@iconify/tailwind");

/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./src/*.html"],
  plugins: [
    // Iconify plugin, requires writing list of icon sets to load
    addIconSelectors({
      // List of prefixes, required
      prefixes: ["mdi", "mdi-light"],

      // All other properties below are optional. This example shows default values.
      // Mask and background selectors
      maskSelector: ".iconify-color",
      backgroundSelector: ".iconify",
      // Icon selector, must have "{prefix}" and "{name}" in it
      iconSelector: ".{prefix}--{name}",
      // Variable name to use for icon data
      varName: "svg",
      // Scale icons, which sets width/height in background/mask selectors
      scale: 1,
      // Make icons square
      square: true,
      // Extra rules to add to mask and background selectors
      extraMaskRules: {},
      extraBackgroundRules: {},
      // Callback to customise icons (such as change stroke-width, color, etc...).
      // First param is content, second is icon name, third is icon set prefix.
      // Function should return modified content.
      customise: (content, name, prefix) => content,
    }),
  ],
 };
```

## Options

Plugin options:

- prefixes, (string|IconSetOptions)\[\] - [array of icon sets to load](https://iconify.design/docs/prefixes.html).
- maskSelector, string - custom mask selector. Set to empty string to disable it.
- backgroundSelector, string - custom background selector. Set to empty string to disable it.
- iconSelector, string - custom icon selector. Must include "{prefix}" and "{name}".
- varName, string - CSS variable name to use for icon data.
- scale - scales icons. See below.
- square, boolean - makes icons square. Set to false to generate non-square icons.
- extraMaskRules - extra rules to add to mask selector.
- extraBackgroundRules - extra rules to add to background selector.
- customise - callback to customise icon. You can use it to [change stroke width, color](https://iconify.design/docs/customise.html) and so on.

Default values for all options, except prefixes are shown in code sample above. The default value for prefixes is an empty array.

### Prefixes list

This plugin requires setting a list of icon sets you want to use, set as either the only parameter to plugin or as prefixes property in options.

You can use it to:

- Select icon sets you want to use.
- Filter icons to render only icons that you need, which improves plugin performance.
- Customise icons.
- Import custom icon sets.

See [prefixes option documentation](https://iconify.design/docs/prefixes.html) for details and usage examples.

### Customise option

Customise option can be used to customise icons.

You can change icon color, stroke width, animation duration and so on.

See [customise option documentation](https://iconify.design/docs/customise.html) for details and usage examples.

### Selectors

Options maskSelector and backgroundSelector can be used to customise selectors used for background and mask.

See [selectors options documentation](https://iconify.design/docs/selectors.html) for details and usage examples.

## Issues

If everything is done correctly, icons should work.

Possible issues:

### Errors when building CSS

If an icon set is missing or icon is missing, the plugin will throw errors.

See error message. If the plugin cannot find an icon set, install dependency. If the plugin cannot find icon, you are using the wrong icon name.

### Selectors do not work

You have added class names, built your CSS, but icons do not work?

First, make sure the class name is correct. If it is correct, most likely Tailwind CSS is not seeing your class names. If you are familiar with Tailwind CSS, the process of fixing it is exactly the same as any other missing class name:

- You can check if your files are scanned.
- You can add it to safelist in config.

[Page 17](https://iconify.design/docs/usage/css/tailwind/iconify/size-color.html "Current Page.")

## Changing icon size and color in Iconify for Tailwind CSS

This documentation explains how to change icon size and color for [addIconSelectors](https://iconify.design/docs/usage/css/tailwind/iconify/ "addIconSelectors() documentation") plugin.

## Icon color

There are two types of icons:

- Icons with hardcoded palette.
- Monotone icons.

See [how monotone icons work in CSS](https://iconify.design/#monotone) (html syntax in linked tutorial is different - tutorial is not specific to this plugin).

### Monotone icons

To change the color of monotone icons, render them as mask images and change text color:

html
```
<span class="iconify mdi-light--home text-blue-600"></span>
```

### Icons with palette

Icons with hardcoded palette aren't designed to be customisable. However, [addIconSelectors](https://iconify.design/docs/usage/css/tailwind/iconify/ "addIconSelectors() documentation") plugin gives you option to change color via [customise](https://iconify.design/docs/customise.html) option.

For example, this code will change yellow background in Twitter emojis with red:

js
```
addIconSelectors({
    prefixes: [
        // Render 'twemoji' icon set
        'twemoji',
        // Render 'twemoji' as 'twemoji-red' with custom color changes 
        {
            // Change icon set prefix by setting 'prefix' property
            prefix: 'twemoji-red',
            
            // Resolve location of icon set from '@iconify-json/twemoji' package 
            // Also below is the same code, using '@iconify/json' package
            source: require.resolve('@iconify-json/twemoji/icons.json'),
            // source: require.resolve('@iconify/json/json/twemoji.json'),
            
            // Filter only icons that contain 'face' to improve plugin performance
            icons: (name) => name.includes('face'),
            
            // Change color
            customise: (content, name) => content.replaceAll('#ffcc4d', '#ff9667'),
        },
    ],
 })
```

Then you can use both original and customised icons:

html
```
<span class="iconify-color twemoji--winking-face"></span>
<span class="iconify-color twemoji-red--winking-face"></span>
```

See [customise option documentation](https://iconify.design/docs/customise.html) for details and usage examples.

Also see [prefixes option documentation](https://iconify.design/docs/prefixes.html) for explanation of how the configuration above works.

## Icon size

By default, icons are rendered as 1em x 1em square.

To change icon size, you can change font size:

html
```
<span class="iconify mdi-light--home text-2xl"></span>
```

Because common selectors, which contain size, are treated as Tailwind components, you can also set width/height to resize icon:

html
```
<span class="iconify mdi-light--home w-12 h-12"></span>
```

Make sure width and height are identical (see square option below). Some browsers (Safari) fail to keep proportions when using SVG as a mask image, so using different width and height values might result in unexpected user experience for some users.

Additionally, you can change default size by using scale option.

### Non-square icons

By default, all icons are rendered as square icons. This makes it easy to resize icons.

However, if you want to render non-square icons as is, you can disable this behavior by changing option square to false:

js
```
addIconSelectors({
    prefixes: ['fa6-regular'],
    square: false,
 })
```

However, be aware that this might make resizing icon a bit more complex. If you are setting width and height, make sure width/height ratio matches icon's ratio.

### Scaling icon

Option scale changes default icon size from 1em.

The following configuration

js
```
addIconSelectors({
    prefixes: ['mdi-light'],
    scale: 1.2,
 })
```

changes default size to 1.2em x 1.2em square.

You can use font size to further resize icons, like in the example above, but icons will be 1.2 times bigger.

### Fixed size

If you want to set default icon size to a fixed size in pixels, such as 24 to render icons that are designed for 24 x 24, you can set width and height in pixels using extraMaskRules or extraBackgroundRules options:

js
```
addIconSelectors({
    maskSelector: '.material-icon',
    extraMaskRules: {
        'width': '24px',
        'height': '24px',
    },
    backgroundSelector: '.material-icon-color',
    extraBackgroundRules: {
        'width': '24px',
        'height': '24px',
    },
 })
```

### Multiple sizes

What if you want to use 1em icons, icons without size and icons with fixed size in pixels in the same project?

You can use multiple instances of plugin with different settings and different selectors:

js
```
plugins: [
    // Default options, 1em size
    addIconSelectors(['mdi-light']),
    // Fixed size
    addIconSelectors({
        // Set fixed size
        maskSelector: '.material-icon',
        extraMaskRules: {
            'width': '24px',
            'height': '24px',
        },
        // Not using background selector for this demo - demo uses monotone icons only
        backgroundSelector: '',
    }),
 ]
```

html
```
<p>
  Icon with 1em size: 
  <span class="iconify mdi-light--home"></span>
</p>
<p>
  Using custom width/height: 
  <span class="iconify mdi-light--home h-12 w-12"></span>
</p>
<p>
  24px icon:
  <span class="material-icon mdi-light--home"></span>
</p>
```

Because icon data is identical in all instances of plugin, there is no need to change icon selector and the prefixes option needs to be used only once. This reduces duplication and makes parsing faster.

[Page 18](https://iconify.design/docs/usage/css/tailwind/iconify/prefixes.html "Current Page.")

## Selecting icon sets in Iconify for Tailwind CSS

This documentation covers prefixes option for [addIconSelectors](https://iconify.design/docs/usage/css/tailwind/iconify/ "addIconSelectors() documentation") plugin.

## Prefixes list

[addIconSelectors()](https://iconify.design/docs/usage/css/tailwind/iconify/ "addIconSelectors() documentation") plugin requires setting a list of icon sets you want to use, set as either the only parameter to plugin or as prefixes property in options.

Why is it needed?

- Iconify offers a massive number of icons. Tailwind CSS plugin system requires creating all selectors, which means parsing all icons. By selecting icon sets you want to use, plugin only parses those icon sets, reducing build time.
- It can be used for custom icon sets.

Value of prefixes list is an array, each entry can be:

- A string, containing icon set prefix.
- IconSetOptions object.

If you use a string with icon set prefix, all icons in icon set will be parsed without any changes.

IconSetOptions object gives you more control over icons, allowing you to filter icons, customise icons and load custom icon sets.

## IconSetOptions

Object IconSetOptions has the following properties:

- prefix, string. Icon set prefix.
- source, string| [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation"). Icon set source.
- icons, string\[\]|function. List of icons to load or a callback to filter icons.
- customise, function. Callback to customise icons.

Either prefix or source must be set. If both are set, the icon set is loaded from source, but prefix is set to value of prefix.

### Source

Property source of IconSetOptions can be:

- Location of icon set to load in [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") format.
- Icon set in [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") format.

### Icons

Property icons of IconSetOptions can be used to filter icons in the loaded icon set.

By filtering unused icons, you can improve parsing time, thus making the build process faster.

### Customise

Property customise of IconSetOptions can be used to customise icons. For example, to change stroke-width, change certain color in icons with color, change animation duration in animated icons and so on.

Callback has two parameters:

- content, string. SVG content.
- name, string. Icon name.

Callback should return new content. If icon is not modified, it should return value passed in content property.

## Examples

Examples of using prefixes option to load custom icon sets and customise icons:

js
```
addIconSelectors({
    prefixes: [
        {
            // Change stroke width in Tabler icons
            prefix: 'tabler',
            customise: (content) =>
                content.replaceAll('stroke-width="2"', 'stroke-width="1.5"'),
        },
        {
            // Change color in face emojis from Twitter, also rename icon set
            
            // Change icon set prefix by setting 'prefix' property
            prefix: 'twemoji-red',
            
            // Resolve location of icon set from '@iconify-json/twemoji' package 
            // Also below is the same code, using '@iconify/json' package
            source: require.resolve('@iconify-json/twemoji/icons.json'),
            // source: require.resolve('@iconify/json/json/twemoji.json'),
            
            // Filter only icons that contain 'face' to improve plugin performance
            icons: (name) => name.includes('face'),
            
            // Change color
            customise: (content, name) => content.replaceAll('#ffcc4d', '#ff9667'),
        },
        {
            // Load custom icon set. It can be pre-generated using Iconify Tools
            prefix: 'custom',
            source: 'data/custom.json',
            
            // Example of using Iconify Tools icon set as source. Assumes that customIconSet is an IconSet class instance. 
            // source: customIconSet.export(),
        },
    ],
 })
```

[Page 19](https://iconify.design/docs/usage/css/tailwind/iconify/selectors.html "Current Page.")

## Selectors in Iconify for Tailwind CSS

This documentation covers options that change selectors for [addIconSelectors](https://iconify.design/docs/usage/css/tailwind/iconify/ "addIconSelectors() documentation") plugin.

## Options

There are several selectors set by plugin:

- Selector for mask image rules, default value is ".iconify".
- Selector for background image rules, default value is ".iconify-color".
- Selectors for each icon, default value is ".{prefix}--{name}".

To render an icon, you need to use icon selector (which provides icon data) and either background or mask selector (which renders that icon).

You can customise all of them.

Why would you want to do that?

- To use multiple instances of plugin with different settings.
- To change class names because they conflict with something else.
- To keep using old class names after migrating from a different plugin or platform.

## Mask and background image

Mask and background image selectors must be used in each icon together with icon name selector. These selectors contain all rules needed to render icon as mask or background image.

To customise mask or background image selectors, use the following options:

- maskSelector, string - mask image selector, default value is ".iconify".
- backgroundSelector, string - background image selector, default value is ".iconify-color".

Set value to an empty string to disable it.

Why would you want to disable it? It can be useful if classes are already set somewhere else, such as another instance of plugin, or you are not using background or mask mode.

### Extra rules

You can also add CSS rules for background and mask selectors by using extraBackgroundRules and extraMaskRules options.

That can be used to change dimensions, display mode or add vertical alignment.

## Icon selector

Icon selector gives you control over icon name. To change it, change option iconSelector.

Value must include:

- "{prefix}" that is replaced with icon set prefix for each icon.
- "{name}" that is replaced with icon name.

Default value is ".{prefix}--{name}".

## Examples

The following configuration changes syntax to syntax used by UnoCSS:

However, be aware that you still must have a background or a mask selector for each icon, which UnoCSS does not use.

js
```
addIconSelectors({
    iconSelector: '.i-{prefix}-{name}',
    // UnoCSS uses scale 1.2 by default
    scale: 1.2
 })
```

html
```
<span class="iconify i-mdi-light-home"></span>
```

The following configuration will create several instances of plugin with different options:

js
```
plugins: [
    addIconSelectors(['mdi-light']),
    addIconSelectors({
        // Change selectors to avoid conflicts
        maskSelector: '.icon',
        backgroundSelector: '.icon-color',
        // Disable width and height 
        scale: 0,
        // Not using 'prefixes' because icons are already set in previous instance
        // Yes, you can mix selectors from different instances of plugin: background or mask from one, 
        // icon from another, but only as long as \`varName\` option is the same (or not customised).
        // Since icons used in example below are identical, no need to re-parse them.
    }),
    addIconSelectors({
        // Align icon below baseline and set fixed size
        maskSelector: '.material-icon',
        extraMaskRules: {
            'vertical-align': '-0.125em',
            'width': '24px',
            'height': '24px',
        },
        // Not using background selector for this demo - demo uses monotone icons only
        backgroundSelector: '',
    })
 ]
```

html
```
<p>
  Icon with 1em size: 
  <span class="iconify mdi-light--home"></span>
</p>
<p>
  Icon without size (using custom width/height): 
  <span class="icon mdi-light--home h-12 w-12"></span>
</p>
<p>
  24px icon aligned to bottom: 
  <span class="material-icon mdi-light--home"></span>
</p>
```

[Page 20](https://iconify.design/docs/usage/css/tailwind/iconify/customise.html "Current Page.")

## Customising icons in Iconify for Tailwind CSS

This documentation covers customise option for [addIconSelectors](https://iconify.design/docs/usage/css/tailwind/iconify/ "addIconSelectors() documentation") plugin.

## Customise callback

Option customise allows you to change content of icons.

What is it for?

- You can change stroke-width in icons that use stroke.
- You can change colors in icons that use hardcoded palette, such as emojis.
- You can change animation duration in animated icons.
- You can change opacity of semi-transparent elements.
- You can add extra shapes to icons.

...and so on. You have full control over SVG content.

## Usage

customise option is a function, which has 3 parameters:

- content, string. Icon content.
- name, string. Icon name.
- prefix, string. Icon set prefix.

Function should return modified content. If there is nothing to modify, it should return original content value.

## Example

Example of using customise option to change stroke-width in [Tabler icons](https://icon-sets.iconify.design/tabler/):

js
```
addIconSelectors({
    prefixes: ['tabler'],
    customise: (content, name, prefix) => {
        switch (prefix) {
            case 'tabler':
                return content.replaceAll('stroke-width="2"', 'stroke-width="1.5"');
        }
        return content;
    }
 })
```

## Conflicts

If you also have a customise option used in entry in [prefixes option](https://iconify.design/docs/prefixes.html), that callback has a priority and main customise will not be used for that icon set.

[Page 21](https://iconify.design/docs/usage/css/tailwind/dynamic/ "Current Page.")

## Using Iconify plugin for Tailwind CSS

[Iconify plugin for Tailwind CSS package](https://iconify.design/) has several plugins. This documentation covers addDynamicIconSelectors plugin.

This plugin for Tailwind 3, which can also be used with Tailwind 4 but requires creating a config file.

For newer Tailwind 4 plugin, see [Tailwind 4 plugin documentation](https://iconify.design/tailwind4/).

## The Difference

What makes this plugin different from [addIconSelectors()](https://iconify.design/docs/usage/css/tailwind/iconify/ "addIconSelectors() documentation")?

It is easier to use.

- No need to configure plugin.
- One class name per icon.

Downsides:

- Less compact CSS.
- Weird selectors (caused by Tailwind CSS plugin system limitations).

## HTML

To use icons in HTML, all you have to do is create <span> element with a class name that contains icon name.

Syntax of class names is this: "icon-\[{prefix}--{name}\]", where "{prefix}" is icon set prefix, "{name}" is icon name.

Examples:

html
```
<span class="icon-[ph--alarm-duotone]"></span>
<span class="icon-[fluent-emoji-flat--alarm-clock]"></span>
<span class="icon-[carbon--edit-off]"></span>
```

Make sure prefix and icon name are separated with two hyphens: "--".

Why such a complex syntax? It is because of Tailwind CSS limitations. It can handle dynamic class names only if they are created in format "rule-\[value\]".

## Usage

To add plugin to Tailwind CSS, you need to open tailwind.config.js, import addDynamicIconSelectors from @iconify/tailwind and add it to a list of plugins.

### Basic usage

js
```
const { addDynamicIconSelectors } = require("@iconify/tailwind");

/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./src/*.html"],
  plugins: [
    // Iconify plugin
    addDynamicIconSelectors(),
  ],
 };
```

#### Color

To change icon color, change text color. See [how monotone icons work in CSS](https://iconify.design/#monotone).

#### Size

See [icon size documentation](https://iconify.design/docs/size.html).

### Advanced usage

Plugin accepts options to customise plugin behavior.

If you need to, you can create several instances of plugin with different options.

You must use a different value for prefix option for each plugin instance!

js
```
const { addDynamicIconSelectors } = require("@iconify/tailwind");

/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./src/*.html"],
  plugins: [
    // Iconify plugin
    addDynamicIconSelectors({
      // Prefix for selectors, must be different for each addDynamicIconSelectors()
      prefix: "icon",
      // Removes redundant rules
      overrideOnly: false,
      // Icon height, 0 to disable size
      scale: 1,
      // Custom icon sets
      iconSets: {},
      // Callback to customise icons (such as change stroke-width, color, etc...).
      // First param is content, second is icon name, third is icon set prefix.
      // Function should return modified content.
      customise: (content, name, prefix) => content,
    }),
  ],
 };
```

## Options

Plugin options:

- prefix, string - prefix for dynamic class names.
- overrideOnly, boolean - if enabled, removes duplicate CSS.
- iconSets - icon sets as an object, it can be used for location of icon sets or custom icon sets.
- scale - scales icons. See below.
- customise - callback to customise icon. You can use it to [change stroke width, color](https://iconify.design/docs/customise.html) and so on.

Default values for all options are shown in code sample above.

### prefix

Option prefix sets prefix for dynamic class names.

Default value is "icon".

For example, if you set it to "icon-hover", like in a code sample above, you can use icons as "icon-hover-\[mdi-light--home\]".

Value must not include "-" at the end. Class names will always have "-" added after prefix. That's how Tailwind CSS dynamic class names work.

You can use multiple instances of plugin with different prefix values to support different configuration options, like in the example below.

### overrideOnly

If enabled, generated CSS will include only rules that override icons.

For example, with configuration in code example above, plugin will generate the following CSS for "icon-hover-\[mdi-light--arrow-right\]":

css
```
.icon-hover-\[mdi-light--arrow-right\] {
  --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cpath fill='black' d='M4 12h12.25L11 6.75l.66-.75l6.5 6.5l-6.5 6.5l-.66-.75L16.25 13H4v-1Z'/%3E%3C/svg%3E");
 }
```

This can be used in combination with default selectors to swap icon on hover without duplicating CSS:

js
```
/** @type {import('tailwindcss').Config} */
module.exports = {
    plugins: [
        // Plugin with dynamic selectors for '.icon-'
        addDynamicIconSelectors(),
        // Plugin with dynamic selectors that contains
        // only css for overriding icon for '.icon-hover-'
        addDynamicIconSelectors({
            prefix: 'icon-hover',
            overrideOnly: true,
        }),
    ],
 };
```

html
```
<span class="icon-[mdi--bell-outline] hover:icon-hover-[mdi--bell-off]"></span>
```

### iconSets

With iconSets you can use custom files for icon sets.

See [custom icon sets documentation](https://iconify.design/docs/icon-sets.html).

### scale

See [icon size documentation](https://iconify.design/docs/size.html).

### Customise option

Customise option can be used to customise icons.

You can change icon color, stroke width, animation duration and so on.

See [customise option documentation](https://iconify.design/docs/customise.html) for details and usage examples.

## Issues

If everything is done correctly, icons should work.

Possible issues:

### Errors when building CSS

If an icon set is missing or icon is missing, the plugin will throw errors.

See error message. If the plugin cannot find an icon set, install dependency. If the plugin cannot find icon, you are using the wrong icon name.

### Selectors do not work

You have added class names, built your CSS, but icons do not work?

First, make sure the class name is correct. If it is correct, most likely Tailwind CSS is not seeing your class names. If you are familiar with Tailwind CSS, the process of fixing it is exactly the same as any other missing class name:

- You can check if your files are scanned.
- You can add it to safelist in config.

## Multiple instances

You can add plugin to the plugin list in Tailwind CSS config multiple times, with different options.

Each addDynamicIconSelectors() entry in the plugin list should have different prefix option to avoid conflicts. The default value for prefix is "icon".

[Page 22](https://iconify.design/docs/usage/css/tailwind/dynamic/size.html "Current Page.")

## Changing icon size in Iconify for Tailwind CSS

This documentation explains how to change icon size and color for [addDynamicIconSelectors](https://iconify.design/docs/usage/css/tailwind/dynamic/ "addDynamicIconSelectors() documentation") plugin.

## Icon size

By default, icons are rendered with 1em height.

Width is set automatically, using icon's width/height ratio. Though the vast majority of icons are square, so usually width is the same as height.

To change icon size, you can change font size:

html
```
<span class="icon-[mdi-light--home] text-2xl"></span>
```

Additionally, you can:

- Change default size by using scale option.
- Remove size by setting scale to 0 and use width and height to resize icon.

### Scaling icon

Option scale changes default icon size from 1em.

The following configuration

js
```
addDynamicIconSelectors({
    scale: 1.2,
 })
```

changes default height to 1.2em.

You can use font size to further resize icons, like in the example above, but icons will be 1.2 times bigger.

### Custom size

To use width and height to resize icons, you need to set scale to 0:

js
```
addDynamicIconSelectors({
    scale: 0,
 })
```

If you do this, icons will not have width and height, so you must set size to each icon:

html
```
<span class="icon-[mdi-light--home] h-12 w-12"></span>
```

### Multiple sizes

What if you want to use 1em icons, icons without size and icons with fixed size in pixels in the same project?

You can use multiple instances of plugin with different settings and different selectors:

js
```
plugins: [
    // Default options, 1em height
    addDynamicIconSelectors(),
    // No size
    addDynamicIconSelectors({
        // Change prefix
        prefix: 'icon-nosize',
        // Disable width and height 
        scale: 0,
    })
 ]
```

html
```
<p>
  Icon with 1em size: 
  <span class="icon-[mdi-light--home]"></span>
</p>
<p>
  Icon without size (using custom width/height): 
  <span class="icon-nosize-[mdi-light--home] h-12 w-12"></span>
</p>
```

Note that prefix option in plugin config does not have "-" at the end, but it does in HTML. This is due to Tailwind CSS requirements for dynamic selectors. Make sure to not forget "-" in HTML.

[Page 23](https://iconify.design/docs/usage/css/tailwind/dynamic/icon-sets.html "Current Page.")

## Custom icon sets in Iconify for Tailwind CSS

This documentation covers iconSets option for [addDynamicIconSelectors](https://iconify.design/docs/usage/css/tailwind/dynamic/ "addDynamicIconSelectors() documentation") plugin.

## iconSets option

Option iconSets allows you to use custom icon sets with plugin.

Option is an object, where key is an icon set prefix, and value is one of the following:

- string: location of icon set JSON file in [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") format.
- [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation"): loaded icon set.
- function: callback that returns [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") icon set. Due to Tailwind plugin system limitations, callback must be synchronous.

Make sure icon set includes info property with palette set. Plugin uses this to tell if an icon set contains icons with hardcoded palette or monotone icons. Mixed icon sets cannot be used. See [IconifyInfo](https://iconify.design/docs/types/iconify-info.html "IconifyInfo documentation") type.

js
```
addDynamicIconSelectors({
    iconSets: {
        test: './icon-sets/test.json',
    },
 });
```

[Page 24](https://iconify.design/docs/usage/css/tailwind/dynamic/customise.html "Current Page.")

## Customising icons in Iconify for Tailwind CSS

This documentation covers customise option for [addDynamicIconSelectors](https://iconify.design/docs/usage/css/tailwind/dynamic/ "addDynamicIconSelectors() documentation") plugin.

## Customise callback

Option customise allows you to change content of icons.

What is it for?

- You can change stroke-width in icons that use stroke.
- You can change colors in icons that use hardcoded palette, such as emojis.
- You can change animation duration in animated icons.
- You can change opacity of semi-transparent elements.
- You can add extra shapes to icons.

...and so on. You have full control over SVG content.

## Usage

customise option is a function, which has 3 parameters:

- content, string. Icon content.
- name, string. Icon name.
- prefix, string. Icon set prefix.

Function should return modified content. If there is nothing to modify, it should return original content value.

## Example

Example of using customise option to change stroke-width in [Tabler icons](https://icon-sets.iconify.design/tabler/):

js
```
addDynamicIconSelectors({
    // Change prefix
    // Thin icons will be used as <span class="icon-thin-[tabler--app-window]"></span>
    // and <span class="icon-[tabler--app-window]"></span> will still have default 2px stroke
    prefix: 'icon-thin',
    // Customise content
    customise: (content, name, prefix) => {
        switch (prefix) {
            case 'tabler':
                return content.replaceAll('stroke-width="2"', 'stroke-width="1"');
        }
        return content;
    }
 })
```

[Page 25](https://iconify.design/docs/usage/css/unocss/ "Current Page.")

## Icons with UnoCSS

If you are using [UnoCSS](https://github.com/unocss/unocss), you can easily use [over 275,000 open source icons](https://iconify.design/docs/icons/icon-data.html) and custom icons with minimal code.

Among other features, UnoCSS has @unocss/preset-icons package that dynamically generates icons. It uses [icon data from Iconify](https://iconify.design/docs/icons/icon-data.html).

## Usage

To use icons with UnoCSS, add @unocss/preset-icons preset to config:

js
```
import presetIcons from '@unocss/preset-icons';

UnoCSS({
    presets: [
        presetIcons({
            /* options */
        }),
        // ...other presets
    ],
 });
```

In your code add element with the following class name: "i-" + icon set prefix + "-" + icon name.

Examples:

html
```
<span class="i-carbon-logo-github"></span>
<span class="i-mdi-light-home"></span>
```

It is that simple.

For more information, see [README file in preset-icons package](https://github.com/unocss/unocss/tree/main/packages/preset-icons/).

## Icon size

Be aware that by default, UnoCSS scales icons to 1.2em.

You can change that by changing scale option.

If you want to change width and height separately or make icon square, you can use customize option. See below.

## Custom icons

You can use UnoCSS with custom icons. During the build process, you can import, clean up and optimise icons using [Iconify Tools](https://iconify.design/docs/libraries/tools/).

See [demo from Iconify Tools package](https://github.com/iconify/tools/tree/main/%40iconify-demo/unocss). Configuration is in unocss.config.ts.

Functions used in that config file are documented in [Iconify Tools](https://iconify.design/docs/libraries/tools/) section of this documentation.

## Customise icons

You can customise icons using customize option.

Option customize is part of customizations option, it is a function has 3 parameters:

- customisations that can be used for flip or rotate icon.
- data, [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") with icon data.
- name, string with icon name in "prefix:name" format.

The first parameter is a legacy option, it is not really useful.

Icon data is a mutable object, you can change it to customise icon. You can change colors in icons that have hardcoded palette, opacity, timing for animations, add additional shapes and so on... You can also resize icon or add padding by messing with width, height, left and top properties.

See [IconifyIcon type](https://iconify.design/docs/types/iconify-icon.html) for icon data format.

Icon name lets you know which icon you are customizing.

### Examples

Making all icons square:

js
```
presetIcons({
    customizations: {
        customize: (defaultCustomizations, data, name) => {
            // Make icon square
            const width = data.width ?? 16;
            const height = data.height ?? 16;
            if (height > width) {
              // Set width to match height
              data.width = height;
              // Center icon horizontally by changing viewBox left position
              data.left = (data.left ?? 0) - (height - width) / 2;
            }
            
            return defaultCustomizations
        },
    }
 })
```

Changing color:

js
```
presetIcons({
    customizations: {
        customize: (defaultCustomizations, data, name) => {
            if (name === 'twemoji:blue-square') {
                // Turn blue square into red square
                data.body = data.body.replaceAll('#55ACEE', '#e83933')
            }
            
            return defaultCustomizations
        },
    }
 })
```

If something is not working, don't forget that you can always console.log(data) to see icon data.

[Page 26](https://iconify.design/docs/usage/css/utils/ "Current Page.")

## Generate CSS for icons with Iconify Utils

This method requires a bit of coding, using Node.js.

If you are not using Node.js or not comfortable with the code below, [consider other methods of generating CSS for icons](https://iconify.design/#tools).

## Node.js

If you do not have a Node.js app, you need to create one to generate CSS.

There are plenty of tutorials on how Node.js works, short version of steps:

- Install Node.js on your computer.
- Create an empty directory, run npm init -y to create a basic project.

## Dependencies

You need to install two dependencies:

- @iconify/utils to install [Iconify Utils](https://iconify.design/docs/libraries/utils/) that have function to generate CSS.
- @iconify/json to install [data for all open source icon sets](https://iconify.design/docs/icons/icon-data.html).

To install them, run

```
npm install --save-dev @iconify/utils @iconify/json
```

## Functions

Iconify Utils has several functions that generate CSS for icons:

- [getIconsCSS()](https://iconify.design/docs/libraries/utils/get-icons-css.html "getIconsCSS() documentation") generates CSS for selected icons from an icon set.
- [getIconCSS()](https://iconify.design/docs/libraries/utils/get-icon-css.html "getIconCSS() documentation") generates CSS for one icon (uses icon as a source instead of an icon set).
- [getIconsContentCSS()](https://iconify.design/docs/libraries/utils/get-icons-content-css.html "getIconsContentCSS() documentation") renders selected icons from an icon set as content of pseudo-elements.
- [getIconContentCSS()](https://iconify.design/docs/libraries/utils/get-icon-content-css.html "getIconContentCSS() documentation") renders one icon as content of pseudo-element (uses icon as source).

This tutorial shows how to use [getIconsCSS()](https://iconify.design/docs/libraries/utils/get-icons-css.html "getIconsCSS() documentation"), which fits most use cases.

## Build script

The process of building CSS is simple:

- Load icon set.
- Generate CSS for icons you need from that icon set.
- Save it to.css file.

js
```
import { readFile, writeFile } from 'node:fs/promises';
import { getIconsCSS } from '@iconify/utils';
import { locate } from '@iconify/json';

/**
 * List of icons. Key is icon set prefix, value is array of icons
 *
 * @type {Record<string, string[]>}
 */
const icons = {
    'mdi': ['home', 'menu'],
    'mdi-light': ['alert-circle', 'circle', 'help-circle'],
 };

// Parse each icon set
let code = '';
for (const prefix in icons) {
    // Find location of .json file
    const filename = locate(prefix);

    // Load file and parse it
    /** @type {import("@iconify/types").IconifyJSON} */
    const iconSet = JSON.parse(await readFile(filename, 'utf8'));

    // Get CSS
    const css = getIconsCSS(iconSet, icons[prefix]);

    // Add it to code
    code += css;
 }

// Save CSS file
await writeFile('assets/style.css', code, 'utf8');
console.log(\`Saved CSS (${code.length} bytes)\`);
```

Change the list of icons, location of.css file, run it to build CSS.

## Usage

To use those icons in HTML, use <span> elements with two class names: class name for the icon set, class name for the icon.

html
```
<span class="icon--mdi-light icon--mdi-light--alert-circle"></span>
```

## Options

There are options for [getIconsCSS()](https://iconify.design/docs/libraries/utils/get-icons-css.html "getIconsCSS() documentation") that you can use to customise generated CSS.

See [getIconsCSS() documentation](https://iconify.design/docs/libraries/utils/get-icons-css.html).

[Page 27](https://iconify.design/docs/usage/svg/ "Current Page.")

## How to embed SVG in HTML

Using SVG in HTML requires embedding HTML in documents.

[Skip to list of available tools](#tools) if you want to skip long explanation of how it all works.

## Advantages

There are advantages and disadvantages of using SVG in HTML over [using SVG in CSS](https://iconify.design/css/).

Advantages:

- You can easily target elements inside icons, such as changing stroke-width or controlling SVG animations.

However, it also has big disadvantages:

- There can be multiple entries for each icon. While this can be solved with SVG sprites, it is not always possible.
- Deep DOM tree and large document size.

### Security

Additionally, there could be security concerns.

SVG from untrusted sources should never be embedded in HTML. SVG can include scripts, links to external resources (fonts, other images) that could potentially be used for tracking.

All icons in Iconify packages pass very strict validation, so they do not contain any potentially harmful content, such as scripts and external resources.

## Usage

All you have to do is insert <svg> elements in your HTML wherever you want to use it.

svg
```
<svg xmlns="http://www.w3.org/2000/svg" width="1em" height="1em" viewBox="0 0 24 24">
    <path fill="currentColor" d="M12 4a4 4 0 0 1 4 4a4 4 0 0 1-4 4a4 4 0 0 1-4-4a4 4 0 0 1 4-4m0 10c4.42 0 8 1.79 8 4v2H4v-2c0-2.21 3.58-4 8-4Z"/>
</svg>
```

### External images

One possible solution to deep DOM tree and large document size is linking to external SVG files using <img> or <picture> tags.

However, it cannot be used for monotone icons. It is not possible to change color of external image without generating separate images for each used color. That makes external images unusable in the Iconify ecosystem.

A workaround is to use icons as external mask images in CSS. See [how to use SVG in CSS](https://iconify.design/css/).

## Tools

How to get SVG to add to your documents?

### Components

For many frameworks, there are components that handle embedding SVG in HTML:

- [Unplugin Icons](https://iconify.design/docs/unplugin/) for React, Vue, Svelte, Solid, Astro, Qwik.
- [Astro Icon](https://iconify.design/docs/astro/) for Astro.
- [Edge Iconify](https://github.com/edge-js/edge-iconify) for Edge template engine.
- [Iconify Prerendered](https://github.com/cawa-93/iconify-prerendered) is another option for Vue developers.

### Functions

Not using any frameworks, but want to automate the build process?

[Iconify Utils](https://iconify.design/docs/libraries/utils/) offers easy to use functions that generate SVG.

See [how to export SVG with Iconify Utils](https://iconify.design/docs/utils/).

### No code

If you do not want to use any components, you can get SVG at one of the following websites:

- [Iconify icon sets](https://icon-sets.iconify.design/) - official website.
- [Icones](https://icones.js.org/) - alternative website created by Anthony Fu.

Find icon you want to use, select it, copy SVG to clipboard, paste it to HTML.

## Custom components

Want to build a custom component that generates SVG?

Currently, you'll need to use JavaScript for that. There are no usable libraries for other programming languages.

### JavaScript

[Iconify Utils](https://iconify.design/docs/libraries/utils/) package includes all functions you need. Process of generating SVG is simple:

- Locate icon set file.
- Read it and parse JSON.
- Use [iconToSVG()](https://iconify.design/docs/libraries/utils/icon-to-svg.html "iconToSVG() documentation") to generate SVG content and attributes.
- Create an SVG element from it. See below.

Code samples that should help you:

- See [Iconify Utils documentation for SVG](https://iconify.design/docs/utils/).
- See [parseIconSet()](https://iconify.design/docs/libraries/utils/parse-icon-set.html "parseIconSet() documentation") or [getIconData()](https://iconify.design/docs/libraries/utils/get-icon-data.html "getIconData() documentation") to extract icon data from an icon set.
- See [iconToSVG()](https://iconify.design/docs/libraries/utils/icon-to-svg.html "iconToSVG() documentation") documentation.
- Source code for [Iconify for Tailwind CSS](https://github.com/iconify/iconify/tree/main/plugins/tailwind) for code to locate and load icon sets.

#### Convert iconToSVG result to SVG

Function [iconToSVG()](https://iconify.design/docs/libraries/utils/icon-to-svg.html "iconToSVG() documentation") does not return full SVG, it returns attributes for <svg> element and contents.

This is done on purpose. Many frameworks, such as React, expect you to use the framework specific code to create elements.

So, for React, you need to create an element like this:

js
```
const data = iconToSVG(icon, {});

return React.createElement('svg', {
    // Mandatory attributes
    xmlns: 'http://www.w3.org/2000/svg',
    xmlnsXlink: 'http://www.w3.org/1999/xlink',
    // width, height, viewBox
    ...data.attributes,
    // innerHTML
    dangerouslySetInnerHTML: {
        __html: data.body,
    },
 });
```

For other frameworks that use native ways to create elements, use similar framework specific code.

If a framework does not have some way to set innerHTML, which is required to set contents of <svg>, this code cannot be used. You'll need to find a way to convert HTML string to tree of components.

If you want to create full <svg> element as string, you can use [iconToHTML()](https://iconify.design/docs/libraries/utils/icon-to-html.html "iconToHTML() documentation") function to convert the result of [iconToSVG()](https://iconify.design/docs/libraries/utils/icon-to-svg.html "iconToSVG() documentation") to string:

js
```
const data = iconToSVG(icon, {});

return iconToHTML(data.body, data.attributes);
```

See [Iconify Utils examples](https://iconify.design/docs/utils/).

[Page 28](https://iconify.design/docs/usage/svg/no-code/ "Current Page.")

## SVG for icons without coding

You can get SVG for icons without writing any code.

There are 2 options:

- You can download SVG from Iconify website (very easy).
- You can use Iconify API to generate SVG (might be too complicated or inefficient).

If you would rather generate SVG programmatically, [consider using Iconify Utils](https://iconify.design/utils/).

## Websites

You can browse all available icons and copy code or SVG on the following websites:

- [Iconify icon sets](https://icon-sets.iconify.design/) - official website.
- [Icones](https://icones.js.org/) - alternative website created by Anthony Fu.

Find icon you want, select it, copy SVG to clipboard, paste it in your HTML.

## API

If you know the name of the icon you want to use, you can download SVG from Iconify API.

Iconify API is an open source hosted (or self-hosted) service for developers. Public Iconify API servers host over 275,000 icons from more than 200 open source icon sets.

You can get icons from public API by visiting URLs like this: https://api.iconify.design/mdi-light/home.svg.

Replace mdi-light with icon set prefix, home with icon name.

Optional parameters:

- ?height=none - removes width and height.
- ?height=auto - sets width and height to same as viewBox.
- ?color=black - changes currentColor to color, usable only for monotone icons. If color contains "#", replace it with "%23" (see URL encoding).
- ?box=1 - adds empty rectangle that match viewBox. When importing SVG to some software, such as Sketch, it is needed to maintain icon dimensions after import.
- ?download=1 - forces browser to download file.

Example: https://api.iconify.design/ri/account-box-line.svg?height=none&color=%23000&box=1

Process:

- Get SVG from API.
- Download and save it.
- Copy it to clipboard, paste in your HTML.

See [Iconify API documentation](https://iconify.design/docs/api/svg.html) for details and more parameters.

[Page 29](https://iconify.design/docs/usage/svg/unplugin/ "Current Page.")

## Unplugin Icons

Unplugin Icons is a plug-in that dynamically generates icon components.

You can use it to render icons if you are building an app using one of the following UI frameworks:

- React, Preact
- Vue 2.7+, Vue 3
- Svelte
- Solid
- Astro
- Qwik

With Unplugin Icons, you can easily use [over 275,000 open source icons](https://iconify.design/docs/icons/icon-data.html) and custom icons with minimal code.

## How does it work?

It is a plug-in that works with practically all modern build tools, generating components dynamically as needed.

## React example

tsx
```
import HomeIcon from '~icons/mdi/home';

function Demo() {
    return (
        <p>
            Home icon: <HomeIcon />
        </p>
    );
 }
```

## Vue example

Example of Vue template:

vue
```
<script setup lang="ts">
import MdiHome from 'virtual:icons/mdi/home';
</script>

<template>
    <p>Home icon: <MdiHome /></p>
</template>
```

## Installation and usage

Installation and usage instructions depend on what build tools and UI framework you are using.

See [Unplugin Icons readme](https://github.com/antfu/unplugin-icons) for instructions.

## Examples

If you want to see full examples, which include both configuration and templates, check out [Unplugin Icons examples](https://github.com/antfu/unplugin-icons/tree/main/examples).

## Custom icons

You can use Unplugin Icons with custom icons.

With [Iconify Tools](https://iconify.design/docs/libraries/tools/) you can import, clean up and optimise icons and use them with Unplugin Icons.

You can find a working example in [Iconify Tools repository](https://github.com/iconify/tools/tree/main/%40iconify-demo/unplugin), see vite.config.ts for example of config that loads custom icons.

Functions are documented in [Iconify Tools](https://iconify.design/docs/libraries/tools/) section of this documentation.

[Page 30](https://iconify.design/docs/usage/svg/utils/ "Current Page.")

## Generate SVG with Iconify Utils

This method requires a bit of coding, using Node.js.

If you are not using Node.js or not comfortable with the code below, [consider other methods of generating CSS for icons](https://iconify.design/#tools).

## Process

How it works:

- Load icon set data.
- Export icons as SVG files.

In the end, you'll have thousands of SVG files, which you can embed in HTML.

How you embed SVG in HTML depends on your project. If you can't automate it, simply copy/paste code from.svg file to.html file where you want to use icon.

## Node.js

If you do not have a Node.js app, you need to create one to generate CSS.

There are plenty of tutorials on how Node.js works, short version of steps:

- Install Node.js on your computer.
- Create directory for the project, run npm init -y to initialise it.

## Dependencies

You need to install 2 dependencies:

- @iconify/utils to install [Iconify Utils](https://iconify.design/docs/libraries/utils/) that have function to generate CSS.
- @iconify/json to install [data for all open source icon sets](https://iconify.design/docs/icons/icon-data.html).

To install them, run

```
npm install --save-dev @iconify/utils @iconify/json
```

## Scripts

There are two sample scripts, use whichever works better for your use case:

- Script that exports all icons as.svg files from an icon set.
- Script with function that generates SVG for selected icon.

### Export all icons

This script exports all icons from icon set as.svg files.

Process of generating SVG files is simple:

- Load icon set.
- Parse it to list all icons.
- In callback generate.svg files for each icon.

js
```
import { mkdir, readFile, writeFile } from 'node:fs/promises';
import { iconToSVG, iconToHTML, parseIconSetAsync } from '@iconify/utils';
import { locate } from '@iconify/json';

/**
 * Dimensions of generated SVG:
 * - '1em' -> 1em, easy to resize icons with font-size.
 * - 'auto' -> same as icon's viewBox.
 * - 'unset' -> no width/height in generated icons. You'll need to assign width and height in CSS.
 */
const height = '1em';

/**
 * List of icon sets you want to export
 *
 * @type {string[]}
 */
const prefixes = ['mdi', 'mdi-light'];

/**
 * Output directory for SVG
 */
const target = 'assets/svg';

// Parse each icon set
for (let i = 0; i < prefixes.length; i++) {
    const prefix = prefixes[i];

    // Find location of .json file
    const filename = locate(prefix);

    // Load file and parse it
    /** @type {import("@iconify/types").IconifyJSON} */
    const iconSet = JSON.parse(await readFile(filename, 'utf8'));

    // Create output directory if it doesn't exist
    const outDir = \`${target}/${prefix}\`;
    try {
        await mkdir(outDir, {
            recursive: true,
        });
    } catch {}

    // Get all icons
    let counter = 0;
    await parseIconSetAsync(iconSet, async (name, data) => {
        if (!data) {
            // Failed icon
            return;
        }

        // Generate SVG
        const { attributes, body } = iconToSVG(data, {
            height,
        });
        const svg = iconToHTML(body, attributes);

        // Save it
        await writeFile(\`${outDir}/${name}.svg\`, svg, 'utf8');
        counter++;
    });

    // Log it
    console.log(\`Exported ${counter} icons from ${iconSet.info?.name || prefix}\`);
 }
```

Change options, run it to export SVG files.

Functions from [Iconify Utils](https://iconify.design/docs/libraries/utils/) used in sample:

- [parseIconSetAsync()](https://iconify.design/docs/libraries/utils/parse-icon-set.html "parseIconSetAsync() documentation") to parse icon set.
- [iconToSVG()](https://iconify.design/docs/libraries/utils/icon-to-svg.html "iconToSVG() documentation") and [iconToHTML()](https://iconify.design/docs/libraries/utils/icon-to-html.html "iconToHTML() documentation") to generate SVG.

### Get SVG for icon

This script generates SVG for selected icon.

You can use that function in your build process to generate SVG, which you can embed in HTML.

Process of generating SVG:

- Load icon set.
- Get data for selected icon.
- Generate SVG.

js
```
import { readFileSync } from 'node:fs';
import { iconToSVG, iconToHTML, getIconData } from '@iconify/utils';
import { locate } from '@iconify/json';

/**
 * Default dimensions of generated SVG:
 * - '1em' -> 1em, easy to resize icons with font-size.
 * - 'auto' -> same as icon's viewBox.
 * - 'unset' -> no width/height in generated icons. You'll need to assign width and height in CSS.
 */
const height = '1em';

/**
 * Generate SVG
 *
 * @param {string} prefix Icon set prefix
 * @param {string} name Icon name
 * @param {import("@iconify/utils").IconifyIconCustomisations} customisations Optional icon customisations
 * @returns {string | undefined} SVG as string, undefined on failure
 */
export function generateSVG(prefix, name, customisations = { height }) {
    // Find and load icon set
    const filename = locate(prefix);

    // Load file and parse it
    /** @type {import("@iconify/types").IconifyJSON} */
    const iconSet = JSON.parse(readFileSync(filename, 'utf8'));

    // Get icon data
    const data = getIconData(iconSet, name);
    if (!data) {
        return;
    }

    // Generate SVG
    const { attributes, body } = iconToSVG(data, {
        height,
    });
    return iconToHTML(body, attributes);
 }

// Sample usage
console.log(generateSVG('mdi-light', 'home'));
```

Functions from [Iconify Utils](https://iconify.design/docs/libraries/utils/) used in sample:

- [getIconData()](https://iconify.design/docs/libraries/utils/get-icon-data.html "getIconData() documentation") to extract icon data from icon set.
- [iconToSVG()](https://iconify.design/docs/libraries/utils/icon-to-svg.html "iconToSVG() documentation") and [iconToHTML()](https://iconify.design/docs/libraries/utils/icon-to-html.html "iconToHTML() documentation") to generate SVG.

[Page 31](https://iconify.design/docs/usage/svg/astro/ "Current Page.")

## Astro Icon

Astro Icon is a simple icon component for [Astro](https://astro.build/).

With Astro Icon, you can easily use [over 275,000 open source icons](https://iconify.design/docs/icons/icon-data.html) and custom icons with minimal code.

## Installation

Install astro-icon:

```
npm i -D astro-icon
```

## Usage

Astro Icon can inline SVG directly in your HTML:

astro
```
---
import { Icon } from 'astro-icon/components'
---

<Icon name="mdi:home" />
```

It can also generate SVG sprites.

See [Astro Icon readme](https://github.com/natemoo-re/astro-icon) for more details.

[Page 32](https://iconify.design/docs/icon-components/ "Current Page.")

## Icons on demand

Iconify ecosystem has a unique feature: [Iconify API](https://iconify.design/docs/api/).

It can be used to [load icon data on demand](https://iconify.design/docs/api/icon-data.html) and is used by Iconify icon components.

[Skip to list of available components](#components) if you want to skip long explanation of how it all works.

## How does it work?

Iconify icon components are very easy to use. All developer has to specify is an icon name:

html
```
<iconify-icon icon="mdi:home"></iconify-icon>
```

Unlike [regular icon components](https://iconify.design/docs/usage/svg/), Iconify icon components do not bundle icon data. They load only data for icons used on currently viewed page at run time.

### Advantages

Loading icon data on demand has its advantages and disadvantages over using [regular icon components](https://iconify.design/docs/usage/svg/).

Advantages:

- Very easy to use.
- If you are using many icons on various pages, bundle size is smaller because icon data is loaded only as needed.
- It can be used with customisable themes, where a developer doesn't know which icons theme is using.
- Small HTML. Icons are loaded only in browser, not server side rendered.

Disadvantages:

- Requires access to Iconify API, making it unusable for offline applications. You can host your own API instance, but it is not trivial.
- Icons might not render instantly. Even though there are multiple layers of caching icon data, there is a few milliseconds delay in rendering.

## Components

The best option by far is [Web component](#web-component). It is usable in HTML with or without UI frameworks.

Additionally, there are [components for UI frameworks](#ui-frameworks): React, Vue, Svelte, Ember.

In future, only iconify-icon web component will be supported. Why?

- SVG Framework is an old version of the web component, developed many years ago as an experiment when browser did not support web components. It has no place in modern development.
- Framework-specific components have issue with server side rendering. Web compponent solves those issues.

### Web component

The best option by far is web component. It is the most modern iteration, works with all UI frameworks and works great with server side rendering.

Usage is simple:

html
```
<iconify-icon icon="mdi:home"></iconify-icon>
```

See [Iconify icon web component documentation](https://iconify.design/docs/iconify-icon/).

#### Shadow DOM

Web component renders icon in Shadow DOM, separating it from the main document.

That has its advantages and disadvantages over other components.

Advantages:

- Separates icon from main DOM, so main DOM doesn't become bloated.
- No conflicts with unique ids, which are used in some icons in masks, clip paths, animations and few other elements.
- Works wonderfully with SSR, much better than UI framework native components: no ID conflicts, render is independent of framework rendering, so it doesn't cause any issues with hydration.

Disadvantages:

- Accessing icon content, such as changing stroke-width, is not always possible. Depends on use case.
- Cannot render icon without width and height, making it impossible to resize icon with those properties. Icon can be resized only with font-size.

If these disadvantages are unacceptable for your project, use "SVG framework" or one of UI framework specific components listed below.

### UI frameworks

Iconify offers components native to various UI frameworks:

- [React](https://iconify.design/docs/react/) (warning: when using with Next.js, wrap it in a client-only component or switch to IconifyIcon web component!)
- [Vue](https://iconify.design/docs/vue/)
- [Svelte](https://iconify.design/docs/svelte/)

Usage is as any other component:

jsx
```
<Icon icon="mdi:home" />
```

These components behave differently than the web component:

- To avoid SSR errors, icons are rendered only after a component is mounted. Otherwise, it breaks hydration.
- Icons can be rendered without width and height attributes, making it easy to style in CSS.

You should consider using the iconify-icon web component instead of components mentioned above. Dynamic data loading does not work well with SSR. Web component solves those issues.

#### Legacy components

In addition to components listed above, there are several legacy components. They were created a long time ago, but no longer relevant in modern development.

These components are no longer updated, but can be used if you really need it:

- [Vue 2](https://iconify.design/docs/vue2/) (Vue 3 was released a long time ago, no point in supporting the old version)
- [Ember](https://iconify.design/docs/ember/) (Ember framework is outdated)
- [SVG Framework](https://iconify.design/docs/svg-framework/) (the oldest of components, has been replaced by the IconifyIcon web component)

[Page 33](https://iconify.design/docs/iconify-icon/ "Current Page.")

## Iconify Icon web component

Iconify Icon is a web component renders icons.

## Usage

It is designed to be as easy to use as possible.

html
```
<iconify-icon icon="mdi:home"></iconify-icon>
```

### Supported frameworks

Web component can be used in HTML without any UI framework. See usage examples below.

It also works great with all modern frameworks that support web components:

- Svelte and SvelteKit/Sapper.
- Vue 2 and Vue 3. Require changing config when used in Nuxt (see below).
- Lit.
- Ember.
- React and Next, but with small differences, such as using class instead of className. [Wrapper fixes it](https://iconify.design/docs/react.html).

However, some UI frameworks require custom wrappers:

- Solid. See [Iconify icon web component for Solid](https://iconify.design/docs/solid.html).

### Layout shift

Web component is not rendered instantly. There could be a few milliseconds delay.

This is caused by:

- JavaScript. Web component cannot be rendered until it is loaded and registered.
- Because of web component spec. Rendering is done asynchronously in browser, often causing tiny delay.

This might cause layout shift.

To avoid layout shift, add this to your CSS:

css
```
iconify-icon {
  display: inline-block;
  width: 1em;
  height: 1em;
 }
```

## Icon data on demand

Instead of embedding an entire icon, all you need to do is provide an icon name in icon attribute.

Web component will retrieve icon data from [Iconify API](https://iconify.design/api/), then will render SVG in shadow DOM.

There are over 275k icons available from many open source icon sets.

Don't want to rely on third party API servers? You can [host your own Iconify API](https://iconify.design/docs/api/hosting.html). You can also use it with your own icons.

## Shadow DOM

SVG is rendered in shadow DOM. What does that mean?

- HTML for icon is hidden, not part of the main document.
- It simplifies hydration when the web component is used in a UI framework with server side rendering. See below.
- Stylesheet used in the document does not affect icons, preventing potential conflicts.

Sometimes this can be a disadvantage, for example, if you do want to access icon content to perform CSS or JavaScript based animations. If you do not want a web component that uses shadow DOM, take a look at [Iconify icon components](https://iconify.design/icon-components/).

### SSR hydration

One of the issues a web component solves is a hydration, which is used by many modern UI frameworks.

Server side rendering is becoming more and more popular, hydration is complex and can easily be broken by a mismatched DOM.

What is hydration? Hydration is a process of matching content generated on server and content generated by UI framework in browser. Instead of re-rendering document, a UI framework uses HTML generated on server. This is the basic explanation. It is actually more complex than that, see various articles on SSR hydration.

There are several issues with hydrating icons:

- Icons might have unique IDs in elements, such as masks and clip paths. Using multiple icons on the same page requires using different IDs (or randomising them), which usually breaks hydration process.
- Dynamically loaded icon data cannot be rendered before hydration ends. This can be solved by rendering icon only after component has been mounted, but that might cause rendering delays and other issues.

Shadow DOM used by web components solves hydration problems. When a UI framework renders icon on server, it only renders <iconify-icon> element. During hydration process, UI framework only checks <iconify-icon> element, but not actual icon. This means:

- Server side can generate only <iconify-icon icon="mdi:home"></iconify-icon>, reducing document size.
- Web component can load icon data and render it immediately and independent of a UI framework, not waiting for a UI framework to mount the component.
- No issues with duplicate unique IDs. Each icon has its own document, so no need to change IDs of icon elements.
- Faster hydration. Icons can be complex, not checking icon content means less work for a UI framework.

Using shadow DOM to render icon leads to better experience for developers. No need to configure anything, no need to worry about icon data, no need to worry about conflicts. It just works.

### Rendering only visible icons

As of version 2.0.0 of the web component, icons are rendered only when visible to the visitor.

For long documents with many icons, this improves the performance of pages by a lot.

As of version 2.1.0, you can opt out of this behavior by adding noobserver attribute to web component's HTML:

html
```
<iconify-icon icon="mdi:home" noobserver></iconify-icon>
```

## Why not use icon font?

Shadow DOM used by web component has big advantages over usual SVGs or framework specific components, but what about icon fonts?

Do not use icon fonts!!!

- Icon fonts are ugly. Browser renders icons using font rendering methods, which causes blurred icon edges and icons lose their sharpness.
- Icons rendered from icon fonts are often hard to align, resulting in misaligned icons.
- Browsers load huge fonts just to render few icons. This can be solved by using custom icon fonts, but doesn't solve other issues.
- No colored icons, only monotone. No SVG animations.

Icon fonts do not belong in modern web. They were a great solution when Internet Explorer was popular, web components did not exist and SVG support was buggy. Those bad times are over.

## Registering the web component

For the web component to work, it needs to be registered. iconify-icon package does that automatically. All you need to do is include it on a page.

If you are building a project with a bundler, you can include the script by installing iconify-icon as a dependency and importing it in your project:

js
```
import "iconify-icon";
```

If you are not using bundles or want icon web component to be imported separately, add script to your document:

html
```
<script src="https://code.iconify.design/iconify-icon/3.0.0/iconify-icon.min.js"></script>
```

or

html
```
<script src="https://cdn.jsdelivr.net/npm/[email protected]/dist/iconify-icon.min.js"></script>
```

### Nuxt

When using component with Nuxt, you need to tell it that <iconify-icon> is a web component.

Example of nuxt.config.ts:

ts
```
import { defineNuxtConfig } from "nuxt3";

export default defineNuxtConfig({
  vue: {
    compilerOptions: {
      isCustomElement: (tag) => tag === "iconify-icon",
    },
  },
 });
```

## Attributes

There are several attributes to customise icon appearance.

To change color (color can be changed only for monotone icons) or size, use style:

html
```
<iconify-icon
    icon="mdi:alert"
    style="color: #ba3329; font-size: 48px"
 ></iconify-icon>
```

You can also change size using width and/or height attributes:

All icons below are 36x36:

html
```
<p>All icons below are 36x36:</p>
<iconify-icon icon="cil:locomotive" height="36"></iconify-icon>
<iconify-icon icon="cil:paper-plane" width="36"></iconify-icon>
<iconify-icon
    icon="cil:truck"
    style="font-size: 18px"
    height="2em"
 ></iconify-icon>
```

If only one size attribute is set, another attribute is calculated using icon's width/height ratio.

You can also transform icon. Unlike CSS transformations, these transformations are done inside icon, which also affects icon's viewBox:

No transformations:

Horizontal flip:

Vertical flip:

Horizontal and vertical flip (same as 180° rotation):

90° rotation:

180° rotation:

270° rotation:

html
```
<p>No transformations: <iconify-icon icon="bi:check2-circle"></iconify-icon></p>
<p>
    Horizontal flip:
    <iconify-icon icon="bi:check2-circle" flip="horizontal"></iconify-icon>
</p>
<p>
    Vertical flip:
    <iconify-icon icon="bi:check2-circle" flip="vertical"></iconify-icon>
</p>
<p>
    Horizontal and vertical flip (same as 180° rotation):
    <iconify-icon
        icon="bi:check2-circle"
        flip="horizontal,vertical"
    ></iconify-icon>
</p>
<p>
    90° rotation:
    <iconify-icon icon="bi:check2-circle" rotate="90deg"></iconify-icon>
</p>
<p>
    180° rotation:
    <iconify-icon icon="bi:check2-circle" rotate="180deg"></iconify-icon>
</p>
<p>
    270° rotation:
    <iconify-icon icon="bi:check2-circle" rotate="270deg"></iconify-icon>
</p>
```

### Attributes list

All attributes are also available as properties, so you can access them easy in JavaScript when working with elements.

Required attribute:

- icon, [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") |string icon name or icon data. Because attributes can only be strings, if you want to provide [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") data, you need to either use property or JSON.stringify() it. See [icon data](https://iconify.design/docs/icon.html).

Optional attributes:

- mode, string sets icon rendering mode. See [rendering modes](https://iconify.design/docs/modes.html).
- inline, boolean changes vertical alignment. See [vertical alignment](https://iconify.design/docs/inline.html).
- width, string|number icon width. See [icon dimensions](https://iconify.design/docs/dimensions.html).
- height, string|number icon height. See [icon dimensions](https://iconify.design/docs/dimensions.html).
- flip, string flip icon. See [icon transformations](https://iconify.design/docs/transform.html).
- rotate, number|string rotates icon. See [icon transformations](https://iconify.design/docs/transform.html).

## Functions

For advanced developers, web component offers several functions to control it.

These functions can be used to load custom icons, get icon data, preload icons from API, configure custom API and so on. See functions list below.

Functions can be imported from:

- iconify-icon package, which also bundles web component. Usable in browser and Node.js.
- Web component class as static methods, which is available after component is registered.
- <iconify-icon> node as methods, which are available after component is registered and new elements are created.

First method is the most reliable because it is a simple import. It is used in all examples:

js
```
import { loadIcon } from "iconify-icon";

const name = "mdi:home";
loadIcon(name)
  .then((data) => {
    console.log("Loaded data for", name);
  })
  .catch(console.error);
```

For second method, class can be retrieved from custom elements' registry:

js
```
const IconifyIcon = window.customElements.get("iconify-icon");

const name = "mdi:home";
IconifyIcon.loadIcon(name)
  .then((data) => {
    console.log("Loaded data for", name);
  })
  .catch(console.error);
```

Third method can be used after creating a new icon element or accessing an existing element:

js
```
const IconifyIcon = document.createElement("iconify-icon");

const name = "mdi:home";
IconifyIcon.loadIcon(name)
  .then((data) => {
    console.log("Loaded data for", name);
  })
  .catch(console.error);
```

Functions are split in several groups (click function name to see more details and examples):

### Instance functions

These functions are available only on web component nodes:

- restartAnimation(). Restarts SVG animation, useful if you want to restart animation on hover event, as shown in right side navigation of this website.

### Check available icons

There are several functions in this section:

- [iconLoaded(name)](https://iconify.design/docs/iconify-icon/icon-exists.html "iconLoaded() documentation"). Checks if icon data is available, returns boolean.
- [listIcons()](https://iconify.design/docs/iconify-icon/list-icons.html "listIcons() documentation"). Lists available icons, returns string\[\].
- [getIcon(name)](https://iconify.design/docs/iconify-icon/get-icon.html "getIcon() documentation"). Returns icon data, returns [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") object.

### Adding icons

Functions for adding icons to the component:

- [addIcon()](https://iconify.design/docs/iconify-icon/add-icon.html "addIcon() documentation"). Adds one icon.
- [addCollection()](https://iconify.design/docs/iconify-icon/add-collection.html "addCollection() documentation"). Adds an icon set.

Note: icons added to the component with these functions are not stored in the icon data cache. Component caches only icons retrieved from API.

### Custom loaders

Custom loaders can be used to load icons from custom sources:

- [setCustomIconLoader()](https://iconify.design/docs/iconify-icon/custom-loaders.html "setCustomIconLoader() documentation"). Loads one icon.
- [setCustomIconsLoader()](https://iconify.design/docs/iconify-icon/custom-loaders.html "setCustomIconsLoader() documentation"). Loads icons in bulk.

Loaders are set per icon set prefix. Make sure to configure loader before displaying any icons.

It can also be used to customise icons: in custom loader you can load icon from API using [loadIcon](https://iconify.design/docs/iconify-icon/load-icon.html "loadIcon() documentation"), change its content (such as colors or stroke width) and return modified icon.

### Helper functions

- calculateSize(). Calculates icon size. It is used to calculate width if only height is set and vice versa.
- [buildIcon(icon, customisations?)](https://iconify.design/docs/iconify-icon/build-icon.html "buildIcon() documentation"). Generates data used by icon component. This can be used if you prefer to generate <svg> yourself. Data includes attributes for <svg> and inner HTML.

### API functions

- [loadIcons(icons, callback?)](https://iconify.design/docs/iconify-icon/load-icons.html "loadIcons() documentation"). Loads icons from API, calls optional callback when either all or part of icons have been loaded.
- [loadIcon(icon)](https://iconify.design/docs/iconify-icon/load-icon.html "loadIcon() documentation"). Loads one icon from API, returns Promise.
- [addAPIProvider()](https://iconify.design/docs/iconify-icon/add-api-provider.html "addAPIProvider() documentation"). Adds custom API provider. See [API providers documentation](https://iconify.design/docs/api/providers.html).

### Internal API functions

There are several internal API functions that are exposed. They are intended to be used by developers that need more control over the component. For example, it is used in Sketch and Figma plug-ins. Use them carefully.

All internal API functions are exposed as properties of \_api object:

- getAPI(). Returns internal API module.
- getAPIConfig(). Returns API configuration.
- setAPIModule(provider). Sets API module for provider. This is an experimental function intended for custom API providers that use custom module for retrieving data from API.
- [setFetch(fetch)](https://iconify.design/docs/iconify-icon/set-fetch.html "setFetch() documentation"). Set custom Fetch API.
- getFetch(). Returns used fetch() function, null if Fetch API is not available.

[Page 34](https://iconify.design/docs/iconify-icon/react.html "Current Page.")

## Iconify Icon web component with React

This tutorial is part of [Iconify Icon web component tutorial](https://iconify.design/docs/).

Iconify icon web component works well with React, but there are few problems:

- When using web components in React, you need to use class instead of className to pass class name.
- Property icon can only be a string.
- No JSX hints.

## Iconify Icon for React

These problems are solved by Iconify Icon for React.

It is a wrapper for web component that provides support for className, allows to use objects with icon and provides typings for React component.

## Installation

Instead of iconify-icon package, install @iconify-icon/react package:

```
npm install --save-dev @iconify-icon/react
```

```
yarn add --dev @iconify-icon/react
```

## Usage

Import Icon component from @iconify-icon/react, set icon in icon property:

jsx
```
import React from 'react';
import { Icon } from '@iconify-icon/react';

export function Alert() {
    return (
        <div className="alert">
            <Icon icon="mdi-light:alert" />
            Important notice with alert icon!
        </div>
    );
 }
```

### Usage with objects

You can pass objects in icon property:

jsx
```
import React from 'react';
import { Icon } from '@iconify-icon/react';
import alertIcon from '@iconify-icons/mdi-light/alert';

export function Alert() {
    return (
        <div className="alert">
            <Icon icon={alertIcon} />
            Important notice with alert icon!
        </div>
    );
 }
```

### Functions

All other functions, listed in [Iconify Icon web component tutorial](https://iconify.design/docs/#functions), are available. You can import them directly from @iconify-icon/react package:

jsx
```
import React from 'react';
import { Icon, addIcon } from '@iconify-icon/react';

addIcon('alert', {
    body: '<path fill="currentColor" d="M1 21L11.5 2.813L22 21H1Zm19.268-1L11.5 4.813L2.732 20h17.536ZM11 14v-4h1v4h-1Zm0 2h1v2h-1v-2Z"/>',
    width: 24,
    height: 24,
 });

export function Alert() {
    return (
        <div className="alert">
            <Icon icon="alert" />
            Important notice with alert icon!
        </div>
    );
 }
```

See [Iconify Icon web component](https://iconify.design/docs/) for list of all attributes, functions and usage examples. @iconify-icon/react is only a wrapper for iconify-icon, not a different component, it supports all the same properties and functions.

[Page 35](https://iconify.design/docs/iconify-icon/solid.html "Current Page.")

## Iconify Icon web component with SolidJS

This tutorial is part of [Iconify Icon web component tutorial](https://iconify.design/docs/).

Currently, SolidJS has poor support for web components. It is caused by issues in the web components spec. When setting a property to a web component, it sometimes does not work as expected.

## Workaround

Workaround for Solid usage is to force Solid to use attributes instead of properties:

html
```
<iconify-icon attr:icon="mdi-light:home"></iconify-icon>
```

## Iconify Icon for Solid

Iconify Icon for Solid solves that by mapping properties to attributes in a native Solid component, so you can use the web component without any issues.

It also provides typings for the component, making it easier to use in JSX and supports objects for icon property.

## Installation

Instead of iconify-icon package, install @iconify-icon/solid package:

```
npm install --save-dev @iconify-icon/solid
```

```
yarn add --dev @iconify-icon/solid
```

## Usage

Import Icon component from @iconify-icon/solid, set icon in icon property:

jsx
```
import { Icon } from '@iconify-icon/solid';

export default () => {
    return (
        <div class="alert">
            <Icon icon="mdi-light:alert" />
            Important notice with alert icon!
        </div>
    );
 };
```

### Usage with objects

You can pass objects in icon property:

jsx
```
import { Icon } from '@iconify-icon/solid';
import alertIcon from '@iconify-icons/mdi-light/alert';

export default () => {
    return (
        <div class="alert">
            <Icon icon={alertIcon} />
            Important notice with alert icon!
        </div>
    );
 };
```

### Functions

All other functions, listed in [Iconify Icon web component tutorial](https://iconify.design/docs/#functions), are available. You can import them directly from @iconify-icon/solid package:

jsx
```
import { Icon, addIcon } from '@iconify-icon/solid';

addIcon('alert', {
    body: '<path fill="currentColor" d="M1 21L11.5 2.813L22 21H1Zm19.268-1L11.5 4.813L2.732 20h17.536ZM11 14v-4h1v4h-1Zm0 2h1v2h-1v-2Z"/>',
    width: 24,
    height: 24,
 });

export default () => {
    return (
        <div class="alert">
            <Icon icon="alert" />
            Important notice with alert icon!
        </div>
    );
 };
```

See [Iconify Icon web component](https://iconify.design/docs/) for the list of all attributes, all functions and usage examples. @iconify-icon/solid is only a wrapper for iconify-icon, not a different component, it supports all the same properties and functions.

[Page 36](https://iconify.design/docs/iconify-icon/color.html "Current Page.")

## Icon color

This tutorial is part of [Iconify Icon web component tutorial](https://iconify.design/docs/).

You can only change color of monotone icons. Some icons, such as emoji, have a hardcoded palette that cannot be changed.

To change color of a monotone icon, simply change text color or use color attribute or add style with color.

All icons inside this div are light blue, including a bell icon and attachment icon This text and icon are orange: Red home icons (shows different ways to change color): Icon with palette:

html
```
<div class="light-blue-block">
    All icons inside this div are light blue, including a bell icon
    <iconify-icon inline icon="bi:bell-fill"></iconify-icon>
    and attachment icon
    <iconify-icon inline icon="bi:stopwatch"></iconify-icon>
</div>
<div class="orange-block">
    This text and icon are orange:
    <iconify-icon inline icon="bi:bell-fill"></iconify-icon>
</div>
<div>
    Red home icons (shows different ways to change color):
    <iconify-icon inline class="red-icon" icon="bx:bx-home"></iconify-icon>
    <iconify-icon inline style="color: red" icon="bx:bx-home"></iconify-icon>
</div>
<div>
    Icon with palette:
    <iconify-icon inline icon="noto:paintbrush"></iconify-icon>
</div>
```

css
```
// Change text color for ".orange-block" to #e70
.orange-block {
    color: #e70;
 }
// Change all icons inside ".light-blue-block" to #08f
.light-blue-block svg {
    color: #08f;
 }
// Change text color for ".red-icon" to #e00
.red-icon {
    color: #e00;
 }
```

Color only works for icons that do not have a palette. Color in icons that do have a palette, like paintbrush icon in an example above, cannot be changed.

You can change color the same way as you would for text.

## RGBA and HSLA colors

Avoid using rgba and hsla colors. Some icons have multiple layers on top of each other. Using semi-transparent color will result in both layers being visible.

Instead, use a solid color and add transparency with opacity. This will result in browser rendering shapes with a solid color, then applying opacity to an entire icon.

[Page 37](https://iconify.design/docs/iconify-icon/dimensions.html "Current Page.")

## Icon dimensions

This tutorial is part of [Iconify Icon web component tutorial](https://iconify.design/docs/).

By default, icon height is set to "1em", icon width is changed dynamically based on the icon's width/height ratio.

This makes it easy to change icon size by changing font-size in the stylesheet or in style, just like icon fonts:

html
```
<p>
    <iconify-icon icon="cil:locomotive"></iconify-icon>
    <iconify-icon
        class="iconify"
        icon="cil:paper-plane"
        style="font-size: 36px"
    ></iconify-icon>
    <iconify-icon class="big-icon" icon="cil:truck"></iconify-icon>
</p>
```

css
```
p {
    font-size: 24px;
 }

.big-icon {
    font-size: 72px;
 }
```

If you want to control icon size with width and height in CSS, see [how to remove icon dimensions](#unset) section below.

## Units

Both width and height can be used as properties and attributes.

Examples of 24px icon:

html
```
<iconify-icon icon="mdi:home" height="24"></iconify-icon>
<iconify-icon icon="mdi:home" height="24px"></iconify-icon>
<iconify-icon
    icon="mdi:home"
    style="font-size: 16px;"
    height="1.5em"
 ></iconify-icon>
```

## Keyword "auto"

Special keyword "auto" sets size to value from viewBox. This makes it easy to render an icon as it was originally designed.

It is enough to set one dimension to "auto", another dimension will be set to "auto" too, unless you specify otherwise.

For example, if viewBox="0 0 24 24" and height is set to "auto", height will be set to 24.

html
```
<iconify-icon icon="mdi:home" height="auto"></iconify-icon>
```

## Keywords "none" and "unset"

Special keywords "none" and "unset" remove dimensions from generated SVG.

This results in icon without dimensions. You should set icon's width and height in CSS.

It is enough to set one dimension to "unset", another dimension will be set to "unset" too, unless you specify otherwise.

html
```
<iconify-icon
    icon="mdi:home"
    height="none"
    style="width: 48px; height: 48px"
 ></iconify-icon>
```

This gives you full control over each icon's dimension separately in CSS instead of controlling them both with font-size.

Sometimes you might also need to add display: block; to CSS for icon to behave correctly.

## Setting only width or height

In an example above, all icons only use height.

What happens when only one dimension is set?

- If width is not set, but height is set, width is calculated using icon's width/height ratio.
- If height is not set, but width is set, height is calculated using icon's height/width ratio.
- If no dimensions are set in attributes, height is set to "1em" and width is calculated using icon's width/height ratio. Then icon behaves like a text and can be resized using font-size in stylesheet.

### Example

Many icons are square. For such icons if you set one dimension, another dimension will have the same value.

However, there are many icons that are not square. For example, icons imported from icon fonts and Font Awesome.

This is data for fa-regular:address-book:

json
```
{
    "body": "<path d=\"M436 160c6.6 0 12-5.4 12-12v-40c0-6.6-5.4-12-12-12h-20V48c0-26.5-21.5-48-48-48H48C21.5 0 0 21.5 0 48v416c0 26.5 21.5 48 48 48h320c26.5 0 48-21.5 48-48v-48h20c6.6 0 12-5.4 12-12v-40c0-6.6-5.4-12-12-12h-20v-64h20c6.6 0 12-5.4 12-12v-40c0-6.6-5.4-12-12-12h-20v-64h20zm-68 304H48V48h320v416zM208 256c35.3 0 64-28.7 64-64s-28.7-64-64-64s-64 28.7-64 64s28.7 64 64 64zm-89.6 128h179.2c12.4 0 22.4-8.6 22.4-19.2v-19.2c0-31.8-30.1-57.6-67.2-57.6c-10.8 0-18.7 8-44.8 8c-26.9 0-33.4-8-44.8-8c-37.1 0-67.2 25.8-67.2 57.6v19.2c0 10.6 10 19.2 22.4 19.2z\" fill=\"currentColor\"/>",
    "width": 448,
    "height": 512
}
```

Icon size is 448 x 512

If you do not set any dimensions, height will be set to "1em" and width will be set to 448 / 512 = "0.875em". However, values that have more than 2 numbers after decimal point are rounded up, so actual width will be "0.88em":

html
```
<svg
    xmlns="http://www.w3.org/2000/svg"
    xmlns:xlink="http://www.w3.org/1999/xlink"
    aria-hidden="true"
    focusable="false"
    role="img"
    class="iconify iconify--fa-regular"
    width="0.88em"
    height="1em"
    preserveAspectRatio="xMidYMid meet"
    viewBox="0 0 448 512"
 >
    <path d="..." fill="currentColor"></path>
</svg>
```

If you set width to 56, but do not set height, height will be set to 56 \* 512 / 448 = 64:

html
```
<svg width="56" height="64" ...>...</svg>
```

If you set both values: width to 56 and height to 128, values will be as you set them (also see "Alignment" section below):

html
```
<svg width="56" height="128" ...>...</svg>
```

## Alignment

What if you set both width and height and its ratio doesn't match icon's width/height ratio?

For example, what will happen if icon is 24x24, but you set one dimension to 40 and other dimension to 24?

Using box-shadow to show icon dimensions

html
```
<iconify-icon icon="jam:info" width="40" height="24"></iconify-icon>
<iconify-icon icon="jam:info" width="24" height="40"></iconify-icon>
```

SVG do not behave like other images. When you set a wrong width/height ratio for other image formats, images get stretched. When you do that for SVG, bounding box is changed and the image is aligned inside that bounding box.

In an example above, one icon is too wide and another icon is too tall. The browser will move icons to center instead of stretching icon.

You can control alignment with preserveAspectRatio attribute. Default value is "xMidYMid slice".

### Slice

Instead of adding space around icon to fit it in bounding box, browser can also cut parts of icon that do not fit.

To cut parts of icon, add preserveAspectRatio="xMidYMid slice" to icon:

Using box-shadow to show icon dimensions

html
```
<iconify-icon
    icon="jam:info"
    width="40"
    height="24"
    preserveAspectRatio="xMidYMid slice"
 ></iconify-icon>
<iconify-icon
    icon="jam:info"
    width="24"
    height="40"
    preserveAspectRatio="xMidYMid slice"
 ></iconify-icon>
```

### Horizontal alignment

When...

- icon is too wide...
- icon is too tall and slice is enabled...

...you can align icon horizontally.

To align icon horizontally, change "xMid" in preserveAspectRatio to "xMin" or "xMax":

Examples of aligning wide icon:

Using box-shadow to show icon dimensions

html
```
<iconify-icon
    icon="jam:info"
    width="40"
    height="24"
    preserveAspectRatio="xMinYMid meet"
 ></iconify-icon>
<iconify-icon
    icon="jam:info"
    width="40"
    height="24"
    preserveAspectRatio="xMidYMid meet"
 ></iconify-icon>
<iconify-icon
    icon="jam:info"
    width="40"
    height="24"
    preserveAspectRatio="xMaxYMid meet"
 ></iconify-icon>
```

Examples of aligning tall icon with slice enabled:

Using box-shadow to show icon dimensions

html
```
<iconify-icon
    icon="jam:info"
    width="24"
    height="40"
    preserveAspectRatio="xMinYMid slice"
 ></iconify-icon>
<iconify-icon
    icon="jam:info"
    width="24"
    height="40"
    preserveAspectRatio="xMidYMid slice"
 ></iconify-icon>
<iconify-icon
    icon="jam:info"
    width="24"
    height="40"
    preserveAspectRatio="xMaxYMid slice"
 ></iconify-icon>
```

### Vertical alignment

When...

- icon is too tall...
- icon is too wide and slice is enabled...

...you can align icon vertically.

To align icon vertically, change "YMid" in preserveAspectRatio to "YMin" or "YMax":

Examples of aligning tall icon:

Using box-shadow to show icon dimensions

html
```
<iconify-icon
    icon="jam:info"
    width="24"
    height="40"
    preserveAspectRatio="xMidYMin meet"
 ></iconify-icon>
<iconify-icon
    icon="jam:info"
    width="24"
    height="40"
    preserveAspectRatio="xMidYMid meet"
 ></iconify-icon>
<iconify-icon
    icon="jam:info"
    width="24"
    height="40"
    preserveAspectRatio="xMidYMax meet"
 ></iconify-icon>
```

Examples of aligning wide icon with slice enabled:

Using box-shadow to show icon dimensions

html
```
<iconify-icon
    icon="jam:info"
    width="40"
    height="24"
    preserveAspectRatio="xMidYMin slice"
 ></iconify-icon>
<iconify-icon
    icon="jam:info"
    width="40"
    height="24"
    preserveAspectRatio="xMidYMid slice"
 ></iconify-icon>
<iconify-icon
    icon="jam:info"
    width="40"
    height="24"
    preserveAspectRatio="xMidYMax slice"
 ></iconify-icon>
```

### Vertical and horizontal alignment

You can add both horizontal and vertical alignment to icon.

One of alignments will have no effect. For example, if icon is too tall, horizontal alignment is ignored because icon is already aligned to both left and right sides.

Using box-shadow to show icon dimensions

html
```
<iconify-icon
    icon="jam:info"
    width="40"
    height="24"
    preserveAspectRatio="xMinYMin meet"
 ></iconify-icon>
<iconify-icon
    icon="jam:info"
    width="40"
    height="24"
    preserveAspectRatio="xMinYMin slice"
 ></iconify-icon>
```

[Page 38](https://iconify.design/docs/iconify-icon/transform.html "Current Page.")

## Transformations

This tutorial is part of [Iconify Icon web component tutorial](https://iconify.design/docs/).

An icon can be rotated and flipped horizontally and/or vertically. All transformations are done relative to the center of the icon.

There are two types of transformations:

- Horizontal and vertical flip.
- Rotation by 90, 180 and 270 degrees.

## CSS vs Iconify transformations

These are not CSS transformations, transformations are applied inside SVG.

What's the difference from CSS transformations?

- If you rotate an icon by 90 degrees in CSS, icon's bounding box remains the same. 16x24 icon still takes space for 16x24, but might overlap elements around it.
- If you rotate an icon by 90 degrees in SVG Framework, icon's dimensions swap places. 16x24 icon becomes 24x16 icon, and it does not affect elements around it.

Example:

Test icon with text around it

Test icon with text around it

Using box-shadow to show icon dimensions

html
```
<p>
    Test icon
    <iconify-icon
        inline
        icon="fa-regular:handshake"
        rotate="90deg"
    ></iconify-icon>
    with text around it
</p>
<p>
    Test icon
    <iconify-icon
        inline
        icon="fa-regular:handshake"
        style="transform: rotate(90deg)"
    ></iconify-icon>
    with text around it
</p>
```

In example above, first icon is rotated using rotate attribute, second icon is rotated using CSS. The first icon kept its 1em height, second icon became taller than it should be.

Sometimes you do want behaviour that CSS transformations provide. Then you can still use CSS transformations by adding it to style.

## Flip

You can flip an icon horizontally and/or vertically.

One way to do that is to add flip attribute with comma-separated values. Possible values:

- "horizontal": flip icon horizontally.
- "vertical": flip icon vertically.

You can also do that by setting hFlip and / or vFlip attributes to true.

Example:

No flip:

Horizontal flip:

Vertical flip:

Both (or 180° rotation):

html
```
<p>No flip: <iconify-icon inline icon="bi:check2-circle"></iconify-icon></p>
<p>
    Horizontal flip:
    <iconify-icon inline icon="bi:check2-circle" flip="horizontal"></iconify-icon>
</p>
<p>
    Vertical flip:
    <iconify-icon inline icon="bi:check2-circle" flip="vertical"></iconify-icon>
</p>
<p>
    Both (or 180° rotation):
    <iconify-icon
        inline
        icon="bi:check2-circle"
        flip="horizontal,vertical"
    ></iconify-icon>
</p>
```

## Rotation

You can rotate icon by 90, 180 and 270 degrees.

To do that, add rotate attribute. Possible values:

- "90deg", "1": rotate by 90 degrees.
- "180deg", "2": rotate by 180 degrees.
- "270deg", "3": rotate by 270 degrees.

Example:

No rotation:

90° rotation:

180° rotation:

270° rotation:

html
```
<p>No rotation: <iconify-icon inline icon="bi:check2-circle"></iconify-icon></p>
<p>
    90° rotation:
    <iconify-icon inline icon="bi:check2-circle" rotate="90deg"></iconify-icon>
</p>
<p>
    180° rotation:
    <iconify-icon inline icon="bi:check2-circle" rotate="180deg"></iconify-icon>
</p>
<p>
    270° rotation:
    <iconify-icon inline icon="bi:check2-circle" rotate="270deg"></iconify-icon>
</p>
```

## Rotate and flip

You can use both rotation and flip on an icon. The icon is flipped first, then rotated.

[Page 39](https://iconify.design/docs/iconify-icon/inline.html "Current Page.")

## Vertical alignment

This tutorial is part of [Iconify Icon web component tutorial](https://iconify.design/docs/).

When an icon is rendered in text, by default it is aligned at baseline, as any other images.

Emojis and icon fonts are rendered slightly below baseline, like any text.

If you want to render icon in text, you probably want to add vertical-align to each icon to render it slightly below baseline, to make it fit in text, similar to emojis and icon fonts:

SVG in text:

SVG in text with vertical-align: -0.125em:

## Inline attribute

Instead of adding vertical-align to each icon, the icon component has a property inline. Adding inline property to the icon component is identical to setting style="vertical-align: -0.125em":

Inline attribute demo:

html
```
<p>
    Inline attribute demo:
    <iconify-icon inline icon="line-md:image-twotone"></iconify-icon>
    <iconify-icon inline icon="mdi:account-box-outline"></iconify-icon>
</p>
```

Important: this attribute does not change display mode for icon. It only adds vertical-align style.

[Page 40](https://iconify.design/docs/iconify-icon/modes.html "Current Page.")

## Rendering modes

This tutorial is part of [Iconify Icon web component tutorial](https://iconify.design/docs/).

Web component supports several icon rendering modes.

## Modes

There are 4 modes supported by web component:

- "svg": renders <svg> element.
- "style": uses either "bg" or "mask" mode, depending on icon palette.
- "bg": renders <span> element with icon as background image. Usable only for icons that have palette.
- "mask": renders <span> element with icon as mask image. Usable only for icons that do not have palette.

Demo showing 2 icons (one monotone, one with palette) rendered with 4 modes:

svg:

style:

bg:monotone icon shown as black

mask:icon with palette loses color

### Code samples

What do these modes actually look like in DOM?

Examples for mdi:home (used in modes demo above) icon:

html
```
<svg
    xmlns="http://www.w3.org/2000/svg"
    width="1em"
    height="1em"
    viewBox="0 0 24 24"
 >
    <path fill="currentColor" d="M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5Z"></path>
</svg>
```

html
```
<span
    style="
        --svg: url('data:image/svg+xml,%3Csvg xmlns=\'http://www.w3.org/2000/svg\' width=\'24\' height=\'24\' viewBox=\'0 0 24 24\'%3E%3Cpath fill=\'currentColor\' d=\'M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5Z\'/%3E%3C/svg%3E');
        width: 1em;
        height: 1em;
        background-color: transparent;
        background-image: var(--svg);
        background-repeat: no-repeat;
        background-size: 100% 100%;
    "
 ></span>
```

html
```
<span
    style="
        --svg: url('data:image/svg+xml,%3Csvg xmlns=\'http://www.w3.org/2000/svg\' width=\'24\' height=\'24\' viewBox=\'0 0 24 24\'%3E%3Cpath fill=\'currentColor\' d=\'M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5Z\'/%3E%3C/svg%3E');
        width: 1em;
        height: 1em;
        background-color: currentcolor;
        -webkit-mask-image: var(--svg);
        -webkit-mask-repeat: no-repeat;
        -webkit-mask-size: 100% 100%;
        mask-image: var(--svg);
        mask-repeat: no-repeat;
        mask-size: 100% 100%;
    "
 ></span>
```

## Why not just render SVG?

You are probably wondering, why is it even needed? Isn't <svg> enough?

Rendering icon as <svg> works for most icons, but it does not always work for icons that use SVG animations.

SVG animations cannot start until document is ready. It might seem like a small thing, but animations not rendering quickly enough can cause bad user experience. This issue can be caused by small things, such as statistics script failing to load or ad code loading slowly. If at least one server that page is loading resources from is unreachable, it might break all animated SVGs on page. Async and defer attributes do not help. Issue can even be caused by script in an iframe.

### Animation delay demo

Below is an <iframe> that shows icon rendering issue. It contains animated icon, rendered as <svg> and as background image. Both icons render instantly, but animation in <svg> does not start for few seconds because document is still loading.

<iframe src="https://iconify.design/delay-demo.html"></iframe>Hover demo above to restart it.

[Page 41](https://iconify.design/docs/iconify-icon/icon-exists.html "Current Page.")

## Web component function: iconLoaded

This tutorial is part of [Iconify Icon web component tutorial](https://iconify.design/docs/#functions).

The function iconLoaded() checks if icon data is available for rendering.

## Usage

The function has the following parameter:

- name, string. Icon name.

The function returns boolean value: true if icon data is available, false if icon data is not available.

## Example

js
```
import { iconLoaded, loadIcons } from "iconify-icon";

function renderLeftArrow() {
  // Check if 'bi:arrow-left' is available
  if (iconLoaded("bi:arrow-left")) {
    // Return HTML for 'bi:arrow-left'
    return '<iconify-icon icon="bi:arrow-left"></iconify-icon>';
  }

  // Load icon. Bad example because this should use a callback to re-render arrow in a stateful
  // component, but this code example is about iconLoaded(), not loadIcons()

  // Function loadIcons() is asynchronous, so in this example it will only trigger loading, but
  // icon data will not be available immediately
  loadIcons(["bi:arrow-left"]);

  // Return '<'
  return "<span>&lt;</span>";
 }
```

## Legacy

Note: in old versions of component, this function was named iconExists(). It was the same function, but with bad name.

Because of bad name, some developers assumed it checks if icon exists on Iconify API. It does not. All it does is checks component's storage.

To avoid confusion, function was renamed.

[Page 42](https://iconify.design/docs/iconify-icon/list-icons.html "Current Page.")

## Web component function: listIcons

This tutorial is part of [Iconify Icon web component tutorial](https://iconify.design/docs/#functions).

The function listIcons() lists loaded icons.

## Usage

The function has the following optional parameters:

- provider, string. Lists only icons from one API provider.
- prefix, string. Lists only icons with specific prefix. If prefix is set, provider must be set too (for Iconify public API provider value is empty string "").

The function returns an array of icon names.

## Examples

js
```
import { listIcons } from 'iconify-icon';

// List all icons
console.log(listIcons());
```

Another example:

js
```
import { listIcons } from 'iconify-icon';

// List all loaded Material Design Icons
console.log(listIcons('', 'mdi'));
// ["mdi:alert", "mdi:home", "mdi:account-box-outline", "mdi:eyedropper", "mdi:account-off", "mdi:account", "mdi:account-box", "mdi:account-cash"]
```

[Page 43](https://iconify.design/docs/iconify-icon/get-icon.html "Current Page.")

## Web component function: getIcon

This tutorial is part of [Iconify Icon web component tutorial](https://iconify.design/docs/#functions).

The function getIcon() retrieves icon data.

## Usage

The function has the following parameter:

- name, string. Icon name.

The function returns icon data in [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") format, null if icon is not available.

## Examples

js
```
import { getIcon } from 'iconify-icon';

const data = getIcon('bi:check2-circle');
```

json
```
{
    "body": "<g fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M15.354 2.646a.5.5 0 0 1 0 .708l-7 7a.5.5 0 0 1-.708 0l-3-3a.5.5 0 1 1 .708-.708L8 9.293l6.646-6.647a.5.5 0 0 1 .708 0z\"/><path fill-rule=\"evenodd\" d=\"M8 2.5A5.5 5.5 0 1 0 13.5 8a.5.5 0 0 1 1 0a6.5 6.5 0 1 1-3.25-5.63a.5.5 0 1 1-.5.865A5.472 5.472 0 0 0 8 2.5z\"/></g>",
    "left": 0,
    "top": 0,
    "width": 16,
    "height": 16,
    "rotate": 0,
    "vFlip": false,
    "hFlip": false
}
```

Another example:

js
```
import { getIcon } from 'iconify-icon';

const data = getIcon('cil:paper-plane');
```

json
```
{
    "body": "<path fill=\"currentColor\" d=\"M474.444 19.857a20.336 20.336 0 0 0-21.592-2.781L33.737 213.8v38.066l176.037 70.414L322.69 496h38.074l120.3-455.4a20.342 20.342 0 0 0-6.62-20.743zM337.257 459.693L240.2 310.37l149.353-163.582l-23.631-21.576L215.4 290.069L70.257 232.012L443.7 56.72z\"/>",
    "left": 0,
    "top": 0,
    "width": 512,
    "height": 512,
    "rotate": 0,
    "vFlip": false,
    "hFlip": false
}
```

Example with bad icon name, returns null:

js
```
import { getIcon } from 'iconify-icon';

// null
const data = getIcon('no-such-icon');
```

[Page 44](https://iconify.design/docs/iconify-icon/add-icon.html "Current Page.")

## Web component function: addIcon

This tutorial is part of [Iconify Icon web component tutorial](https://iconify.design/docs/#functions).

Function addIcon() adds one icon to the component's icon data storage.

## Usage

The function has the following parameters:

- name, string. Icon name.
- data, [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation"). Icon data.

The function returns boolean value: true on success, false if something is wrong with data.

## Examples

js
```
import { addIcon } from 'iconify-icon';

addIcon('mdi:account-box', {
    body: '<path d="M6 17c0-2 4-3.1 6-3.1s6 1.1 6 3.1v1H6m9-9a3 3 0 0 1-3 3a3 3 0 0 1-3-3a3 3 0 0 1 3-3a3 3 0 0 1 3 3M3 5v14a2 2 0 0 0 2 2h14a2 2 0 0 0 2-2V5a2 2 0 0 0-2-2H5a2 2 0 0 0-2 2z" fill="currentColor"/>',
    width: 24,
    height: 24,
 });
```

Note: icons added by this function are not cached in localStorage and sessionStorage.

## API provider

API provider parameter can be used to load custom icons asynchronously without triggering API queries.

Each API provider has its own API endpoint, so if you are using custom API provider that component doesn't have configuration for (currently by default component has no API providers configured), the component will not attempt to load missing icons from an unknown API provider.

Example:

js
```
import { addIcon } from 'iconify-icon';

addIcon('@custom:md:test', {
    body: '<path d="M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5z" fill="currentColor"/>',
    width: 24,
    height: 24,
 });
```

Code above adds the following icon:

- provider is "custom".
- prefix is "md".
- name is "test".

In HTML this icon can be used like this:

html
```
<iconify-icon icon="@custom:md:test"></iconify-icon>
```

Syntax is similar to default icon syntax, but with API provider "@custom" in icon name. See [API providers documentation](https://iconify.design/docs/api/providers.html) for details.

## One icon

This function adds one icon in [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") format.

If you want to add several icons, or you have [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") data, use function [addCollection()](https://iconify.design/docs/iconify-icon/add-collection.html "addCollection() documentation") instead.

[Page 45](https://iconify.design/docs/iconify-icon/add-collection.html "Current Page.")

## Web component function: addCollection

This tutorial is part of [Iconify Icon web component tutorial](https://iconify.design/docs/#functions).

Function addCollection() adds an icon set to component's icon storage.

## Usage

The function has the following parameters:

- data, [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation"). Icon set data.
- provider, string. Optional API provider ID.

The function returns boolean value: true on success, false if something is wrong with data.

If an icon set has provider property and second parameter to addCollection() is passed, provider from second parameter overrides provider from an icon set.

## Examples

js
```
import { addCollection } from 'iconify-icon';

addCollection({
    prefix: 'custom',
    icons: {
        icon1: {
            body: '<path d="M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5z" fill="currentColor"/>',
        },
    },
    width: 24,
    height: 24,
 });
```

js
```
import { addCollection } from 'iconify-icon';

addCollection({
    prefix: 'mdi',
    icons: {
        'account-box': {
            body: '<path d="M6 17c0-2 4-3.1 6-3.1s6 1.1 6 3.1v1H6m9-9a3 3 0 0 1-3 3a3 3 0 0 1-3-3a3 3 0 0 1 3-3a3 3 0 0 1 3 3M3 5v14a2 2 0 0 0 2 2h14a2 2 0 0 0 2-2V5a2 2 0 0 0-2-2H5a2 2 0 0 0-2 2z" fill="currentColor"/>',
        },
        'account-cash': {
            body: '<path d="M11 8c0 2.21-1.79 4-4 4s-4-1.79-4-4s1.79-4 4-4s4 1.79 4 4m0 6.72V20H0v-2c0-2.21 3.13-4 7-4c1.5 0 2.87.27 4 .72M24 20H13V3h11v17m-8-8.5a2.5 2.5 0 0 1 5 0a2.5 2.5 0 0 1-5 0M22 7a2 2 0 0 1-2-2h-3c0 1.11-.89 2-2 2v9a2 2 0 0 1 2 2h3c0-1.1.9-2 2-2V7z" fill="currentColor"/>',
        },
        'account': {
            body: '<path d="M12 4a4 4 0 0 1 4 4a4 4 0 0 1-4 4a4 4 0 0 1-4-4a4 4 0 0 1 4-4m0 10c4.42 0 8 1.79 8 4v2H4v-2c0-2.21 3.58-4 8-4z" fill="currentColor"/>',
        },
        'home': {
            body: '<path d="M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5z" fill="currentColor"/>',
        },
    },
    width: 24,
    height: 24,
 });
```

Note: icons added by this function are not cached in localStorage and sessionStorage.

## API provider

API provider parameter can be used to specify that icon set belongs to the specific API provider.

It can also be used to load custom icons asynchronously without triggering API queries. Each API provider has its own API endpoint, so if you are using custom API provider that component doesn't have configuration for (currently by default component has no API providers configured), the component will not attempt to load missing icons from an unknown API provider.

Example:

js
```
import { addCollection } from 'iconify-icon';

addCollection(
    // Icon set: prefix and icons
    {
        prefix: 'md',
        icons: {
            test: {
                body: '<path d="M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5z" fill="currentColor"/>',
            },
        },
        width: 24,
        height: 24,
    },
    // API provider
    'custom'
 );
```

Code above adds only one icon:

- provider is "custom".
- prefix is "md".
- name is "test".

In HTML this icon can be used like this:

html
```
<iconify-icon icon="@custom:md:test"></iconify-icon>
```

Syntax is similar to default icon syntax, but with API provider "@custom" in icon name. See [API providers documentation](https://iconify.design/docs/api/providers.html) for details.

## One icon

This function adds an entire icon set in [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") format.

If you want to add only once icon, and you have [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") data, use function [addIcon()](https://iconify.design/docs/iconify-icon/add-icon.html "addIcon() documentation") instead.

[Page 46](https://iconify.design/docs/iconify-icon/load-icons.html "Current Page.")

## Web component function: loadIcons

This tutorial is part of [Iconify Icon web component tutorial](https://iconify.design/docs/#functions).

The function loadIcons() retrieves icons from Iconify API.

When to use this function:

- To preload multiple icons that you will use later. This will make sure icon data is available when needed and it will load faster.
- If you need to get icon data as soon as it is available. For example, when rendering a custom component. However, if you need to load just one icon, there is also [loadIcon()](https://iconify.design/docs/iconify-icon/load-icon.html "loadIcon() documentation") that is easier to use.

This function is the most efficient way to preload icons that you know will be needed at some point. It loads icon data from Iconify API in bulk, reducing the number of queries.

It is safe to call the function multiple times with the same icon name, component will not load icon data from Iconify API twice. If you set a callback parameter, callback will be called correctly even if icon was loaded with different loadIcons() call, making sure callback is reliable.

## Usage

The function has the following parameters:

- icons, (string| [IconifyIconName](https://iconify.design/docs/iconify-icon/icon-name.html "IconifyIconName documentation"))\[\]. List of icons to load.
- callback, function. Optional callback to call. Callback is called not only when all icons have been retrieved, but also when part of icons have been retrieved.

The function returns function you can use to stop loading icons. It is needed when, for example, you are loading icons in a custom component, but the component's life cycle ended before icons have loaded, so you need to remove callback.

## Icons list

List of icons is an array. Each element can be a string, such as mdi:home or a [IconifyIconName](https://iconify.design/docs/iconify-icon/icon-name.html "IconifyIconName documentation") object.

## Callback

Optional callback has the following parameters:

- loaded, [IconifyIconName](https://iconify.design/docs/iconify-icon/icon-name.html "IconifyIconName documentation") \[\]. List of icons that have been loaded.
- missing, [IconifyIconName](https://iconify.design/docs/iconify-icon/icon-name.html "IconifyIconName documentation") \[\]. List of icons that are not available on API.
- pending, [IconifyIconName](https://iconify.design/docs/iconify-icon/icon-name.html "IconifyIconName documentation") \[\]. List of icons that are still loading.
- unsubscribe, function. Function to call to cancel loading. It is the same as result of loadIcons() call.

## IconifyIconName type

[IconifyIconName](https://iconify.design/docs/iconify-icon/icon-name.html "IconifyIconName documentation") is a simple object with the following properties, all properties are mandatory:

- provider, string. [API provider](https://iconify.design/docs/api/providers.html). For public Iconify API value is an empty string "".
- prefix, string. Icon set prefix.
- name, string. Icon name.

## Examples

Simple callback that loads one icon:

js
```
import { loadIcons } from 'iconify-icon';

const iconName = 'mdi:home';
loadIcons([iconName], (loaded, missing, pending, unsubscribe) => {
    if (loaded.length) {
        console.log(
            \`Icon ${iconName} have been loaded and is ready to be renderered.\`
        );
        return;
    }

    if (missing.length) {
        console.log(\`Icon ${iconName} does not exist.\`);
        return;
    }

    if (pending.length) {
        // Pending icons list in this example is empty.
        // If you call loadIcons() with multiple icons, pending list might not be empty, but for one icon it is always empty.
        //
        // Callback is called when something changes, with 1 icon there can only be 2 type of changes: icon has loaded or icon is missing.
    }
 });
```

Async version of loadIcons():

js
```
import { loadIcons } from 'iconify-icon';

/**
 * Function to load icons, returns Promise
 */
function loadTestIcons(icons) {
    return new Promise((fulfill, reject) => {
        loadIcons(icons, (loaded, missing, pending, unsubscribe) => {
            if (pending.length) {
                // Icons are pending, wait for all to load/fail
                //
                // If pending list is not empty, callback will be called
                // again when all icons are either loaded or missing
                return;
            }
            if (missing.length) {
                reject({
                    loaded,
                    missing,
                });
            } else {
                fulfill({
                    loaded,
                });
            }
        });
    });
 }

/**
 * Usage example in async function
 */
async function test() {
    // Wait for icons to load
    await loadTestIcons(['jam:info', 'cil:locomotive', 'cil:paper-plane']).catch(
        (err) => {
            console.error('Failed to load icons:', err.missing);
        }
    );

    // Do stuff with loaded icons
    console.log('Loaded!');
 }
test();
```

If you want to load only one icon, there is also [loadIcon()](https://iconify.design/docs/iconify-icon/load-icon.html "loadIcon() documentation") that is easier to use.

[Page 47](https://iconify.design/docs/iconify-icon/load-icon.html "Current Page.")

## Web component function: loadIcon

This tutorial is part of [Iconify Icon web component tutorial](https://iconify.design/docs/#functions).

The function loadIcon() retrieves an icon from Iconify API.

It returns Promise instance, making it very easy to use in asynchronous code.

When to use this function:

- When you need to get icon data inside an asynchronous function.

When not to use this function:

- To preload multiple icons that you will use later. Use [loadIcons()](https://iconify.design/docs/iconify-icon/load-icons.html "loadIcons() documentation") instead.

It is safe to call function multiple times with the same icon name, component will not load icon data from Iconify API twice. If you pass string icon name as parameter, multiple calls of the function will return the same Promise instance.

## Usage

The function has the following parameter:

- icon, string| [IconifyIconName](https://iconify.design/docs/iconify-icon/icon-name.html "IconifyIconName documentation"). Name of the icon to load.

The function returns Promise instance, which returns [FullIconifyIcon](https://iconify.design/docs/libraries/utils/full-iconify-icon.html "FullIconifyIcon documentation") data for icon on success.

## IconifyIconName type

[IconifyIconName](https://iconify.design/docs/iconify-icon/icon-name.html "IconifyIconName documentation") is a simple object with the following properties, all properties are mandatory:

- provider, string. [API provider](https://iconify.design/docs/api/providers.html). For public Iconify API value is an empty string "".
- prefix, string. Icon set prefix.
- name, string. Icon name.

## Examples

Using Promise syntax:

js
```
import { loadIcon } from 'iconify-icon';

const iconName = 'mdi:home';
loadIcon(iconName)
    .then((data) => {
        console.log(
            \`Icon ${iconName} have been loaded and is ready to be renderered.\`
        );
        console.log(data);
    })
    .catch((err) => {
        console.log(\`Icon ${iconName} does not exist.\`);
    });
```

Async/await syntax:

js
```
import { loadIcon } from 'iconify-icon';

/**
 * Usage example in async function
 */
async function test() {
    try {
        const data = await loadIcon('mdi:home');
        console.log('Loaded home icon!');
    } catch (err) {
        console.error('Failed to load home icon');
    }
 }
test();
```

If you want to load multiple icons, see [loadIcons()](https://iconify.design/docs/iconify-icon/load-icons.html "loadIcons() documentation").

[Page 48](https://iconify.design/docs/iconify-icon/custom-loaders.html "Current Page.")

## Custom icon loaders

This tutorial is part of [Iconify Icon web component tutorial](https://iconify.design/docs/#functions).

Functions setCustomIconLoader() and setCustomIconsLoader() are used to define custom icon loaders.

What is it for?

- To load icon data from custom sources.
- To modify icons, such as changing color or stroke width.

## Usage

Both functions have the same parameters, except for type of callback:

- callback, function. Callback that loads icons, can be synchronous or asynchronous function.
- prefix, string. Icon set prefix.
- provider, string. Icon set provider, optional.

Callback is a function that loads icon data.

Both synchronous and asynchronous (returns Promise instance) callbacks are supported.

Callbacks for both functions have similar parameters.

Parameters for setCustomIconLoader():

- name, string. Icon name.
- prefix, string. Icon set prefix.
- provider, string. Icon set provider.

Order of parameters is intentional: from most important to least important. If you have set loader for one prefix, you most likely only need name parameter.

The callback returns icon data as [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") or null on failure (or Promise of those types).

Callback for setCustomIconsLoader() is almost identical, except:

- First parameter is an array of icon names: string\[\].
- Callback returns an icon set as [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") or null on failure (or Promise of those types).

## Example

js
```
import { setCustomIconLoader, loadIcon } from "iconify-icon";

// Creates icon set "tabler-thin" that loads icons from Tabler Icons and makes them thinner
// Then you can use "tabler:angle" to render icon with default stroke, or "tabler-thin:angle" to render thinner icon
setCustomIconLoader(async (name) => {
  const data = await loadIcon(\`tabler:${name}\`);
  return data
    ? {
        ...data,
        body: data.body.replaceAll('stroke-width="2"', 'stroke-width="1"'),
      }
    : null;
 }, "tabler-thin");

// Fetches icon from custom server
// Icon data must be in IconifyIcon format
setCustomIconLoader(async (name) => {
  const response = await fetch(\`https://example.com/icons/${name}.json\`);
  if (!response.ok) {
    return null;
  }
  return await response.json();
 }, "custom-server");
```

Make sure loader is set before any icons are rendered, otherwise component might attempt to load icon from API and fail to render it.

[Page 49](https://iconify.design/docs/iconify-icon/build-icon.html "Current Page.")

## Web component function: buildIcon

This tutorial is part of [Iconify Icon web component tutorial](https://iconify.design/docs/#functions).

Function buildIcon() generates data used by icon component to render icon.

You can use this function to generate <svg> code.

## Usage

The function has the following parameters:

- icon, [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation"). Icon data.
- customisations. Optional customizations object.

The function returns object containing icon data, null if icon is not available.

You need icon data before you can use this function. See [getIcon()](https://iconify.design/docs/iconify-icon/get-icon.html "getIcon() documentation"), [iconLoaded()](https://iconify.design/docs/iconify-icon/icon-exists.html "iconLoaded() documentation") and [loadIcon()](https://iconify.design/docs/iconify-icon/load-icon.html "loadIcon() documentation") functions.

## Result

Result object has the following properties:

- attributes, object. List of attributes for <svg> element.
- body, string. Icon contents.

The list of attributes does not include standard attributes: xmlns, xmlns:link. It also does not include attributes that are added by icon component: aria-hidden, focusable, role, class, style. It is up to you to decide what attributes you want to add.

## Customizations

Second parameter is optional icon customizations. Available customizations:

IconifyIconCustomisations type is an object with the following optional properties, split into several categories.

Vertical alignment:

- inline, boolean. If enabled, adds vertical-align: -0.125em to style, rendering icon below baseline. The default value is false.

Icon dimensions:

- width, string|number|null. Icon width. The default value is null.
- height, string|number|null. Icon height. The default value is null.

There are several keywords that can be used for width and height:

- "auto" sets dimension to original icon's dimensions found in viewBox.
- "unset" and "none" remove dimensions from SVG.

If neither of dimensions is set, height defaults to "1em".

It is enough to set one dimension, such as height. Another dimension will be calculated using icon's width/height ratio. In the case of keywords, another dimension will be set to the same keyword.

Transformations:

- hFlip, boolean. Flip icon horizontally. The default value is false.
- vFlip, boolean. Flip icon vertically. The default value is false.
- rotate, number. Rotation in 90 degrees increments. The default value is 0.

For more details about dimensions see [icon dimensions documentation](https://iconify.design/docs/dimensions.html).

For more details about transformations see [icon transformations documentation](https://iconify.design/docs/transform.html).

## Example

js
```
import { buildIcon } from 'iconify-icon';
import biStopwatch from '@iconify-icons/bi/stopwatch';

buildIcon(biStopwatch, {
    hFlip: true,
    height: '24',
 });
```

json
```
{
    "attributes": {
        "width": "24",
        "height": "24",
        "viewBox": "0 0 16 16"
    },
    "body": "<g transform=\"translate(16 0) scale(-1 1)\"><g fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M8 15A6 6 0 1 0 8 3a6 6 0 0 0 0 12zm0 1A7 7 0 1 0 8 2a7 7 0 0 0 0 14z\"/><path fill-rule=\"evenodd\" d=\"M8 4.5a.5.5 0 0 1 .5.5v4a.5.5 0 0 1-.5.5H4.5a.5.5 0 0 1 0-1h3V5a.5.5 0 0 1 .5-.5zM5.5.5A.5.5 0 0 1 6 0h4a.5.5 0 0 1 0 1H6a.5.5 0 0 1-.5-.5z\"/><path d=\"M7 1h2v2H7V1z\"/></g></g>"
}
```

[Page 50](https://iconify.design/docs/icon-components/react/ "Current Page.")

## Iconify for React

Iconify offers native icon components for several popular UI frameworks.

Iconify for React is one of such components.

Yet another icon component? What are the advantages over other icon components?

- One syntax for over 275,000 icons from 200+ icon sets.
- Renders SVG. Many components simply render icon fonts, which look ugly. Iconify uses only pixel perfect SVG.
- Loads icons on demand. No need to bundle icons, component will automatically load icon data for icons that you use from Iconify API.

## Installation

If you are using NPM:

```
npm install --save-dev @iconify/react
```

If you are using Yarn:

```
yarn add --dev @iconify/react
```

### Version 4

As of version 5, the component is a modern functional component that uses React hooks.

If you want to use the icon component with an older version of React, you can install version 4 using @legacy tag:

```
npm install --save-dev @iconify/react@legacy
```

## Usage

Install @iconify/react and import Icon component from it:

js
```
import { Icon } from "@iconify/react";
```

Then use Icon component with icon name as icon parameter:

jsx
```
<Icon icon="mdi-light:home" />
```

Component will automatically retrieve data for mdi-light:home from Iconify API and render it. There are over 275,000 icons available on Iconify API from various free and open source icon sets, including all the most popular icon sets.

Availability of Iconify API is the biggest feature that makes Iconify components different from alternatives.

API sends data for icons on demand. Loading icons on demand has massive advantages over other methods:

- There can be an unlimited number of icons, giving you more choices. Icons you do not use are not loaded.
- No useless data. Icon sets usually have thousands of icons. Instead of bundling all icons, component retrieves only icons you use.

### Next.js

Component is compatible with the latest Next.js.

Unfortunately, Next.js currently does not support useState in components, making it impossible to use the same stateful components on server and client, so the icon component is a client-only component. SVG will not be rendered on server.

Additionally, to avoid hydration errors, component renders SVG only after it is mounted, which can sometimes cause a tiny delay. If you are using Next.js or similar framework, consider switching to [Iconify Icon web component](https://iconify.design/docs/iconify-icon/).

If you do want to render SVGs without a delay, provide [icon data](https://iconify.design/docs/types/iconify-icon.html) as parameter instead of icon name or use a different way to render icons, such as:

- [Iconify Icon web component](https://iconify.design/docs/iconify-icon/)
- [Unplugin Icons](https://iconify.design/docs/usage/svg/unplugin/)
- [Tailwind CSS with Iconify plugin](https://iconify.design/docs/usage/css/tailwind/iconify/)
- [UnoCSS with icons preset](https://iconify.design/docs/usage/css/unocss/)

## Properties

You can pass any custom properties to Icon.

Required properties:

- icon, [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") |string icon name or icon data.

Optional properties:

- inline, boolean changes vertical alignment.
- width, string|number icon width.
- height, string|number icon height.
- hFlip, boolean flips icon horizontally.
- vFlip, boolean flips icon vertically.
- flip, string alternative to hFlip and vFlip.
- rotate, number|string rotates icon.
- color, string changes icon color.
- onLoad, function is a callback that is called when icon data has been loaded. See below.

See below for more information on each optional property.

In addition to the properties mentioned above, the icon component accepts any other properties and events. All other properties and events will be passed to generated SVG element, so you can do stuff like assigning onClick event, setting the inline style, add title and so on.

## Icon

Icon name is a string, which has 3 parts:

| @api-provider | : | icon-prefix | : | icon-name |
| --- | --- | --- | --- | --- |
| provider |  | prefix |  | name |

- provider points to API source. Starts with "@", can be empty (empty value is used for public Iconify API).
- prefix is name of icon set.
- name is name of icon.

Examples of valid icon names:

- flat-color-icons:voice-presentation - icon is "voice-presentation" from [Flat Color Icons](https://icon-sets.iconify.design/flat-color-icons/) icon set, from public Iconify API.
- mdi-light:home - icon is "home" from [Material Design Light](https://icon-sets.iconify.design/mdi-light/) icon set, from public Iconify API.

Exceptions:

- If the API provider is empty, it can be skipped (like in examples above).
- If prefix does not contain "-", prefix and icon name can be separated with hyphen. This is to support people migrating from icon fonts. For example, fa:arrow-left and fa-arrow-left are identical because "fa" does not contain hyphen.

There are over 275,000 icons available from 200+ icon sets. [Browse icons sets](https://icon-sets.iconify.design/) to see all available icons.

You can also add custom API providers for more icon choices. See [API providers documentation](https://iconify.design/docs/api/providers.html).

## Color

You can only change the color of monotone icons. Some icons, such as emoji, have a hardcoded palette that cannot be changed.

To add color to a monotone icon, simply change text color.

jsx
```
<Icon icon="mdi:home" style={{ color: "red" }} />
```

For various ways to set color, see [how to change icon color in Iconify for React](https://iconify.design/docs/color.html).

## Dimensions

By default, icon height is set to "1em", icon width is changed dynamically based on the icon's width/height ratio. This makes it easy to change icon size by changing font-size in the stylesheet, just like icon fonts.

There are several ways to change icon dimensions:

- Setting font-size in style (or fontSize if you are using inline style).
- Setting width and/or height property.

Values for width and height can be numbers or strings.

If you set only one dimension, another dimension will be calculated using the icon's width/height ratio. For example, if the icon size is 16 x 24, you set the height to 48, the width will be set to 32. Calculations work not only with numbers, but also with string values.

jsx
```
<Icon icon="mdi:home" style={{ fontSize: "24px" }} />
```

For various ways to change icon dimensions, see [how to change icon dimensions in Iconify for React](https://iconify.design/docs/dimensions.html).

## Transformations

An icon can be rotated and flipped horizontally and/or vertically. All transformations are done relative to the center of the icon.

These are not CSS transformations, transformations are applied inside SVG.

For more details see [how to transform icon in Iconify for React](https://iconify.design/docs/transform.html).

## onLoad

onLoad property is an optional callback function. It is called when icon data has been loaded.

It is not an event, such as click event for links, it is a simple callback function.

When onLoad is called:

- If value of icon property is an object, onLoad is not called.
- If value of icon property is a string and icon data is available, onLoad is called on first render.
- If value of icon property is a string and icon data is not available, onLoad is called on first re-render after icon data is retrieved from API.

What is the purpose of onLoad? To let you know when Icon component renders an icon and when it does not render anything. This allows you to do things like adding class name for the parent element, such as "container--with-icon" that modify layout if icon is being displayed.

## Functions

Component exports various functions, which developers can use to control icons.

Functions are split in several groups (click function name to see more details and examples):

### Check available icons

There are several functions in this section:

- [iconLoaded(name)](https://iconify.design/docs/icon-components/react/icon-exists.html "iconLoaded() documentation"). Checks if icon data is available, returns boolean.
- [listIcons()](https://iconify.design/docs/icon-components/react/list-icons.html "listIcons() documentation"). Lists available icons, returns string\[\].
- [getIcon(name)](https://iconify.design/docs/icon-components/react/get-icon.html "getIcon() documentation"). Returns icon data, returns [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") object.

### Adding icons

Functions for adding icons to the component:

- [addIcon()](https://iconify.design/docs/icon-components/react/add-icon.html "addIcon() documentation"). Adds one icon.
- [addCollection()](https://iconify.design/docs/icon-components/react/add-collection.html "addCollection() documentation"). Adds an icon set.

Note: icons added to the component with these functions are not stored in the icon data cache. Component caches only icons retrieved from API.

### Custom loaders

Custom loaders can be used to load icons from custom sources:

- [setCustomIconLoader()](https://iconify.design/docs/icon-components/react/custom-loaders.html "setCustomIconLoader() documentation"). Loads one icon.
- [setCustomIconsLoader()](https://iconify.design/docs/icon-components/react/custom-loaders.html "setCustomIconsLoader() documentation"). Loads icons in bulk.

Loaders are set per icon set prefix. Make sure to configure loader before displaying any icons.

It can also be used to customise icons: in custom loader you can load icon from API using [loadIcon](https://iconify.design/docs/icon-components/react/load-icon.html "loadIcon() documentation"), change its content (such as colors or stroke width) and return modified icon.

### Helper functions

- [replaceIDs(html)](https://iconify.design/docs/icon-components/react/replace-ids.html "replaceIDs() documentation"). Randomises IDs in generated string. This should be used when rendering icon based on data returned by [getIcon()](https://iconify.design/docs/icon-components/react/get-icon.html "getIcon() documentation") to make sure elements inside each icon have unique IDs.
- calculateSize(). Calculates icon size. It is used to calculate width if only height is set and vice versa.
- [buildIcon(icon, customisations?)](https://iconify.design/docs/icon-components/react/build-icon.html "buildIcon() documentation"). Generates data used by icon component. This can be used if you prefer to generate <svg> yourself. Data includes attributes for <svg> and inner HTML.

### API functions

- [loadIcons(icons, callback?)](https://iconify.design/docs/icon-components/react/load-icons.html "loadIcons() documentation"). Loads icons from API, calls optional callback when either all or part of icons have been loaded.
- [loadIcon(icon)](https://iconify.design/docs/icon-components/react/load-icon.html "loadIcon() documentation"). Loads one icon from API, returns Promise.
- [addAPIProvider()](https://iconify.design/docs/icon-components/react/add-api-provider.html "addAPIProvider() documentation"). Adds custom API provider. See [API providers documentation](https://iconify.design/docs/api/providers.html).

### Internal API functions

There are several internal API functions that are exposed. They are intended to be used by developers that need more control over the component. For example, it is used in Sketch and Figma plug-ins. Use them carefully.

All internal API functions are exposed as properties of \_api object:

- getAPI(). Returns internal API module.
- getAPIConfig(). Returns API configuration.
- setAPIModule(provider). Sets API module for provider. This is an experimental function intended for custom API providers that use custom module for retrieving data from API.
- setFetch(fetch). Set custom Fetch API.
- getFetch(). Returns used fetch() function, null if Fetch API is not available.

[Page 51](https://iconify.design/docs/icon-components/react/color.html "Current Page.")

## Icon color

This tutorial is part of [Iconify for React tutorial](https://iconify.design/docs/).

You can only change color of monotone icons. Some icons, such as emoji, have a hardcoded palette that cannot be changed.

To change color of a monotone icon, simply change text color or use color attribute or add style with color.

All icons inside this div are light blue, including a bell icon and attachment icon

This text and icon are orange:

Red home icons (shows different ways to change color):

Icon with palette:

jsx
```
import React from 'react';

// <InlineIcon /> is equal to <Icon inline={true} />
import { InlineIcon } from '@iconify/react';

export function colorDemo() {
    return (
        <div>
            <div className="light-blue-block">
                All icons inside this div are light blue, including a bell icon{' '}
                <InlineIcon icon="bi:bell-fill" /> and stopwatch icon{' '}
                <InlineIcon icon="bi:stopwatch" />
            </div>
            <div className="orange-block">
                This text and icon are orange: <InlineIcon icon="bi:bell-fill" />
            </div>
            <div>
                Red home icons (shows different ways to change color):{' '}
                <InlineIcon className="red-icon" icon="bx:bx-home" />{' '}
                <InlineIcon style={{ color: 'red' }} icon="bx:bx-home" />{' '}
                <InlineIcon color="red" icon="bx:bx-home" />
            </div>
            <div>
                Icon with palette: <InlineIcon icon="noto:paintbrush" />
            </div>
        </div>
    );
 }
```

css
```
// Change text color for ".orange-block" to #e70
.orange-block {
    color: #e70;
 }
// Change all icons inside ".light-blue-block" to #08f
.light-blue-block svg {
    color: #08f;
 }
// Change text color for ".red-icon" to #e00
.red-icon {
    color: #e00;
 }
```

Color only works for icons that do not have a palette. Color in icons that do have a palette, like paintbrush icon in an example above, cannot be changed.

You can change color the same way as you would for text.

## RGBA and HSLA colors

Avoid using rgba and hsla colors. Some icons have multiple layers on top of each other. Using semi-transparent color will result in both layers being visible.

Instead, use a solid color and add transparency with opacity. This will result in browser rendering shapes with a solid color, then applying opacity to an entire icon.

## fill and stroke

Avoid using fill and stroke in stylesheet, unless you are using it for a specific icon.

Not all icons are the same. Some use fill for shapes, some use stroke. If you set fill, you might end up with filled shapes that should not be filled.

[Page 52](https://iconify.design/docs/icon-components/react/dimensions.html "Current Page.")

## Icon dimensions

This tutorial is part of [Iconify for React tutorial](https://iconify.design/docs/).

By default, icon height is set to "1em", icon width is changed dynamically based on the icon's width/height ratio.

This makes it easy to change icon size by changing font-size in the stylesheet or in style, just like icon fonts:

jsx
```
import React from 'react';
import { Icon } from '@iconify/react';

export function sizeDemo() {
    return (
        <div>
            <Icon icon="cil:locomotive" />
            <Icon icon="cil:paper-plane" style={{ fontSize: '36px' }} />
            <Icon icon="cil:truck" className="big-icon" />
        </div>
    );
 }
```

css
```
svg {
    font-size: 24px;
    line-height: 1em;
 }

.big-icon {
    font-size: 72px;
 }
```

If you want to control icon size with width and height in CSS, see [how to remove icon dimensions](#unset) section below.

## Units

Size can be a string with or without units or a number. If value is a number or string without units, it will be treated by browser as pixels.

Examples of 24px icon:

jsx
```
// Number
 <Icon icon="mdi:home" height={24} />
// String without units
<Icon icon="mdi:home" height="24" />
// String with units
<Icon icon="mdi:home" height="24px" />
// String with units, font-size is 16px
<Icon icon="mdi:home" height="1.5em" />
```

## Keyword "auto"

Special keyword "auto" sets size to value from viewBox. This makes it easy to render an icon as it was originally designed.

It is enough to set one dimension to "auto", another dimension will be set to "auto" too, unless you specify otherwise.

For example, if viewBox="0 0 24 24" and height is set to "auto", height will be set to 24.

jsx
```
<Icon icon="mdi:home" height="auto" />
```

## Keywords "none" and "unset"

Special keywords "none" and "unset" remove dimensions from generated SVG.

This results in icon without dimensions. You should set icon's width and height in CSS.

It is enough to set one dimension to "unset", another dimension will be set to "unset" too, unless you specify otherwise.

jsx
```
import React from 'react';
import { Icon } from '@iconify/react';

export function sizeDemo() {
    return (
        <div>
            <Icon
                icon="mdi:home"
                height="none"
                style={{ width: '48px', height: '48px' }}
            />
        </div>
    );
 }
```

This gives you full control over each icon's dimension separately in CSS instead of controlling them both with font-size.

Sometimes you might also need to add display: block; to CSS for icon to behave correctly.

## Setting only width or height

In an example above, all icons only use height.

What happens when only one dimension is set?

- If width is not set, but height is set, width is calculated using icon's width/height ratio.
- If height is not set, but width is set, height is calculated using icon's height/width ratio.
- If no dimensions are set in attributes, height is set to "1em" and width is calculated using icon's width/height ratio. Then icon behaves like a text and can be resized using font-size in stylesheet.

### Example

Many icons are square. For such icons if you set one dimension, another dimension will have the same value.

However, there are many icons that are not square. For example, icons imported from icon fonts and Font Awesome.

This is data for fa-regular:address-book:

json
```
{
    "body": "<path d=\"M436 160c6.6 0 12-5.4 12-12v-40c0-6.6-5.4-12-12-12h-20V48c0-26.5-21.5-48-48-48H48C21.5 0 0 21.5 0 48v416c0 26.5 21.5 48 48 48h320c26.5 0 48-21.5 48-48v-48h20c6.6 0 12-5.4 12-12v-40c0-6.6-5.4-12-12-12h-20v-64h20c6.6 0 12-5.4 12-12v-40c0-6.6-5.4-12-12-12h-20v-64h20zm-68 304H48V48h320v416zM208 256c35.3 0 64-28.7 64-64s-28.7-64-64-64s-64 28.7-64 64s28.7 64 64 64zm-89.6 128h179.2c12.4 0 22.4-8.6 22.4-19.2v-19.2c0-31.8-30.1-57.6-67.2-57.6c-10.8 0-18.7 8-44.8 8c-26.9 0-33.4-8-44.8-8c-37.1 0-67.2 25.8-67.2 57.6v19.2c0 10.6 10 19.2 22.4 19.2z\" fill=\"currentColor\"/>",
    "width": 448,
    "height": 512
}
```

Icon size is 448 x 512

If you do not set any dimensions, height will be set to "1em" and width will be set to 448 / 512 = "0.875em". However, values that have more than 2 numbers after decimal point are rounded up, so actual width will be "0.88em":

html
```
<svg
    xmlns="http://www.w3.org/2000/svg"
    xmlns:xlink="http://www.w3.org/1999/xlink"
    aria-hidden="true"
    focusable="false"
    role="img"
    class="iconify iconify--fa-regular"
    width="0.88em"
    height="1em"
    preserveAspectRatio="xMidYMid meet"
    viewBox="0 0 448 512"
 >
    <path d="..." fill="currentColor"></path>
</svg>
```

If you set width to 56, but do not set height, height will be set to 56 \* 512 / 448 = 64:

html
```
<svg width="56" height="64" ...>...</svg>
```

If you set both values: width to 56 and height to 128, values will be as you set them (also see "Alignment" section below):

html
```
<svg width="56" height="128" ...>...</svg>
```

## Alignment

What if you set both width and height and its ratio doesn't match icon's width/height ratio?

For example, what will happen if icon is 24x24, but you set one dimension to 40 and other dimension to 24?

Using box-shadow to show icon dimensions

jsx
```
<Icon icon="jam:info" width="40" height="24" />
<Icon icon="jam:info" width="24" height="40" />
```

SVG do not behave like other images. When you set a wrong width/height ratio for other image formats, images get stretched. When you do that for SVG, bounding box is changed and the image is aligned inside that bounding box.

In an example above, one icon is too wide and another icon is too tall. The browser will move icons to center instead of stretching icon.

[Page 53](https://iconify.design/docs/icon-components/react/transform.html "Current Page.")

## Transformations

This tutorial is part of [Iconify for React tutorial](https://iconify.design/docs/).

An icon can be rotated and flipped horizontally and/or vertically. All transformations are done relative to the center of the icon.

There are two types of transformations:

- Horizontal and vertical flip.
- Rotation by 90, 180 and 270 degrees.

## CSS vs Iconify transformations

These are not CSS transformations, transformations are applied inside SVG.

What's the difference from CSS transformations?

- If you rotate an icon by 90 degrees in CSS, icon's bounding box remains the same. 16x24 icon still takes space for 16x24, but might overlap elements around it.
- If you rotate an icon by 90 degrees in SVG Framework, icon's dimensions swap places. 16x24 icon becomes 24x16 icon, and it does not affect elements around it.

Example:

Test icon with text around it

Test icon with text around it

Using box-shadow to show icon dimensions

jsx
```
<p>
    Test icon <InlineIcon icon="fa-regular:handshake" rotate="90deg" /> with text around it
</p>
<p>
    Test icon <InlineIcon icon="fa-regular:handshake" style={{ transform: 'rotate(90deg)' }} /> with text around it
</p>
```

In example above, first icon is rotated using rotate attribute, second icon is rotated using CSS. The first icon kept its 1em height, second icon became taller than it should be.

Sometimes you do want behaviour that CSS transformations provide. Then you can still use CSS transformations by adding it to style.

## Flip

You can flip an icon horizontally and/or vertically.

One way to do that is to add flip attribute with comma-separated values. Possible values:

- "horizontal": flip icon horizontally.
- "vertical": flip icon vertically.

You can also do that by setting hFlip and / or vFlip attributes to true.

Example:

No flip:

Horizontal flip:

Vertical flip:

Both (or 180° rotation):

jsx
```
<p>
    No flip: <InlineIcon icon="bi:check2-circle" />
</p>
<p>
    Horizontal flip: <InlineIcon icon="bi:check2-circle" flip="horizontal" />
</p>
<p>
    Vertical flip: <InlineIcon icon="bi:check2-circle" flip="vertical" />
</p>
<p>
    Both (or 180° rotation): <InlineIcon icon="bi:check2-circle" flip="horizontal,vertical" />
</p>
```

jsx
```
<p>
    No flip: <InlineIcon icon="bi:check2-circle" />
</p>
<p>
    Horizontal flip: <InlineIcon icon="bi:check2-circle" hFlip={true} />
</p>
<p>
    Vertical flip: <InlineIcon icon="bi:check2-circle" vFlip={true} />
</p>
<p>
    Both (or 180° rotation): <InlineIcon icon="bi:check2-circle" hFlip={true} vFlip={true} />
</p>
```

## Rotation

You can rotate icon by 90, 180 and 270 degrees.

To do that, add rotate attribute. Possible values:

- "90deg", "1": rotate by 90 degrees.
- "180deg", "2": rotate by 180 degrees.
- "270deg", "3": rotate by 270 degrees.

Example:

No rotation:

90° rotation:

180° rotation:

270° rotation:

jsx
```
<p>
    No rotation: <InlineIcon icon="bi:check2-circle" />
</p>
<p>
    90° rotation: <InlineIcon icon="bi:check2-circle" rotate="90deg" />
</p>
<p>
    180° rotation: <InlineIcon icon="bi:check2-circle" rotate="180deg" />
</p>
<p>
    270° rotation: <InlineIcon icon="bi:check2-circle" rotate={3} />
</p>
```

## Rotate and flip

You can use both rotation and flip on an icon. The icon is flipped first, then rotated.

[Page 54](https://iconify.design/docs/icon-components/react/inline.html "Current Page.")

## Vertical alignment

This tutorial is part of [Iconify for React tutorial](https://iconify.design/docs/).

When an icon is rendered in text, by default it is aligned at baseline, as any other images.

Emojis and icon fonts are rendered slightly below baseline, like any text.

If you want to render icon in text, you probably want to add vertical-align to each icon to render it slightly below baseline, to make it fit in text, similar to emojis and icon fonts:

SVG in text:

SVG in text with vertical-align: -0.125em:

## Inline attribute

To add vertical-align to icon, the icon component has several options:

- Swapping Icon component with InlineIcon.
- Adding inline attribute.
- Adding vertical-align style with value -0.125em.

Inline attribute demo:

jsx
```
import React from 'react';
import { Icon, InlineIcon } from '@iconify/react';

export function inlineDemo() {
    return (
        <div>
            <p>
                Inline attribute demo:
                <Icon inline={true} icon="line-md:image-twotone" />
                <InlineIcon icon="mdi:account-box-outline" />
            </p>
        </div>
    );
 }
```

Important: this attribute does not change display mode for icon. It only adds vertical-align style.

[Page 55](https://iconify.design/docs/icon-components/react/icon-exists.html "Current Page.")

## Iconify for React function: iconLoaded

This tutorial is part of [Iconify for React functions tutorial](https://iconify.design/docs/#functions).

The function iconLoaded() checks if icon data is available for rendering.

## Usage

The function has the following parameter:

- name, string. Icon name.

The function returns boolean value: true if icon data is available, false if icon data is not available.

## Example

jsx
```
import { iconLoaded, loadIcons, Icon } from "@iconify/react";

function renderLeftArrow() {
  // Check if 'bi:arrow-left' is available
  if (iconLoaded("bi:arrow-left")) {
    // Return HTML for 'bi:arrow-left'
    return <Icon icon="bi:arrow-left" />;
  }

  // Load icon. Bad example because this should use a callback to re-render arrow in a stateful
  // component, but this code example is about iconLoaded(), not loadIcons()

  // Function loadIcons() is asynchronous, so in this example it will only trigger loading, but
  // icon data will not be available immediately
  loadIcons(["bi:arrow-left"]);

  // Return '<'
  return <span>&lt;</span>;
 }
```

## Legacy

Note: in old versions of component, this function was named iconExists(). It was the same function, but with bad name.

Because of bad name, some developers assumed it checks if icon exists on Iconify API. It does not. All it does is checks component's storage.

To avoid confusion, function was renamed.

[Page 56](https://iconify.design/docs/icon-components/react/list-icons.html "Current Page.")

## Iconify for React function: listIcons

This tutorial is part of [Iconify for React functions tutorial](https://iconify.design/docs/#functions).

The function listIcons() lists loaded icons.

## Usage

The function has the following optional parameters:

- provider, string. Lists only icons from one API provider.
- prefix, string. Lists only icons with specific prefix. If prefix is set, provider must be set too (for Iconify public API provider value is empty string "").

The function returns an array of icon names.

## Examples

js
```
import { listIcons } from '@iconify/react';

// List all icons
console.log(listIcons());
```

Another example:

js
```
import { listIcons } from '@iconify/react';

// List all loaded Material Design Icons
console.log(listIcons('', 'mdi'));
// ["mdi:alert", "mdi:home", "mdi:account-box-outline", "mdi:eyedropper", "mdi:account-off", "mdi:account", "mdi:account-box", "mdi:account-cash"]
```

[Page 57](https://iconify.design/docs/icon-components/react/get-icon.html "Current Page.")

## Iconify for React function: getIcon

This tutorial is part of [Iconify for React functions tutorial](https://iconify.design/docs/#functions).

The function getIcon() retrieves icon data.

## Usage

The function has the following parameter:

- name, string. Icon name.

The function returns icon data in [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") format, null if icon is not available.

## Examples

js
```
import { getIcon } from '@iconify/react';

const data = getIcon('bi:check2-circle');
```

json
```
{
    "body": "<g fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M15.354 2.646a.5.5 0 0 1 0 .708l-7 7a.5.5 0 0 1-.708 0l-3-3a.5.5 0 1 1 .708-.708L8 9.293l6.646-6.647a.5.5 0 0 1 .708 0z\"/><path fill-rule=\"evenodd\" d=\"M8 2.5A5.5 5.5 0 1 0 13.5 8a.5.5 0 0 1 1 0a6.5 6.5 0 1 1-3.25-5.63a.5.5 0 1 1-.5.865A5.472 5.472 0 0 0 8 2.5z\"/></g>",
    "left": 0,
    "top": 0,
    "width": 16,
    "height": 16,
    "rotate": 0,
    "vFlip": false,
    "hFlip": false
}
```

Another example:

js
```
import { getIcon } from '@iconify/react';

const data = getIcon('cil:paper-plane');
```

json
```
{
    "body": "<path fill=\"currentColor\" d=\"M474.444 19.857a20.336 20.336 0 0 0-21.592-2.781L33.737 213.8v38.066l176.037 70.414L322.69 496h38.074l120.3-455.4a20.342 20.342 0 0 0-6.62-20.743zM337.257 459.693L240.2 310.37l149.353-163.582l-23.631-21.576L215.4 290.069L70.257 232.012L443.7 56.72z\"/>",
    "left": 0,
    "top": 0,
    "width": 512,
    "height": 512,
    "rotate": 0,
    "vFlip": false,
    "hFlip": false
}
```

Example with bad icon name, returns null:

js
```
import { getIcon } from '@iconify/react';

// null
const data = getIcon('no-such-icon');
```

[Page 58](https://iconify.design/docs/icon-components/react/add-icon.html "Current Page.")

## Iconify for React function: addIcon

This tutorial is part of [Iconify for React functions tutorial](https://iconify.design/docs/#functions).

Function addIcon() adds one icon to the component's icon data storage.

## Usage

The function has the following parameters:

- name, string. Icon name.
- data, [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation"). Icon data.

The function returns boolean value: true on success, false if something is wrong with data.

## Examples

js
```
import { addIcon } from '@iconify/react';

addIcon('mdi:account-box', {
    body: '<path d="M6 17c0-2 4-3.1 6-3.1s6 1.1 6 3.1v1H6m9-9a3 3 0 0 1-3 3a3 3 0 0 1-3-3a3 3 0 0 1 3-3a3 3 0 0 1 3 3M3 5v14a2 2 0 0 0 2 2h14a2 2 0 0 0 2-2V5a2 2 0 0 0-2-2H5a2 2 0 0 0-2 2z" fill="currentColor"/>',
    width: 24,
    height: 24,
 });
```

Note: icons added by this function are not cached in localStorage and sessionStorage.

## API provider

API provider parameter can be used to load custom icons asynchronously without triggering API queries.

Each API provider has its own API endpoint, so if you are using custom API provider that component doesn't have configuration for (currently by default component has no API providers configured), the component will not attempt to load missing icons from an unknown API provider.

Example:

js
```
import { addIcon } from '@iconify/react';

addIcon('@custom:md:test', {
    body: '<path d="M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5z" fill="currentColor"/>',
    width: 24,
    height: 24,
 });
```

Code above adds the following icon:

- provider is "custom".
- prefix is "md".
- name is "test".

In component JSX this icon can be used like this:

jsx
```
<Icon icon="@custom:md:test" />
```

Syntax is similar to default icon syntax, but with API provider "@custom" in icon name. See [API providers documentation](https://iconify.design/docs/api/providers.html) for details.

## One icon

This function adds one icon in [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") format.

If you want to add several icons, or you have [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") data, use function [addCollection()](https://iconify.design/docs/icon-components/react/add-collection.html "addCollection() documentation") instead.

[Page 59](https://iconify.design/docs/icon-components/react/add-collection.html "Current Page.")

## Iconify for React function: addCollection

This tutorial is part of [Iconify for React functions tutorial](https://iconify.design/docs/#functions).

Function addCollection() adds an icon set to component's icon storage.

## Usage

The function has the following parameters:

- data, [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation"). Icon set data.
- provider, string. Optional API provider ID.

The function returns boolean value: true on success, false if something is wrong with data.

If an icon set has provider property and second parameter to addCollection() is passed, provider from second parameter overrides provider from an icon set.

## Examples

js
```
import { addCollection } from '@iconify/react';

addCollection({
    prefix: 'custom',
    icons: {
        icon1: {
            body: '<path d="M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5z" fill="currentColor"/>',
        },
    },
    width: 24,
    height: 24,
 });
```

js
```
import { addCollection } from '@iconify/react';

addCollection({
    prefix: 'mdi',
    icons: {
        'account-box': {
            body: '<path d="M6 17c0-2 4-3.1 6-3.1s6 1.1 6 3.1v1H6m9-9a3 3 0 0 1-3 3a3 3 0 0 1-3-3a3 3 0 0 1 3-3a3 3 0 0 1 3 3M3 5v14a2 2 0 0 0 2 2h14a2 2 0 0 0 2-2V5a2 2 0 0 0-2-2H5a2 2 0 0 0-2 2z" fill="currentColor"/>',
        },
        'account-cash': {
            body: '<path d="M11 8c0 2.21-1.79 4-4 4s-4-1.79-4-4s1.79-4 4-4s4 1.79 4 4m0 6.72V20H0v-2c0-2.21 3.13-4 7-4c1.5 0 2.87.27 4 .72M24 20H13V3h11v17m-8-8.5a2.5 2.5 0 0 1 5 0a2.5 2.5 0 0 1-5 0M22 7a2 2 0 0 1-2-2h-3c0 1.11-.89 2-2 2v9a2 2 0 0 1 2 2h3c0-1.1.9-2 2-2V7z" fill="currentColor"/>',
        },
        'account': {
            body: '<path d="M12 4a4 4 0 0 1 4 4a4 4 0 0 1-4 4a4 4 0 0 1-4-4a4 4 0 0 1 4-4m0 10c4.42 0 8 1.79 8 4v2H4v-2c0-2.21 3.58-4 8-4z" fill="currentColor"/>',
        },
        'home': {
            body: '<path d="M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5z" fill="currentColor"/>',
        },
    },
    width: 24,
    height: 24,
 });
```

Note: icons added by this function are not cached in localStorage and sessionStorage.

## API provider

API provider parameter can be used to specify that icon set belongs to the specific API provider.

It can also be used to load custom icons asynchronously without triggering API queries. Each API provider has its own API endpoint, so if you are using custom API provider that component doesn't have configuration for (currently by default component has no API providers configured), the component will not attempt to load missing icons from an unknown API provider.

Example:

js
```
import { addCollection } from '@iconify/react';

addCollection(
    // Icon set: prefix and icons
    {
        prefix: 'md',
        icons: {
            test: {
                body: '<path d="M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5z" fill="currentColor"/>',
            },
        },
        width: 24,
        height: 24,
    },
    // API provider
    'custom'
 );
```

Code above adds only one icon:

- provider is "custom".
- prefix is "md".
- name is "test".

In component JSX this icon can be used like this:

jsx
```
<Icon icon="@custom:md:test" />
```

Syntax is similar to default icon syntax, but with API provider "@custom" in icon name. See [API providers documentation](https://iconify.design/docs/api/providers.html) for details.

## One icon

This function adds an entire icon set in [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") format.

If you want to add only once icon, and you have [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") data, use function [addIcon()](https://iconify.design/docs/icon-components/react/add-icon.html "addIcon() documentation") instead.

[Page 60](https://iconify.design/docs/icon-components/react/load-icons.html "Current Page.")

## Iconify for React function: loadIcons

This tutorial is part of [Iconify for React functions tutorial](https://iconify.design/docs/#functions).

The function loadIcons() retrieves icons from Iconify API.

When to use this function:

- To preload multiple icons that you will use later. This will make sure icon data is available when needed and it will load faster.
- If you need to get icon data as soon as it is available. For example, when rendering a custom component. However, if you need to load just one icon, there is also [loadIcon()](https://iconify.design/docs/icon-components/react/load-icon.html "loadIcon() documentation") that is easier to use.

This function is the most efficient way to preload icons that you know will be needed at some point. It loads icon data from Iconify API in bulk, reducing the number of queries.

It is safe to call the function multiple times with the same icon name, component will not load icon data from Iconify API twice. If you set a callback parameter, callback will be called correctly even if icon was loaded with different loadIcons() call, making sure callback is reliable.

## Usage

The function has the following parameters:

- icons, (string| [IconifyIconName](https://iconify.design/docs/icon-components/react/icon-name.html "IconifyIconName documentation"))\[\]. List of icons to load.
- callback, function. Optional callback to call. Callback is called not only when all icons have been retrieved, but also when part of icons have been retrieved.

The function returns function you can use to stop loading icons. It is needed when, for example, you are loading icons in a custom component, but the component's life cycle ended before icons have loaded, so you need to remove callback.

## Icons list

List of icons is an array. Each element can be a string, such as mdi:home or a [IconifyIconName](https://iconify.design/docs/icon-components/react/icon-name.html "IconifyIconName documentation") object.

## Callback

Optional callback has the following parameters:

- loaded, [IconifyIconName](https://iconify.design/docs/icon-components/react/icon-name.html "IconifyIconName documentation") \[\]. List of icons that have been loaded.
- missing, [IconifyIconName](https://iconify.design/docs/icon-components/react/icon-name.html "IconifyIconName documentation") \[\]. List of icons that are not available on API.
- pending, [IconifyIconName](https://iconify.design/docs/icon-components/react/icon-name.html "IconifyIconName documentation") \[\]. List of icons that are still loading.
- unsubscribe, function. Function to call to cancel loading. It is the same as result of loadIcons() call.

## IconifyIconName type

[IconifyIconName](https://iconify.design/docs/icon-components/react/icon-name.html "IconifyIconName documentation") is a simple object with the following properties, all properties are mandatory:

- provider, string. [API provider](https://iconify.design/docs/api/providers.html). For public Iconify API value is an empty string "".
- prefix, string. Icon set prefix.
- name, string. Icon name.

## Examples

Simple callback that loads one icon:

js
```
import { loadIcons } from '@iconify/react';

const iconName = 'mdi:home';
loadIcons([iconName], (loaded, missing, pending, unsubscribe) => {
    if (loaded.length) {
        console.log(
            \`Icon ${iconName} have been loaded and is ready to be renderered.\`
        );
        return;
    }

    if (missing.length) {
        console.log(\`Icon ${iconName} does not exist.\`);
        return;
    }

    if (pending.length) {
        // Pending icons list in this example is empty.
        // If you call loadIcons() with multiple icons, pending list might not be empty, but for one icon it is always empty.
        //
        // Callback is called when something changes, with 1 icon there can only be 2 type of changes: icon has loaded or icon is missing.
    }
 });
```

Async version of loadIcons():

js
```
import { loadIcons } from '@iconify/react';

/**
 * Function to load icons, returns Promise
 */
function loadTestIcons(icons) {
    return new Promise((fulfill, reject) => {
        loadIcons(icons, (loaded, missing, pending, unsubscribe) => {
            if (pending.length) {
                // Icons are pending, wait for all to load/fail
                //
                // If pending list is not empty, callback will be called
                // again when all icons are either loaded or missing
                return;
            }
            if (missing.length) {
                reject({
                    loaded,
                    missing,
                });
            } else {
                fulfill({
                    loaded,
                });
            }
        });
    });
 }

/**
 * Usage example in async function
 */
async function test() {
    // Wait for icons to load
    await loadTestIcons(['jam:info', 'cil:locomotive', 'cil:paper-plane']).catch(
        (err) => {
            console.error('Failed to load icons:', err.missing);
        }
    );

    // Do stuff with loaded icons
    console.log('Loaded!');
 }
test();
```

If you want to load only one icon, there is also [loadIcon()](https://iconify.design/docs/icon-components/react/load-icon.html "loadIcon() documentation") that is easier to use.

[Page 61](https://iconify.design/docs/icon-components/react/load-icon.html "Current Page.")

## Iconify for React function: loadIcon

This tutorial is part of [Iconify for React functions tutorial](https://iconify.design/docs/#functions).

The function loadIcon() retrieves an icon from Iconify API.

It returns Promise instance, making it very easy to use in asynchronous code.

When to use this function:

- When you need to get icon data inside an asynchronous function.

When not to use this function:

- To preload multiple icons that you will use later. Use [loadIcons()](https://iconify.design/docs/icon-components/react/load-icons.html "loadIcons() documentation") instead.

It is safe to call function multiple times with the same icon name, component will not load icon data from Iconify API twice. If you pass string icon name as parameter, multiple calls of the function will return the same Promise instance.

## Usage

The function has the following parameter:

- icon, string| [IconifyIconName](https://iconify.design/docs/icon-components/react/icon-name.html "IconifyIconName documentation"). Name of the icon to load.

The function returns Promise instance, which returns [FullIconifyIcon](https://iconify.design/docs/libraries/utils/full-iconify-icon.html "FullIconifyIcon documentation") data for icon on success.

## IconifyIconName type

[IconifyIconName](https://iconify.design/docs/icon-components/react/icon-name.html "IconifyIconName documentation") is a simple object with the following properties, all properties are mandatory:

- provider, string. [API provider](https://iconify.design/docs/api/providers.html). For public Iconify API value is an empty string "".
- prefix, string. Icon set prefix.
- name, string. Icon name.

## Examples

Using Promise syntax:

js
```
import { loadIcon } from '@iconify/react';

const iconName = 'mdi:home';
loadIcon(iconName)
    .then((data) => {
        console.log(
            \`Icon ${iconName} have been loaded and is ready to be renderered.\`
        );
        console.log(data);
    })
    .catch((err) => {
        console.log(\`Icon ${iconName} does not exist.\`);
    });
```

Async/await syntax:

js
```
import { loadIcon } from '@iconify/react';

/**
 * Usage example in async function
 */
async function test() {
    try {
        const data = await loadIcon('mdi:home');
        console.log('Loaded home icon!');
    } catch (err) {
        console.error('Failed to load home icon');
    }
 }
test();
```

If you want to load multiple icons, see [loadIcons()](https://iconify.design/docs/icon-components/react/load-icons.html "loadIcons() documentation").

[Page 62](https://iconify.design/docs/icon-components/react/custom-loaders.html "Current Page.")

## Custom icon loaders

This tutorial is part of [Iconify for React tutorial](https://iconify.design/docs/).

Functions setCustomIconLoader() and setCustomIconsLoader() are used to define custom icon loaders.

What is it for?

- To load icon data from custom sources.
- To modify icons, such as changing color or stroke width.

## Usage

Both functions have the same parameters, except for type of callback:

- callback, function. Callback that loads icons, can be synchronous or asynchronous function.
- prefix, string. Icon set prefix.
- provider, string. Icon set provider, optional.

Callback is a function that loads icon data.

Both synchronous and asynchronous (returns Promise instance) callbacks are supported.

Callbacks for both functions have similar parameters.

Parameters for setCustomIconLoader():

- name, string. Icon name.
- prefix, string. Icon set prefix.
- provider, string. Icon set provider.

Order of parameters is intentional: from most important to least important. If you have set loader for one prefix, you most likely only need name parameter.

The callback returns icon data as [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") or null on failure (or Promise of those types).

Callback for setCustomIconsLoader() is almost identical, except:

- First parameter is an array of icon names: string\[\].
- Callback returns an icon set as [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") or null on failure (or Promise of those types).

## Example

js
```
import { setCustomIconLoader, loadIcon } from "@iconify/react";

// Creates icon set "tabler-thin" that loads icons from Tabler Icons and makes them thinner
// Then you can use "tabler:angle" to render icon with default stroke, or "tabler-thin:angle" to render thinner icon
setCustomIconLoader(async (name) => {
  const data = await loadIcon(\`tabler:${name}\`);
  return data
    ? {
        ...data,
        body: data.body.replaceAll('stroke-width="2"', 'stroke-width="1"'),
      }
    : null;
 }, "tabler-thin");

// Fetches icon from custom server
// Icon data must be in IconifyIcon format
setCustomIconLoader(async (name) => {
  const response = await fetch(\`https://example.com/icons/${name}.json\`);
  if (!response.ok) {
    return null;
  }
  return await response.json();
 }, "custom-server");
```

Make sure loader is set before any icons are rendered, otherwise component might attempt to load icon from API and fail to render it.

[Page 63](https://iconify.design/docs/icon-components/react/build-icon.html "Current Page.")

## Iconify for React function: buildIcon

This tutorial is part of [Iconify for React functions tutorial](https://iconify.design/docs/#functions).

Function buildIcon() generates data used by icon component to render icon.

You can use this function to generate <svg> code.

## Usage

The function has the following parameters:

- icon, [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation"). Icon data.
- customisations. Optional customizations object.

The function returns object containing icon data, null if icon is not available.

You need icon data before you can use this function. See [getIcon()](https://iconify.design/docs/icon-components/react/get-icon.html "getIcon() documentation"), [iconLoaded()](https://iconify.design/docs/icon-components/react/icon-exists.html "iconLoaded() documentation") and [loadIcon()](https://iconify.design/docs/icon-components/react/load-icon.html "loadIcon() documentation") functions.

## Result

Result object has the following properties:

- attributes, object. List of attributes for <svg> element.
- body, string. Icon contents.

The list of attributes does not include standard attributes: xmlns, xmlns:link. It also does not include attributes that are added by icon component: aria-hidden, focusable, role, class, style. It is up to you to decide what attributes you want to add.

## Customizations

Second parameter is optional icon customizations. Available customizations:

IconifyIconCustomisations type is an object with the following optional properties, split into several categories.

Vertical alignment:

- inline, boolean. If enabled, adds vertical-align: -0.125em to style, rendering icon below baseline. The default value is false.

Icon dimensions:

- width, string|number|null. Icon width. The default value is null.
- height, string|number|null. Icon height. The default value is null.

There are several keywords that can be used for width and height:

- "auto" sets dimension to original icon's dimensions found in viewBox.
- "unset" and "none" remove dimensions from SVG.

If neither of dimensions is set, height defaults to "1em".

It is enough to set one dimension, such as height. Another dimension will be calculated using icon's width/height ratio. In the case of keywords, another dimension will be set to the same keyword.

Transformations:

- hFlip, boolean. Flip icon horizontally. The default value is false.
- vFlip, boolean. Flip icon vertically. The default value is false.
- rotate, number. Rotation in 90 degrees increments. The default value is 0.

For more details about dimensions see [icon dimensions documentation](https://iconify.design/docs/dimensions.html).

For more details about transformations see [icon transformations documentation](https://iconify.design/docs/transform.html).

## Example

js
```
import { buildIcon } from '@iconify/react';
import biStopwatch from '@iconify-icons/bi/stopwatch';

buildIcon(biStopwatch, {
    hFlip: true,
    height: '24',
 });
```

json
```
{
    "attributes": {
        "width": "24",
        "height": "24",
        "viewBox": "0 0 16 16"
    },
    "body": "<g transform=\"translate(16 0) scale(-1 1)\"><g fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M8 15A6 6 0 1 0 8 3a6 6 0 0 0 0 12zm0 1A7 7 0 1 0 8 2a7 7 0 0 0 0 14z\"/><path fill-rule=\"evenodd\" d=\"M8 4.5a.5.5 0 0 1 .5.5v4a.5.5 0 0 1-.5.5H4.5a.5.5 0 0 1 0-1h3V5a.5.5 0 0 1 .5-.5zM5.5.5A.5.5 0 0 1 6 0h4a.5.5 0 0 1 0 1H6a.5.5 0 0 1-.5-.5z\"/><path d=\"M7 1h2v2H7V1z\"/></g></g>"
}
```

[Page 64](https://iconify.design/docs/icon-components/react/replace-ids.html "Current Page.")

## Iconify for React function: replaceIDs

This tutorial is part of [Iconify for React functions tutorial](https://iconify.design/docs/#functions).

The function replaceIDs() finds IDs in SVG and replaces them with unique random IDs.

This function is meant to be used when you generate <svg> element yourself using data provided by [getIcon()](https://iconify.design/docs/icon-components/react/get-icon.html "getIcon() documentation").

## Usage

The function has the following parameters:

- data, string. Icon content.
- prefix, string|function. Optional prefix for generated IDs. It can be a string or a callback that returns string.

The function returns string containing icon data with IDs replaced.

## Example

This is a rather useless example. In real code, this function is used when generating SVG code samples in Icon Finder, which is not as simple as this example.

js
```
import { replaceIDs, getIcon } from '@iconify/react';

// Get icon data
const data = getIcon('carbon:deploy');

// Get content
const body = replaceIDs(data.body);

console.log('Icon content:', body);
```

[Page 65](https://iconify.design/docs/icon-components/vue/ "Current Page.")

## Iconify for Vue

Iconify offers native icon components for several popular UI frameworks.

Iconify for Vue is one of such components.

Yet another icon component? What are the advantages over other icon components?

- One syntax for over 275,000 icons from 200+ icon sets.
- Renders SVG. Many components simply render icon fonts, which look ugly. Iconify uses only pixel perfect SVG.
- Loads icons on demand. No need to bundle icons, component will automatically load icon data for icons that you use from Iconify API.

Please be aware that this component is not designed for server side rendering. If you are using SSR, consider switching to [Iconify Icon web component](https://iconify.design/docs/iconify-icon/).

## Installation

If you are using NPM:

```
npm install --save-dev @iconify/vue
```

If you are using Yarn:

```
yarn add --dev @iconify/vue
```

## Usage

Install @iconify/vue and import component from it (component is exported as named export):

js
```
import { Icon } from "@iconify/vue";
```

Then in template use Icon component with icon name as icon parameter:

jsx
```
<Icon icon="mdi-light:home" />
```

### Nuxt.js

Component is compatible with Nuxt.js.

The component does not retrieve icon data until it is mounted. For server side rendering it means generated HTML will not include SVGs, icons will be rendered only on the client side after hydration is complete.

If you do want to render SVGs on the server side, provide [icon data](https://iconify.design/docs/types/iconify-icon.html) as a parameter instead of icon name or [use a different icon component](https://iconify.design/docs/usage/).

#### SSR attribute

In version 4.1.2 new boolean attribute was added: ssr.

If enabled, it will render icon immediately:

vue
```
<Icon icon="mdi:home" :ssr="true" />
```

It is safe to use without SSR because there is no hydration to break.

If you are using SSR, such as Nuxt, make sure icon data is available on both server and client sides.

## Properties

You can pass any custom properties to component.

Required properties:

- icon, [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") |string icon name or icon data.

Optional properties:

- inline, boolean changes vertical alignment.
- width, string|number icon width.
- height, string|number icon height.
- horizontalFlip, boolean flips icon horizontally.
- verticalFlip, boolean flips icon vertically.
- flip, string alternative to horizontalFlip and verticalFlip.
- rotate, number|string rotates icon.
- color, string changes icon color.
- onLoad, function is a callback that is called when icon data has been loaded. See below.

See below for more information on each optional property.

In addition to the properties mentioned above, the icon component accepts any other properties and events. All other properties and events will be passed to generated SVG element, so you can do stuff like setting the inline style, add title, add onClick event and so on.

## Icon

Icon name is a string, which has 3 parts:

| @api-provider | : | icon-prefix | : | icon-name |
| --- | --- | --- | --- | --- |
| provider |  | prefix |  | name |

- provider points to API source. Starts with "@", can be empty (empty value is used for public Iconify API).
- prefix is name of icon set.
- name is name of icon.

Examples of valid icon names:

- flat-color-icons:voice-presentation - icon is "voice-presentation" from [Flat Color Icons](https://icon-sets.iconify.design/flat-color-icons/) icon set, from public Iconify API.
- mdi-light:home - icon is "home" from [Material Design Light](https://icon-sets.iconify.design/mdi-light/) icon set, from public Iconify API.

Exceptions:

- If the API provider is empty, it can be skipped (like in examples above).
- If prefix does not contain "-", prefix and icon name can be separated with hyphen. This is to support people migrating from icon fonts. For example, fa:arrow-left and fa-arrow-left are identical because "fa" does not contain hyphen.

There are over 275,000 icons available from 200+ icon sets. [Browse icons sets](https://icon-sets.iconify.design/) to see all available icons.

You can also add custom API providers for more icon choices. See [API providers documentation](https://iconify.design/docs/api/providers.html).

## Color

You can only change the color of monotone icons. Some icons, such as emoji, have a hardcoded palette that cannot be changed.

To add color to a monotone icon, simply change text color.

vue
```
<Icon icon="mdi:home" style="color: red" />
```

For various ways to set color, see [how to change icon color in Iconify for Vue](https://iconify.design/docs/color.html).

## Dimensions

By default, icon height is set to "1em", icon width is changed dynamically based on the icon's width/height ratio. This makes it easy to change icon size by changing font-size in the stylesheet, just like icon fonts.

There are several ways to change icon dimensions:

- Setting font-size in style (or fontSize if you are using inline style).
- Setting width and/or height property.

Values for width and height can be numbers or strings.

If you set only one dimension, another dimension will be calculated using the icon's width/height ratio. For example, if the icon size is 16 x 24, you set the height to 48, the width will be set to 32. Calculations work not only with numbers, but also with string values.

vue
```
<Icon icon="mdi:home" style="font-size: 24px;" />
```

For various ways to change icon dimensions, see [how to change icon dimensions in Iconify for Vue](https://iconify.design/docs/dimensions.html).

## Transformations

An icon can be rotated and flipped horizontally and/or vertically. All transformations are done relative to the center of the icon.

These are not CSS transformations, transformations are applied inside SVG.

For more details see [how to transform icon in Iconify for Vue](https://iconify.design/docs/transform.html).

## Load event

load event is fired when icon data has been loaded.

When load is fired:

- If value of icon property is an object, load is not fired.
- If value of icon property is a string and icon data is available, load is fired only on first render.
- If value of icon property is a string and icon data is not available, load is fired on first re-render after icon data is retrieved from API.

What is the purpose of load event? To let you know when Icon component renders an icon and when it does not render anything. This allows you to do things like adding class name for the parent element, such as "container--with-icon" that modify layout if icon is being displayed.

## Functions

Component exports various functions, which developers can use to control icons.

Functions are split in several groups (click function name to see more details and examples):

### Check available icons

There are several functions in this section:

- iconLoaded(name). Checks if icon data is available, returns boolean.
- [listIcons()](https://iconify.design/docs/icon-components/vue/list-icons.html "listIcons() documentation"). Lists available icons, returns string\[\].
- [getIcon(name)](https://iconify.design/docs/icon-components/vue/get-icon.html "getIcon() documentation"). Returns icon data, returns [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") object.

### Adding icons

Functions for adding icons to the component:

- [addIcon()](https://iconify.design/docs/icon-components/vue/add-icon.html "addIcon() documentation"). Adds one icon.
- [addCollection()](https://iconify.design/docs/icon-components/vue/add-collection.html "addCollection() documentation"). Adds an icon set.

Note: icons added to the component with these functions are not stored in the icon data cache. Component caches only icons retrieved from API.

### Custom loaders

Custom loaders can be used to load icons from custom sources:

- [setCustomIconLoader()](https://iconify.design/docs/icon-components/vue/custom-loaders.html "setCustomIconLoader() documentation"). Loads one icon.
- [setCustomIconsLoader()](https://iconify.design/docs/icon-components/vue/custom-loaders.html "setCustomIconsLoader() documentation"). Loads icons in bulk.

Loaders are set per icon set prefix. Make sure to configure loader before displaying any icons.

It can also be used to customise icons: in custom loader you can load icon from API using [loadIcon](https://iconify.design/docs/icon-components/vue/load-icon.html "loadIcon() documentation"), change its content (such as colors or stroke width) and return modified icon.

### Helper functions

- [replaceIDs(html)](https://iconify.design/docs/icon-components/vue/replace-ids.html "replaceIDs() documentation"). Randomises IDs in generated string. This should be used when rendering icon based on data returned by [getIcon()](https://iconify.design/docs/icon-components/vue/get-icon.html "getIcon() documentation") to make sure elements inside each icon have unique IDs.
- calculateSize(). Calculates icon size. It is used to calculate width if only height is set and vice versa.
- [buildIcon(icon, customisations?)](https://iconify.design/docs/icon-components/vue/build-icon.html "buildIcon() documentation"). Generates data used by icon component. This can be used if you prefer to generate <svg> yourself. Data includes attributes for <svg> and inner HTML.

### API functions

- [loadIcons(icons, callback?)](https://iconify.design/docs/icon-components/vue/load-icons.html "loadIcons() documentation"). Loads icons from API, calls optional callback when either all or part of icons have been loaded.
- [loadIcon(icon)](https://iconify.design/docs/icon-components/vue/load-icon.html "loadIcon() documentation"). Loads one icon from API, returns Promise.
- [addAPIProvider()](https://iconify.design/docs/icon-components/vue/add-api-provider.html "addAPIProvider() documentation"). Adds custom API provider. See [API providers documentation](https://iconify.design/docs/api/providers.html).

### Internal API functions

There are several internal API functions that are exposed. They are intended to be used by developers that need more control over the component. For example, it is used in Sketch and Figma plug-ins. Use them carefully.

All internal API functions are exposed as properties of \_api object:

- getAPI(). Returns internal API module.
- getAPIConfig(). Returns API configuration.
- setAPIModule(provider). Sets API module for provider. This is an experimental function intended for custom API providers that use custom module for retrieving data from API.
- [setFetch(fetch)](https://iconify.design/docs/icon-components/vue/set-fetch.html "setFetch() documentation"). Set custom Fetch API.
- getFetch(). Returns used fetch() function, null if Fetch API is not available.

[Page 66](https://iconify.design/docs/icon-components/vue/color.html "Current Page.")

## Icon color

This tutorial is part of [Iconify for Vue tutorial](https://iconify.design/docs/).

You can only change color of monotone icons. Some icons, such as emoji, have a hardcoded palette that cannot be changed.

To change color of a monotone icon, simply change text color or use color attribute or add style with color.

All icons inside this div are light blue, including a bell icon and attachment icon

This text and icon are orange:

Red home icons (shows different ways to change color):

Icon with palette:

vue
```
<template>
    <div>
        <div class="light-blue-block">
            All icons inside this div are light blue, including a bell icon
            <Icon icon="bi:bell-fill" :inline="true" />
            and stopwatch icon
            <Icon icon="bi:stopwatch" :inline="true" />
        </div>
        <div class="orange-block">
            This text and icon are orange:
            <Icon icon="bi:bell-fill" :inline="true" />
        </div>
        <div>
            Red home icons (shows different ways to change color):
            <Icon class="red-icon" icon="bx:bx-home" :inline="true" />
            <Icon :style="{ color: 'red' }" icon="bx:bx-home" :inline="true" />
            <Icon color="red" icon="bx:bx-home" :inline="true" />
        </div>
        <div>Icon with palette: <Icon icon="noto:paintbrush" :inline="true" /></div>
    </div>
</template>

<script>
import { Icon } from '@iconify/vue';

export default {
    components: {
        Icon,
    },
 };
</script>
```

css
```
// Change text color for ".orange-block" to #e70
.orange-block {
    color: #e70;
 }
// Change all icons inside ".light-blue-block" to #08f
.light-blue-block svg {
    color: #08f;
 }
// Change text color for ".red-icon" to #e00
.red-icon {
    color: #e00;
 }
```

Color only works for icons that do not have a palette. Color in icons that do have a palette, like paintbrush icon in an example above, cannot be changed.

You can change color the same way as you would for text.

## RGBA and HSLA colors

Avoid using rgba and hsla colors. Some icons have multiple layers on top of each other. Using semi-transparent color will result in both layers being visible.

Instead, use a solid color and add transparency with opacity. This will result in browser rendering shapes with a solid color, then applying opacity to an entire icon.

## fill and stroke

Avoid using fill and stroke in stylesheet, unless you are using it for a specific icon.

Not all icons are the same. Some use fill for shapes, some use stroke. If you set fill, you might end up with filled shapes that should not be filled.

[Page 67](https://iconify.design/docs/icon-components/vue/dimensions.html "Current Page.")

## Icon dimensions

This tutorial is part of [Iconify for Vue tutorial](https://iconify.design/docs/).

By default, icon height is set to "1em", icon width is changed dynamically based on the icon's width/height ratio.

This makes it easy to change icon size by changing font-size in the stylesheet or in style, just like icon fonts:

vue
```
<template>
    <div>
        <Icon icon="cil:locomotive" />
        <Icon icon="cil:paper-plane" :style="{ fontSize: '36px' }" />
        <Icon icon="cil:truck" class="big-icon" />
    </div>
</template>

<script>
import { Icon } from '@iconify/vue';

export default {
    components: {
        Icon,
    },
 };
</script>
```

css
```
svg {
    font-size: 24px;
    line-height: 1em;
 }

.big-icon {
    font-size: 72px;
 }
```

If you want to control icon size with width and height in CSS, see [how to remove icon dimensions](#unset) section below.

## Units

Size can be a string with or without units or a number. If value is a number or string without units, it will be treated by browser as pixels.

Examples of 24px icon:

vue
```
<Icon icon="mdi:home" :height="24" />
<Icon icon="mdi:home" height="24" />
<Icon icon="mdi:home" height="24px" />
```

## Keyword "auto"

Special keyword "auto" sets size to value from viewBox. This makes it easy to render an icon as it was originally designed.

It is enough to set one dimension to "auto", another dimension will be set to "auto" too, unless you specify otherwise.

For example, if viewBox="0 0 24 24" and height is set to "auto", height will be set to 24.

vue
```
<Icon icon="mdi:home" height="auto" />
```

## Keywords "none" and "unset"

Special keywords "none" and "unset" remove dimensions from generated SVG.

This results in icon without dimensions. You should set icon's width and height in CSS.

It is enough to set one dimension to "unset", another dimension will be set to "unset" too, unless you specify otherwise.

vue
```
<template>
    <Icon
        icon="mdi:home"
        height="none"
        :style="{ width: '48px', height: '48px' }"
    />
</template>

<script>
import { Icon } from '@iconify/vue';

export default {
    components: {
        Icon,
    },
 };
</script>
```

This gives you full control over each icon's dimension separately in CSS instead of controlling them both with font-size.

Sometimes you might also need to add display: block; to CSS for icon to behave correctly.

## Setting only width or height

In an example above, all icons only use height.

What happens when only one dimension is set?

- If width is not set, but height is set, width is calculated using icon's width/height ratio.
- If height is not set, but width is set, height is calculated using icon's height/width ratio.
- If no dimensions are set in attributes, height is set to "1em" and width is calculated using icon's width/height ratio. Then icon behaves like a text and can be resized using font-size in stylesheet.

### Example

Many icons are square. For such icons if you set one dimension, another dimension will have the same value.

However, there are many icons that are not square. For example, icons imported from icon fonts and Font Awesome.

This is data for fa-regular:address-book:

json
```
{
    "body": "<path d=\"M436 160c6.6 0 12-5.4 12-12v-40c0-6.6-5.4-12-12-12h-20V48c0-26.5-21.5-48-48-48H48C21.5 0 0 21.5 0 48v416c0 26.5 21.5 48 48 48h320c26.5 0 48-21.5 48-48v-48h20c6.6 0 12-5.4 12-12v-40c0-6.6-5.4-12-12-12h-20v-64h20c6.6 0 12-5.4 12-12v-40c0-6.6-5.4-12-12-12h-20v-64h20zm-68 304H48V48h320v416zM208 256c35.3 0 64-28.7 64-64s-28.7-64-64-64s-64 28.7-64 64s28.7 64 64 64zm-89.6 128h179.2c12.4 0 22.4-8.6 22.4-19.2v-19.2c0-31.8-30.1-57.6-67.2-57.6c-10.8 0-18.7 8-44.8 8c-26.9 0-33.4-8-44.8-8c-37.1 0-67.2 25.8-67.2 57.6v19.2c0 10.6 10 19.2 22.4 19.2z\" fill=\"currentColor\"/>",
    "width": 448,
    "height": 512
}
```

Icon size is 448 x 512

If you do not set any dimensions, height will be set to "1em" and width will be set to 448 / 512 = "0.875em". However, values that have more than 2 numbers after decimal point are rounded up, so actual width will be "0.88em":

html
```
<svg
    xmlns="http://www.w3.org/2000/svg"
    xmlns:xlink="http://www.w3.org/1999/xlink"
    aria-hidden="true"
    focusable="false"
    role="img"
    class="iconify iconify--fa-regular"
    width="0.88em"
    height="1em"
    preserveAspectRatio="xMidYMid meet"
    viewBox="0 0 448 512"
 >
    <path d="..." fill="currentColor"></path>
</svg>
```

If you set width to 56, but do not set height, height will be set to 56 \* 512 / 448 = 64:

html
```
<svg width="56" height="64" ...>...</svg>
```

If you set both values: width to 56 and height to 128, values will be as you set them (also see "Alignment" section below):

html
```
<svg width="56" height="128" ...>...</svg>
```

## Alignment

What if you set both width and height and its ratio doesn't match icon's width/height ratio?

For example, what will happen if icon is 24x24, but you set one dimension to 40 and other dimension to 24?

Using box-shadow to show icon dimensions

vue
```
<Icon icon="jam:info" width="40" height="24" />
<Icon icon="jam:info" width="24" height="40" />
```

SVG do not behave like other images. When you set a wrong width/height ratio for other image formats, images get stretched. When you do that for SVG, bounding box is changed and the image is aligned inside that bounding box.

In an example above, one icon is too wide and another icon is too tall. The browser will move icons to center instead of stretching icon.

[Page 68](https://iconify.design/docs/icon-components/vue/transform.html "Current Page.")

## Transformations

This tutorial is part of [Iconify for Vue tutorial](https://iconify.design/docs/).

An icon can be rotated and flipped horizontally and/or vertically. All transformations are done relative to the center of the icon.

There are two types of transformations:

- Horizontal and vertical flip.
- Rotation by 90, 180 and 270 degrees.

## CSS vs Iconify transformations

These are not CSS transformations, transformations are applied inside SVG.

What's the difference from CSS transformations?

- If you rotate an icon by 90 degrees in CSS, icon's bounding box remains the same. 16x24 icon still takes space for 16x24, but might overlap elements around it.
- If you rotate an icon by 90 degrees in SVG Framework, icon's dimensions swap places. 16x24 icon becomes 24x16 icon, and it does not affect elements around it.

Example:

Test icon with text around it

Test icon with text around it

Using box-shadow to show icon dimensions

vue
```
<template>
    <div>
        <p>
            Test icon
            <Icon icon="fa-regular:handshake" :inline="true" rotate="90deg" /> with
            text around it
        </p>
        <p>
            Test icon
            <Icon
                icon="fa-regular:handshake"
                :inline="true"
                :style="{ transform: 'rotate(90deg)' }"
            />
            with text around it
        </p>
    </div>
</template>

<script>
import { Icon } from '@iconify/vue';

export default {
    components: {
        Icon,
    },
 };
</script>
```

In example above, first icon is rotated using rotate attribute, second icon is rotated using CSS. The first icon kept its 1em height, second icon became taller than it should be.

Sometimes you do want behaviour that CSS transformations provide. Then you can still use CSS transformations by adding it to style.

## Flip

You can flip an icon horizontally and/or vertically.

One way to do that is to add flip attribute with comma-separated values. Possible values:

- "horizontal": flip icon horizontally.
- "vertical": flip icon vertically.

You can also do that by setting horizontalFlip and / or verticalFlip attributes to true.

Example:

No flip:

Horizontal flip:

Vertical flip:

Both (or 180° rotation):

vue
```
<template>
    <div>
        <p>No flip: <Icon icon="bi:check2-circle" :inline="true" /></p>
        <p>
            Horizontal flip:
            <Icon icon="bi:check2-circle" :inline="true" flip="horizontal" />
        </p>
        <p>
            Vertical flip:
            <Icon icon="bi:check2-circle" :inline="true" flip="vertical" />
        </p>
        <p>
            Both (or 180° rotation):
            <Icon icon="bi:check2-circle" :inline="true" flip="horizontal,vertical" />
        </p>
    </div>
</template>

<script>
import { Icon } from '@iconify/vue';

export default {
    components: {
        Icon,
    },
 };
</script>
```

vue
```
<template>
    <div>
        <p>
            No flip:
            <Icon icon="bi:check2-circle" :inline="true" />
        </p>
        <p>
            Horizontal flip:
            <Icon icon="bi:check2-circle" :inline="true" :horizontalFlip="true" />
        </p>
        <p>
            Vertical flip:
            <Icon icon="bi:check2-circle" :inline="true" :verticalFlip="true" />
        </p>
        <p>
            Both (or 180° rotation):
            <Icon
                icon="bi:check2-circle"
                :inline="true"
                :horizontalFlip="true"
                :verticalFlip="true"
            />
        </p>
    </div>
</template>

<script>
import { Icon } from '@iconify/vue';

export default {
    components: {
        Icon,
    },
 };
</script>
```

## Rotation

You can rotate icon by 90, 180 and 270 degrees.

To do that, add rotate attribute. Possible values:

- "90deg", "1": rotate by 90 degrees.
- "180deg", "2": rotate by 180 degrees.
- "270deg", "3": rotate by 270 degrees.

Example:

No rotation:

90° rotation:

180° rotation:

270° rotation:

vue
```
<template>
    <div>
        <p>No rotation: <Icon icon="bi:check2-circle" :inline="true" /></p>
        <p>
            90° rotation:
            <Icon icon="bi:check2-circle" :inline="true" rotate="90deg" />
        </p>
        <p>
            180° rotation:
            <Icon icon="bi:check2-circle" :inline="true" rotate="180deg" />
        </p>
        <p>
            270° rotation: <Icon icon="bi:check2-circle" :inline="true" :rotate="3" />
        </p>
    </div>
</template>

<script>
import { Icon } from '@iconify/vue';

export default {
    components: {
        Icon,
    },
 };
</script>
```

## Rotate and flip

You can use both rotation and flip on an icon. The icon is flipped first, then rotated.

## Property names

In other components, properties for flip are hFlip and vFlip. Vue has special treatment for properties that start with v-, so vFlip (same applies to vAlign attribute) attribute is not available without using tricky syntax.

Because of that, Vue component uses longer property names: verticalFlip instead of vFlip and horizontalFlip instead of hFlip for consistency.

[Page 69](https://iconify.design/docs/icon-components/vue/inline.html "Current Page.")

## Vertical alignment

This tutorial is part of [Iconify for Vue tutorial](https://iconify.design/docs/).

When an icon is rendered in text, by default it is aligned at baseline, as any other images.

Emojis and icon fonts are rendered slightly below baseline, like any text.

If you want to render icon in text, you probably want to add vertical-align to each icon to render it slightly below baseline, to make it fit in text, similar to emojis and icon fonts:

SVG in text:

SVG in text with vertical-align: -0.125em:

## Inline attribute

Instead of adding vertical-align to each icon, the icon component has a property inline. Adding inline property to the icon component is identical to setting style="vertical-align: -0.125em":

Inline attribute demo:

vue
```
<template>
    <div>
        <p>
            Inline attribute demo:
            <Icon icon="line-md:image-twotone" :inline="true" />
            <Icon icon="mdi:account-box-outline" :inline="true" />
        </p>
    </div>
</template>

<script>
import { Icon } from '@iconify/vue';

export default {
    components: {
        Icon,
    },
 };
</script>
```

Important: this attribute does not change display mode for icon. It only adds vertical-align style.

[Page 70](https://iconify.design/docs/icon-components/vue/icon-exists.html "Current Page.")

## Iconify for Vue function: iconLoaded

This tutorial is part of [Iconify for Vue functions tutorial](https://iconify.design/docs/#functions).

The function iconLoaded() checks if icon data is available for rendering.

## Usage

The function has the following parameter:

- name, string. Icon name.

The function returns boolean value: true if icon data is available, false if icon data is not available.

## Example

js
```
import { iconLoaded } from "@iconify/vue";

const icon = "bi:arrow-left";
console.log(\`Is ${icon} available?\`, iconLoaded(icon) ? "yes" : "no");
```

This example dynamically loads icon data and renders <slot /> while icon is being loaded. It is redundant because Vue component already does that, but it is used to show how to use iconLoaded() and [loadIcons()](https://iconify.design/docs/icon-components/vue/load-icons.html "loadIcons() documentation"), though instead of iconLoaded() it is better done with [getIcon()](https://iconify.design/docs/icon-components/vue/get-icon.html "getIcon() documentation").

js
```
import { Icon, iconLoaded, loadIcons } from "@iconify/vue";
import { h, defineComponent, ref } from "vue";

export default defineComponent({
  components: {
    Icon,
  },
  props: ["icon"],
  setup() {
    // Variable to store function to cancel loading
    const loader = ref(null);

    // Icon status
    const loaded = ref(null);

    // Function to check if icon data is available
    const check = (icon: string) => {
      const isLoaded = (loaded.value = iconLoaded(icon));

      // Cancel old loder
      if (loader.value) {
        loader.value();
        loader.value = null;
      }

      if (!isLoaded) {
        loader.value = loadIcons([icon], () => {
          loaded.value = iconLoaded(icon);
        });
      }
    };
    return {
      loader,
      loaded,
      check,
    };
  },
  watch: {
    icon: {
      immediate: true,
      handler(value) {
        // Check new value
        this.check(value);
      },
    },
  },
  // Stop loading
  unmounted() {
    const loader = this.loader.value;
    if (loader) {
      loader();
    }
  },
  render() {
    const loaded = this.loaded;
    if (loaded) {
      return h(Icon, {
        icon: this.icon,
      });
    }
    return this.$slots.default ? this.$slots.default() : null;
  },
 });
```

## Legacy

Note: in old versions of component, this function was named iconExists(). It was the same function, but with bad name.

Because of bad name, some developers assumed it checks if icon exists on Iconify API. It does not. All it does is checks component's storage.

To avoid confusion, function was renamed.

[Page 71](https://iconify.design/docs/icon-components/vue/list-icons.html "Current Page.")

## Iconify for Vue function: listIcons

This tutorial is part of [Iconify for Vue functions tutorial](https://iconify.design/docs/#functions).

The function listIcons() lists loaded icons.

## Usage

The function has the following optional parameters:

- provider, string. Lists only icons from one API provider.
- prefix, string. Lists only icons with specific prefix. If prefix is set, provider must be set too (for Iconify public API provider value is empty string "").

The function returns an array of icon names.

## Examples

js
```
import { listIcons } from '@iconify/vue';

// List all icons
console.log(listIcons());
```

Another example:

js
```
import { listIcons } from '@iconify/vue';

// List all loaded Material Design Icons
console.log(listIcons('', 'mdi'));
// ["mdi:alert", "mdi:home", "mdi:account-box-outline", "mdi:eyedropper", "mdi:account-off", "mdi:account", "mdi:account-box", "mdi:account-cash"]
```

[Page 72](https://iconify.design/docs/icon-components/vue/get-icon.html "Current Page.")

## Iconify for Vue function: getIcon

This tutorial is part of [Iconify for Vue functions tutorial](https://iconify.design/docs/#functions).

The function getIcon() retrieves icon data.

## Usage

The function has the following parameter:

- name, string. Icon name.

The function returns icon data in [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") format, null if icon is not available.

## Examples

js
```
import { getIcon } from '@iconify/vue';

const data = getIcon('bi:check2-circle');
```

json
```
{
    "body": "<g fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M15.354 2.646a.5.5 0 0 1 0 .708l-7 7a.5.5 0 0 1-.708 0l-3-3a.5.5 0 1 1 .708-.708L8 9.293l6.646-6.647a.5.5 0 0 1 .708 0z\"/><path fill-rule=\"evenodd\" d=\"M8 2.5A5.5 5.5 0 1 0 13.5 8a.5.5 0 0 1 1 0a6.5 6.5 0 1 1-3.25-5.63a.5.5 0 1 1-.5.865A5.472 5.472 0 0 0 8 2.5z\"/></g>",
    "left": 0,
    "top": 0,
    "width": 16,
    "height": 16,
    "rotate": 0,
    "vFlip": false,
    "hFlip": false
}
```

Another example:

js
```
import { getIcon } from '@iconify/vue';

const data = getIcon('cil:paper-plane');
```

json
```
{
    "body": "<path fill=\"currentColor\" d=\"M474.444 19.857a20.336 20.336 0 0 0-21.592-2.781L33.737 213.8v38.066l176.037 70.414L322.69 496h38.074l120.3-455.4a20.342 20.342 0 0 0-6.62-20.743zM337.257 459.693L240.2 310.37l149.353-163.582l-23.631-21.576L215.4 290.069L70.257 232.012L443.7 56.72z\"/>",
    "left": 0,
    "top": 0,
    "width": 512,
    "height": 512,
    "rotate": 0,
    "vFlip": false,
    "hFlip": false
}
```

Example with bad icon name, returns null:

js
```
import { getIcon } from '@iconify/vue';

// null
const data = getIcon('no-such-icon');
```

[Page 73](https://iconify.design/docs/icon-components/vue/add-icon.html "Current Page.")

## Iconify for Vue function: addIcon

This tutorial is part of [Iconify for Vue functions tutorial](https://iconify.design/docs/#functions).

Function addIcon() adds one icon to the component's icon data storage.

## Usage

The function has the following parameters:

- name, string. Icon name.
- data, [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation"). Icon data.

The function returns boolean value: true on success, false if something is wrong with data.

## Examples

js
```
import { addIcon } from '@iconify/vue';

addIcon('mdi:account-box', {
    body: '<path d="M6 17c0-2 4-3.1 6-3.1s6 1.1 6 3.1v1H6m9-9a3 3 0 0 1-3 3a3 3 0 0 1-3-3a3 3 0 0 1 3-3a3 3 0 0 1 3 3M3 5v14a2 2 0 0 0 2 2h14a2 2 0 0 0 2-2V5a2 2 0 0 0-2-2H5a2 2 0 0 0-2 2z" fill="currentColor"/>',
    width: 24,
    height: 24,
 });
```

Note: icons added by this function are not cached in localStorage and sessionStorage.

## API provider

API provider parameter can be used to load custom icons asynchronously without triggering API queries.

Each API provider has its own API endpoint, so if you are using custom API provider that component doesn't have configuration for (currently by default component has no API providers configured), the component will not attempt to load missing icons from an unknown API provider.

Example:

js
```
import { addIcon } from '@iconify/vue';

addIcon('@custom:md:test', {
    body: '<path d="M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5z" fill="currentColor"/>',
    width: 24,
    height: 24,
 });
```

Code above adds the following icon:

- provider is "custom".
- prefix is "md".
- name is "test".

In component template this icon can be used like this:

jsx
```
<Icon icon="@custom:md:test" />
```

Syntax is similar to default icon syntax, but with API provider "@custom" in icon name. See [API providers documentation](https://iconify.design/docs/api/providers.html) for details.

## One icon

This function adds one icon in [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") format.

If you want to add several icons, or you have [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") data, use function [addCollection()](https://iconify.design/docs/icon-components/vue/add-collection.html "addCollection() documentation") instead.

[Page 74](https://iconify.design/docs/icon-components/vue/add-collection.html "Current Page.")

## Iconify for Vue function: addCollection

This tutorial is part of [Iconify for Vue functions tutorial](https://iconify.design/docs/#functions).

Function addCollection() adds an icon set to component's icon storage.

## Usage

The function has the following parameters:

- data, [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation"). Icon set data.
- provider, string. Optional API provider ID.

The function returns boolean value: true on success, false if something is wrong with data.

If an icon set has provider property and second parameter to addCollection() is passed, provider from second parameter overrides provider from an icon set.

## Examples

js
```
import { addCollection } from '@iconify/vue';

addCollection({
    prefix: 'custom',
    icons: {
        icon1: {
            body: '<path d="M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5z" fill="currentColor"/>',
        },
    },
    width: 24,
    height: 24,
 });
```

js
```
import { addCollection } from '@iconify/vue';

addCollection({
    prefix: 'mdi',
    icons: {
        'account-box': {
            body: '<path d="M6 17c0-2 4-3.1 6-3.1s6 1.1 6 3.1v1H6m9-9a3 3 0 0 1-3 3a3 3 0 0 1-3-3a3 3 0 0 1 3-3a3 3 0 0 1 3 3M3 5v14a2 2 0 0 0 2 2h14a2 2 0 0 0 2-2V5a2 2 0 0 0-2-2H5a2 2 0 0 0-2 2z" fill="currentColor"/>',
        },
        'account-cash': {
            body: '<path d="M11 8c0 2.21-1.79 4-4 4s-4-1.79-4-4s1.79-4 4-4s4 1.79 4 4m0 6.72V20H0v-2c0-2.21 3.13-4 7-4c1.5 0 2.87.27 4 .72M24 20H13V3h11v17m-8-8.5a2.5 2.5 0 0 1 5 0a2.5 2.5 0 0 1-5 0M22 7a2 2 0 0 1-2-2h-3c0 1.11-.89 2-2 2v9a2 2 0 0 1 2 2h3c0-1.1.9-2 2-2V7z" fill="currentColor"/>',
        },
        'account': {
            body: '<path d="M12 4a4 4 0 0 1 4 4a4 4 0 0 1-4 4a4 4 0 0 1-4-4a4 4 0 0 1 4-4m0 10c4.42 0 8 1.79 8 4v2H4v-2c0-2.21 3.58-4 8-4z" fill="currentColor"/>',
        },
        'home': {
            body: '<path d="M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5z" fill="currentColor"/>',
        },
    },
    width: 24,
    height: 24,
 });
```

Note: icons added by this function are not cached in localStorage and sessionStorage.

## API provider

API provider parameter can be used to specify that icon set belongs to the specific API provider.

It can also be used to load custom icons asynchronously without triggering API queries. Each API provider has its own API endpoint, so if you are using custom API provider that component doesn't have configuration for (currently by default component has no API providers configured), the component will not attempt to load missing icons from an unknown API provider.

Example:

js
```
import { addCollection } from '@iconify/vue';

addCollection(
    // Icon set: prefix and icons
    {
        prefix: 'md',
        icons: {
            test: {
                body: '<path d="M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5z" fill="currentColor"/>',
            },
        },
        width: 24,
        height: 24,
    },
    // API provider
    'custom'
 );
```

Code above adds only one icon:

- provider is "custom".
- prefix is "md".
- name is "test".

In component template this icon can be used like this:

jsx
```
<Icon icon="@custom:md:test" />
```

Syntax is similar to default icon syntax, but with API provider "@custom" in icon name. See [API providers documentation](https://iconify.design/docs/api/providers.html) for details.

## One icon

This function adds an entire icon set in [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") format.

If you want to add only once icon, and you have [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") data, use function [addIcon()](https://iconify.design/docs/icon-components/vue/add-icon.html "addIcon() documentation") instead.

[Page 75](https://iconify.design/docs/icon-components/vue/load-icons.html "Current Page.")

## Iconify for Vue function: loadIcons

This tutorial is part of [Iconify for Vue functions tutorial](https://iconify.design/docs/#functions).

The function loadIcons() retrieves icons from Iconify API.

When to use this function:

- To preload multiple icons that you will use later. This will make sure icon data is available when needed and it will load faster.
- If you need to get icon data as soon as it is available. For example, when rendering a custom component. However, if you need to load just one icon, there is also [loadIcon()](https://iconify.design/docs/icon-components/vue/load-icon.html "loadIcon() documentation") that is easier to use.

This function is the most efficient way to preload icons that you know will be needed at some point. It loads icon data from Iconify API in bulk, reducing the number of queries.

It is safe to call the function multiple times with the same icon name, component will not load icon data from Iconify API twice. If you set a callback parameter, callback will be called correctly even if icon was loaded with different loadIcons() call, making sure callback is reliable.

## Usage

The function has the following parameters:

- icons, (string| [IconifyIconName](https://iconify.design/docs/icon-components/vue/icon-name.html "IconifyIconName documentation"))\[\]. List of icons to load.
- callback, function. Optional callback to call. Callback is called not only when all icons have been retrieved, but also when part of icons have been retrieved.

The function returns function you can use to stop loading icons. It is needed when, for example, you are loading icons in a custom component, but the component's life cycle ended before icons have loaded, so you need to remove callback.

## Icons list

List of icons is an array. Each element can be a string, such as mdi:home or a [IconifyIconName](https://iconify.design/docs/icon-components/vue/icon-name.html "IconifyIconName documentation") object.

## Callback

Optional callback has the following parameters:

- loaded, [IconifyIconName](https://iconify.design/docs/icon-components/vue/icon-name.html "IconifyIconName documentation") \[\]. List of icons that have been loaded.
- missing, [IconifyIconName](https://iconify.design/docs/icon-components/vue/icon-name.html "IconifyIconName documentation") \[\]. List of icons that are not available on API.
- pending, [IconifyIconName](https://iconify.design/docs/icon-components/vue/icon-name.html "IconifyIconName documentation") \[\]. List of icons that are still loading.
- unsubscribe, function. Function to call to cancel loading. It is the same as result of loadIcons() call.

## IconifyIconName type

[IconifyIconName](https://iconify.design/docs/icon-components/vue/icon-name.html "IconifyIconName documentation") is a simple object with the following properties, all properties are mandatory:

- provider, string. [API provider](https://iconify.design/docs/api/providers.html). For public Iconify API value is an empty string "".
- prefix, string. Icon set prefix.
- name, string. Icon name.

## Examples

Simple callback that loads one icon:

js
```
import { loadIcons } from '@iconify/vue';

const iconName = 'mdi:home';
loadIcons([iconName], (loaded, missing, pending, unsubscribe) => {
    if (loaded.length) {
        console.log(
            \`Icon ${iconName} have been loaded and is ready to be renderered.\`
        );
        return;
    }

    if (missing.length) {
        console.log(\`Icon ${iconName} does not exist.\`);
        return;
    }

    if (pending.length) {
        // Pending icons list in this example is empty.
        // If you call loadIcons() with multiple icons, pending list might not be empty, but for one icon it is always empty.
        //
        // Callback is called when something changes, with 1 icon there can only be 2 type of changes: icon has loaded or icon is missing.
    }
 });
```

Async version of loadIcons():

js
```
import { loadIcons } from '@iconify/vue';

/**
 * Function to load icons, returns Promise
 */
function loadTestIcons(icons) {
    return new Promise((fulfill, reject) => {
        loadIcons(icons, (loaded, missing, pending, unsubscribe) => {
            if (pending.length) {
                // Icons are pending, wait for all to load/fail
                //
                // If pending list is not empty, callback will be called
                // again when all icons are either loaded or missing
                return;
            }
            if (missing.length) {
                reject({
                    loaded,
                    missing,
                });
            } else {
                fulfill({
                    loaded,
                });
            }
        });
    });
 }

/**
 * Usage example in async function
 */
async function test() {
    // Wait for icons to load
    await loadTestIcons(['jam:info', 'cil:locomotive', 'cil:paper-plane']).catch(
        (err) => {
            console.error('Failed to load icons:', err.missing);
        }
    );

    // Do stuff with loaded icons
    console.log('Loaded!');
 }
test();
```

## Component example

This example dynamically loads icon data and renders <slot /> while icon is being loaded. It is redundant because Vue component already does that, but it is used to show how to use [getIcon()](https://iconify.design/docs/icon-components/vue/get-icon.html "getIcon() documentation") and loadIcons().

js
```
import { Icon, getIcon, loadIcons } from '@iconify/vue';
import { h, defineComponent, ref } from 'vue';

export default defineComponent({
    components: {
        Icon,
    },
    props: ['icon'],
    setup() {
        // Variable to store function to cancel loading
        const loader = ref(null);

        // Icon data
        const data = ref(null);

        // Function to check icon data
        const check = (icon: string) => {
            const iconData = getIcon(icon);

            // Cancel old loder
            if (loader.value) {
                loader.value();
                loader.value = null;
            }

            if (iconData) {
                data.value = iconData;
            } else {
                loader.value = loadIcons([icon], () => {
                    data.value = getIcon(icon);
                });
            }
        };
        return {
            loader,
            data,
            check,
        };
    },
    watch: {
        icon: {
            immediate: true,
            handler(value) {
                // Check new value
                this.check(value);
            },
        },
    },
    // Stop loading
    unmounted() {
        const loader = this.loader.value;
        if (loader) {
            loader();
        }
    },
    render() {
        const icon = this.data;
        if (icon) {
            return h(Icon, {
                icon,
            });
        }
        return this.$slots.default ? this.$slots.default() : null;
    },
 });
```

If you want to load only one icon, there is also [loadIcon()](https://iconify.design/docs/icon-components/vue/load-icon.html "loadIcon() documentation") that is easier to use.

[Page 76](https://iconify.design/docs/icon-components/vue/load-icon.html "Current Page.")

## Iconify for Vue function: loadIcon

This tutorial is part of [Iconify for Vue functions tutorial](https://iconify.design/docs/#functions).

The function loadIcon() retrieves an icon from Iconify API.

It returns Promise instance, making it very easy to use in asynchronous code.

When to use this function:

- When you need to get icon data inside an asynchronous function.

When not to use this function:

- To preload multiple icons that you will use later. Use [loadIcons()](https://iconify.design/docs/icon-components/vue/load-icons.html "loadIcons() documentation") instead.

It is safe to call function multiple times with the same icon name, component will not load icon data from Iconify API twice. If you pass string icon name as parameter, multiple calls of the function will return the same Promise instance.

## Usage

The function has the following parameter:

- icon, string| [IconifyIconName](https://iconify.design/docs/icon-components/vue/icon-name.html "IconifyIconName documentation"). Name of the icon to load.

The function returns Promise instance, which returns [FullIconifyIcon](https://iconify.design/docs/libraries/utils/full-iconify-icon.html "FullIconifyIcon documentation") data for icon on success.

## IconifyIconName type

[IconifyIconName](https://iconify.design/docs/icon-components/vue/icon-name.html "IconifyIconName documentation") is a simple object with the following properties, all properties are mandatory:

- provider, string. [API provider](https://iconify.design/docs/api/providers.html). For public Iconify API value is an empty string "".
- prefix, string. Icon set prefix.
- name, string. Icon name.

## Examples

Using Promise syntax:

js
```
import { loadIcon } from '@iconify/vue';

const iconName = 'mdi:home';
loadIcon(iconName)
    .then((data) => {
        console.log(
            \`Icon ${iconName} have been loaded and is ready to be renderered.\`
        );
        console.log(data);
    })
    .catch((err) => {
        console.log(\`Icon ${iconName} does not exist.\`);
    });
```

Async/await syntax:

js
```
import { loadIcon } from '@iconify/vue';

/**
 * Usage example in async function
 */
async function test() {
    try {
        const data = await loadIcon('mdi:home');
        console.log('Loaded home icon!');
    } catch (err) {
        console.error('Failed to load home icon');
    }
 }
test();
```

If you want to load multiple icons, see [loadIcons()](https://iconify.design/docs/icon-components/vue/load-icons.html "loadIcons() documentation").

[Page 77](https://iconify.design/docs/icon-components/vue/custom-loaders.html "Current Page.")

## Custom icon loaders

This tutorial is part of [Iconify for Vue tutorial](https://iconify.design/docs/).

Functions setCustomIconLoader() and setCustomIconsLoader() are used to define custom icon loaders.

What is it for?

- To load icon data from custom sources.
- To modify icons, such as changing color or stroke width.

## Usage

Both functions have the same parameters, except for type of callback:

- callback, function. Callback that loads icons, can be synchronous or asynchronous function.
- prefix, string. Icon set prefix.
- provider, string. Icon set provider, optional.

Callback is a function that loads icon data.

Both synchronous and asynchronous (returns Promise instance) callbacks are supported.

Callbacks for both functions have similar parameters.

Parameters for setCustomIconLoader():

- name, string. Icon name.
- prefix, string. Icon set prefix.
- provider, string. Icon set provider.

Order of parameters is intentional: from most important to least important. If you have set loader for one prefix, you most likely only need name parameter.

The callback returns icon data as [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") or null on failure (or Promise of those types).

Callback for setCustomIconsLoader() is almost identical, except:

- First parameter is an array of icon names: string\[\].
- Callback returns an icon set as [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") or null on failure (or Promise of those types).

## Example

js
```
import { setCustomIconLoader, loadIcon } from "@iconify/vue";

// Creates icon set "tabler-thin" that loads icons from Tabler Icons and makes them thinner
// Then you can use "tabler:angle" to render icon with default stroke, or "tabler-thin:angle" to render thinner icon
setCustomIconLoader(async (name) => {
  const data = await loadIcon(\`tabler:${name}\`);
  return data
    ? {
        ...data,
        body: data.body.replaceAll('stroke-width="2"', 'stroke-width="1"'),
      }
    : null;
 }, "tabler-thin");

// Fetches icon from custom server
// Icon data must be in IconifyIcon format
setCustomIconLoader(async (name) => {
  const response = await fetch(\`https://example.com/icons/${name}.json\`);
  if (!response.ok) {
    return null;
  }
  return await response.json();
 }, "custom-server");
```

Make sure loader is set before any icons are rendered, otherwise component might attempt to load icon from API and fail to render it.

[Page 78](https://iconify.design/docs/icon-components/vue/build-icon.html "Current Page.")

## Iconify for Vue function: buildIcon

This tutorial is part of [Iconify for Vue functions tutorial](https://iconify.design/docs/#functions).

Function buildIcon() generates data used by icon component to render icon.

You can use this function to generate <svg> code.

## Usage

The function has the following parameters:

- icon, [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation"). Icon data.
- customisations. Optional customizations object.

The function returns object containing icon data, null if icon is not available.

You need icon data before you can use this function. See [getIcon()](https://iconify.design/docs/icon-components/vue/get-icon.html "getIcon() documentation"), [iconLoaded()](https://iconify.design/docs/icon-components/vue/icon-exists.html "iconLoaded() documentation") and [loadIcon()](https://iconify.design/docs/icon-components/vue/load-icon.html "loadIcon() documentation") functions.

## Result

Result object has the following properties:

- attributes, object. List of attributes for <svg> element.
- body, string. Icon contents.

The list of attributes does not include standard attributes: xmlns, xmlns:link. It also does not include attributes that are added by icon component: aria-hidden, focusable, role, class, style. It is up to you to decide what attributes you want to add.

## Customizations

Second parameter is optional icon customizations. Available customizations:

IconifyIconCustomisations type is an object with the following optional properties, split into several categories.

Vertical alignment:

- inline, boolean. If enabled, adds vertical-align: -0.125em to style, rendering icon below baseline. The default value is false.

Icon dimensions:

- width, string|number|null. Icon width. The default value is null.
- height, string|number|null. Icon height. The default value is null.

There are several keywords that can be used for width and height:

- "auto" sets dimension to original icon's dimensions found in viewBox.
- "unset" and "none" remove dimensions from SVG.

If neither of dimensions is set, height defaults to "1em".

It is enough to set one dimension, such as height. Another dimension will be calculated using icon's width/height ratio. In the case of keywords, another dimension will be set to the same keyword.

Transformations:

- hFlip, boolean. Flip icon horizontally. The default value is false.
- vFlip, boolean. Flip icon vertically. The default value is false.
- rotate, number. Rotation in 90 degrees increments. The default value is 0.

For more details about dimensions see [icon dimensions documentation](https://iconify.design/docs/dimensions.html).

For more details about transformations see [icon transformations documentation](https://iconify.design/docs/transform.html).

## Example

js
```
import { buildIcon } from '@iconify/vue';
import biStopwatch from '@iconify-icons/bi/stopwatch';

buildIcon(biStopwatch, {
    hFlip: true,
    height: '24',
 });
```

json
```
{
    "attributes": {
        "width": "24",
        "height": "24",
        "viewBox": "0 0 16 16"
    },
    "body": "<g transform=\"translate(16 0) scale(-1 1)\"><g fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M8 15A6 6 0 1 0 8 3a6 6 0 0 0 0 12zm0 1A7 7 0 1 0 8 2a7 7 0 0 0 0 14z\"/><path fill-rule=\"evenodd\" d=\"M8 4.5a.5.5 0 0 1 .5.5v4a.5.5 0 0 1-.5.5H4.5a.5.5 0 0 1 0-1h3V5a.5.5 0 0 1 .5-.5zM5.5.5A.5.5 0 0 1 6 0h4a.5.5 0 0 1 0 1H6a.5.5 0 0 1-.5-.5z\"/><path d=\"M7 1h2v2H7V1z\"/></g></g>"
}
```

[Page 79](https://iconify.design/docs/icon-components/vue/replace-ids.html "Current Page.")

## Iconify for Vue function: replaceIDs

This tutorial is part of [Iconify for Vue functions tutorial](https://iconify.design/docs/#functions).

The function replaceIDs() finds IDs in SVG and replaces them with unique random IDs.

This function is meant to be used when you generate <svg> element yourself using data provided by [getIcon()](https://iconify.design/docs/icon-components/vue/get-icon.html "getIcon() documentation").

## Usage

The function has the following parameters:

- data, string. Icon content.
- prefix, string|function. Optional prefix for generated IDs. It can be a string or a callback that returns string.

The function returns string containing icon data with IDs replaced.

## Example

This is a rather useless example. In real code, this function is used when generating SVG code samples in Icon Finder, which is not as simple as this example.

js
```
import { replaceIDs, getIcon } from '@iconify/vue';

// Get icon data
const data = getIcon('carbon:deploy');

// Get content
const body = replaceIDs(data.body);

console.log('Icon content:', body);
```

[Page 80](https://iconify.design/docs/icon-components/svelte/ "Current Page.")

## Iconify for Svelte

Iconify offers native icon components for several popular UI frameworks.

Iconify for Svelte is one of such components.

Yet another icon component? What are the advantages over other icon components?

- One syntax for over 275,000 icons from 200+ icon sets.
- Renders SVG. Many components simply render icon fonts, which look ugly. Iconify uses only pixel perfect SVG.
- Loads icons on demand. No need to bundle icons, component will automatically load icon data for icons that you use from Iconify API.

Please be aware that this component is not designed for server side rendering. If you are using SSR, consider switching to [Iconify Icon web component](https://iconify.design/docs/iconify-icon/).

## Installation

If you are using NPM:

```
npm install --save-dev @iconify/svelte
```

If you are using Yarn:

```
yarn add --dev @iconify/svelte
```

### Svelte 4

Starting with version 6.0.0 of component, it uses Svelte 5 syntax, which is not compatible with Svelte 4.

If you are using Svelte 4, you need to use version 5 of component:

```
npm install --save-dev @iconify/svelte@4
```

or use a [web component](https://iconify.design/docs/iconify-icon/).

## Usage

Install @iconify/svelte and import component from it (component is exported as default export):

js
```
import Icon from "@iconify/svelte";
```

Then in template use Icon component with icon name as icon parameter:

jsx
```
<Icon icon="mdi-light:home" />
```

### SvelteKit

Component is compatible with SvelteKit. Syntax is the same as with Svelte.

The component does not retrieve icon data until it is mounted. For server side rendering it means generated HTML will not include SVGs, icons will be rendered only on the client side after hydration is complete.

If you do want to render SVGs on the server side, provide [icon data](https://iconify.design/docs/types/iconify-icon.html) as a parameter instead of icon name or [use a different icon component](https://iconify.design/docs/usage/).

## Properties

You can pass any custom properties to Icon.

Required properties:

- icon, [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") |string icon name or icon data.

Optional properties:

- inline, boolean changes vertical alignment.
- width, string|number icon width.
- height, string|number icon height.
- hFlip, boolean flips icon horizontally.
- vFlip, boolean flips icon vertically.
- flip, string alternative to hFlip and vFlip.
- rotate, number|string rotates icon.
- color, string changes icon color.
- onLoad, function is a callback that is called when icon data has been loaded. See below.

See below for more information on each optional property.

In addition to the properties mentioned above, the icon component accepts any other properties. All other properties will be passed to generated SVG element, so you can do stuff like setting the inline style, add title and so on.

Unlike React component, Svelte component does not support events.

## Icon

Icon name is a string, which has 3 parts:

| @api-provider | : | icon-prefix | : | icon-name |
| --- | --- | --- | --- | --- |
| provider |  | prefix |  | name |

- provider points to API source. Starts with "@", can be empty (empty value is used for public Iconify API).
- prefix is name of icon set.
- name is name of icon.

Examples of valid icon names:

- flat-color-icons:voice-presentation - icon is "voice-presentation" from [Flat Color Icons](https://icon-sets.iconify.design/flat-color-icons/) icon set, from public Iconify API.
- mdi-light:home - icon is "home" from [Material Design Light](https://icon-sets.iconify.design/mdi-light/) icon set, from public Iconify API.

Exceptions:

- If the API provider is empty, it can be skipped (like in examples above).
- If prefix does not contain "-", prefix and icon name can be separated with hyphen. This is to support people migrating from icon fonts. For example, fa:arrow-left and fa-arrow-left are identical because "fa" does not contain hyphen.

There are over 275,000 icons available from 200+ icon sets. [Browse icons sets](https://icon-sets.iconify.design/) to see all available icons.

You can also add custom API providers for more icon choices. See [API providers documentation](https://iconify.design/docs/api/providers.html).

## Color

You can only change the color of monotone icons. Some icons, such as emoji, have a hardcoded palette that cannot be changed.

To add color to a monotone icon, simply change text color.

jsx
```
<Icon icon="mdi:home" style="color: red" />
```

For various ways to set color, see [how to change icon color in Iconify for Svelte](https://iconify.design/docs/color.html).

## Dimensions

By default, icon height is set to "1em", icon width is changed dynamically based on the icon's width/height ratio. This makes it easy to change icon size by changing font-size in the stylesheet, just like icon fonts.

There are several ways to change icon dimensions:

- Setting font-size in style (or fontSize if you are using inline style).
- Setting width and/or height property.

Values for width and height can be numbers or strings.

If you set only one dimension, another dimension will be calculated using the icon's width/height ratio. For example, if the icon size is 16 x 24, you set the height to 48, the width will be set to 32. Calculations work not only with numbers, but also with string values.

jsx
```
<Icon icon="mdi:home" style="font-size: 24px;" />
```

For various ways to change icon dimensions, see [how to change icon dimensions in Iconify for Svelte](https://iconify.design/docs/dimensions.html).

## Transformations

An icon can be rotated and flipped horizontally and/or vertically. All transformations are done relative to the center of the icon.

These are not CSS transformations, transformations are applied inside SVG.

For more details see [how to transform icon in Iconify for Svelte](https://iconify.design/docs/transform.html).

## onLoad

onLoad property is an optional callback function. It is called when icon data has been loaded.

It is not an event, such as click event for links, it is a simple callback function.

When onLoad is called:

- If value of icon property is an object, onLoad is not called.
- If value of icon property is a string and icon data is available, onLoad is called on first render.
- If value of icon property is a string and icon data is not available, onLoad is called on first re-render after icon data is retrieved from API.

What is the purpose of onLoad? To let you know when Icon component renders an icon and when it does not render anything. This allows you to do things like adding class name for the parent element, such as "container--with-icon" that modify layout if icon is being displayed.

## Functions

Component exports various functions, which developers can use to control icons.

Functions are split in several groups (click function name to see more details and examples):

### Check available icons

There are several functions in this section:

- [iconLoaded(name)](https://iconify.design/docs/icon-components/svelte/icon-exists.html "iconLoaded() documentation"). Checks if icon data is available, returns boolean.
- [listIcons()](https://iconify.design/docs/icon-components/svelte/list-icons.html "listIcons() documentation"). Lists available icons, returns string\[\].
- [getIcon(name)](https://iconify.design/docs/icon-components/svelte/get-icon.html "getIcon() documentation"). Returns icon data, returns [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") object.

### Adding icons

Functions for adding icons to the component:

- [addIcon()](https://iconify.design/docs/icon-components/svelte/add-icon.html "addIcon() documentation"). Adds one icon.
- [addCollection()](https://iconify.design/docs/icon-components/svelte/add-collection.html "addCollection() documentation"). Adds an icon set.

Note: icons added to the component with these functions are not stored in the icon data cache. Component caches only icons retrieved from API.

### Custom loaders

Custom loaders can be used to load icons from custom sources:

- [setCustomIconLoader()](https://iconify.design/docs/icon-components/svelte/custom-loaders.html "setCustomIconLoader() documentation"). Loads one icon.
- [setCustomIconsLoader()](https://iconify.design/docs/icon-components/svelte/custom-loaders.html "setCustomIconsLoader() documentation"). Loads icons in bulk.

Loaders are set per icon set prefix. Make sure to configure loader before displaying any icons.

It can also be used to customise icons: in custom loader you can load icon from API using [loadIcon](https://iconify.design/docs/icon-components/svelte/load-icon.html "loadIcon() documentation"), change its content (such as colors or stroke width) and return modified icon.

### Helper functions

- [replaceIDs(html)](https://iconify.design/docs/icon-components/svelte/replace-ids.html "replaceIDs() documentation"). Randomises IDs in generated string. This should be used when rendering icon based on data returned by [getIcon()](https://iconify.design/docs/icon-components/svelte/get-icon.html "getIcon() documentation") to make sure elements inside each icon have unique IDs.
- calculateSize(). Calculates icon size. It is used to calculate width if only height is set and vice versa.
- [buildIcon(icon, customisations?)](https://iconify.design/docs/icon-components/svelte/build-icon.html "buildIcon() documentation"). Generates data used by icon component. This can be used if you prefer to generate <svg> yourself. Data includes attributes for <svg> and inner HTML.

### API functions

- [loadIcons(icons, callback?)](https://iconify.design/docs/icon-components/svelte/load-icons.html "loadIcons() documentation"). Loads icons from API, calls optional callback when either all or part of icons have been loaded.
- [loadIcon(icon)](https://iconify.design/docs/icon-components/svelte/load-icon.html "loadIcon() documentation"). Loads one icon from API, returns Promise.
- [addAPIProvider()](https://iconify.design/docs/icon-components/svelte/add-api-provider.html "addAPIProvider() documentation"). Adds custom API provider. See [API providers documentation](https://iconify.design/docs/api/providers.html).

### Internal API functions

There are several internal API functions that are exposed. They are intended to be used by developers that need more control over the component. For example, it is used in Sketch and Figma plug-ins. Use them carefully.

All internal API functions are exposed as properties of \_api object:

- getAPI(). Returns internal API module.
- getAPIConfig(). Returns API configuration.
- setAPIModule(provider). Sets API module for provider. This is an experimental function intended for custom API providers that use custom module for retrieving data from API.
- [setFetch(fetch)](https://iconify.design/docs/icon-components/svelte/set-fetch.html "setFetch() documentation"). Set custom Fetch API.
- getFetch(). Returns used fetch() function, null if Fetch API is not available.

[Page 81](https://iconify.design/docs/icon-components/svelte/color.html "Current Page.")

## Icon color

This tutorial is part of [Iconify for Svelte tutorial](https://iconify.design/docs/).

You can only change color of monotone icons. Some icons, such as emoji, have a hardcoded palette that cannot be changed.

To change color of a monotone icon, simply change text color or use color attribute or add style with color.

All icons inside this div are light blue, including a bell icon and attachment icon

This text and icon are orange:

Red home icons (shows different ways to change color):

Icon with palette:

svelte
```
<script>
    import IconifyIcon from '@iconify/svelte';
</script>

<style>
    /* 
        Cannot target component in CSS, target SVG 
        instead using Svelte's :global() function 

        This is equivalent of adding inline={true} to each icon
    */
    div :global(svg) {
        vertical-align: -0.125em;
    }

    /* Change text color for ".orange-block" to #e70 */
    .orange-block {
        color: #e70;
    }
    /* Change all icons inside ".light-blue-block" to #08f */
    /*
        Must use :global() because Svelte cannot assign style to
        a component, so need to target SVG generated by component.
    */
    .light-blue-block :global(svg) {
        color: #08f;
    }

    /* Change text color for ".red-icon" to #e00 */
    /*
        Must use :global() because Svelte cannot assign style to a
        component by class name, it can only work with standard HTML tags.
    */
    div :global(.red-icon) {
        color: #e00;
    }
</style>

<div>
    <div class="light-blue-block">
        All icons inside this div are light blue, including a bell icon
        <IconifyIcon icon="bi:bell-fill" />
        and stopwatch icon
        <IconifyIcon icon="bi:stopwatch" />
    </div>
    <div class="orange-block">
        This text and icon are orange:
        <IconifyIcon icon="bi:bell-fill" />
    </div>
    <div>
        Red home icons (shows different ways to change color):
        <IconifyIcon class="red-icon" icon="bx:bx-home" />
        <IconifyIcon style="color: red" icon="bx:bx-home" />
        <IconifyIcon color="red" icon="bx:bx-home" />
    </div>
    <div>
        Icon with palette:
        <IconifyIcon icon="noto:paintbrush" />
    </div>
</div>
```

Color only works for icons that do not have a palette. Color in icons that do have a palette, like paintbrush icon in an example above, cannot be changed.

You can change color the same way as you would for text.

## RGBA and HSLA colors

Avoid using rgba and hsla colors. Some icons have multiple layers on top of each other. Using semi-transparent color will result in both layers being visible.

Instead, use a solid color and add transparency with opacity. This will result in browser rendering shapes with a solid color, then applying opacity to an entire icon.

## fill and stroke

Avoid using fill and stroke in stylesheet, unless you are using it for a specific icon.

Not all icons are the same. Some use fill for shapes, some use stroke. If you set fill, you might end up with filled shapes that should not be filled.

[Page 82](https://iconify.design/docs/icon-components/svelte/dimensions.html "Current Page.")

## Icon dimensions

This tutorial is part of [Iconify for Svelte tutorial](https://iconify.design/docs/).

By default, icon height is set to "1em", icon width is changed dynamically based on the icon's width/height ratio.

This makes it easy to change icon size by changing font-size in the stylesheet or in style, just like icon fonts:

svelte
```
<script>
    import Icon from '@iconify/svelte';
</script>

<style>
    /* 
        Cannot target component in CSS, target SVG 
        instead using Svelte's :global() function 
    */
    div :global(svg) {
        font-size: 24px;
        line-height: 1em;
    }

    /*
        Must use :global() because Svelte cannot assign style to a
        component by class name, it can only work with standard HTML tags.
    */
    div :global(.big-icon) {
        font-size: 72px;
    }
</style>

<div>
    <Icon icon="cil:locomotive" />
    <Icon icon="cil:paper-plane" style="font-size: 36px" />
    <Icon icon="cil:truck" class="big-icon" />
</div>
```

If you want to control icon size with width and height in CSS, see [how to remove icon dimensions](#unset) section below.

## Units

Size can be a string with or without units or a number. If value is a number or string without units, it will be treated by browser as pixels.

Examples of 24px icon:

jsx
```
// Number
 <Icon icon="mdi:home" height={24} />
// String without units
<Icon icon="mdi:home" height="24" />
// String with units
<Icon icon="mdi:home" height="24px" />
// String with units, font-size is 16px
<Icon icon="mdi:home" height="1.5em" />
```

## Keyword "auto"

Special keyword "auto" sets size to value from viewBox. This makes it easy to render an icon as it was originally designed.

It is enough to set one dimension to "auto", another dimension will be set to "auto" too, unless you specify otherwise.

For example, if viewBox="0 0 24 24" and height is set to "auto", height will be set to 24.

jsx
```
<Icon icon="mdi:home" height="auto" />
```

## Keywords "none" and "unset"

Special keywords "none" and "unset" remove dimensions from generated SVG.

This results in icon without dimensions. You should set icon's width and height in CSS.

It is enough to set one dimension to "unset", another dimension will be set to "unset" too, unless you specify otherwise.

svelte
```
<script>
    import Icon from '@iconify/svelte';
</script>

<div>
    <Icon 
        icon="mdi:home"
        height="none"
        style="width: 48px; height: 48px"
    />
</div>
```

This gives you full control over each icon's dimension separately in CSS instead of controlling them both with font-size.

Sometimes you might also need to add display: block; to CSS for icon to behave correctly.

## Setting only width or height

In an example above, all icons only use height.

What happens when only one dimension is set?

- If width is not set, but height is set, width is calculated using icon's width/height ratio.
- If height is not set, but width is set, height is calculated using icon's height/width ratio.
- If no dimensions are set in attributes, height is set to "1em" and width is calculated using icon's width/height ratio. Then icon behaves like a text and can be resized using font-size in stylesheet.

### Example

Many icons are square. For such icons if you set one dimension, another dimension will have the same value.

However, there are many icons that are not square. For example, icons imported from icon fonts and Font Awesome.

This is data for fa-regular:address-book:

json
```
{
    "body": "<path d=\"M436 160c6.6 0 12-5.4 12-12v-40c0-6.6-5.4-12-12-12h-20V48c0-26.5-21.5-48-48-48H48C21.5 0 0 21.5 0 48v416c0 26.5 21.5 48 48 48h320c26.5 0 48-21.5 48-48v-48h20c6.6 0 12-5.4 12-12v-40c0-6.6-5.4-12-12-12h-20v-64h20c6.6 0 12-5.4 12-12v-40c0-6.6-5.4-12-12-12h-20v-64h20zm-68 304H48V48h320v416zM208 256c35.3 0 64-28.7 64-64s-28.7-64-64-64s-64 28.7-64 64s28.7 64 64 64zm-89.6 128h179.2c12.4 0 22.4-8.6 22.4-19.2v-19.2c0-31.8-30.1-57.6-67.2-57.6c-10.8 0-18.7 8-44.8 8c-26.9 0-33.4-8-44.8-8c-37.1 0-67.2 25.8-67.2 57.6v19.2c0 10.6 10 19.2 22.4 19.2z\" fill=\"currentColor\"/>",
    "width": 448,
    "height": 512
}
```

Icon size is 448 x 512

If you do not set any dimensions, height will be set to "1em" and width will be set to 448 / 512 = "0.875em". However, values that have more than 2 numbers after decimal point are rounded up, so actual width will be "0.88em":

html
```
<svg
    xmlns="http://www.w3.org/2000/svg"
    xmlns:xlink="http://www.w3.org/1999/xlink"
    aria-hidden="true"
    focusable="false"
    role="img"
    class="iconify iconify--fa-regular"
    width="0.88em"
    height="1em"
    preserveAspectRatio="xMidYMid meet"
    viewBox="0 0 448 512"
 >
    <path d="..." fill="currentColor"></path>
</svg>
```

If you set width to 56, but do not set height, height will be set to 56 \* 512 / 448 = 64:

html
```
<svg width="56" height="64" ...>...</svg>
```

If you set both values: width to 56 and height to 128, values will be as you set them (also see "Alignment" section below):

html
```
<svg width="56" height="128" ...>...</svg>
```

## Alignment

What if you set both width and height and its ratio doesn't match icon's width/height ratio?

For example, what will happen if icon is 24x24, but you set one dimension to 40 and other dimension to 24?

Using box-shadow to show icon dimensions

jsx
```
<Icon icon="jam:info" width="40" height="24" />
<Icon icon="jam:info" width="24" height="40" />
```

SVG do not behave like other images. When you set a wrong width/height ratio for other image formats, images get stretched. When you do that for SVG, bounding box is changed and the image is aligned inside that bounding box.

In an example above, one icon is too wide and another icon is too tall. The browser will move icons to center instead of stretching icon.

[Page 83](https://iconify.design/docs/icon-components/svelte/transform.html "Current Page.")

## Transformations

This tutorial is part of [Iconify for Svelte tutorial](https://iconify.design/docs/).

An icon can be rotated and flipped horizontally and/or vertically. All transformations are done relative to the center of the icon.

There are two types of transformations:

- Horizontal and vertical flip.
- Rotation by 90, 180 and 270 degrees.

## CSS vs Iconify transformations

These are not CSS transformations, transformations are applied inside SVG.

What's the difference from CSS transformations?

- If you rotate an icon by 90 degrees in CSS, icon's bounding box remains the same. 16x24 icon still takes space for 16x24, but might overlap elements around it.
- If you rotate an icon by 90 degrees in SVG Framework, icon's dimensions swap places. 16x24 icon becomes 24x16 icon, and it does not affect elements around it.

Example:

Test icon with text around it

Test icon with text around it

Using box-shadow to show icon dimensions

svelte
```
<script>
    import Icon from '@iconify/svelte';
</script>

<style>
    /* 
        Align icon to bottom of text, like in icon fonts.

        Cannot target component in CSS, target SVG 
        instead using Svelte's :global() function 

        This is the same as adding inline={true} to each <Icon />
    */
    p :global(svg) {
        vertical-align: -0.125em;
    }
</style>

<p>
    Test icon
    <Icon icon="fa-regular:handshake" rotate="90deg" />
    with text around it
</p>
<p>
    Test icon
    <Icon icon="fa-regular:handshake" style="transform: rotate(90deg);" />
    with text around it
</p>
```

In example above, first icon is rotated using rotate attribute, second icon is rotated using CSS. The first icon kept its 1em height, second icon became taller than it should be.

Sometimes you do want behaviour that CSS transformations provide. Then you can still use CSS transformations by adding it to style.

## Flip

You can flip an icon horizontally and/or vertically.

One way to do that is to add flip attribute with comma-separated values. Possible values:

- "horizontal": flip icon horizontally.
- "vertical": flip icon vertically.

You can also do that by setting hFlip and / or vFlip attributes to true.

Example:

No flip:

Horizontal flip:

Vertical flip:

Both (or 180° rotation):

svelte
```
<script>
    import Icon from '@iconify/svelte';
</script>

<p>
    No flip:
    <Icon icon="bi:check2-circle" inline={true} />
</p>
<p>
    Horizontal flip:
    <Icon icon="bi:check2-circle" inline={true}flip="horizontal" />
</p>
<p>
    Vertical flip:
    <Icon icon="bi:check2-circle" inline={true}flip="vertical" />
</p>
<p>
    Both (or 180° rotation):
    <Icon icon="bi:check2-circle" inline={true}flip="horizontal,vertical" />
</p>
```

svelte
```
<script>
    import Icon from '@iconify/svelte';
</script>

<p>
    No flip:
    <Icon icon="bi:check2-circle" inline={true} />
</p>
<p>
    Horizontal flip:
    <Icon icon="bi:check2-circle" inline={true}hFlip={true} />
</p>
<p>
    Vertical flip:
    <Icon icon="bi:check2-circle" inline={true}vFlip={true} />
</p>
<p>
    Both (or 180° rotation):
    <Icon icon="bi:check2-circle" inline={true}hFlip={true}vFlip={true} />
</p>
```

## Rotation

You can rotate icon by 90, 180 and 270 degrees.

To do that, add rotate attribute. Possible values:

- "90deg", "1": rotate by 90 degrees.
- "180deg", "2": rotate by 180 degrees.
- "270deg", "3": rotate by 270 degrees.

Example:

No rotation:

90° rotation:

180° rotation:

270° rotation:

svelte
```
<script>
    import Icon from '@iconify/svelte';
</script>

<style>
    /* 
        Align icon to bottom of text, like in icon fonts.

        Cannot target component in CSS, target SVG 
        instead using Svelte's :global() function 

        This is the same as adding inline={true} to each <Icon />
    */
    p :global(svg) {
        vertical-align: -0.125em;
    }
</style>

<p>
    No rotation:
    <Icon icon="bi:check2-circle" />
</p>
<p>
    90° rotation:
    <Icon icon="bi:check2-circle" rotate="90deg" />
</p>
<p>
    180° rotation:
    <Icon icon="bi:check2-circle" rotate="180deg" />
</p>
<p>
    270° rotation:
    <Icon icon="bi:check2-circle" rotate={3} />
</p>
```

## Rotate and flip

You can use both rotation and flip on an icon. The icon is flipped first, then rotated.

[Page 84](https://iconify.design/docs/icon-components/svelte/inline.html "Current Page.")

## Vertical alignment

This tutorial is part of [Iconify for Svelte tutorial](https://iconify.design/docs/).

When an icon is rendered in text, by default it is aligned at baseline, as any other images.

Emojis and icon fonts are rendered slightly below baseline, like any text.

If you want to render icon in text, you probably want to add vertical-align to each icon to render it slightly below baseline, to make it fit in text, similar to emojis and icon fonts:

SVG in text:

SVG in text with vertical-align: -0.125em:

## Inline attribute

Instead of adding vertical-align to each icon, the icon component has a property inline. Adding inline property to the icon component is identical to setting style="vertical-align: -0.125em":

Inline attribute demo:

svelte
```
<script>
    import Icon from '@iconify/svelte';
</script>

<p>
    Inline attribute demo:
    <Icon icon="line-md:image-twotone" inline={true} />
    <Icon icon="mdi:account-box-outline" inline={true} />
</p>
```

Important: this attribute does not change display mode for icon. It only adds vertical-align style.

[Page 85](https://iconify.design/docs/icon-components/svelte/icon-exists.html "Current Page.")

## Iconify for Svelte function: iconLoaded

This tutorial is part of [Iconify for Svelte functions tutorial](https://iconify.design/docs/#functions).

The function iconLoaded() checks if icon data is available for rendering.

## Usage

The function has the following parameter:

- name, string. Icon name.

The function returns boolean value: true if icon data is available, false if icon data is not available.

## Example

This example renders fallback snippet while icon is being loaded.

svelte
```
<script lang="ts">
    import Icon, { iconLoaded, loadIcons, type IconifyIconLoaderAbort }from '@iconify/svelte';
    import{ onDestroy }from 'svelte';

    // Icon to render and fallback children
    let{ icon, fallback } = $props();

    // Icon status and cleanup function
    let loaded = $state(false);
    let cleanup: IconifyIconLoaderAbort | null = null;
    let update = $state(0);

    $effect(() =>{
        // Mention update to re-run this effect when state changes
        update;

        // Get icon data
        loaded = iconLoaded(icon);

        // Cancel previous callback
        if (cleanup) {
            cleanup();
            cleanup = null;
        }

        // Load icon
        if (!loaded) {
            cleanup = loadIcons([icon], () => {
                // Trigger re-running of code above
                update ++;
            });
        }
    })

    // Cleanup
    onDestroy(() =>{
        if (cleanup) {
            cleanup();
        }
    })
</script>

{#if loaded}
    <Icon icon={icon} />
{:else}
    {@render fallback?.()}
{/if}
```

Usage example:

svelte
```
<IconWrapper icon="mdi-light:alert">
    {#snippet fallback()}
        <small>!</small>
    {/snippet}
</IconWrapper>
```

This example uses iconLoaded() to show function, but for this purpose it is better to use [getIcon()](https://iconify.design/docs/icon-components/svelte/get-icon.html "getIcon() documentation"). See [getIcon()](https://iconify.design/docs/icon-components/svelte/get-icon.html "getIcon() documentation") documentation for better example.

## Legacy

Note: in old versions of component, this function was named iconExists(). It was the same function, but with bad name.

Because of bad name, some developers assumed it checks if icon exists on Iconify API. It does not. All it does is checks component's storage.

To avoid confusion, function was renamed.

[Page 86](https://iconify.design/docs/icon-components/svelte/list-icons.html "Current Page.")

## Iconify for Svelte function: listIcons

This tutorial is part of [Iconify for Svelte functions tutorial](https://iconify.design/docs/#functions).

The function listIcons() lists loaded icons.

## Usage

The function has the following optional parameters:

- provider, string. Lists only icons from one API provider.
- prefix, string. Lists only icons with specific prefix. If prefix is set, provider must be set too (for Iconify public API provider value is empty string "").

The function returns an array of icon names.

## Examples

js
```
import { listIcons } from '@iconify/svelte';

// List all icons
console.log(listIcons());
```

Another example:

js
```
import { listIcons } from '@iconify/svelte';

// List all loaded Material Design Icons
console.log(listIcons('', 'mdi'));
// ["mdi:alert", "mdi:home", "mdi:account-box-outline", "mdi:eyedropper", "mdi:account-off", "mdi:account", "mdi:account-box", "mdi:account-cash"]
```

[Page 87](https://iconify.design/docs/icon-components/svelte/get-icon.html "Current Page.")

## Iconify for Svelte function: getIcon

This tutorial is part of [Iconify for Svelte functions tutorial](https://iconify.design/docs/#functions).

The function getIcon() retrieves icon data.

## Usage

The function has the following parameter:

- name, string. Icon name.

The function returns icon data in [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") format, null if icon is not available.

## Examples

js
```
import { getIcon } from '@iconify/svelte';

const data = getIcon('bi:check2-circle');
```

json
```
{
    "body": "<g fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M15.354 2.646a.5.5 0 0 1 0 .708l-7 7a.5.5 0 0 1-.708 0l-3-3a.5.5 0 1 1 .708-.708L8 9.293l6.646-6.647a.5.5 0 0 1 .708 0z\"/><path fill-rule=\"evenodd\" d=\"M8 2.5A5.5 5.5 0 1 0 13.5 8a.5.5 0 0 1 1 0a6.5 6.5 0 1 1-3.25-5.63a.5.5 0 1 1-.5.865A5.472 5.472 0 0 0 8 2.5z\"/></g>",
    "left": 0,
    "top": 0,
    "width": 16,
    "height": 16,
    "rotate": 0,
    "vFlip": false,
    "hFlip": false
}
```

Another example:

js
```
import { getIcon } from '@iconify/svelte';

const data = getIcon('cil:paper-plane');
```

json
```
{
    "body": "<path fill=\"currentColor\" d=\"M474.444 19.857a20.336 20.336 0 0 0-21.592-2.781L33.737 213.8v38.066l176.037 70.414L322.69 496h38.074l120.3-455.4a20.342 20.342 0 0 0-6.62-20.743zM337.257 459.693L240.2 310.37l149.353-163.582l-23.631-21.576L215.4 290.069L70.257 232.012L443.7 56.72z\"/>",
    "left": 0,
    "top": 0,
    "width": 512,
    "height": 512,
    "rotate": 0,
    "vFlip": false,
    "hFlip": false
}
```

Example with bad icon name, returns null:

js
```
import { getIcon } from '@iconify/svelte';

// null
const data = getIcon('no-such-icon');
```

## Svelte component example

This example renders <slot /> while icon is being loaded, emulating behavior of React component. Due to bug in Svelte, third party components cannot use <slot />, so Svelte component behaves a bit different than other components.

svelte
```
<script>
    import Icon, { getIcon, loadIcons } from '@iconify/svelte';
    import { onDestroy } from 'svelte';

    // Icon to render, string or object
    export let icon;

    // Icon data and cleanup function
    let data = null;
    let cleanup = null;
    let update = 0;

    $: {
        // Mention dummy variable to trigger re-running this code from loadIcons() callback
        update;

        // Get icon data
        data = typeof icon === 'object' ? icon : getIcon(icon);

        // Cancel previous callback
        if (cleanup) {
            cleanup();
            cleanup = null;
        }

        // Load icon
        if (data === null) {
            cleanup = loadIcons([icon], () => {
                // Trigger re-running of code above
                update ++;
            });
        }
    }

    // Cleanup
    onDestroy(() => {
        if (cleanup) {
            cleanup();
        }
    })
</script>

{#if data}
    <Icon icon={data} />
{:else}
    <slot />
{/if}
```

[Page 88](https://iconify.design/docs/icon-components/svelte/add-icon.html "Current Page.")

## Iconify for Svelte function: addIcon

This tutorial is part of [Iconify for Svelte functions tutorial](https://iconify.design/docs/#functions).

Function addIcon() adds one icon to the component's icon data storage.

## Usage

The function has the following parameters:

- name, string. Icon name.
- data, [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation"). Icon data.

The function returns boolean value: true on success, false if something is wrong with data.

## Examples

js
```
import { addIcon } from '@iconify/svelte';

addIcon('mdi:account-box', {
    body: '<path d="M6 17c0-2 4-3.1 6-3.1s6 1.1 6 3.1v1H6m9-9a3 3 0 0 1-3 3a3 3 0 0 1-3-3a3 3 0 0 1 3-3a3 3 0 0 1 3 3M3 5v14a2 2 0 0 0 2 2h14a2 2 0 0 0 2-2V5a2 2 0 0 0-2-2H5a2 2 0 0 0-2 2z" fill="currentColor"/>',
    width: 24,
    height: 24,
 });
```

Note: icons added by this function are not cached in localStorage and sessionStorage.

## API provider

API provider parameter can be used to load custom icons asynchronously without triggering API queries.

Each API provider has its own API endpoint, so if you are using custom API provider that component doesn't have configuration for (currently by default component has no API providers configured), the component will not attempt to load missing icons from an unknown API provider.

Example:

js
```
import { addIcon } from '@iconify/svelte';

addIcon('@custom:md:test', {
    body: '<path d="M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5z" fill="currentColor"/>',
    width: 24,
    height: 24,
 });
```

Code above adds the following icon:

- provider is "custom".
- prefix is "md".
- name is "test".

In component template this icon can be used like this:

jsx
```
<Icon icon="@custom:md:test" />
```

Syntax is similar to default icon syntax, but with API provider "@custom" in icon name. See [API providers documentation](https://iconify.design/docs/api/providers.html) for details.

## One icon

This function adds one icon in [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") format.

If you want to add several icons, or you have [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") data, use function [addCollection()](https://iconify.design/docs/icon-components/svelte/add-collection.html "addCollection() documentation") instead.

[Page 89](https://iconify.design/docs/icon-components/svelte/add-collection.html "Current Page.")

## Iconify for Svelte function: addCollection

This tutorial is part of [Iconify for Svelte functions tutorial](https://iconify.design/docs/#functions).

Function addCollection() adds an icon set to component's icon storage.

## Usage

The function has the following parameters:

- data, [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation"). Icon set data.
- provider, string. Optional API provider ID.

The function returns boolean value: true on success, false if something is wrong with data.

If an icon set has provider property and second parameter to addCollection() is passed, provider from second parameter overrides provider from an icon set.

## Examples

js
```
import { addCollection } from '@iconify/svelte';

addCollection({
    prefix: 'custom',
    icons: {
        icon1: {
            body: '<path d="M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5z" fill="currentColor"/>',
        },
    },
    width: 24,
    height: 24,
 });
```

js
```
import { addCollection } from '@iconify/svelte';

addCollection({
    prefix: 'mdi',
    icons: {
        'account-box': {
            body: '<path d="M6 17c0-2 4-3.1 6-3.1s6 1.1 6 3.1v1H6m9-9a3 3 0 0 1-3 3a3 3 0 0 1-3-3a3 3 0 0 1 3-3a3 3 0 0 1 3 3M3 5v14a2 2 0 0 0 2 2h14a2 2 0 0 0 2-2V5a2 2 0 0 0-2-2H5a2 2 0 0 0-2 2z" fill="currentColor"/>',
        },
        'account-cash': {
            body: '<path d="M11 8c0 2.21-1.79 4-4 4s-4-1.79-4-4s1.79-4 4-4s4 1.79 4 4m0 6.72V20H0v-2c0-2.21 3.13-4 7-4c1.5 0 2.87.27 4 .72M24 20H13V3h11v17m-8-8.5a2.5 2.5 0 0 1 5 0a2.5 2.5 0 0 1-5 0M22 7a2 2 0 0 1-2-2h-3c0 1.11-.89 2-2 2v9a2 2 0 0 1 2 2h3c0-1.1.9-2 2-2V7z" fill="currentColor"/>',
        },
        'account': {
            body: '<path d="M12 4a4 4 0 0 1 4 4a4 4 0 0 1-4 4a4 4 0 0 1-4-4a4 4 0 0 1 4-4m0 10c4.42 0 8 1.79 8 4v2H4v-2c0-2.21 3.58-4 8-4z" fill="currentColor"/>',
        },
        'home': {
            body: '<path d="M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5z" fill="currentColor"/>',
        },
    },
    width: 24,
    height: 24,
 });
```

Note: icons added by this function are not cached in localStorage and sessionStorage.

## API provider

API provider parameter can be used to specify that icon set belongs to the specific API provider.

It can also be used to load custom icons asynchronously without triggering API queries. Each API provider has its own API endpoint, so if you are using custom API provider that component doesn't have configuration for (currently by default component has no API providers configured), the component will not attempt to load missing icons from an unknown API provider.

Example:

js
```
import { addCollection } from '@iconify/svelte';

addCollection(
    // Icon set: prefix and icons
    {
        prefix: 'md',
        icons: {
            test: {
                body: '<path d="M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5z" fill="currentColor"/>',
            },
        },
        width: 24,
        height: 24,
    },
    // API provider
    'custom'
 );
```

Code above adds only one icon:

- provider is "custom".
- prefix is "md".
- name is "test".

In component template code this icon can be used like this:

jsx
```
<Icon icon="@custom:md:test" />
```

Syntax is similar to default icon syntax, but with API provider "@custom" in icon name. See [API providers documentation](https://iconify.design/docs/api/providers.html) for details.

## One icon

This function adds an entire icon set in [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") format.

If you want to add only once icon, and you have [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") data, use function [addIcon()](https://iconify.design/docs/icon-components/svelte/add-icon.html "addIcon() documentation") instead.

[Page 90](https://iconify.design/docs/icon-components/svelte/load-icons.html "Current Page.")

## Iconify for Svelte function: loadIcons

This tutorial is part of [Iconify for Svelte functions tutorial](https://iconify.design/docs/#functions).

The function loadIcons() retrieves icons from Iconify API.

When to use this function:

- To preload multiple icons that you will use later. This will make sure icon data is available when needed and it will load faster.
- If you need to get icon data as soon as it is available. For example, when rendering a custom component. However, if you need to load just one icon, there is also [loadIcon()](https://iconify.design/docs/icon-components/svelte/load-icon.html "loadIcon() documentation") that is easier to use.

This function is the most efficient way to preload icons that you know will be needed at some point. It loads icon data from Iconify API in bulk, reducing the number of queries.

It is safe to call the function multiple times with the same icon name, component will not load icon data from Iconify API twice. If you set a callback parameter, callback will be called correctly even if icon was loaded with different loadIcons() call, making sure callback is reliable.

## Usage

The function has the following parameters:

- icons, (string| [IconifyIconName](https://iconify.design/docs/icon-components/svelte/icon-name.html "IconifyIconName documentation"))\[\]. List of icons to load.
- callback, function. Optional callback to call. Callback is called not only when all icons have been retrieved, but also when part of icons have been retrieved.

The function returns function you can use to stop loading icons. It is needed when, for example, you are loading icons in a custom component, but the component's life cycle ended before icons have loaded, so you need to remove callback.

## Icons list

List of icons is an array. Each element can be a string, such as mdi:home or a [IconifyIconName](https://iconify.design/docs/icon-components/svelte/icon-name.html "IconifyIconName documentation") object.

## Callback

Optional callback has the following parameters:

- loaded, [IconifyIconName](https://iconify.design/docs/icon-components/svelte/icon-name.html "IconifyIconName documentation") \[\]. List of icons that have been loaded.
- missing, [IconifyIconName](https://iconify.design/docs/icon-components/svelte/icon-name.html "IconifyIconName documentation") \[\]. List of icons that are not available on API.
- pending, [IconifyIconName](https://iconify.design/docs/icon-components/svelte/icon-name.html "IconifyIconName documentation") \[\]. List of icons that are still loading.
- unsubscribe, function. Function to call to cancel loading. It is the same as result of loadIcons() call.

## IconifyIconName type

[IconifyIconName](https://iconify.design/docs/icon-components/svelte/icon-name.html "IconifyIconName documentation") is a simple object with the following properties, all properties are mandatory:

- provider, string. [API provider](https://iconify.design/docs/api/providers.html). For public Iconify API value is an empty string "".
- prefix, string. Icon set prefix.
- name, string. Icon name.

## Examples

Simple callback that loads one icon:

js
```
import { loadIcons } from '@iconify/svelte';

const iconName = 'mdi:home';
loadIcons([iconName], (loaded, missing, pending, unsubscribe) => {
    if (loaded.length) {
        console.log(
            \`Icon ${iconName} have been loaded and is ready to be renderered.\`
        );
        return;
    }

    if (missing.length) {
        console.log(\`Icon ${iconName} does not exist.\`);
        return;
    }

    if (pending.length) {
        // Pending icons list in this example is empty.
        // If you call loadIcons() with multiple icons, pending list might not be empty, but for one icon it is always empty.
        //
        // Callback is called when something changes, with 1 icon there can only be 2 type of changes: icon has loaded or icon is missing.
    }
 });
```

Async version of loadIcons():

js
```
import { loadIcons } from '@iconify/svelte';

/**
 * Function to load icons, returns Promise
 */
function loadTestIcons(icons) {
    return new Promise((fulfill, reject) => {
        loadIcons(icons, (loaded, missing, pending, unsubscribe) => {
            if (pending.length) {
                // Icons are pending, wait for all to load/fail
                //
                // If pending list is not empty, callback will be called
                // again when all icons are either loaded or missing
                return;
            }
            if (missing.length) {
                reject({
                    loaded,
                    missing,
                });
            } else {
                fulfill({
                    loaded,
                });
            }
        });
    });
 }

/**
 * Usage example in async function
 */
async function test() {
    // Wait for icons to load
    await loadTestIcons(['jam:info', 'cil:locomotive', 'cil:paper-plane']).catch(
        (err) => {
            console.error('Failed to load icons:', err.missing);
        }
    );

    // Do stuff with loaded icons
    console.log('Loaded!');
 }
test();
```

## Svelte component example

This example renders <slot /> while icon is being loaded, emulating behavior of React component. Due to bug in Svelte, third party components cannot use <slot />, so Svelte component behaves a bit different than other components.

svelte
```
<script>
    import Icon, { getIcon, loadIcons } from '@iconify/svelte';
    import { onDestroy } from 'svelte';

    // Icon to render, string or object
    export let icon;

    // Icon data and cleanup function
    let data = null;
    let cleanup = null;
    let update = 0;

    $: {
        // Mention dummy variable to trigger re-running this code from loadIcons() callback
        update;

        // Get icon data
        data = typeof icon === 'object' ? icon : getIcon(icon);

        // Cancel previous callback
        if (cleanup) {
            cleanup();
            cleanup = null;
        }

        // Load icon
        if (data === null) {
            cleanup = loadIcons([icon], () => {
                // Trigger re-running of code above
                update ++;
            });
        }
    }

    // Cleanup
    onDestroy(() => {
        if (cleanup) {
            cleanup();
        }
    })
</script>

{#if data}
    <Icon icon={data} />
{:else}
    <slot />
{/if}
```

If you want to load only one icon, there is also [loadIcon()](https://iconify.design/docs/icon-components/svelte/load-icon.html "loadIcon() documentation") that is easier to use.

[Page 91](https://iconify.design/docs/icon-components/svelte/load-icon.html "Current Page.")

## Iconify for Svelte function: loadIcon

This tutorial is part of [Iconify for Svelte functions tutorial](https://iconify.design/docs/#functions).

The function loadIcon() retrieves an icon from Iconify API.

It returns Promise instance, making it very easy to use in asynchronous code.

When to use this function:

- When you need to get icon data inside an asynchronous function.

When not to use this function:

- To preload multiple icons that you will use later. Use [loadIcons()](https://iconify.design/docs/icon-components/svelte/load-icons.html "loadIcons() documentation") instead.

It is safe to call function multiple times with the same icon name, component will not load icon data from Iconify API twice. If you pass string icon name as parameter, multiple calls of the function will return the same Promise instance.

## Usage

The function has the following parameter:

- icon, string| [IconifyIconName](https://iconify.design/docs/icon-components/svelte/icon-name.html "IconifyIconName documentation"). Name of the icon to load.

The function returns Promise instance, which returns [FullIconifyIcon](https://iconify.design/docs/libraries/utils/full-iconify-icon.html "FullIconifyIcon documentation") data for icon on success.

## IconifyIconName type

[IconifyIconName](https://iconify.design/docs/icon-components/svelte/icon-name.html "IconifyIconName documentation") is a simple object with the following properties, all properties are mandatory:

- provider, string. [API provider](https://iconify.design/docs/api/providers.html). For public Iconify API value is an empty string "".
- prefix, string. Icon set prefix.
- name, string. Icon name.

## Examples

Using Promise syntax:

js
```
import { loadIcon } from '@iconify/svelte';

const iconName = 'mdi:home';
loadIcon(iconName)
    .then((data) => {
        console.log(
            \`Icon ${iconName} have been loaded and is ready to be renderered.\`
        );
        console.log(data);
    })
    .catch((err) => {
        console.log(\`Icon ${iconName} does not exist.\`);
    });
```

Async/await syntax:

js
```
import { loadIcon } from '@iconify/svelte';

/**
 * Usage example in async function
 */
async function test() {
    try {
        const data = await loadIcon('mdi:home');
        console.log('Loaded home icon!');
    } catch (err) {
        console.error('Failed to load home icon');
    }
 }
test();
```

If you want to load multiple icons, see [loadIcons()](https://iconify.design/docs/icon-components/svelte/load-icons.html "loadIcons() documentation").

[Page 92](https://iconify.design/docs/icon-components/svelte/custom-loaders.html "Current Page.")

## Custom icon loaders

This tutorial is part of [Iconify for Svelte tutorial](https://iconify.design/docs/).

Functions setCustomIconLoader() and setCustomIconsLoader() are used to define custom icon loaders.

What is it for?

- To load icon data from custom sources.
- To modify icons, such as changing color or stroke width.

## Usage

Both functions have the same parameters, except for type of callback:

- callback, function. Callback that loads icons, can be synchronous or asynchronous function.
- prefix, string. Icon set prefix.
- provider, string. Icon set provider, optional.

Callback is a function that loads icon data.

Both synchronous and asynchronous (returns Promise instance) callbacks are supported.

Callbacks for both functions have similar parameters.

Parameters for setCustomIconLoader():

- name, string. Icon name.
- prefix, string. Icon set prefix.
- provider, string. Icon set provider.

Order of parameters is intentional: from most important to least important. If you have set loader for one prefix, you most likely only need name parameter.

The callback returns icon data as [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") or null on failure (or Promise of those types).

Callback for setCustomIconsLoader() is almost identical, except:

- First parameter is an array of icon names: string\[\].
- Callback returns an icon set as [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") or null on failure (or Promise of those types).

## Example

js
```
import { setCustomIconLoader, loadIcon } from "@iconify/svelte";

// Creates icon set "tabler-thin" that loads icons from Tabler Icons and makes them thinner
// Then you can use "tabler:angle" to render icon with default stroke, or "tabler-thin:angle" to render thinner icon
setCustomIconLoader(async (name) => {
  const data = await loadIcon(\`tabler:${name}\`);
  return data
    ? {
        ...data,
        body: data.body.replaceAll('stroke-width="2"', 'stroke-width="1"'),
      }
    : null;
 }, "tabler-thin");

// Fetches icon from custom server
// Icon data must be in IconifyIcon format
setCustomIconLoader(async (name) => {
  const response = await fetch(\`https://example.com/icons/${name}.json\`);
  if (!response.ok) {
    return null;
  }
  return await response.json();
 }, "custom-server");
```

Make sure loader is set before any icons are rendered, otherwise component might attempt to load icon from API and fail to render it.

[Page 93](https://iconify.design/docs/icon-components/svelte/build-icon.html "Current Page.")

## Iconify for Svelte function: buildIcon

This tutorial is part of [Iconify for Svelte functions tutorial](https://iconify.design/docs/#functions).

Function buildIcon() generates data used by icon component to render icon.

You can use this function to generate <svg> code.

## Usage

The function has the following parameters:

- icon, [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation"). Icon data.
- customisations. Optional customizations object.

The function returns object containing icon data, null if icon is not available.

You need icon data before you can use this function. See [getIcon()](https://iconify.design/docs/icon-components/svelte/get-icon.html "getIcon() documentation"), iconLoaded() and [loadIcon()](https://iconify.design/docs/icon-components/svelte/load-icon.html "loadIcon() documentation") functions.

## Result

Result object has the following properties:

- attributes, object. List of attributes for <svg> element.
- body, string. Icon contents.

The list of attributes does not include standard attributes: xmlns, xmlns:link. It also does not include attributes that are added by icon component: aria-hidden, focusable, role, class, style. It is up to you to decide what attributes you want to add.

## Customizations

Second parameter is optional icon customizations. Available customizations:

IconifyIconCustomisations type is an object with the following optional properties, split into several categories.

Vertical alignment:

- inline, boolean. If enabled, adds vertical-align: -0.125em to style, rendering icon below baseline. The default value is false.

Icon dimensions:

- width, string|number|null. Icon width. The default value is null.
- height, string|number|null. Icon height. The default value is null.

There are several keywords that can be used for width and height:

- "auto" sets dimension to original icon's dimensions found in viewBox.
- "unset" and "none" remove dimensions from SVG.

If neither of dimensions is set, height defaults to "1em".

It is enough to set one dimension, such as height. Another dimension will be calculated using icon's width/height ratio. In the case of keywords, another dimension will be set to the same keyword.

Transformations:

- hFlip, boolean. Flip icon horizontally. The default value is false.
- vFlip, boolean. Flip icon vertically. The default value is false.
- rotate, number. Rotation in 90 degrees increments. The default value is 0.

For more details about dimensions see [icon dimensions documentation](https://iconify.design/docs/dimensions.html).

For more details about transformations see [icon transformations documentation](https://iconify.design/docs/transform.html).

## Example

js
```
import { buildIcon } from '@iconify/svelte';
import biStopwatch from '@iconify-icons/bi/stopwatch';

buildIcon(biStopwatch, {
    hFlip: true,
    height: '24',
 });
```

json
```
{
    "attributes": {
        "width": "24",
        "height": "24",
        "viewBox": "0 0 16 16"
    },
    "body": "<g transform=\"translate(16 0) scale(-1 1)\"><g fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M8 15A6 6 0 1 0 8 3a6 6 0 0 0 0 12zm0 1A7 7 0 1 0 8 2a7 7 0 0 0 0 14z\"/><path fill-rule=\"evenodd\" d=\"M8 4.5a.5.5 0 0 1 .5.5v4a.5.5 0 0 1-.5.5H4.5a.5.5 0 0 1 0-1h3V5a.5.5 0 0 1 .5-.5zM5.5.5A.5.5 0 0 1 6 0h4a.5.5 0 0 1 0 1H6a.5.5 0 0 1-.5-.5z\"/><path d=\"M7 1h2v2H7V1z\"/></g></g>"
}
```

[Page 94](https://iconify.design/docs/icon-components/svelte/replace-ids.html "Current Page.")

## Iconify for Svelte function: replaceIDs

This tutorial is part of [Iconify for Svelte functions tutorial](https://iconify.design/docs/#functions).

The function replaceIDs() finds IDs in SVG and replaces them with unique random IDs.

This function is meant to be used when you generate <svg> element yourself using data provided by [getIcon()](https://iconify.design/docs/icon-components/svelte/get-icon.html "getIcon() documentation").

## Usage

The function has the following parameters:

- data, string. Icon content.
- prefix, string|function. Optional prefix for generated IDs. It can be a string or a callback that returns string.

The function returns string containing icon data with IDs replaced.

## Example

This is a rather useless example. In real code, this function is used when generating SVG code samples in Icon Finder, which is not as simple as this example.

js
```
import { replaceIDs, getIcon } from '@iconify/svelte';

// Get icon data
const data = getIcon('carbon:deploy');

// Get content
const body = replaceIDs(data.body);

console.log('Icon content:', body);
```

[Page 95](https://iconify.design/docs/design/ "Current Page.")

## Iconify for designers

For designers, Iconify ecosystem offers several ways to easily import icons in various design tools.

Available options:

- Figma users can install [Iconify plug-in for Figma](https://iconify.design/docs/figma/).
- Penpot users can install [Iconify plug-in for Penpot](https://iconify.design/docs/penpot/).
- Sketch users can install [Iconify plugin-in for Sketch](https://iconify.design/docs/sketch/).
- For other design tools, or if you are experiencing issues with plug-ins listed above, you can copy and paste SVG from one of sources listed below.

## Browse icons

You can browse and search more than 60k open source icons at one of the following websites:

- [Iconify icon sets](https://icon-sets.iconify.design/) - official website.
- [Icones](https://icones.js.org/) - alternative website created by Anthony Fu.

Find icon you want, select it, copy SVG to clipboard, paste it to your favorite design tool.

Possible issues:

- Some design tools do not support currentColor. Set icon color to black before copying code sample.
- Almost all image editing software do not support SVG 2 animations. Animated icons will be imported without animations, sometimes rendered weirdly.

[Page 96](https://iconify.design/docs/design/figma/ "Current Page.")

## Iconify for Figma

With the Iconify plugin for Figma you can import over 275,000 vector icons to Figma.

It is completely free!

Unlike other plugins that offer many icons, but require payment to use SVG, Iconify always imports icons as SVG. Iconify project is open source and offers only open source icon sets.

Plugin remembers the last page you have visited, making it easy to continue searching or browsing icons.

For visitors that have small monitors, the plugin offers compact mode. Button to toggle compact mode is in the top right corner of the plugin window.

## Installation

You can install Iconify for Figma from [Iconify plugin page](https://www.figma.com/community/plugin/735098390272716381/Iconify).

## Usage

In Figma menu select "Plugins", then select "Iconify".

Browse or search icons, select any icon, click "Import Icon" button or drag icon to the Figma document.

### Detailed instructions

After opening the plugin, you will see the main page:

![Iconify for Figma: main page](https://iconify.design/assets/images/plugins/figma41-icon-sets.png)

Click any icon set or search icons.

When you click an icon set, the plugin will show you all icons in that icon set. You can filter icons by categories (if the current icon set has them), search icons.

To show more icons, simply scroll the icons list.

![Iconify for Figma: icon set](https://iconify.design/assets/images/plugins/figma41-icon-set.png)

You can also search all icon sets for icons. For example, search for "gear":

![Iconify for Figma: icon search results](https://iconify.design/assets/images/plugins/figma41-search-compact.png)

The plugin will show you all icons that match your keyword.

When you hover any icon, you will see a button to show more information.

If you hover it, you will see the icon name. If you click it, you will see:

- Icon size.
- Author information and license (only in search results).
- Buttons to quickly import icon as a component or frame and to get code sample.

You can import icon by:

- Using quick import buttons from icon tooltip.
- Dragging icon from plugin window to Figma document.
- Clicking icon to select it, importing it using buttons in plugin window footer.

### Advanced import

When you select an icon, it will appear in page footer with options:

![Iconify for Figma: icon code](https://iconify.design/assets/images/plugins/figma41-icon-set-selected2.png)

For icons that do not have a hardcoded palette, color picker is available, showing recently used colors and available color styles:

![Iconify for Figma: color picker](https://iconify.design/assets/images/plugins/figma41-color-picker.png)

### Compact mode

If you have limited window space available, you can make the plugin window even smaller.

Click the compact window button in the top right corner and the plugin window will become much smaller:

![Iconify for Figma: compact mode](https://iconify.design/assets/images/plugins/figma41-icon-sets-compact.png)

## Support and feedback

Feedback is welcome.

See "feedback" page in the plugin or visit [support page on website](https://iconify.design/support/).

[Page 97](https://iconify.design/docs/design/penpot/ "Current Page.")

## Iconify for Penpot

With the Iconify plugin for Penpot you can import over 275,000 vector icons to Penpot.

It is completely free!

Unlike other plugins that offer many icons, but require payment to use SVG, Iconify always imports icons as SVG. Iconify project is open source and offers only open source icon sets.

Plugin remembers the last page you have visited, making it easy to continue searching or browsing icons.

## Installation

Plugin is available at [Iconify for Penpot GitHub repository](https://github.com/iconify/iconify-penpot/).

To install plugin, open plugin manager in Penpot and add the following URL:

```
https://penpot.iconify.design/manifest.json
```

## Usage

In Penpot menu select "Plugins", then select "Iconify".

Browse or search icons, select any icon, click "Import Icon" button or drag icon to the Penpot document.

### Themes

Plugin supports both light and dark themes.

To change theme, change theme in Penpot settings.

Screenshots below demonstrate both themes.

### Detailed instructions

After opening the plugin, you will see the main page:

![Iconify for Penpot: main page](https://iconify.design/assets/images/plugins/penpot-index2-light.png)

Click any icon set or search icons.

When you click an icon set, the plugin will show you all icons in that icon set. You can filter icons by categories (if the current icon set has them), search icons.

To show more icons, simply scroll the icons list.

![Iconify for Penpot: icon set](https://iconify.design/assets/images/plugins/penpot-tabler-dark.png)

You can also search all icon sets for icons. For example, search for "home":

![Iconify for Penpot: icon search results](https://iconify.design/assets/images/plugins/penpot-home-light.png)

The plugin will show you all icons that match your keyword.

When you hover any icon, you will see a button to show more information.

If you hover it, you will see the icon name. If you click it, you will see:

- Icon size.
- Author information and license (only in search results).
- Buttons to import icon and to get code sample.

You can import icon by:

- Using quick import buttons from icon tooltip.
- Dragging icon from plugin window to Penpot document.
- Clicking icon to select it, importing it using buttons in plugin window footer.

### Advanced import

When you select an icon, it will appear in page footer with options:

![Iconify for Penpot: icon code](https://iconify.design/assets/images/plugins/penpot-icon-light.png)

For icons that do not have a hardcoded palette, color picker is available, showing recently used colors:

![Iconify for Penpot: color picker](https://iconify.design/assets/images/plugins/penpot-color-light.png)

## Support and feedback

Feedback is welcome.

See "feedback" page in the plugin or visit [support page on website](https://iconify.design/support/).

[Page 98](https://iconify.design/docs/design/sketch/ "Current Page.")

## Iconify for Sketch

Want to add icons to your designs?

Iconify for Sketch got you covered. One plugin offers over 275,000 icons from 200+ icon sets.

With Sketch plug-in you can:

- Browse icon sets.
- Search icon sets.
- Import any icon as vector shape to Sketch document.

It is completely free! Unlike other plugins that offer many icons, but require payment to use SVG, Iconify always imports icons as SVG. Iconify project is open source and offers only open source icon sets.

## Installation

Go to [plug-in releases page](https://github.com/iconify/iconify-sketch/releases), download the latest file, unpack it, open iconify.sketchplugin in Finder. Finder should launch Sketch that should install plug-in.

If plug-in installation fails, copy iconify.sketchplugin to ~/Library/Application Support/com.bohemiancoding.sketch3/Plugins/.

## Usage

In Sketch menu select "Plug-ins", then "Iconify" or press Ctrl+Shift+I.

Browse or search icons, select any icon, click "Import" button. Plug-in will import icon to your current project.

## Screenshots

Importing icon:

![Iconify for Sketch: footer](https://iconify.design/assets/images/plugins/sketch_footer.png)

Big choice of "home" icons:

![Iconify for Sketch: search results](https://iconify.design/assets/images/plugins/sketch_home_grid.png)

Collections list:

![Iconify for Sketch: browse collections](https://iconify.design/assets/images/plugins/sketch_index.png)

Importing multiple icons:

![Iconify for Sketch: browsing icons set](https://iconify.design/assets/images/plugins/sketch_select_multiple.png)

## Available icons

You can browse and import iver 275k open source icons hosted on [Iconify API](https://iconify.design/api/) to Sketch projects.

## Source code

All source code is available at [Iconify for Sketch repository](https://github.com/iconify/iconify-sketch).

To build it, install all necessary dependencies and run npm run build. Build script will generate iconify.sketchplugin that you can install.

[Page 99](https://iconify.design/docs/icons/ "Current Page.")

## Icons

There are over 275,000 icons available from more than 200 open source icon sets, which you can use in your projects.

This section of Iconify documentation explains:

- Where to get raw data for icons to use in your projects.
- How icons are organised.
- How icons are handled in Iconify (imported, cleaned up, updated).

This section is only about icon data, it does not explain how to use icons in your project, for that [see different section of documentation](https://iconify.design/docs/usage/).

## Icon data

How icons are organised:

- Icons are grouped in icon sets. Each icon set contains icons from the same source.
- Icon sets are exported in easy to use JSON format, which includes icons and extra metadata.
- All icon sets are stored in one main GitHub repository, also available as NPM packages.

See [how to get icon data](https://iconify.design/docs/icon-data.html) for a list of packages and repositories.

You can use that data to create your own components, plugins, generate icons in various formats.

Iconify ecosystem offers [different components and plugins to render icons](https://iconify.design/docs/usage/) and [tools to work with icons](https://iconify.design/docs/libraries/).

### What makes Iconify different?

What makes Iconify different from other projects that consolidate icons?

- All icon sets are automatically kept up to date.
- Icons are not just dumped as is, they pass strict validation, cleanup and optimisation process to make sure all icons from all icon sets can be used in the same consistent way.
- Icon data is available in easy to use format, encouraging developers to create their own components that render it.

See [icon clean up and validation process](https://iconify.design/docs/icon-basics.html) article for more details. It also describes icon naming convention used in Iconify.

## Icon sets

Icons in Iconify are organised in icon sets.

Each icon set has icons from the same author(s) following the same theme.

See [icon set basics](https://iconify.design/docs/icon-set-basics.html) for more details.

Icon sets are automatically kept up to date, checking for updates several times a week.

## Custom icons

You can also use Iconify with custom icons.

This allows you to reuse components and plugins from Iconify ecosystem with your icons instead of creating your own.

See [building custom icon sets](https://iconify.design/docs/custom.html) for details.

## Add an icon set

If you have created an open source icon set that you want to add to Iconify, please [follow this guide](https://iconify.design/docs/articles/add-icon-set/).

[Page 100](https://iconify.design/docs/icons/icon-data.html "Current Page.")

## Icon data

There are over 275,000 open source icons available, which you can use in your projects.

All these icons are:

- Open source.
- Validated and cleaned up.
- Automatically kept up to date.

## Where to get them?

To make it easier for developers to work with icons, there are several ways to get data for icons.

The main source of icon sets is [iconify/icon-sets](https://github.com/iconify/icon-sets) repository on GitHub. Icon sets are stored in [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") format.

In addition to git repository, icon sets are available as:

- Big NPM package @iconify/json, which is identical to git repository.
- Packagist package iconify/json for PHP developers.
- NPM package @iconify/collections that contains only list of available icon sets (file collections.json from big package).
- Smaller NPM packages @iconify-json/\* that contain only one icon set per package in [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") format.
- [Iconify API](https://iconify.design/docs/api/) that can be used to retrieve icon data on demand.

Below is a description for each of those sources.

### All icons

You can get the latest version of package from the following sources:

- From GitHub: [https://github.com/iconify/icon-sets](https://github.com/iconify/icon-sets).
- From NPM: @iconify/json.
- From Packagist: iconify/json.

This package is big and might take a while to download.

See [big icons package documentation](https://iconify.design/docs/all.html) for list of files, functions and usage examples.

### Icon set list

If you want to get a list of all available icon sets, it is:

- included in big package listed above as collections.json.
- available icon sets is available as NPM package @iconify/collections.

See [icon sets list](https://iconify.design/docs/collections.html) for more details.

### Individual icon sets

Each icon set is also published as a separate NPM package @iconify-json/{prefix} (where "{prefix}" is an icon set prefix).

See [split icon sets packages](https://iconify.design/docs/json.html) for more details.

### API

[Iconify API](https://iconify.design/api/) is very different from all other sources.

Other sources are various packages you can use during build time. Using them requires knowing which icons you are using, so build tools would extract data only for icons that you need. You cannot use them at run time because they are too big.

API is intended to be used when you don't know which icons you need. [Several icon components](https://iconify.design/docs/icon-components/) retrieve icon data from API as needed, then render icon.

There are several downsides of using API to get icon data:

- Requires a visitor to be online. Not usable in offline applications.
- Relies on third party service, though you can host your own Iconify API instances.
- Icon components contain overhead: code that downloads icon data on demand.

API also provides a list of available icon sets and icons, which can be used to build applications for browsing and searching icons, such as various plugins and icon pickers.

### SVG

There are no special packages for SVG files, but you can generate them yourself using [Iconify Tools](https://iconify.design/docs/libraries/tools/).

In Iconify Tools examples, you can find a [simple script that exports all icons as SVGs](https://iconify.design/docs/libraries/tools/examples/export-svg.html).

[Page 101](https://iconify.design/docs/icons/all.html "Current Page.")

## Iconify icon sets package

You can get the latest version of open source icon data from the following sources:

- From GitHub: [https://github.com/iconify/icon-sets](https://github.com/iconify/icon-sets)
- From NPM: @iconify/json
- From Packagist: iconify/json

You can also get smaller packages, but it is not covered in this document. See [icon data documentation](https://iconify.design/docs/icon-data.html).

## Contents

Package contains:

- List of icon sets in collections.json.
- Icon sets in json/{prefix}.json, where "{prefix}" is icon set prefix, such as json/mdi-light.json.
- Helper functions for PHP and Node.js
- Misc files, such as package definition files, README, human-readable list of icon sets.

## Icon sets list

Icon sets list is stored in collections.json.

Contents are a simple object, where key is icon set prefix, value is icon set information in [IconifyInfo](https://iconify.design/docs/types/iconify-json-metadata.html "IconifyInfo documentation") format. Information includes icon set name, author information, license, number of files and 3 sample files to display.

Additionally, collections.md contains the same data, but in human-readable format.

## Icon sets

Each icon has is stored in one file, located in directory json/. File name matches icon set prefix, which you can find as key in icon sets list in collections.json.

Contents are stored in [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") format.

Icon set files contain all icon set data, including info and metadata. If you want to get minimal version without extra stuff, use [small packages instead](https://iconify.design/docs/json.html).

## Maintenance

Package is automatically updated every few days, so it always includes the latest icons. If you want to use the latest icons, all you have to do is keep dependencies in your project up to date.

If you are using [Iconify API](https://iconify.design/api/), you do not need to do anything because changes are automatically pushed to API servers within minutes after being published.

## Reading data

For reading icon sets, you can use:

- [Iconify Utils](https://iconify.design/docs/libraries/utils/) for JavaScript.
- [Iconify JSON Tools](https://github.com/iconify/json-tools.php) for PHP, deprecated and unmaintained.

To use icon set packages with Iconify Utils, follow these steps:

- Read icons data from JSON file for specific icon set. If you are using file system functions that return a string, convert it to [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") object using JSON.parse().
- Extract data. To extract multiple icons, use [getIcons()](https://iconify.design/docs/libraries/utils/get-icons.html "getIcons() documentation"), to extract one icon use [getIconData()](https://iconify.design/docs/libraries/utils/get-icon-data.html "getIconData() documentation"). Click function links for code samples.

## Helper functions

Package contains simple helper functions for Node.js and PHP.

### Node.js functions

In Node.js version of @iconify/json functions are asynchronous:

- lookupCollections() returns list of collections. It is a simple object, where key is prefix, value is information about icon set in [IconifyInfo](https://iconify.design/docs/types/iconify-json-metadata.html "IconifyInfo documentation") format.
- lookupCollection(prefix) loads an icon set. Result is [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") object.

All functions listed above are asynchronous and require using await before function name (see example below).

There are also few synchronous functions:

- locate(prefix) returns location of JSON file for an icon set.

### PHP functions

PHP is a synchronous language, so functions for PHP are identical for versions 1 and 2.

Use Iconify\\IconsJSON\\Finder class that has the following static functions:

- collections() returns list of collections. It is a simple object, where key is prefix, value is information about icon set. For version 1 data is in [LegacyIconifyInfo](https://iconify.design/docs/types/iconify-json-metadata.html "LegacyIconifyInfo documentation") format, for version 2 data is in [IconifyInfo](https://iconify.design/docs/types/iconify-json-metadata.html "IconifyInfo documentation") format.
- locate(prefix) returns location of JSON file for an icon set.
- rootDir() returns location of root directory of package.

### Example

Example:

js
```
// Installation: npm install --save @iconify/json
import { lookupCollections, locate } from '@iconify/json';

 (async () => {
    // Get list of all icon sets
    const iconSets = await lookupCollections();
    const prefixes = Object.keys(iconSets);
    console.log(\`Available ${prefixes.length} icon sets\`);

    // List icon sets in format: "prefix: name (total icons)"
    console.log(
        prefixes
            .map((prefix) => {
                const item = iconSets[prefix];
                // prefix: name (total icons)
                return prefix + ': ' + item.name + ' (' + item.total + ' icons)';
            })
            .join('\n')
    );

    // Get location of Taber Icons JSON file
    const tabler = locate('tabler');
    console.log('Tabler icons JSON file is located at:', tabler);
 })();
```

php
```
<?php
require './vendor/autoload.php';

// Installation: composer require iconify/json
use Iconify\IconsJSON\Finder;

// Get list of all icon sets
$iconSets = Finder::collections();
$prefixes = array_keys($iconSets);
echo 'Available ', count($prefixes), " icon sets\n";

// List icon sets in format: "prefix: name (total icons)"
echo implode("\n", array_map(function ($prefix) use ($iconSets) {
    $item = $iconSets[$prefix];
    return $prefix . ': ' . $item['name'] . ' (' . $item['total'] . ' icons)';
 }, $prefixes)), "\n";

// Get location of Taber Icons JSON file
$tabler = Finder::locate('tabler');
echo 'Tabler icons JSON file is located at: ', $tabler, "\n";
```

These helper functions only list and locate icon sets.

For reading icon sets, you can use [Iconify Utils](https://iconify.design/docs/libraries/utils/).

## Adding icon sets

Do you know a good open source icon set that is missing in Iconify icon sets? [Open an issue on GitHub](https://github.com/iconify/icon-sets/issues) to request to add it to Iconify icon sets.

## Licences

All icon sets available in Iconify collections are released under free or open source licence, which allows redistribution. See each icon set's info for details.

[Page 102](https://iconify.design/docs/icons/collections.html "Current Page.")

## Available icon sets list

If you are not using [full icon sets package](https://iconify.design/docs/all.html), which contains collections.json, you might need to know list of available open source icon sets.

There are several ways to get it:

- From @iconify/collections NPM package.
- [From Iconify API](https://iconify.design/api/collections.html).

In @iconify/collections and full icon sets package you'll find collections.json with list of all icon sets.

## Structure

Data is stored as an object, where key is icon set prefix, value is icon set information in [IconifyInfo](https://iconify.design/docs/types/iconify-json-metadata.html "IconifyInfo documentation") format.

## Import

If you are using @iconify/collections package, you can import icon sets list directly from @iconify/collections/collections.json as default import or use named import:

js
```
import { collections } from '@iconify/collections';
```

Code above uses JSON modules, which does not work with outdated version of Node.js. If you are using older version of Node, importing JSON files requires running script with "--experimental-json-modules" flag.

Alternatively, for older versions of Node.js you can use require():

js
```
const collections = require('@iconify/collections/collections.json');
```

[Page 103](https://iconify.design/docs/icons/json.html "Current Page.")

## Individual icon sets

For developer's convenience, [full icon sets package](https://iconify.design/docs/all.html) is also available as smaller packages, one package per icon set.

## Packages

Packages are published as @iconify-json/{prefix}, where "{prefix}" is icon set prefix.

These packages are available only on NPM. They are automatically generated from [big icon sets package](https://iconify.design/docs/all.html) whenever it is updated.

## Contents

Unlike full package, where all data for icon set is stored in one file, individual icon sets split data in several files, so you can load only data you need:

- icons.json contains icon set in [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") format, without any metadata.
- info.json contains icon set information in [IconifyInfo](https://iconify.design/docs/types/iconify-json-metadata.html "IconifyInfo documentation") format.
- chars.json contains characters map, if exists in [IconifyChars](https://iconify.design/docs/types/iconify-json-metadata.html#chars "IconifyChars documentation") format. File might not exist in some icon sets.
- metadata.json contains metadata in [IconifyMetaData](https://iconify.design/docs/types/iconify-json-metadata.html#iconify-categories "IconifyMetaData documentation") format: categories, themes. File might not exist in some icon sets.

You can import icon set using named import from package, like this:

js
```
import { icons as mdiIcons } from "@iconify-json/mdi";
import { icons as mdiLightIcons } from "@iconify-json/mdi-light";
```

Code samples above use JSON modules. It works fine when using bundlers or when using CommonJS. When using ES modules, older versions of Node.js require running script with "--experimental-json-modules" flag.

If you are using older Node.js and cannot import JSON files, you can use require():

js
```
const mdiIcons = require("@iconify-json/mdi/icons.json");
const mdiLightIcons = require("@iconify-json/mdi-light/icons.json");
```

## Creating packages

If you want to create a package for your icon set, see [exportJSONPackage()](https://iconify.design/docs/libraries/tools/export/json-package.html "exportJSONPackage() documentation") of [Iconify Tools](https://iconify.design/docs/libraries/tools/).

## Difference from big icon sets package

In [big icon sets package](https://iconify.design/docs/all.html), all JSON files contain an entire icon set: icon data, information, metadata (categories, themes), characters map.

In small packages that data is split into several files, as described above. If you only want icon data, it is better to read icons.json from multiple small packages because they are smaller.

## Icon sets list

If you need to get list of available open source icon sets, see [icon sets list package](https://iconify.design/docs/collections.html).

## Reading data

For reading icon sets, you can use:

- [Iconify Utils](https://iconify.design/docs/libraries/utils/) for JavaScript.
- [Iconify JSON Tools](https://github.com/iconify/json-tools.php) for PHP (deprecated).

To use icon set packages with Iconify Utils, follow these steps:

- Read icons data. If you are using file system functions that return a string, convert it to [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") object using JSON.parse().
- Extract data. To extract multiple icons, use [getIcons()](https://iconify.design/docs/libraries/utils/get-icons.html "getIcons() documentation"), to extract one icon use [getIconData()](https://iconify.design/docs/libraries/utils/get-icon-data.html "getIconData() documentation"). Click function links for code samples.

[Page 104](https://iconify.design/docs/icons/icon-basics.html "Current Page.")

## Icons Cleanup

One of goals of Iconify project is to make icons easy to use.

This is not as simple as running icons through popular optimisation tools. Icon parsing in Iconify is very strict and process is much more invasive.

Icons are modified, so they can be used the same way regardless of icon set.

## What exactly is done?

Each icon is:

- Validated (see below).
- Cleaned up and optimised (see below).
- Palette is fixed to either contain currentColor or hardcoded palette.
- If needed, icons are renamed to follow Iconify naming convention (see below).

## Naming convention

To make icons easy to use regardless of their source, all icons follow the same naming convention.

Allowed characters in icon names are "a-z", numbers and "-". Hyphen cannot be used at start or end of name, 2 hyphens in a row "--" are not allowed.

Examples of valid icon names: "home-outline", "1st-place-medal", "camera-with-flash".

## Validation

When icons are imported and validated, icons that contain any of the following are not allowed:

- Scripts and event listeners. They can be harmful or badly coded, thus they do not belong in public icons.
- Raster images. They don't scale, so they do not belong in vector icons.
- External resources. Icon should not rely on something hosted elsewhere.
- Text. Texts are rendered differently in different browsers and operating systems. Icons should look identical to all visitors. Convert text to shapes.

Additionally, everything that does not affect icon rendering is removed. Many bad editors leave a lot of junk code in generated SVG, all of that is removed.

This is done during import process for open source icon sets using [Iconify Tools](https://iconify.design/docs/libraries/). Custom icon sets might not follow the same guidelines.

## Clean up and optimisation

Clean up and optimisation process removes all unnecessary code, making icon as small as possible, without breaking icon.

For more details about icon cleanup, see [icons clean up process](https://iconify.design/docs/articles/cleaning-up-icons/).

## Palette

Palette is always checked and fixed if necessary.

What exactly is done depends on type of icon.

There are 2 types of icons:

- Icons with hardcoded palette, such as emojis. Colors cannot be changed.
- Monotone icons. They have only one color that can be changed.

What is the difference?

### Hardcoded palette

Colors in icons with hardcoded palette cannot be changed.

Examples:

[twemoji:clapper-board](https://icon-sets.iconify.design/twemoji/clapper-board/)

[twemoji:loudspeaker](https://icon-sets.iconify.design/twemoji/loudspeaker/)

In CSS these icons are used as background images.

Palette in such icons is kept as is.

### Monotone icons

All monotone icons are modified to use currentColor for color.

This makes it easy to change icon color by changing text color in CSS.

Examples:

[bi:bell-fill](https://icon-sets.iconify.design/bi/bell-fill/)

[line-md:beer-alt-twotone-loop](https://icon-sets.iconify.design/line-md/beer-alt-twotone-loop/)

[mdi:material-design](https://icon-sets.iconify.design/mdi/material-design/)

Hover samples above to see color change.

Why not fill? Main reason is because many icons use stroke for color. Using fill to set color is bad practice because it limits your icons to only icons that use fill. It also prevents icons from being used as mask images because background color cannot be set to fill color.

In CSS these icons are used as mask images, see [using SVG in CSS](https://iconify.design/docs/usage/css/) for details.

#### Do not set fill!

Some icon sets recommend changing color by changing fill, but you should never do that with Iconify!

This is a very bad practice because not all icons use fill. Many icons use stroke, but you cannot change stroke because it would add stroke to icons that do not have stroke.

To avoid all that mess, Iconify changes color in monotone icons to currentColor, so you can change icon color by changing text color, regardless of how icon is structured.

### Mixing currentColor and custom colors

While it is possible to mix monotone and hardcoded palette, it is a very bad idea. Icon with mix of currentColor and hardcoded colors is unusable because:

- It cannot be used in CSS. If it is used as a background image, currentColor becomes black. If it is used as a mask image, custom palette disappears.
- It works only with a specific color scheme, usually designed only for white background.

Therefore, icons with mixed palette are not allowed in Iconify open source icon sets repository.

## Format

Icons are stored converted to [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") format, then stored in icon sets in [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") format.

Data is stored in easy to use JSON files.

### Custom type

Why is icon stored in custom [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") type instead of SVG?

Format splits icon attributes for <svg> element and content. This it makes it easy to alter SVG without parsing XML: resize, change viewBox, render as components without parsing JSX, append/prepend shapes to icon, etc.

## Icon sets

Multiple icons are stored in an icon set. See [icon sets documentation](https://iconify.design/docs/icon-set-basics.html) for details.

[Page 105](https://iconify.design/docs/icons/icon-set-basics.html "Current Page.")

## Icon Sets

What are icon sets?

Icon set is a set of icons, created by the same author or group of authors, published with the same name and license.

## Examples

Several examples of icon sets:

- [Material Design Icons](https://icon-sets.iconify.design/mdi/)
- [Material Design Icons Light](https://icon-sets.iconify.design/mdi-light/)
- [Tabler Icons](https://icon-sets.iconify.design/tabler/)
- [Twitter Emoji](https://icon-sets.iconify.design/twemoji/)

All icons in an icon set must have the following in common:

- Same license. License is per icon set, not per icon.
- Be either monotone or have hardcoded palette. Only one type of icons is stored in one icon set. See [icon basics](https://iconify.design/docs/icon-basics.html).

Additionally, icons in open source icon sets have the following in common:

- Icons use the same design principles: grid, padding.
- Icons thematically fit together.

## Format

In Iconify icons are not stored one by one as SVG, they are stored as icon sets in an easy to read custom JSON format, which uses [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") type.

Advantages of using [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") to store icon sets:

- One file per icon set instead of many SVG files.
- Easy to read, supported by all programming languages.
- Stores only content of icon, without <svg> element. This makes it easy to manipulate icons without parsing XML, add custom attributes to <svg>, use framework native code to create SVG element in frameworks like React.
- Stores metadata, such as icon set author information, license, categories and themes used to filter icons, used when browsing available icons.
- Prevents duplication with aliases, which support basic transformations: flip and 90/180/270 degrees rotations. For example, instead of designing arrow-left, you can design only arrow-right and create an alias for it with horizontal flip.

## Naming

Each icon set has a prefix. It is unique for each icon set.

Prefix naming rules are the same as icon naming rules: allowed characters are "a-z", numbers and "-". Hyphen cannot be used at start or end of name, 2 hyphens in a row "--" are not allowed.

Examples of valid prefixes: "mdi", "mdi-light", "fluent-emoji-flat".

## Functions

To parse icon sets, [Iconify Utils](https://iconify.design/docs/libraries/utils/) offers the following functions:

- [parseIconSet()](https://iconify.design/docs/libraries/utils/parse-icon-set.html "parseIconSet() documentation") parses an entire icon set, calling custom function for every icon.
- [getIconData()](https://iconify.design/docs/libraries/utils/get-icon-data.html "getIconData() documentation") extracts data for an icon in [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") format.

To create convert icons to icon sets, use [Iconify Tools](https://iconify.design/docs/libraries/tools/).

[Page 106](https://iconify.design/docs/icons/custom.html "Current Page.")

## Custom icon sets

You can also use Iconify with custom icons.

Most icon components and plugins support custom icon sets. The only exception are plugins that are not meant to work with custom icon sets, such as [Iconify plugin for Figma](https://iconify.design/docs/design/figma/).

## Format

How custom icon sets are handled depends on your use case.

[All tools in Iconify ecosystem](https://iconify.design/docs/usage/) work with [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") format.

Some icon components and plugins that are designed to work in Node.js (server side rendering or works with bundlers) can import individual SVG files, but usually they convert icons to [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") format.

## Import tools

Importing custom icon sets can be done at build time in Node.js environment.

It is done with [Iconify Tools](https://iconify.design/docs/libraries/tools/) package.

Typical import process:

- Import icons. There are [various import functions](https://iconify.design/docs/libraries/tools/import/). They create unparsed icon set.
- [Cleaning up imported icons](https://iconify.design/docs/libraries/tools/icon/cleanup.html).
- For monotone icon sets [parsing colors](https://iconify.design/docs/libraries/tools/icon/colors.html) to make sure all icons use currentColor.
- [Export icon set](https://iconify.design/docs/libraries/tools/icon-set/export.html) to [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation").

See [Iconify Tools code examples](https://iconify.design/docs/libraries/tools/examples/) for code samples.

## Using custom icon sets

Usage depends on where you want to use it. See documentation of icon component you want to use icons with.

If icon component you want to use loads icon data on demand, you probably want to [set up your own Iconify API](https://iconify.design/docs/api/hosting-js/) to host custom icon sets.

[Page 107](https://iconify.design/docs/articles/add-icon-set/ "Current Page.")

## How to add icon set to Iconify

If you have created an icon set, please consider sharing it with Iconify community.

## Benefits

What are the benefits of publishing an icon set to Iconify?

- Icons become available to thousands of users that [use projects that get icon data from Iconify](https://iconify.design/docs/usage/).
- Iconify is open source, all icon sets are also open source and they are used by many open source projects. Do you feel like contributing to open source projects?
- Each icon set has an information section, which includes author name and link to repository. It is shown on websites that list icons, it is shown in Figma and Sketch plugin. It might get you some visitors, followers and links for search engines.

## Adding icon set

To add an icon set to Iconify, all you need to is [open an issue on Iconify icon sets repository on GitHub](https://github.com/iconify/icon-sets).

In opened issue you need to post:

- A link to icons. See below.
- Each icon set has a prefix, such as mdi-light. You can post prefix you want be assigned to your icon set.

### Icon set source

Icon sets are automatically updated several times a week. In order to update icon set, icons must be published and maintained by developer on one of the following sources:

- Public git repository (GitHub, GitLab, etc...) containing SVG files.
- NPM package containing SVG files.
- Figma document. You need to share the file and post link to it.

Updates must be automated, so manually downloading icons from a third party website is not an option.

### Open source

All icon sets must be open source and have a valid open source license.

If you are not sure about licenses, [check out various icon sets](https://icon-sets.iconify.design/). Click any icon set, it will show license and link to license text.

Popular licenses:

- [MIT](https://opensource.org/licenses/MIT).
- [Apache 2.0](https://opensource.org/licenses/Apache-2.0).
- [CC BY 4.0](https://creativecommons.org/licenses/by/4.0/).

See [Open Source Initiative](https://opensource.org/licenses) for more licenses.

### Bad icon sets

Not all icon sets are the same. There are good and bad icon sets. Bad icon sets are not accepted.

Most common reasons:

- Icon set should be useful to community. If icon set is specific to your website, such as your website logos, it is not really useful to other developers.
- Icons, not illustrations. Icon sets must contain only icons, which can be used as a small icon, not as a large image. Collections of vector images with high details, that are meant to be used as large images are not acceptable.
- No icons exported from fonts. Icons exported from fonts are almost always badly aligned, not following any logical grid system. They are very low quality and not usable as SVG.

## Design tips

If you are new to icon design, [Google Material Icons website has excellent guidelines for designing icons](https://material.io/design/iconography/system-icons.html#grid-and-keyline-shapes).

Those guidelines are specific to material design, but the same principles apply to most icons. Even though icons are vector images, displays are pixel devices and icon edges are blurred if shape is not aligned to the edge of a pixel. Icon sets that follow a specific grid, have padding, shapes aligned to pixel edges, are the best looking icon sets.

[Page 108](https://iconify.design/docs/libraries/ "Current Page.")

## Tools for developers

Iconify offers several libraries that help with converting icons, manipulating icon sets and generating icons.

Available libraries:

## Utils

[Iconify Utils](https://iconify.design/docs/utils/) is a set of reusable functions used by icon components and other packages. Its main purpose is to read [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") icon sets and extract data from it.

The Iconify Utils package contains the following functions:

- Reading [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") icon sets.
- Extracting subsets of icons or single icons.
- Generating SVG.
- Validating icon names used by icon components, such as mdi:home.

Additionally, it contains functions for:

- Parsing and validating colors. This can be used by color input in icon picker.

Package works in any environment: node, browser, deno, and closed JavaScript environment.

## Tools

[Iconify Tools](https://iconify.design/docs/tools/) is a large package, its main purpose is to retrieve icons from various sources, validate them, clean them up and generate [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") icon sets as well as various NPM packages.

The Iconify Tools package contains the following functions:

- Importing icons from SVG icon sets, Figma documents.
- Validating icons, cleaning up content, optimising icons.
- Exporting icons to [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") icon sets and several NPM packages.

It is used to maintain available open source icon sets.

This package is designed to work only in Node.js. It is not usable in browser.

[Page 109](https://iconify.design/docs/types/ "Current Page.")

## Iconify types

All Iconify libraries share common object structures. They are described as types in @iconify/types NPM package.

## TypeScript

All types are described with TypeScript.

If you are not familiar with TypeScript, but are familiar with JavaScript, it should not be hard to understand this documentation because it is mostly just basic types.

Few basic TypeScript concepts you need to know to understand documentation:

### Record

Type Record<string,number> is an object, where key is string, value is number.

For PHP developers it is the same as associative array.

### unknown

Type unknown means value can be any type.

### extends

ts
```
interface Foo extends Bar, Baz {}
```

This means one type extends another type. In the example above, type Foo has all properties of types Bar and Baz.

## Main types

There are two main types that are used in Iconify ecosystem:

- [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") is used for data for one icon.
- [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") is used for an entire icon set. It stores icon data, icon aliases and various metadata.

## Additional types

These types are used in [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") type:

- [IconifyAlias](https://iconify.design/docs/types/iconify-alias.html "IconifyAlias documentation") is used for icon aliases.
- [IconifyInfo](https://iconify.design/docs/types/iconify-info.html "IconifyInfo documentation") is used for icon set information.

[Page 110](https://iconify.design/docs/types/iconify-icon.html "Current Page.")

## IconifyIcon type

All Iconify libraries share common object structures. They are described as types in @iconify/types NPM package.

For description of types and short explanation of TypeScript see [types documentation](https://iconify.design/docs/).

This article describes IconifyIcon type that contains data for one icon.

## Usage

Icon data in IconifyIcon type is usually extracted from [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") icon set.

To extract icon data in your code, use [getIconData()](https://iconify.design/docs/libraries/utils/get-icon-data.html "getIconData() documentation") function from Iconify Utils. [Iconify Utils](https://iconify.design/docs/libraries/utils/) can be used in any environment.

To convert SVG to IconifyIcon, you can use [getIcon()](https://iconify.design/docs/libraries/tools/svg/ "getIcon() documentation") function of SVG instance from Iconify Tools. [Iconify Tools](https://iconify.design/docs/libraries/tools/) is a Node.js package for importing and parsing icons. Make sure you [clean up icon](https://iconify.design/docs/libraries/tools/icon/cleanup.html) before exporting it.

## Structure

Type IconifyIcon is a simple object. It has two parts:

- body, string contains icon content, mandatory.
- Optional IconifyOptional properties that contain icon dimensions and basic transformations.

Example of a basic icon:

json
```
{
  "body": "<path fill=\"currentColor\" fill-rule=\"evenodd\" d=\"M8 9.5a1.5 1.5 0 1 0 0-3a1.5 1.5 0 0 0 0 3z\"/>"
}
```

## Body

Body contains contents of <svg>, without <svg> tag.

It does not include <svg> tag because:

- Contents can be manipulated, such as rotating or flipping an icon. This is much easier to do when there is no need to parse an entire <svg>.
- It gives components full control over <svg> tag, allowing addition/removal of custom attributes.
- Makes it easy to use in various frameworks (such as React, Vue, Svelte), where <svg> element is created using framework's native code and content is set as its property.

## Optional properties

There are several properties that are shared in multiple types. They are described in IconifyOptional type.

Properties for viewBox:

- left, number. Left position of viewBox. Default value is 0.
- top, number. Top position of viewBox. Default value is 0.
- width, number. Width of viewBox. Default value is 16.
- height, number. Height of viewBox. Default value is 16.

Transformations:

- rotate, number. Number of 90 degrees rotations. Default value is 0.
- hFlip, boolean. Horizontal flip. Default value is false.
- vFlip, boolean. Vertical flip. Default value is false.

Example of typical icon data:

json
```
{
  "body": "<path d=\"M7 6v12l10-6z\" fill=\"currentColor\"/>",
  "width": 24,
  "height": 24
}
```

In your code you can get default values from defaultIconProps constant from [Iconify Utils](https://iconify.design/docs/libraries/utils/).

[Page 111](https://iconify.design/docs/types/iconify-json.html "Current Page.")

## IconifyJSON type

All Iconify libraries share common object structures. They are described as types in @iconify/types NPM package.

For description of types and short explanation of TypeScript see [types documentation](https://iconify.design/docs/).

This article describes IconifyJSON type.

## Usage

Icon set in IconifyJSON is created by Iconify Tools or loaded from pre-parsed JSON file.

See [Iconify Utils documentation](https://iconify.design/docs/libraries/utils/) for parsing icon sets and [icon sets package documentation](https://iconify.design/docs/icons/all.html).

See [Iconify Tools documentation](https://iconify.design/docs/libraries/tools/) for creating custom icon sets.

## Structure

Type IconifyJSON is an object that has the following required properties.

### Required properties

- prefix, string. Prefix for icons in JSON file. All icons in an icon set have the same prefix and icon set cannot include icons from other icon sets.
- icons, Record<string,[IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") >. List of icons. Key is icon name, value is [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") icon data.

Example:

json
```
{
    "prefix": "mdi",
    "icons": {
        "home": {
            "body": "<path d=\"M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5z\" fill=\"currentColor\"/>",
            "width": 24,
            "height": 24
        }
    }
}
```

Other properties are optional: aliases, default values for all icons, metadata.

### Icon

Object icons contains data for icons.

Key is icon name. Value is icon data, where body is required and other properties are optional:

Properties for viewBox:

- left, number. Left position of viewBox. Default value is 0.
- top, number. Top position of viewBox. Default value is 0.
- width, number. Width of viewBox. Default value is 16.
- height, number. Height of viewBox. Default value is 16.

Transformations:

- rotate, number. Number of 90 degrees rotations. Default value is 0.
- hFlip, boolean. Horizontal flip. Default value is false.
- vFlip, boolean. Vertical flip. Default value is false.

In your code you can get default values from defaultIconProps constant from [Iconify Utils](https://iconify.design/docs/libraries/utils/).

### Alias

One optional property of IconifyJSON type is alias, which has type Record<string,[IconifyAlias](https://iconify.design/docs/types/iconify-alias.html "IconifyAlias documentation") >. Key is alias name, value is [IconifyAlias](https://iconify.design/docs/types/iconify-alias.html "IconifyAlias documentation") alias data. It represents a list of icon aliases.

What are aliases? They are variations of other icons. Aliases are used to reduce duplications.

For example, if icons home and house are identical, only one of those icons can be present in icons property, another icon can be listed in aliases, pointing to original icon:

json
```
{
    "prefix": "mdi",
    "icons": {
        "house": {
            "body": "<path d=\"M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5z\" fill=\"currentColor\"/>",
            "width": 24,
            "height": 24
        }
    },
    "aliases": {
        "home": {
            "parent": "house"
        }
    }
}
```

Aliases can also include transformations: horizontal and/or vertical flip, 90/180/270 degrees rotation. This allows icon variations by reusing another icon, such as creating a right arrow by using left arrow with horizontal flip:

json
```
{
    "prefix": "bi",
    "icons": {
        "arrow-left": {
            "body": "<g fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.854 4.646a.5.5 0 0 1 0 .708L3.207 8l2.647 2.646a.5.5 0 0 1-.708.708l-3-3a.5.5 0 0 1 0-.708l3-3a.5.5 0 0 1 .708 0z\"/><path fill-rule=\"evenodd\" d=\"M2.5 8a.5.5 0 0 1 .5-.5h10.5a.5.5 0 0 1 0 1H3a.5.5 0 0 1-.5-.5z\"/></g>",
            "width": 16,
            "height": 16
        }
    },
    "aliases": {
        "arrow-right": {
            "parent": "arrow-left",
            "hFlip": true
        }
    }
}
```

Alias has the same properties as icons, except for body. It also has additional required property parent that points to parent icon.

Logic for resolving properties of alias:

- For icon dimensions, value set in alias overrides value from parent icon.
- For icon transformations, if value is set in both alias and parent icon, they are merged: horizontal flip + horizontal flip = no horizontal flip, 90 degrees rotation + 180 degrees rotation = 270 degrees rotation.

json
```
{
    "prefix": "bi",
    "icons": {
        "arrow-left": {
            "body": "<g fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.854 4.646a.5.5 0 0 1 0 .708L3.207 8l2.647 2.646a.5.5 0 0 1-.708.708l-3-3a.5.5 0 0 1 0-.708l3-3a.5.5 0 0 1 .708 0z\"/><path fill-rule=\"evenodd\" d=\"M2.5 8a.5.5 0 0 1 .5-.5h10.5a.5.5 0 0 1 0 1H3a.5.5 0 0 1-.5-.5z\"/></g>",
            "width": 16,
            "height": 16
        }
    },
    "aliases": {
        "arrow-right": {
            "parent": "arrow-left",
            "hFlip": true
        }
    }
}
```

json
```
{
    "body": "<g fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.854 4.646a.5.5 0 0 1 0 .708L3.207 8l2.647 2.646a.5.5 0 0 1-.708.708l-3-3a.5.5 0 0 1 0-.708l3-3a.5.5 0 0 1 .708 0z\"/><path fill-rule=\"evenodd\" d=\"M2.5 8a.5.5 0 0 1 .5-.5h10.5a.5.5 0 0 1 0 1H3a.5.5 0 0 1-.5-.5z\"/></g>",
    "width": 16,
    "height": 16,
    "hFlip": true
}
```

Another example:

json
```
{
    "prefix": "mdi",
    "icons": {
        "house": {
            "body": "<path d=\"M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5z\" fill=\"currentColor\"/>",
            "width": 24,
            "height": 24
        }
    },
    "aliases": {
        "house-32": {
            "parent": "house",
            "width": 32,
            "height": 32,
            "left": -4,
            "top": -4
        }
    }
}
```

json
```
{
    "body": "<path d=\"M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5z\" fill=\"currentColor\"/>",
    "width": 32,
    "height": 32,
    "left": -4,
    "top": -4
}
```

### Default dimensions

If most icons in an icon set have the same dimensions, it does not make sense to list them all for each icon:

json
```
{
    "prefix": "mdi",
    "icons": {
        "home": {
            "body": "<path fill=\"currentColor\" d=\"M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5Z\"/>",
            "width": 24,
            "height": 24
        },
        "account": {
            "body": "<path fill=\"currentColor\" d=\"M12 4a4 4 0 0 1 4 4a4 4 0 0 1-4 4a4 4 0 0 1-4-4a4 4 0 0 1 4-4m0 10c4.42 0 8 1.79 8 4v2H4v-2c0-2.21 3.58-4 8-4Z\"/>",
            "width": 24,
            "height": 24
        },
        "arrow-left": {
            "body": "<path fill=\"currentColor\" d=\"M20 11v2H8l5.5 5.5l-1.42 1.42L4.16 12l7.92-7.92L13.5 5.5L8 11h12Z\"/>",
            "width": 24,
            "height": 24
        }
    }
}
```

To reduce that duplication, root of IconifyJSON object might include default values for icon dimensions:

json
```
{
    "prefix": "mdi",
    "icons": {
        "home": {
            "body": "<path fill=\"currentColor\" d=\"M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5Z\"/>"
        },
        "account": {
            "body": "<path fill=\"currentColor\" d=\"M12 4a4 4 0 0 1 4 4a4 4 0 0 1-4 4a4 4 0 0 1-4-4a4 4 0 0 1 4-4m0 10c4.42 0 8 1.79 8 4v2H4v-2c0-2.21 3.58-4 8-4Z\"/>"
        },
        "arrow-left": {
            "body": "<path fill=\"currentColor\" d=\"M20 11v2H8l5.5 5.5l-1.42 1.42L4.16 12l7.92-7.92L13.5 5.5L8 11h12Z\"/>"
        }
    },
    "width": 24,
    "height": 24
}
```

These default values are used only for icons that do not have dimensions:

json
```
{
    "prefix": "mdi",
    "icons": {
        "square": {
            "body": "<path d=\"M3 3v18h18V3\" fill=\"currentColor\"/>"
        },
        "triangle": {
            "body": "<path d=\"M1 21h22L12 2\" fill=\"currentColor\"/>"
        },
        "rectangle": {
            "body": "<path d=\"M4 6v13h16V6H4z\" fill=\"currentColor\"/>"
        },
        "small-circle": {
            "body": "<circle cx=\"8\" cy=\"8\" r=\"8\" fill=\"currentColor\"/>",
            // Custom values override default values
            "width": 16,
            "height": 16
        }
    },
    // Default width and height for icons that do not have width or height
    "width": 24,
    "height": 24
}
```

json
```
{
    "prefix": "mdi",
    "icons": {
        "square": {
            "body": "<path d=\"M3 3v18h18V3\" fill=\"currentColor\"/>",
            "width": 24,
            "height": 24
        },
        "triangle": {
            "body": "<path d=\"M1 21h22L12 2\" fill=\"currentColor\"/>",
            "width": 24,
            "height": 24
        },
        "rectangle": {
            "body": "<path d=\"M4 6v13h16V6H4z\" fill=\"currentColor\"/>",
            "width": 24,
            "height": 24
        },
        "small-circle": {
            "body": "<circle cx=\"8\" cy=\"8\" r=\"8\" fill=\"currentColor\"/>",
            "width": 16,
            "height": 16
        }
    }
}
```

Both examples are identical, first example has default values, second example does not.

If dimensions in an icon are missing, and default values in the root object are missing, default value for property (see the list of properties above) is used:

Icon without dimensions, which default to 16:

json
```
{
    "prefix": "bi",
    "icons": {
        "arrow-left": {
            "body": "<g fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.854 4.646a.5.5 0 0 1 0 .708L3.207 8l2.647 2.646a.5.5 0 0 1-.708.708l-3-3a.5.5 0 0 1 0-.708l3-3a.5.5 0 0 1 .708 0z\"/><path fill-rule=\"evenodd\" d=\"M2.5 8a.5.5 0 0 1 .5-.5h10.5a.5.5 0 0 1 0 1H3a.5.5 0 0 1-.5-.5z\"/></g>"
        }
    }
}
```

json
```
{
    "prefix": "bi",
    "icons": {
        "arrow-left": {
            "body": "<g fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.854 4.646a.5.5 0 0 1 0 .708L3.207 8l2.647 2.646a.5.5 0 0 1-.708.708l-3-3a.5.5 0 0 1 0-.708l3-3a.5.5 0 0 1 .708 0z\"/><path fill-rule=\"evenodd\" d=\"M2.5 8a.5.5 0 0 1 .5-.5h10.5a.5.5 0 0 1 0 1H3a.5.5 0 0 1-.5-.5z\"/></g>",
            "width": 16,
            "height": 16
        }
    }
}
```

Both examples are identical, first example has default property values, second example has explicit dimensions.

In all examples above, width and height are used to demonstrate dimensions. But there are also left and top properties and transformations, which are missing in all examples. This is example above with all properties resolved:

json
```
{
    "prefix": "bi",
    "icons": {
        "arrow-left": {
            "body": "<g fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.854 4.646a.5.5 0 0 1 0 .708L3.207 8l2.647 2.646a.5.5 0 0 1-.708.708l-3-3a.5.5 0 0 1 0-.708l3-3a.5.5 0 0 1 .708 0z\"/><path fill-rule=\"evenodd\" d=\"M2.5 8a.5.5 0 0 1 .5-.5h10.5a.5.5 0 0 1 0 1H3a.5.5 0 0 1-.5-.5z\"/></g>",
            "width": 16,
            "height": 16,
            "left": 0,
            "top": 0,
            "hFlip": false,
            "vFlip": false,
            "rotate": false
        }
    }
}
```

## Metadata

IconifyJSON can also contain additional data that is used for displaying list of icons.

This is optional data that has no effect on rendering icons, so it was moved to a separate document.

See [IconifyJSON metadata](https://iconify.design/docs/iconify-json-metadata.html) for details.

## Functions

To parse icon sets, [Iconify Utils](https://iconify.design/docs/libraries/utils/) offers the following functions:

- [parseIconSet()](https://iconify.design/docs/libraries/utils/parse-icon-set.html "parseIconSet() documentation") parses an entire icon set, calling custom function for every icon.
- [getIconData()](https://iconify.design/docs/libraries/utils/get-icon-data.html "getIconData() documentation") extracts data for an icon in [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") format.

To create convert icons to icon sets, use [Iconify Tools](https://iconify.design/docs/libraries/tools/).

[Page 112](https://iconify.design/docs/types/iconify-json-metadata.html "Current Page.")

## IconifyJSON metadata

[IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") can also contain additional data that is used for displaying a list of icons:

- Last modification time (since version 2).
- Icon set info.
- Categories. Each icon can belong to multiple categories.
- Themes. They are used for variations of the same icon that have different start or end parts.
- Characters map. This is used for icons imported from icon fonts.

## Last modification time

Last modification time is used to check if an icon set was updated. Icon components use it to invalidate old cache.

Value is a number, which needs to be higher than in a previously released version of an icon set.

## Information

Information is stored in info object.

See [IconifyInfo](https://iconify.design/docs/types/iconify-info.html "IconifyInfo documentation") documentation.

## Categories

Categories are stored in categories object.

In TypeScript categories are represented by type IconifyCategories that can be imported from @iconify/types.

This is a simple object, where key is category name, value is an array of icon names that belong to that category.

Example:

json
```
{
    "categories": {
        "Accessibility": ["accessible-icon"],
        "Audio & Video": ["youtube"],
        "Communication": ["bluetooth", "bluetooth-b"],
        "Currency": ["bitcoin", "btc", "ethereum", "gg", "gg-circle"],
        "Games": [
            "playstation",
            "steam",
            "steam-square",
            "steam-symbol",
            "twitch",
            "xbox"
        ]
    }
}
```

## Themes: prefixes and suffixes

Themes are used to display variations of the same icon that have different prefix or suffix. It is similar to categories, but instead of listing every icon, data contains only prefixes or suffixes.

Themes are stored in prefixes and suffixes objects.

In TypeScript both prefixes and suffixes are simple Record<string,string> objects, where:

- key is prefix or suffix in icon.
- value is the name of theme.

Example of prefixes used in [Google Material Icons](https://icon-sets.iconify.design/ic/):

json
```
{
    "prefixes": {
        "baseline": "Baseline",
        "outline": "Outline",
        "round": "Round",
        "sharp": "Sharp",
        "twotone": "Two-Tone"
    }
}
```

In an example above, all icons that start with baseline- belong to "Baseline" theme and so on.

When checking if icon belongs to a prefix, add "-" to prefix. For example, "baseline-home" belongs to "Baseline" theme in example above, "baselinehome" does not, because "-" should separate prefix and icon name.

Example of suffixes used in [Ant Design Icons](https://icon-sets.iconify.design/ant-design/):

json
```
{
    "suffixes": {
        "filled": "Filled",
        "outlined": "Outlined",
        "twotone": "TwoTone"
    }
}
```

In an example above, all icons that end with "-filled" belong to "Filled" theme, all icons that end with "-outlined" belong to "Outlined" theme and all icons that end with "-twotone" belong to "TwoTone" theme.

### Default theme

Both prefixes and suffixes can have default entry, where the key is an empty string. Icons that do not fit other themes should be put in that theme.

Example:

json
```
{
    "suffixes": {
        "": "Filled",
        "outline": "Outline",
        "negative": "Negative"
    }
}
```

Icons that end with "-outline" belong to "Outline" theme, icons that end with "-negative" belong to "Negative" theme, all other icons belong to "Filled" theme.

### Legacy themes

In older versions of metadata, themes were stored in themes property. This has been deprecated and should be ignored.

## Characters map

Map of characters is stored in chars object.

In TypeScript characters are represented by type IconifyChars that can be imported from @iconify/types.

This is a simple object, where key is character code in hexadecimal form, value is name of icon.

Example:

json
```
{
    "chars": {
        "e007": "firefox-browser",
        "e013": "ideal",
        "e01a": "microblog",
        "e01e": "pied-piper-square",
        "e049": "unity",
        "e052": "dailymotion",
        "e055": "instagram-square",
        "e056": "mixer",
        "e057": "shopify"
    }
}
```

[Page 113](https://iconify.design/docs/types/iconify-alias.html "Current Page.")

## IconifyAlias type

All Iconify libraries share common object structures. They are described as types in @iconify/types NPM package.

For description of types and short explanation of TypeScript see [types documentation](https://iconify.design/docs/).

This article describes IconifyAlias type.

## IconifyAlias type

Type IconifyAlias represents an alias for icon. It is used in Iconify JSON files.

What is an alias? An alias is icon that reuses another icon's properties.

arrow-left could be an alias of arrow-right with horizontal flip enabled. No need to create new shape when existing shape can be reused with a simple transformation.

battery-empty could be an alias of battery-0 without any changes. This makes it possible to assign multiple names to the same icon.

## Structure

Type IconifyAlias is similar to [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation").

Properties:

- parent, string. Name of parent icon, required.

Other properties are from IconifyOptional type, they are shared with [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") type.

Properties for viewBox:

- left, number. Left position of viewBox. Default value is 0.
- top, number. Top position of viewBox. Default value is 0.
- width, number. Width of viewBox. Default value is 16.
- height, number. Height of viewBox. Default value is 16.

Transformations:

- rotate, number. Number of 90 degrees rotations. Default value is 0.
- hFlip, boolean. Horizontal flip. Default value is false.
- vFlip, boolean. Vertical flip. Default value is false.

### Parent icon

Parent icon name should not include icon set prefix, and parent icon must be present in the icon set.

If you use another alias as a parent, make sure there are no circular dependencies. For example, if arrow-left is an alias of arrow-right (with horizontal flip), which in turn is an alias of arrow-up (with 90 degrees rotation), which in turn is an alias of arrow-down (with vertical flip), arrow-down could not be an alias of arrow-left because that would create a loop.

To be safe, use only icons as parent, not other aliases.

## Merging properties for icon and alias

If, when merging properties, an icon alias has a property that parent icon also has, the following rules apply:

- hFlip and vFlip. Result is icon.hFlip!== alias.hFlip. That means if both icon and alias are flipped horizontally, the result will not be flipped (horizontal flip + horizontal flip cancel each other). If only one of the items is flipped horizontally, the result will be flipped (horizontal flip + no flip = horizontal flip).
- rotate. The result is a sum of rotations. That means 90 degrees rotation + 180 degrees rotation = 270 degrees rotation.

For all other properties alias overrides parent icon's value.

Examples of merging icon and alias:

json
```
{
    "body": "<path d=\"M7 6v12l10-6z\" fill=\"currentColor\"/>",
    "width": 24,
    "height": 24,
    "hFlip": true
}
```

json
```
{
    "parent": "icon1",
    "hFlip": true,
    "vFlip": true
}
```

json
```
{
    "body": "<path d=\"M7 6v12l10-6z\" fill=\"currentColor\"/>",
    "width": 24,
    "height": 24,
    "parent": "icon1",
    "hFlip": false,
    "vFlip": true
}
```

In the example above, hFlip + hFlip = false,!vFlip + vFlip = true, icon alias overwrote other properties.

## Examples

json
```
{
    "parent": "arrow-left",
    "hFlip": true
}
```

json
```
{
    "prefix": "bi",
    "icons": {
        "arrow-left": {
            "body": "<g fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.854 4.646a.5.5 0 0 1 0 .708L3.207 8l2.647 2.646a.5.5 0 0 1-.708.708l-3-3a.5.5 0 0 1 0-.708l3-3a.5.5 0 0 1 .708 0z\"/><path fill-rule=\"evenodd\" d=\"M2.5 8a.5.5 0 0 1 .5-.5h10.5a.5.5 0 0 1 0 1H3a.5.5 0 0 1-.5-.5z\"/></g>",
            "width": 16,
            "height": 16
        }
    },
    "aliases": {
        "arrow-right": {
            "parent": "arrow-left",
            "hFlip": true
        }
    }
}
```

json
```
{
    "body": "<g fill=\"currentColor\"><path fill-rule=\"evenodd\" d=\"M5.854 4.646a.5.5 0 0 1 0 .708L3.207 8l2.647 2.646a.5.5 0 0 1-.708.708l-3-3a.5.5 0 0 1 0-.708l3-3a.5.5 0 0 1 .708 0z\"/><path fill-rule=\"evenodd\" d=\"M2.5 8a.5.5 0 0 1 .5-.5h10.5a.5.5 0 0 1 0 1H3a.5.5 0 0 1-.5-.5z\"/></g>",
    "width": 16,
    "height": 16,
    "hFlip": true
}
```

json
```
{
    "parent": "house"
}
```

json
```
{
    "prefix": "mdi",
    "icons": {
        "house": {
            "body": "<path d=\"M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5z\" fill=\"currentColor\"/>",
            "width": 24,
            "height": 24
        }
    },
    "aliases": {
        "home": {
            "parent": "house"
        }
    }
}
```

json
```
{
    "body": "<path d=\"M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5z\" fill=\"currentColor\"/>",
    "width": 24,
    "height": 24
}
```

json
```
{
    "parent": "house",
    "width": 32,
    "height": 32,
    "left": -4,
    "top": -4
}
```

json
```
{
    "prefix": "mdi",
    "icons": {
        "house": {
            "body": "<path d=\"M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5z\" fill=\"currentColor\"/>",
            "width": 24,
            "height": 24
        }
    },
    "aliases": {
        "house-32": {
            "parent": "house",
            "width": 32,
            "height": 32,
            "left": -4,
            "top": -4
        }
    }
}
```

json
```
{
    "body": "<path d=\"M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5z\" fill=\"currentColor\"/>",
    "width": 32,
    "height": 32,
    "left": -4,
    "top": -4
}
```

[Page 114](https://iconify.design/docs/types/iconify-info.html "Current Page.")

## IconifyInfo type

All Iconify libraries share common object structures. They are described as types in @iconify/types NPM package.

For description of types and short explanation of TypeScript see [types documentation](https://iconify.design/docs/).

This article describes IconifyAlias type.

## Structure

Type IconifyInfo is used for information about icon set.

It has the following mandatory properties:

Then it has many optional properties, most of these properties are intended for displaying icon set data in list of icon sets:

- total, number. Number of icons in an icon set (see below).
- version, string. Version string.
- samples, string\[\]. Array of icon names to show as samples.
- height, number|number\[\]. Icon grid. If an icon set has mix of icons with different height values, such as half of icons are 16 pixels high, half are 24 pixels high, value can be an array.
- displayHeight, number. Height to use when showing samples. Value should be between 16 and 24.
- category, string. Category in icon sets list.
- tags, string\[\]. List of tags, which can be used to filter icon sets (added in version 2).
- palette, boolean. Set to true if all icons use hardcoded colors, set to false if all icons use currentColor.

## Author

- name, string. Author name, mandatory.
- url, string. Optional link to icon set website. Usually links to GitHub repository.

## License

license property is an object with following properties:

- title, string. Human readable license, mandatory.
- spdx, string. Optional SPDX license identifier.
- url, string. Optional link to license file.

## Examples

json
```
{
    "name": "Phosphor",
    "total": 5206,
    "version": "1.3.2",
    "author": {
        "name": "Phosphor Icons",
        "url": "https://github.com/phosphor-icons/phosphor-icons"
    },
    "license": {
        "title": "MIT",
        "spdx": "MIT"
    },
    "samples": [
        "folder-notch-open-duotone",
        "check-square-offset-thin",
        "pencil-line-fill"
    ],
    "height": 24,
    "displayHeight": 24,
    "category": "General",
    "palette": false
}
```

json
```
{
    "name": "Emoji One (Colored)",
    "total": 1834,
    "version": "2.3.0",
    "author": {
        "name": "Emoji One",
        "url": "https://github.com/EmojiTwo/emojitwo"
    },
    "license": {
        "title": "CC BY 4.0",
        "spdx": "CC-BY-4.0",
        "url": "https://creativecommons.org/licenses/by/4.0/"
    },
    "samples": [
        "anxious-face-with-sweat",
        "cloud-with-snow",
        "studio-microphone"
    ],
    "height": 32,
    "displayHeight": 16,
    "category": "Emoji",
    "palette": true
}
```

[Page 115](https://iconify.design/docs/libraries/tools/ "Current Page.")

## Iconify Tools

Iconify Tools is a set of reusable functions for importing, exporting, and parsing icons.

Library is written in TypeScript.

## Installation

To install library run:

```
npm install @iconify/tools --save
```

### CommonJS support

The latest version does not support CommonJS.

If you need to use CommonJS, install version 4:

```
npm install @iconify/tools@cjs --save
```

## Classes

In Iconify Tools, all functions for parsing icons work with 2 main classes:

- [SVG](https://iconify.design/docs/libraries/tools/svg/ "SVG documentation") represents one icon. This class is used when icon's elements need to be manipulated.
- [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") represents an icon set with easy to use functions for managing icons.

## Import

To start working with an icon set, you can either create blank icon set or import icon set from some source.

Documentation from importing icons:

- [Importing Iconify JSON data](https://iconify.design/docs/import/json.html).
- [Importing SVG](https://iconify.design/docs/import/svg.html).
- [Importing all SVG in directory](https://iconify.design/docs/import/directory.html).
- [Importing icons from Figma](https://iconify.design/docs/import/figma/).

Before using Iconify Tools, you should be aware that package is opinionated. Certain tags are not allowed and will cause import to fail. See [SVG import limitations](https://iconify.design/docs/tags.html).

## Cleanup and validation

Cleaning up and validating icons is the first thing you should do after importing icons if icons come from:

- Image editing software. Often software leaves a lot of junk code in icons, which must be removed.
- Third party. You need to make sure icons do not contain scripts, events.

See [cleanupSVG()](https://iconify.design/docs/libraries/tools/icon/cleanup.html "cleanupSVG() documentation") documentation.

## Manipulation

Iconify Tools offer several functions for manipulating icons. You can:

- Check or change color palette.
- Optimise icon.
- Fix <path> elements to support old software.

See [icon manipulation functions](https://iconify.design/docs/icon/) for list of available functions.

## Export

After manipulating icons, you can [export icon set to various formats](https://iconify.design/docs/export/).

Documentation from exporting icons:

- [Exporting Iconify JSON data](https://iconify.design/docs/export/json.html).
- [Exporting SVG to directory (simplified version)](https://iconify.design/docs/export/directory.html).
- [Exporting SVG](https://iconify.design/docs/export/svg.html).
- [Exporting icon packages](https://iconify.design/docs/export/icon-package.html).
- [Exporting Iconify JSON packages](https://iconify.design/docs/export/json-package.html).

## Package functions

In addition to managing icons, Iconify Tools has several [functions to manage packages and repositories](https://iconify.design/docs/package/):

- [Download Git repository](https://iconify.design/docs/package/git.html)
- [Download GitHub repository using GitHub API](https://iconify.design/docs/package/github.html)
- [Download NPM package](https://iconify.design/docs/package/npm.html)
- [Compare directories](https://iconify.design/docs/package/compare.html)
- [Manage versions of packages or repositories](https://iconify.design/docs/package/#versions)

[Page 116](https://iconify.design/docs/libraries/tools/svg/ "Current Page.")

## SVG class

SVG class represents one icon. It is used in [Iconify Tools](https://iconify.design/) in functions for icon content.

## Usage

To create an instance, use this code:

ts
```
import { SVG } from "@iconify/tools";

const svg = new SVG(
  '<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 24 24"><path d="M7 6v12l10-6z" fill="currentColor"/></svg>'
 );
```

If you are working with icon sets, use function toSVG() of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") instance to get SVG instance:

ts
```
const svg = iconSet("home");
if (!svg) {
  throw new Error('Icon "home" is not available or invalid');
 }
```

## Properties

SVG instance has several properties, all are initialized when instance is created:

- viewBox, ViewBox. Icon's viewBox. It is a simple object with numeric properties left, top, width and height. Properties left, top are optional, default value is 0.
- $svg is a root element of SVG.

## Methods

The following methods are available:

- load(content) replaces icon content. This is identical to creating new SVG instance, but it changes current instance instead of making new one.
- toString() exports icon as string.
- toMinifiedString() export icon as string, but without whitespace.
- toPrettyString() export icon as string, with extra tabs and new lines for readability.
- getBody() export icon's content as string (icon without <svg> tag).
- getIcon() exports icon as [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") object.

## Validating and cleaning up icon

Unfortunately, many editors leave lots of junk in SVG files, sometimes multiplying icon file size several times.

SVG files might also contain scripts and links to external resources.

This is why after loading icon, it should be validated and cleaned up. See [cleanupSVG()](https://iconify.design/docs/libraries/tools/icon/cleanup.html "cleanupSVG() documentation") function.

## Optimising icon

The cleanup process is very basic, it does bare minimum to get rid of bad stuff. However, icons often contain unnecessary or unused elements and attributes.

Before exporting icons, you need to properly fix them. The process can include:

- Fixing color palette.
- Scaling icons.
- Optimising icons.

See [icon manipulation functions](https://iconify.design/icon/).

[Page 117](https://iconify.design/docs/libraries/tools/icon-set/ "Current Page.")

## IconSet class

IconSet class in [Iconify Tools](https://iconify.design/) represents an icon set.

## Usage

To create an instance, use this code to import existing [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") data:

ts
```
import { IconSet } from '@iconify/tools';

const iconSet = new IconSet({
    prefix: 'codicon',
    icons: {
        'add': {
            body: '<g fill="currentColor"><path d="M14 7v1H8v6H7V8H1V7h6V1h1v6h6z"/></g>',
        },
        'chrome-maximize': {
            body: '<g fill="currentColor"><path d="M3 3v10h10V3H3zm9 9H4V4h8v8z"/></g>',
        },
        'chrome-minimize': {
            body: '<g fill="currentColor"><path d="M14 8v1H3V8h11z"/></g>',
        },
    },
 });
```

or this to create an empty icon set:

ts
```
import { blankIconSet } from '@iconify/tools';

const iconSet = blankIconSet('some-prefix');
```

Constructor does not validate the icon set. If you are not sure about the source, you need to validate it using [validateIconSet()](https://iconify.design/docs/libraries/utils/validate-icon-set.html "validateIconSet() documentation") from [Iconify Utils](https://iconify.design/utils/).

## Functions

Working with icons:

- [list()](https://iconify.design/docs/libraries/tools/icon-set/list.html "list() documentation") lists all icons.
- [forEach()](https://iconify.design/docs/libraries/tools/icon-set/for-each.html "forEach() documentation") runs callback for all icons. Supports asynchronous callbacks.
- [exists(name)](https://iconify.design/docs/libraries/tools/icon-set/exists.html "exists() documentation") checks if icon exists.
- [count()](https://iconify.design/docs/libraries/tools/icon-set/count.html "count() documentation") counts number of icons in the icon set.
- [remove(name)](https://iconify.design/docs/libraries/tools/icon-set/remove.html "remove() documentation") removes icon.
- [rename(oldName, newName)](https://iconify.design/docs/libraries/tools/icon-set/rename.html "rename() documentation") renames icon.
- [setItem(name, item)](https://iconify.design/docs/libraries/tools/icon-set/set-item.html "setItem() documentation") adds/updates item in [entries](https://iconify.design/docs/libraries/tools/icon-set/entries.html "entries() documentation") property.
- [setIcon(name, icon)](https://iconify.design/docs/libraries/tools/icon-set/set-icon.html "setIcon() documentation") adds/updates icon, using [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") data.
- [setVariation(name, parent, props)](https://iconify.design/docs/libraries/tools/icon-set/set-variation.html "setVariation() documentation") creates a variation (alias with customisations) for icon.
- [setAlias(name, parent)](https://iconify.design/docs/libraries/tools/icon-set/set-alias.html "setAlias() documentation") creates an alias for icon.
- [getTree()](https://iconify.design/docs/libraries/tools/icon-set/get-tree.html "getTree() documentation") returns list of parent icons for each icon, null if icon is invalid.
- [entries](https://iconify.design/docs/libraries/tools/icon-set/entries.html "entries() documentation") property contains data for all icons and aliases. You can access it directly, but most changes can be done using functions listed above.

Functions for importing/exporting icon set:

- [prefix](https://iconify.design/docs/libraries/tools/icon-set/prefix.html "prefix() documentation") property contains icon set prefix, which is used when exporting icon set. To change prefix, write to property.
- [resolve(name)](https://iconify.design/docs/libraries/tools/icon-set/resolve.html "resolve() documentation") returns [ResolvedIconifyIcon](https://iconify.design/docs/libraries/tools/iconify-icon.html "ResolvedIconifyIcon documentation") object for icon, null on failure.
- [load(data)](https://iconify.design/docs/libraries/tools/icon-set/load.html "load() documentation") loads data from [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") type. This is identical to creating new IconSet instance, but it changes current instance instead of making new one.
- [export()](https://iconify.design/docs/libraries/tools/icon-set/export.html "export() documentation") exports icon set as [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation").
- [toSVG(name)](https://iconify.design/docs/libraries/tools/icon-set/to-svg.html "toSVG() documentation") returns [SVG](https://iconify.design/docs/libraries/tools/svg/ "SVG documentation") instance for icon, null on failure.
- [fromSVG(name, svg)](https://iconify.design/docs/libraries/tools/icon-set/from-svg.html "fromSVG() documentation") adds/updates icon from [SVG](https://iconify.design/docs/libraries/tools/svg/ "SVG documentation") instance.
- [toString(name)](https://iconify.design/docs/libraries/tools/icon-set/to-string.html "toString() documentation") exports icon as SVG string, returns null on failure.

Functions for working with metadata:

- [info](https://iconify.design/docs/libraries/tools/icon-set/info.html "info() documentation") property contains icon set info in [IconifyInfo](https://iconify.design/docs/types/iconify-info.html "IconifyInfo documentation") type (or null if info is not available). To update info, write to property.
- [chars()](https://iconify.design/docs/libraries/tools/icon-set/chars.html "chars() documentation") returns characters map, where key is character (as hexadecimal code) and value is icon name.
- [toggleCharacter(name, char, add)](https://iconify.design/docs/libraries/tools/icon-set/toggle-character.html "toggleCharacter() documentation") adds or removes character for icon.
- [listCategory(category)](https://iconify.design/docs/libraries/tools/icon-set/list-category.html "listCategory() documentation") lists all icons in category, excluding aliases and hidden icons.
- [toggleCategory(name, category, add)](https://iconify.design/docs/libraries/tools/icon-set/toggle-category.html "toggleCategory() documentation") adds or removes category for icon.
- [categories](https://iconify.design/docs/libraries/tools/icon-set/categories.html "categories() documentation") property contains data for categories. You can access it directly if needed.
- [checkTheme()](https://iconify.design/docs/libraries/tools/icon-set/check-theme.html "checkTheme() documentation") checks prefixes or suffixes, returning list of icons that belong to each theme and list of icons that do not belong to any theme.
- [suffixes](https://iconify.design/docs/libraries/tools/icon-set/themes.html "suffixes() documentation") and [prefixes](https://iconify.design/docs/libraries/tools/icon-set/themes.html "prefixes() documentation") properties contain prefixes and suffixes. Access properties directly to update themes.

Other:

- [mergeIconSets()](https://iconify.design/docs/libraries/tools/icon-set/merge.html "mergeIconSets() documentation") merges two IconSet instances, returning new instance. This function is intended to be used to update the icon set.

## Working with icons

All icon optimisation and parsing functions work with [SVG](https://iconify.design/docs/libraries/tools/svg/ "SVG documentation") instances. How to apply those functions to an entire icon set?

It can be done by icons using [forEach()](https://iconify.design/docs/libraries/tools/icon-set/for-each.html "forEach() documentation") method:

ts
```
iconSet.forEach(async (name, type) => {
    if (type !== 'icon') {
        // Ignore aliases and variations: they inherit content from parent icon, so there is nothing to change
        return;
    }

    const svg = iconSet.toSVG(name);
    if (svg) {
        // Change colors to red
        parseColors(svg, {
            defaultColor: 'red',
            callback: (attr, colorStr, color) => {
                return !color || isEmptyColor(color) ? colorStr : 'red';
            },
        });

        // Update icon from SVG instance
        iconSet.fromSVG(name, svg);
    }
 });

// The rest of code here
```

[Page 118](https://iconify.design/docs/libraries/tools/icon-set/list.html "Current Page.")

## list()

This function is part of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") class in [Iconify Tools](https://iconify.design/).

Function list() lists all icons in an icon set.

## Usage

The function has the following parameter:

- type, string\[\]. Optional. Icon types to list, default is \['icon', 'variation'\].

Function returns an array of icon names string\[\].

## Icon types

There are 3 types of icon items in [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation"): "icon", "variation", "alias".

"icon" represents a full unique icon.

"variation" represents variation of another icon. It has the following properties:

- parent, string. Name of parent icon.

and at least one of the transformations:

- rotate rotation by 90, 180 or 270 degrees.
- hFlip horizontal flip.
- vFlip vertical flip.

Variations make it easy to create clones of icons, such as arrow-left after creating arrow-right.

"alias" is an alternative name for icon. It has the following property:

- parent, string. Name of parent icon.

Aliases can be created to have different name for icon. If you have renamed some icon, alias can be used to allow users to use old name.

## Example

ts
```
import { IconSet, cleanupSVG, parseColors, isEmptyColor } from '@iconify/tools';

const iconSet = new IconSet({
    prefix: 'codicon',
    icons: {
        'add': {
            body: '<g fill="currentColor"><path d="M14 7v1H8v6H7V8H1V7h6V1h1v6h6z"/></g>',
        },
        'debug-pause': {
            body: '<g fill="currentColor"><path d="M4.5 3H6v10H4.5V3zm7 0v10H10V3h1.5z"/></g>',
            hidden: true,
        },
        'triangle-left': {
            body: '<g fill="currentColor"><path d="M10.44 2l.56.413v11.194l-.54.393L5 8.373v-.827L10.44 2z"/></g>',
        },
    },
    aliases: {
        'plus': {
            parent: 'add',
        },
        'triangle-right': {
            parent: 'triangle-left',
            hFlip: true,
        },
    },
 });

// List icons and variations
// [ 'add', 'debug-pause', 'triangle-left', 'triangle-right' ]
console.log(iconSet.list());

// List everything
// [ 'add', 'debug-pause', 'triangle-left', 'plus', 'triangle-right' ]
console.log(iconSet.list(['icon', 'variation', 'alias']));

// Icons only
// [ 'add', 'debug-pause', 'triangle-left' ]
console.log(iconSet.list(['icon']));

// Function can also be used to parse all icons in icon set,  though \`forEach()\` is a better choice for this code
const icons = iconSet.list();
for (let i = 0; i < icons.length; i++) {
    const name = icons[i];
    const svg = iconSet.toSVG(name);
    if (svg) {
        // Clean up icon
        try {
            cleanupSVG(svg);
        } catch (err) {
            // Something went wrong: remove icon
            iconSet.remove(name);
            continue;
        }

        // Change colors to red
        parseColors(svg, {
            defaultColor: 'red',
            callback: (attr, colorStr, color) => {
                return !color || isEmptyColor(color) ? colorStr : 'red';
            },
        });

        // Update code
        iconSet.fromSVG(name, svg);
    }
 }

// Export updated icon set
console.log(iconSet.export());
```

json
```
{
    "prefix": "codicon",
    "icons": {
        "add": {
            "body": "<g fill=\"red\"><path d=\"M14 7v1H8v6H7V8H1V7h6V1h1v6h6z\"/></g>"
        },
        "debug-pause": {
            "body": "<g fill=\"red\"><path d=\"M4.5 3H6v10H4.5V3zm7 0v10H10V3h1.5z\"/></g>",
            "hidden": true
        },
        "triangle-left": {
            "body": "<g fill=\"red\"><path d=\"M10.44 2l.56.413v11.194l-.54.393L5 8.373v-.827L10.44 2z\"/></g>"
        },
        "triangle-right": {
            "body": "<g transform=\"translate(16 0) scale(-1 1)\"><g fill=\"red\"><path d=\"M10.44 2l.56.413v11.194l-.54.393L5 8.373v-.827L10.44 2z\"/></g></g>"
        }
    },
    "aliases": {
        "plus": {
            "parent": "add"
        }
    }
}
```

[Page 119](https://iconify.design/docs/libraries/tools/icon-set/for-each.html "Current Page.")

## forEach()

This function is part of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") class in [Iconify Tools](https://iconify.design/).

Function forEach() runs a custom callback for all icons in icon set.

Function supports asynchronous callbacks.

If you use synchronous callback, you can treat function as synchronous, or you can use forEachSync() alias.

## Usage

Function has the following parameters:

- callback. Callback. See below.
- type, string\[\]. Optional. Icon types to iterate, default is \['icon', 'variation', 'alias'\] (all items).

## Callback

Callback can be synchronous or async. It has the following parameters:

- name, string. Icon name.
- type, string. Icon type (see below).

If callback returns false, function stops iterating icons.

## Icon types

There are 3 types of icon items in [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation"): "icon", "variation", "alias".

"icon" represents a full unique icon.

"variation" represents variation of another icon. It has the following properties:

- parent, string. Name of parent icon.

and at least one of the transformations:

- rotate rotation by 90, 180 or 270 degrees.
- hFlip horizontal flip.
- vFlip vertical flip.

Variations make it easy to create clones of icons, such as arrow-left after creating arrow-right.

"alias" is an alternative name for icon. It has the following property:

- parent, string. Name of parent icon.

Aliases can be created to have different name for icon. If you have renamed some icon, alias can be used to allow users to use old name.

## Example

ts
```
import { IconSet, cleanupSVG, parseColors, isEmptyColor } from '@iconify/tools';

const iconSet = new IconSet({
    prefix: 'codicon',
    icons: {
        'add': {
            body: '<g fill="currentColor"><path d="M14 7v1H8v6H7V8H1V7h6V1h1v6h6z"/></g>',
        },
        'debug-pause': {
            body: '<g fill="currentColor"><path d="M4.5 3H6v10H4.5V3zm7 0v10H10V3h1.5z"/></g>',
            hidden: true,
        },
        'triangle-left': {
            body: '<g fill="currentColor"><path d="M10.44 2l.56.413v11.194l-.54.393L5 8.373v-.827L10.44 2z"/></g>',
        },
    },
    aliases: {
        'plus': {
            parent: 'add',
        },
        'triangle-right': {
            parent: 'triangle-left',
            hFlip: true,
        },
    },
 });

// Synchronous example: renaming all icons
console.log('Starting synchronous forEachSync()');
 iconSet.forEach((name) => {
    iconSet.rename(name, 'renamed-' + name);
    console.log(\`Renaming: ${name}\`);
 });
console.log('Completed synchronous forEachSync()');

// Async example: cleaning up icons.
// Wrap code in anonymous async function for asynchronous use case.
console.log('Starting async forEach()');
 (async () => {
    await iconSet.forEach(async (name, type) => {
        if (type !== 'icon') {
            // Ignore aliases and variations: they inherit content from parent icon, so there is nothing to change
            return;
        }

        const svg = iconSet.toSVG(name);
        if (svg) {
            // Clean up icon
            console.log(\`Cleaning up: ${name}\`);
            try {
                cleanupSVG(svg);
            } catch (err) {
                // Something went wrong: remove icon
                iconSet.remove(name);
                return;
            }

            // Change colors to red
            parseColors(svg, {
                defaultColor: 'red',
                callback: (attr, colorStr, color) => {
                    return !color || isEmptyColor(color) ? colorStr : 'red';
                },
            });

            // Update code
            iconSet.fromSVG(name, svg);
        }
    });

    console.log('Completed async forEach()');
 })();

console.log(
    'End of code... (this code is executed before icons are cleaned up, this is why async anonymous function is needed)'
 );
```

```
Starting synchronous forEach()
 Renaming: add
 Renaming: debug-pause
 Renaming: triangle-left
 Renaming: plus
 Renaming: triangle-right
 Completed synchronous forEach()
 Starting async forEach()
 Cleaning up: renamed-add
 End of code... (this code is executed before icons are cleaned up, this is why async anonymous function is needed)
 Cleaning up: renamed-debug-pause
 Cleaning up: renamed-triangle-left
 Completed async forEach()
```

[Page 120](https://iconify.design/docs/libraries/tools/icon-set/exists.html "Current Page.")

[Page 121](https://iconify.design/docs/libraries/tools/icon-set/count.html "Current Page.")

## count()

This function is part of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") class in [Iconify Tools](https://iconify.design/).

Function count() counts icons in icon set.

## Usage

Function has no parameters.

Function returns number of icons.

## What icons are counted?

Counted:

- Icons.
- Variations (see below).

Not counted:

- Hidden icons and their aliases/variations.
- Aliases.

## Icon types

There are 3 types of icon items in [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation"): "icon", "variation", "alias".

"icon" represents a full unique icon.

"variation" represents variation of another icon. It has the following properties:

- parent, string. Name of parent icon.

and at least one of the transformations:

- rotate rotation by 90, 180 or 270 degrees.
- hFlip horizontal flip.
- vFlip vertical flip.

Variations make it easy to create clones of icons, such as arrow-left after creating arrow-right.

"alias" is an alternative name for icon. It has the following property:

- parent, string. Name of parent icon.

Aliases can be created to have different name for icon. If you have renamed some icon, alias can be used to allow users to use old name.

## Example

ts
```
import { IconSet } from '@iconify/tools';

const iconSet = new IconSet({
    prefix: 'codicon',
    icons: {
        // Counted
        'add': {
            body: '<g fill="currentColor"><path d="M14 7v1H8v6H7V8H1V7h6V1h1v6h6z"/></g>',
        },
        // Ignored: hidden
        'debug-pause': {
            body: '<g fill="currentColor"><path d="M4.5 3H6v10H4.5V3zm7 0v10H10V3h1.5z"/></g>',
            hidden: true,
        },
        // Counted
        'triangle-left': {
            body: '<g fill="currentColor"><path d="M10.44 2l.56.413v11.194l-.54.393L5 8.373v-.827L10.44 2z"/></g>',
        },
    },
    aliases: {
        // Ignored: alias
        'plus': {
            parent: 'add',
        },
        // Counted: variation
        'triangle-right': {
            parent: 'triangle-left',
            hFlip: true,
        },
    },
 });

// Count icons: returns 3
console.log(iconSet.count());
```

[Page 122](https://iconify.design/docs/libraries/tools/icon-set/remove.html "Current Page.")

## remove()

This function is part of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") class in [Iconify Tools](https://iconify.design/).

Function remove() deletes an icon.

## Usage

Function has the following parameters:

- name, string. Icon name.
- removeDependencies, boolean|string. Optional, default is true. What to do with aliases and variations that use removed icon as parent icon.

Function returns number of removed items.

Possible values for removeDependencies property:

- true removes icon, all aliases and variations.
- false removes only icon, does not change aliases and variations.
- string removes icon, changes parent property for aliases and variations to provided value.

## Example

ts
```
import { IconSet } from '@iconify/tools';

const iconSet = new IconSet({
    prefix: 'codicon',
    icons: {
        'add': {
            body: '<g fill="currentColor"><path d="M14 7v1H8v6H7V8H1V7h6V1h1v6h6z"/></g>',
        },
        'debug-pause': {
            body: '<g fill="currentColor"><path d="M4.5 3H6v10H4.5V3zm7 0v10H10V3h1.5z"/></g>',
            hidden: true,
        },
        'triangle-left': {
            body: '<g fill="currentColor"><path d="M10.44 2l.56.413v11.194l-.54.393L5 8.373v-.827L10.44 2z"/></g>',
        },
    },
    aliases: {
        'plus': {
            parent: 'add',
        },
        'triangle-right': {
            parent: 'triangle-left',
            hFlip: true,
        },
    },
 });

// Removes 'add' and 'plus' icons
 iconSet.remove('add');

// Removes 'triangle-left' icon.
// Variation 'triangle-right' no longer has valid parent, but still exists in icon set.
 iconSet.remove('triangle-left', false);

// Export icon set. 'triangle-right' will be in result because export() does not validate icons.
console.log(iconSet.export());
```

json
```
{
    "prefix": "codicon",
    "icons": {
        "debug-pause": {
            "body": "<g fill=\"currentColor\"><path d=\"M4.5 3H6v10H4.5V3zm7 0v10H10V3h1.5z\"/></g>",
            "hidden": true
        }
    },
    "aliases": {
        "triangle-right": { "parent": "triangle-left", "hFlip": true }
    }
}
```

[Page 123](https://iconify.design/docs/libraries/tools/icon-set/rename.html "Current Page.")

## rename()

This function is part of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") class in [Iconify Tools](https://iconify.design/).

Function rename() renames icon.

Function checks aliases and variations that use renamed icon, changes parent icon to new name.

If icon with new name already exists, it will be overwritten.

## Usage

Function has the following parameters:

- oldName, string. Old icon name.
- newName, string. New icon name.

Function returns a simple true on success, false on failure.

## Example

ts
```
import { IconSet } from '@iconify/tools';

// Import icon set
const iconSet = new IconSet({
    prefix: 'carbon',
    icons: {
        'add': {
            body: '<path d="M17 15V8h-2v7H8v2h7v7h2v-7h7v-2z" fill="currentColor"/>',
        },
        'arrow-left': {
            body: '<path d="M14 26l1.41-1.41L7.83 17H28v-2H7.83l7.58-7.59L14 6L4 16l10 10z" fill="currentColor"/>',
        },
    },
    aliases: {
        'plus': {
            parent: 'add',
        },
        'arrow-right': {
            parent: 'arrow-left',
            hFlip: true,
        },
    },
    width: 32,
    height: 32,
 });

// Rename 'add' to 'plus'
 iconSet.rename('add', 'plus');

// Rename 'arrow-left' to 'arrow', also changes 'parent' property in 'arrow-right'
 iconSet.rename('arrow-left', 'arrow');

// Export
console.log(iconSet.export());
```

json
```
{
    "prefix": "carbon",
    "icons": {
        "arrow": {
            "body": "<path d=\"M14 26l1.41-1.41L7.83 17H28v-2H7.83l7.58-7.59L14 6L4 16l10 10z\" fill=\"currentColor\"/>"
        },
        "plus": {
            "body": "<path d=\"M17 15V8h-2v7H8v2h7v7h2v-7h7v-2z\" fill=\"currentColor\"/>"
        }
    },
    "aliases": {
        "arrow-right": { "parent": "arrow", "hFlip": true }
    },
    "width": 32,
    "height": 32
}
```

[Page 124](https://iconify.design/docs/libraries/tools/icon-set/set-item.html "Current Page.")

## setItem()

This function is part of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") class in [Iconify Tools](https://iconify.design/).

Function setItem() adds new item to icon set or overwrites existing item. If item is an alias or variation, function checks for parent icon.

This function is not simple to use. Better use one of simpler functions:

- [setIcon()](https://iconify.design/docs/libraries/tools/icon-set/set-icon.html "setIcon() documentation") to set icon.
- [setVariation()](https://iconify.design/docs/libraries/tools/icon-set/set-variation.html "setVariation() documentation") to set icon variation.
- [setAlias()](https://iconify.design/docs/libraries/tools/icon-set/set-alias.html "setAlias() documentation") to set icon alias.

## Usage

Function has the following parameters:

- name, string. Icon name.
- item, [IconSetIconEntry](https://iconify.design/docs/libraries/tools/icon-set/entries.html#type "IconSetIconEntry documentation"). Icon data.

Function returns a simple true on success, false on failure.

[Page 125](https://iconify.design/docs/libraries/tools/icon-set/set-icon.html "Current Page.")

## setIcon()

This function is part of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") class in [Iconify Tools](https://iconify.design/).

Function [setIcon()](https://iconify.design/docs/libraries/tools/icon-set/set-icon.html "setIcon() documentation") adds new icon to icon set or overwrites existing item.

## Usage

Function has the following parameters:

- name, string. Icon name.
- icon, [ResolvedIconifyIcon](https://iconify.design/docs/libraries/tools/iconify-icon.html "ResolvedIconifyIcon documentation"). Icon data, same as [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation"), but with other optional properties.

Function returns a simple true on success, false on failure.

## Example

ts
```
import { blankIconSet } from '@iconify/tools';

// Create icon set, add few icons
const iconSet = blankIconSet('test-prefix');
 iconSet.setIcon('add', {
    body: '<path d="M14 7v1H8v6H7V8H1V7h6V1h1v6h6z"/>',
 });
 iconSet.setIcon('triangle-left', {
    body: '<g fill="currentColor"><path d="M10.44 2l.56.413v11.194l-.54.393L5 8.373v-.827L10.44 2z"/></g>',
 });
 iconSet.setVariation('triangle-right', 'triangle-left', {
    hFlip: true,
 });

// Set information
 iconSet.info = {
    name: 'Test',
    : {
        name: 'Me',
    },
    license: {
        title: 'MIT',
    },
 };

// Export icon set
const data = iconSet.export();
console.log(JSON.stringify(data, null, '\t'));
```

[Page 126](https://iconify.design/docs/libraries/tools/icon-set/set-variation.html "Current Page.")

## setVariation()

This function is part of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") class in [Iconify Tools](https://iconify.design/).

Function [setVariation()](https://iconify.design/docs/libraries/tools/icon-set/set-variation.html "setVariation() documentation") adds new icon variation to icon set or overwrites existing item.

## Variation

Icon variation is an item that is based on different icon, but has at least one transformation applied to it.

For example, "arrow-left" can be a variation of "arrow-right" with hFlip enabled.

Variations make it easier to maintain icons that are based on other icons and reduce content duplication.

## Usage

Function has the following parameters:

- name, string. Icon name.
- parent, string. Parent item name.
- props, [CommonIconProps](https://iconify.design/docs/libraries/tools/icon-set/entries.html#common "CommonIconProps documentation"). Icon transformations.

Function returns a simple true on success, false on failure.

## Example

ts
```
import { blankIconSet } from '@iconify/tools';

// Create icon set, add few icons
const iconSet = blankIconSet('test-prefix');
 iconSet.setIcon('add', {
    body: '<path d="M17 15V8h-2v7H8v2h7v7h2v-7h7v-2z" fill="currentColor"/>',
    width: 32,
    height: 32,
 });

 iconSet.setIcon('caret-down', {
    body: '<path d="M24 12l-8 10l-8-10z" fill="currentColor"/>',
    width: 32,
    height: 32,
 });
 iconSet.setVariation('caret-up', 'caret-down', {
    vFlip: true,
 });

 iconSet.setAlias('plus', 'add');

// Export icon set
const data = iconSet.export();
console.log(JSON.stringify(data, null, '\t'));
```

json
```
{
    "prefix": "test-prefix",
    "icons": {
        "add": {
            "body": "<path d=\"M17 15V8h-2v7H8v2h7v7h2v-7h7v-2z\" fill=\"currentColor\"/>"
        },
        "caret-down": {
            "body": "<path d=\"M24 12l-8 10l-8-10z\" fill=\"currentColor\"/>"
        }
    },
    "aliases": {
        "caret-up": {
            "parent": "caret-down",
            "vFlip": true
        },
        "plus": {
            "parent": "add"
        }
    },
    "width": 32,
    "height": 32
}
```

[Page 127](https://iconify.design/docs/libraries/tools/icon-set/set-alias.html "Current Page.")

## setAlias()

This function is part of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") class in [Iconify Tools](https://iconify.design/).

Function [setAlias()](https://iconify.design/docs/libraries/tools/icon-set/set-alias.html "setAlias() documentation") adds new icon alias.

## Alias

Icon alias is a different name for icon. It is usually used when renaming icon to allow users access icon using old name.

## Usage

Function has the following parameters:

- name, string. Icon name.
- parent, string. Parent item name.

Function returns a simple true on success, false on failure.

## Example

ts
```
import { blankIconSet } from '@iconify/tools';

// Create icon set, add few icons
const iconSet = blankIconSet('test-prefix');
 iconSet.setIcon('add', {
    body: '<path d="M17 15V8h-2v7H8v2h7v7h2v-7h7v-2z" fill="currentColor"/>',
    width: 32,
    height: 32,
 });

 iconSet.setIcon('caret-down', {
    body: '<path d="M24 12l-8 10l-8-10z" fill="currentColor"/>',
    width: 32,
    height: 32,
 });
 iconSet.setVariation('caret-up', 'caret-down', {
    vFlip: true,
 });

 iconSet.setAlias('plus', 'add');

// Export icon set
const data = iconSet.export();
console.log(JSON.stringify(data, null, '\t'));
```

json
```
{
    "prefix": "test-prefix",
    "icons": {
        "add": {
            "body": "<path d=\"M17 15V8h-2v7H8v2h7v7h2v-7h7v-2z\" fill=\"currentColor\"/>"
        },
        "caret-down": {
            "body": "<path d=\"M24 12l-8 10l-8-10z\" fill=\"currentColor\"/>"
        }
    },
    "aliases": {
        "caret-up": {
            "parent": "caret-down",
            "vFlip": true
        },
        "plus": {
            "parent": "add"
        }
    },
    "width": 32,
    "height": 32
}
```

[Page 128](https://iconify.design/docs/libraries/tools/icon-set/get-tree.html "Current Page.")

## getTree()

This function is part of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") class in [Iconify Tools](https://iconify.design/).

Function getTree() returns list of parent icons for each icon in icon set, null for icons that cannot be resolved.

It is useful when you need to figure out which icons need to be exported when exporting a subset of icons, it can be used to figure out which icons have invalid parent icons.

## Usage

Function has the following optional parameter:

- names, string\[\]. List of icons to check. If not set, all icons will be checked.

Function will return object, where key is icon name, value is:

- null if icon cannot be resolved.
- string\[\] array of parent icon names, excluding icon. First entry is direct parent.

## Example

ts
```
import { IconSet } from '@iconify/tools';

const iconSet = new IconSet({
    prefix: 'foo',
    icons: {
        bar: {
            body: '<g />',
        },
    },
    aliases: {
        baz: {
            parent: 'bar',
        },
        baz2: {
            parent: 'baz',
        },
        bad: {
            parent: 'whatever',
        },
    },
 });

console.log(iconSet.getTree());
```

json
```
{
    "bar": [],
    "baz": ["bar"],
    "baz2": ["baz", "bar"],
    "bad": null,
    "whatever": null
}
```

[Page 129](https://iconify.design/docs/libraries/tools/icon-set/entries.html "Current Page.")

## entries

This property is part of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") class in [Iconify Tools](https://iconify.design/).

Property entries contains data for all icons.

Avoid accessing entries if you can, use the following functions instead:

- [remove(name)](https://iconify.design/docs/libraries/tools/icon-set/remove.html "remove() documentation") removes icon.
- [rename(oldName, newName)](https://iconify.design/docs/libraries/tools/icon-set/rename.html "rename() documentation") renames icon.
- [setIcon(name, icon)](https://iconify.design/docs/libraries/tools/icon-set/set-icon.html "setIcon() documentation") adds/updates icon, using [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") data.
- [setVariation(name, parent, props)](https://iconify.design/docs/libraries/tools/icon-set/set-variation.html "setVariation() documentation") creates a variation (alias with customisations) for icon.
- [setAlias(name, parent)](https://iconify.design/docs/libraries/tools/icon-set/set-alias.html "setAlias() documentation") creates an alias for icon.

## Icon types

There are 3 types of icon items in [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation"): "icon", "variation", "alias".

"icon" represents a full unique icon.

"variation" represents variation of another icon. It has the following properties:

- parent, string. Name of parent icon.

and at least one of the transformations:

- rotate rotation by 90, 180 or 270 degrees.
- hFlip horizontal flip.
- vFlip vertical flip.

Variations make it easy to create clones of icons, such as arrow-left after creating arrow-right.

"alias" is an alternative name for icon. It has the following property:

- parent, string. Name of parent icon.

Aliases can be created to have different name for icon. If you have renamed some icon, alias can be used to allow users to use old name.

## Structure

Property entries is a simple object, where key is icon name and value is [IconSetIconEntry](https://iconify.design/docs/libraries/tools/icon-set/entries.html#type "IconSetIconEntry documentation") entry.

## IconSetIconEntry type

Type [IconSetIconEntry](https://iconify.design/docs/libraries/tools/icon-set/entries.html#type "IconSetIconEntry documentation") is a set of 3 types:

- IconSetIcon represents icon (type = 'icon').
- IconSetIconAlias represents alias (type = 'alias').
- IconSetIconVariation represents icon variation (type = 'variation').

To check the type, access type property of icon data.

## Properties

The following properties exist only in IconSetIcon type:

- body, string. Icon content.

The following properties exist on IconSetIcon and IconSetIconVariation types:

- props, [CommonIconProps](https://iconify.design/docs/libraries/tools/icon-set/entries.html#common "CommonIconProps documentation"). Icon data. See below.
- categories, Set<IconCategory>. List of categories, see [categories](https://iconify.design/docs/libraries/tools/icon-set/categories.html "categories() documentation") property.

The following properties exist on IconSetIconVariation and IconSetIconAlias types:

- parent, string. Parent item. Parent item can be any type, though usually it is an icon.

The following properties exist on all types:

- chars, Set<string>. List of characters, see chars() function.

### CommonIconProps type

Type [CommonIconProps](https://iconify.design/docs/libraries/tools/icon-set/entries.html#common "CommonIconProps documentation") is mix of common properties that exist in both ExtendedIconifyIcon and ExtendedIconifyAlias types. It is almost identical to [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") type, but with small differences:

- New property: hidden, boolean.
- Property body does not exist. It is available in IconSetIcon type.

[Page 130](https://iconify.design/docs/libraries/tools/icon-set/resolve.html "Current Page.")

## resolve()

This function is part of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") class in [Iconify Tools](https://iconify.design/).

Function resolve() retrieve data for icon in [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") format.

## Usage

Function has the following parameters:

- name, string. Icon name.
- full, boolean. Optional. If true, function will return full icon data ([FullIconifyIcon](https://iconify.design/docs/libraries/utils/full-iconify-icon.html "FullIconifyIcon documentation")).

Function returns [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") (or [FullIconifyIcon](https://iconify.design/docs/libraries/utils/full-iconify-icon.html "FullIconifyIcon documentation") if second parameter is true), null on error.

## Example

ts
```
import { IconSet } from '@iconify/tools';

const iconSet = new IconSet({
    prefix: 'codicon',
    icons: {
        'add': {
            body: '<g fill="currentColor"><path d="M14 7v1H8v6H7V8H1V7h6V1h1v6h6z"/></g>',
        },
        'debug-pause': {
            body: '<g fill="currentColor"><path d="M4.5 3H6v10H4.5V3zm7 0v10H10V3h1.5z"/></g>',
            hidden: true,
        },
        'triangle-left': {
            body: '<g fill="currentColor"><path d="M10.44 2l.56.413v11.194l-.54.393L5 8.373v-.827L10.44 2z"/></g>',
        },
    },
    aliases: {
        'plus': {
            parent: 'add',
        },
        'triangle-right': {
            parent: 'triangle-left',
            hFlip: true,
        },
    },
 });

// Resolve icon (partial and full)
console.log(iconSet.resolve('debug-pause'));
console.log(iconSet.resolve('debug-pause', true));

// Resolve variation (partial and full)
console.log(iconSet.resolve('triangle-right'));
console.log(iconSet.resolve('triangle-right', true));

// Resolve alias (partial and full)
console.log(iconSet.resolve('plus'));
console.log(iconSet.resolve('plus', true));
```

json
```
{
    "body": "<g fill=\"currentColor\"><path d=\"M4.5 3H6v10H4.5V3zm7 0v10H10V3h1.5z\"/></g>",
    "hidden": true
}
```

json
```
{
    "left": 0,
    "top": 0,
    "width": 16,
    "height": 16,
    "rotate": 0,
    "vFlip": false,
    "hFlip": false,
    "body": "<g fill=\"currentColor\"><path d=\"M4.5 3H6v10H4.5V3zm7 0v10H10V3h1.5z\"/></g>",
    "hidden": true
}
```

json
```
{
    "body": "<g fill=\"currentColor\"><path d=\"M10.44 2l.56.413v11.194l-.54.393L5 8.373v-.827L10.44 2z\"/></g>",
    "hFlip": true
}
```

json
```
{
    "left": 0,
    "top": 0,
    "width": 16,
    "height": 16,
    "rotate": 0,
    "vFlip": false,
    "hFlip": true,
    "body": "<g fill=\"currentColor\"><path d=\"M10.44 2l.56.413v11.194l-.54.393L5 8.373v-.827L10.44 2z\"/></g>"
}
```

json
```
{
    "body": "<g fill=\"currentColor\"><path d=\"M14 7v1H8v6H7V8H1V7h6V1h1v6h6z\"/></g>"
}
```

json
```
{
    "left": 0,
    "top": 0,
    "width": 16,
    "height": 16,
    "rotate": 0,
    "vFlip": false,
    "hFlip": false,
    "body": "<g fill=\"currentColor\"><path d=\"M14 7v1H8v6H7V8H1V7h6V1h1v6h6z\"/></g>"
}
```

[Page 131](https://iconify.design/docs/libraries/tools/icon-set/load.html "Current Page.")

## load()

This function is part of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") class in [Iconify Tools](https://iconify.design/).

Function load() loads icon set from [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") data.

It replaces existing icon set data, so it is identical to creating new [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") instance. If you want to merge icon sets instead, see [mergeIconSets()](https://iconify.design/docs/libraries/tools/ "mergeIconSets() documentation") function.

## Validation

Function does not validate icon set. If you are not sure about source, you need to validate it using [validateIconSet()](https://iconify.design/docs/libraries/utils/validate-icon-set.html "validateIconSet() documentation") from [Iconify Utils](https://iconify.design/utils/).

## Example

ts
```
iconSet.load({
    prefix: 'codicon',
    icons: {
        'add': {
            body: '<g fill="currentColor"><path d="M14 7v1H8v6H7V8H1V7h6V1h1v6h6z"/></g>',
        },
        'chrome-maximize': {
            body: '<g fill="currentColor"><path d="M3 3v10h10V3H3zm9 9H4V4h8v8z"/></g>',
        },
        'chrome-minimize': {
            body: '<g fill="currentColor"><path d="M14 8v1H3V8h11z"/></g>',
        },
    },
 });
```

[Page 132](https://iconify.design/docs/libraries/tools/icon-set/export.html "Current Page.")

## export()

This function is part of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") class in [Iconify Tools](https://iconify.design/).

Function export() exports icon set as [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") object.

## Usage

Function has the following parameters:

- validate, boolean. Optional. If enabled, icons will be validated before export.

Function returns [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") object.

Result includes all metadata. If icon set has information property, export will automatically update total number of icons in info block.

## Example

ts
```
import { blankIconSet } from '@iconify/tools';

// Create icon set, add few icons
const iconSet = blankIconSet('test-prefix');
 iconSet.setIcon('add', {
    body: '<path d="M14 7v1H8v6H7V8H1V7h6V1h1v6h6z"/>',
 });
 iconSet.setIcon('triangle-left', {
    body: '<g fill="currentColor"><path d="M10.44 2l.56.413v11.194l-.54.393L5 8.373v-.827L10.44 2z"/></g>',
 });
 iconSet.setVariation('triangle-right', 'triangle-left', {
    hFlip: true,
 });

// Set information
 iconSet.info = {
    name: 'Test',
    : {
        name: 'Me',
    },
    license: {
        title: 'MIT',
    },
 };

// Export icon set
const data = iconSet.export();
console.log(JSON.stringify(data, null, '\t'));
```

json
```
{
    "prefix": "test-prefix",
    "info": {
        "name": "Test",
        "author": {
            "name": "Me"
        },
        "license": {
            "title": "MIT"
        },
        "total": 3
    },
    "icons": {
        "add": {
            "body": "<path d=\"M14 7v1H8v6H7V8H1V7h6V1h1v6h6z\"/>"
        },
        "triangle-left": {
            "body": "<g fill=\"currentColor\"><path d=\"M10.44 2l.56.413v11.194l-.54.393L5 8.373v-.827L10.44 2z\"/></g>"
        }
    },
    "aliases": {
        "triangle-right": {
            "parent": "triangle-left",
            "hFlip": true
        }
    }
}
```

[Page 133](https://iconify.design/docs/libraries/tools/icon-set/to-svg.html "Current Page.")

## toSVG()

This function is part of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") class in [Iconify Tools](https://iconify.design/).

Function toSVG() exports icon as [SVG](https://iconify.design/docs/libraries/tools/svg/ "SVG documentation") instance.

It is used to process icon using functions that work with [SVG](https://iconify.design/docs/libraries/tools/svg/ "SVG documentation") instances.

### Important notice

[SVG](https://iconify.design/docs/libraries/tools/svg/ "SVG documentation") instance is not synchronised with an icon set.

After changing icon, you need to update entry in [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") using [fromSVG()](https://iconify.design/docs/libraries/tools/icon-set/from-svg.html "fromSVG() documentation") method.

## Usage

The function has the following parameter:

- name, string. Icon name.

Function returns [SVG](https://iconify.design/docs/libraries/tools/svg/ "SVG documentation") instance on success, null on error.

## Example

ts
```
import { blankIconSet, parseColors, isEmptyColor } from '@iconify/tools';

// Create an icon set, add one icon
const iconSet = blankIconSet('');
 iconSet.setIcon('add', {
    body: '<path d="M14 7v1H8v6H7V8H1V7h6V1h1v6h6z"/>',
 });

// Export icon to SVG class instance
// Note: SVG instance is not attached to icon set, so it is not updated automatically (see code below).
const svg = iconSet.toSVG('add');
if (!svg) {
    throw new Error('Icon is missing');
 }

// Set fill to 'currentColor'
parseColors(svg, {
    // If a shape uses default color (used in this example), change it to 'currentColor'.
    defaultColor: 'currentColor',

    // Callback to change colors. Not called in this example because there are no colors in sample icon.
    callback: (attr, colorStr, color) => {
        // color === null -> color cannot be parsed -> return colorStr
        // isEmptyColor() -> checks if color is empty: 'none' or 'transparent' -> return color object
        //         without changes (though color string can also be returned, but using object is faster)
        // for everything else return 'currentColor'
        return !color ? colorStr : isEmptyColor(color) ? color : 'currentColor';
    },
 });

// Icon instance is not attached to icon set, so it is not updated automatically.
// Update icon in icon set
 iconSet.fromSVG('add', svg);

// Log to show icon (two ways to do it, one from icon set, one from icon instance)
console.log(svg.toString());
console.log(iconSet.toString('add'));
```

svg
```
<svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="16" height="16" preserveAspectRatio="xMidYMid meet" viewBox="0 0 16 16"><path d="M14 7v1H8v6H7V8H1V7h6V1h1v6h6z" fill="currentColor"/></svg>
```

[Page 134](https://iconify.design/docs/libraries/tools/icon-set/from-svg.html "Current Page.")

## fromSVG()

This function is part of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") class in [Iconify Tools](https://iconify.design/).

Function fromSVG() imports icon from [SVG](https://iconify.design/docs/libraries/tools/svg/ "SVG documentation") instance to [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") icon set. It can be used to add a new icon or replace an existing icon.

## Usage

Function has the following parameters:

- name, string. Icon name.
- svg, [SVG](https://iconify.design/docs/libraries/tools/svg/ "SVG documentation"). SVG instance.

Function returns true on success, false on failure.

## Example

ts
```
import { blankIconSet, parseColors, isEmptyColor } from '@iconify/tools';

// Create an icon set, add one icon
const iconSet = blankIconSet('');
 iconSet.setIcon('add', {
    body: '<path d="M14 7v1H8v6H7V8H1V7h6V1h1v6h6z"/>',
 });

// Export icon to SVG class instance
// Note: SVG instance is not attached to icon set, so it is not updated automatically (see code below).
const svg = iconSet.toSVG('add');
if (!svg) {
    throw new Error('Icon is missing');
 }

// Set fill to 'currentColor'
parseColors(svg, {
    // If a shape uses default color (used in this example), change it to 'currentColor'.
    defaultColor: 'currentColor',

    // Callback to change colors. Not called in this example because there are no colors in sample icon.
    callback: (attr, colorStr, color) => {
        // color === null -> color cannot be parsed -> return colorStr
        // isEmptyColor() -> checks if color is empty: 'none' or 'transparent' -> return color object
        //         without changes (though color string can also be returned, but using object is faster)
        // for everything else return 'currentColor'
        return !color ? colorStr : isEmptyColor(color) ? color : 'currentColor';
    },
 });

// Icon instance is not attached to icon set, so it is not updated automatically.
// Update icon in icon set
 iconSet.fromSVG('add', svg);

// Log to show icon (two ways to do it, one from icon set, one from icon instance)
console.log(svg.toString());
console.log(iconSet.toString('add'));
```

svg
```
<svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="16" height="16" preserveAspectRatio="xMidYMid meet" viewBox="0 0 16 16"><path d="M14 7v1H8v6H7V8H1V7h6V1h1v6h6z" fill="currentColor"/></svg>
```

[Page 135](https://iconify.design/docs/libraries/tools/icon-set/to-string.html "Current Page.")

## toString()

This function is part of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") class in [Iconify Tools](https://iconify.design/).

Function toString() exports icon as string.

## Usage

Function has the following parameters:

- name, string. Icon name.
- customisations, [IconifyIconCustomisations](https://iconify.design/docs/libraries/utils/icon-customisations.html "IconifyIconCustomisations documentation"). Optional list of customisations.

Function returns rendered icon as string on success, null if icon does not exist.

## Customisations

If customisations is not set, default value is:

json
```
{
    "width": "auto",
    "height": "auto"
}
```

which results in width and height of icon matching viewBox (see example below).

If you want to use 1em height, use the following customisations:

json
```
{
    "height": "1em"
}
```

## Example

ts
```
import { blankIconSet } from '@iconify/tools';

const iconSet = blankIconSet('');
 iconSet.setIcon('add', {
    body: '<g fill="currentColor"><path d="M14 7v1H8v6H7V8H1V7h6V1h1v6h6z"/></g>',
 });

// Export icon
console.log(iconSet.toString('add'));
```

svg
```
<svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="16" height="16" preserveAspectRatio="xMidYMid meet" viewBox="0 0 16 16"><g fill="currentColor"><path d="M14 7v1H8v6H7V8H1V7h6V1h1v6h6z"/></g></svg>
```

[Page 136](https://iconify.design/docs/libraries/tools/icon-set/prefix.html "Current Page.")

## prefix

This property is part of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") class in [Iconify Tools](https://iconify.design/).

Property prefix contains icon set prefix, string.

You can write to property directly to update value.

[Page 137](https://iconify.design/docs/libraries/tools/icon-set/info.html "Current Page.")

## info

This property is part of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") class in [Iconify Tools](https://iconify.design/).

Property info contains icon set information in [IconifyInfo](https://iconify.design/docs/types/iconify-info.html "IconifyInfo documentation") format. It includes icon set name, license, author information and some other data relevant when displaying an icon set.

If an icon set does not have the information block, value is null.

You can write to property directly to update value.

## Value

Value is used when exporting icon set using [export()](https://iconify.design/docs/libraries/tools/icon-set/export.html "export() documentation") function.

Icons count in info property is automatically updated when running [export()](https://iconify.design/docs/libraries/tools/icon-set/export.html "export() documentation") function, so no need to update it manually.

[Page 138](https://iconify.design/docs/libraries/tools/icon-set/chars.html "Current Page.")

## chars()

This function is part of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") class in [Iconify Tools](https://iconify.design/).

Function chars() exports characters map. Function is used by [export()](https://iconify.design/docs/libraries/tools/icon-set/export.html "export() documentation") function to add characters map to [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") data.

## Usage

Function has one parameter:

- names, string\[\]. Optional. List of icons to check.

Function returns a simple Record<string,string> object. Key is character, in hexadecimal form (such as "u1f3cc"), value is name of icon.

## Character map

What is the purpose of characters map?

It is used to generate icon fonts. Each icon in an icon font has a character assigned to it. Even when using ligatures, ligatures point to a character, so character is needed.

### How to assign a character to icon?

You can assign a character to icon by using [toggleCharacter()](https://iconify.design/docs/libraries/tools/icon-set/toggle-character.html "toggleCharacter() documentation") method.

## Example

ts
```
import { blankIconSet } from '@iconify/tools';

// Create icon set, add few icons and characters
const iconSet = blankIconSet('test-prefix');

 iconSet.setIcon('add', {
    body: '<path d="M14 7v1H8v6H7V8H1V7h6V1h1v6h6z"/>',
 });
 iconSet.toggleCharacter('add', 'f001', true);

 iconSet.setIcon('triangle-left', {
    body: '<g fill="currentColor"><path d="M10.44 2l.56.413v11.194l-.54.393L5 8.373v-.827L10.44 2z"/></g>',
 });
 iconSet.toggleCharacter('triangle-left', 'f002', true);

 iconSet.setVariation('triangle-right', 'triangle-left', {
    hFlip: true,
 });
 iconSet.toggleCharacter('triangle-right', 'f003', true);

// Set character for icon that does not exist (will fail)
 iconSet.toggleCharacter('whatever', 'f005', true);

// Export characters map
console.log(iconSet.chars());

// Characters map is also exported in export():
console.log(iconSet.export());
```

json
```
{
    "f001": "add",
    "f002": "triangle-left",
    "f003": "triangle-right"
}
```

json
```
{
    "prefix": "test-prefix",
    "icons": {
        "add": { "body": "<path d=\"M14 7v1H8v6H7V8H1V7h6V1h1v6h6z\"/>" },
        "triangle-left": {
            "body": "<g fill=\"currentColor\"><path d=\"M10.44 2l.56.413v11.194l-.54.393L5 8.373v-.827L10.44 2z\"/></g>"
        }
    },
    "aliases": {
        "triangle-right": { "parent": "triangle-left", "hFlip": true }
    },
    "chars": {
        "f001": "add",
        "f002": "triangle-left",
        "f003": "triangle-right"
    }
}
```

[Page 139](https://iconify.design/docs/libraries/tools/icon-set/toggle-character.html "Current Page.")

## toggleCharacter()

This function is part of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") class in [Iconify Tools](https://iconify.design/).

Function toggleCharacter() adds character to icon or removes it.

## Usage

Function has the following parameters:

- iconName, string. Icon name.
- char, string. Character as hexadecimal string, such as "f001".
- add, boolean. If true, character will be added to icon. If false, character will be removed from icon.

Function returns true on success, false on failure.

## Character map

What is the purpose of characters map?

It is used to generate icon fonts. Each icon in an icon font has a character assigned to it. Even when using ligatures, ligatures point to a character, so character is needed.

## How to find all characters?

You can get list of all assigned characters by using [chars()](https://iconify.design/docs/libraries/tools/icon-set/chars.html "chars() documentation") method.

If you want to know characters assigned to an icon, use code like this:

ts
```
const item = iconSet.entries['some-icon'];
// Set<string>
console.log(item.chars);
```

It is safe to modify characters directly in [entries](https://iconify.design/docs/libraries/tools/icon-set/entries.html "entries() documentation") property.

## Example

ts
```
import { blankIconSet } from '@iconify/tools';

// Create icon set, add few icons and characters
const iconSet = blankIconSet('test-prefix');

 iconSet.setIcon('add', {
    body: '<path d="M14 7v1H8v6H7V8H1V7h6V1h1v6h6z"/>',
 });
 iconSet.toggleCharacter('add', 'f001', true);

 iconSet.setIcon('triangle-left', {
    body: '<g fill="currentColor"><path d="M10.44 2l.56.413v11.194l-.54.393L5 8.373v-.827L10.44 2z"/></g>',
 });
 iconSet.toggleCharacter('triangle-left', 'f002', true);

 iconSet.setVariation('triangle-right', 'triangle-left', {
    hFlip: true,
 });
 iconSet.toggleCharacter('triangle-right', 'f003', true);

// Set character for icon that does not exist (will fail)
 iconSet.toggleCharacter('whatever', 'f005', true);

// Export characters map
console.log(iconSet.chars());

// Characters map is also exported in export():
console.log(iconSet.export());
```

[Page 140](https://iconify.design/docs/libraries/tools/icon-set/list-category.html "Current Page.")

## listCategory()

This function is part of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") class in [Iconify Tools](https://iconify.design/).

Function listCategory() lists icons that belong to a category.

Categories are used to filter icons when displaying icon set.

## Usage

Function has the following parameter:

- category, string| [IconCategory](https://iconify.design/docs/libraries/tools/icon-set/categories.html#type "IconCategory documentation"). Category name or item.

Function returns string\[\] array of icon names.

Result does not include:

- Hidden icons (and their variations).
- Aliases.

This function automatically updates count property of [IconCategory](https://iconify.design/docs/libraries/tools/icon-set/categories.html#type "IconCategory documentation") item. If category is empty, category is removed from [categories](https://iconify.design/docs/libraries/tools/icon-set/categories.html "categories() documentation") property of icon set.

## Example

ts
```
import { IconSet } from '@iconify/tools';

// Import icon set
const iconSet = new IconSet({
    prefix: 'carbon',
    icons: {
        'add': {
            body: '<path d="M17 15V8h-2v7H8v2h7v7h2v-7h7v-2z" fill="currentColor"/>',
        },
        'arrow-down': {
            body: '<path d="M24.59 16.59L17 24.17V4h-2v20.17l-7.59-7.58L6 18l10 10l10-10l-1.41-1.41z" fill="currentColor"/>',
        },
        'arrow-left': {
            body: '<path d="M14 26l1.41-1.41L7.83 17H28v-2H7.83l7.58-7.59L14 6L4 16l10 10z" fill="currentColor"/>',
        },
        'back-to-top': {
            body: '<path d="M16 14L6 24l1.4 1.4l8.6-8.6l8.6 8.6L26 24z" fill="currentColor"/><path d="M4 8h24v2H4z" fill="currentColor"/>',
        },
        'bookmark-filled': {
            body: '<path d="M24 2H8a2 2 0 0 0-2 2v26l10-5.054L26 30V4a2 2 0 0 0-2-2z" fill="currentColor"/>',
        },
        'caret-down': {
            body: '<path d="M24 12l-8 10l-8-10z" fill="currentColor"/>',
        },
        'caret-left': {
            body: '<path d="M20 24l-10-8l10-8z" fill="currentColor"/>',
        },
    },
    aliases: {
        'plus': {
            parent: 'add',
        },
        'arrow-up': {
            parent: 'arrow-down',
            vFlip: true,
        },
        'arrow-right': {
            parent: 'arrow-left',
            hFlip: true,
        },
        'caret-up': {
            parent: 'caret-down',
            vFlip: true,
        },
        'caret-right': {
            parent: 'caret-left',
            hFlip: true,
        },
    },
    width: 32,
    height: 32,
 });

// Add few categories
 iconSet.toggleCategory('arrow-down', 'Arrows', true);
 iconSet.toggleCategory('arrow-left', 'Arrows', true);
 iconSet.toggleCategory('caret-down', 'Arrows', true);
 iconSet.toggleCategory('caret-left', 'Arrows', true);
 iconSet.toggleCategory('bookmark-filled', 'Bookmarks', true);
 iconSet.toggleCategory('bookmark-filled', 'Filled', true);

// List icons in category
// [ 'arrow-down', 'arrow-left', 'caret-down', 'caret-left' ]
console.log(iconSet.listCategory('Arrows'));

// Rename category using \`categories\` property
 iconSet.categories.forEach((item) => {
    if (item.title === 'Arrows') {
        item.title = 'Simple Icons';
    }
 });

// List icons in category (no longer exists)
// null
console.log(iconSet.listCategory('Arrows'));
```

[Page 141](https://iconify.design/docs/libraries/tools/icon-set/toggle-category.html "Current Page.")

## toggleCategory()

This function is part of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") class in [Iconify Tools](https://iconify.design/).

Function toggleCategory() adds category to icon.

Categories are used to filter icons when displayng icon set.

## Usage

Function has the following parameter:

- iconName, string. Icon name.
- category, string. Category name.
- add, boolean. If true, category will be added to icon. If false, category will be removed.

Function returns true on success, false on failure.

## Example

ts
```
import { IconSet } from '@iconify/tools';

// Import icon set
const iconSet = new IconSet({
    prefix: 'carbon',
    icons: {
        'add': {
            body: '<path d="M17 15V8h-2v7H8v2h7v7h2v-7h7v-2z" fill="currentColor"/>',
        },
        'arrow-down': {
            body: '<path d="M24.59 16.59L17 24.17V4h-2v20.17l-7.59-7.58L6 18l10 10l10-10l-1.41-1.41z" fill="currentColor"/>',
        },
        'arrow-left': {
            body: '<path d="M14 26l1.41-1.41L7.83 17H28v-2H7.83l7.58-7.59L14 6L4 16l10 10z" fill="currentColor"/>',
        },
        'back-to-top': {
            body: '<path d="M16 14L6 24l1.4 1.4l8.6-8.6l8.6 8.6L26 24z" fill="currentColor"/><path d="M4 8h24v2H4z" fill="currentColor"/>',
        },
        'bookmark-filled': {
            body: '<path d="M24 2H8a2 2 0 0 0-2 2v26l10-5.054L26 30V4a2 2 0 0 0-2-2z" fill="currentColor"/>',
        },
        'caret-down': {
            body: '<path d="M24 12l-8 10l-8-10z" fill="currentColor"/>',
        },
        'caret-left': {
            body: '<path d="M20 24l-10-8l10-8z" fill="currentColor"/>',
        },
    },
    aliases: {
        'plus': {
            parent: 'add',
        },
        'arrow-up': {
            parent: 'arrow-down',
            vFlip: true,
        },
        'arrow-right': {
            parent: 'arrow-left',
            hFlip: true,
        },
        'caret-up': {
            parent: 'caret-down',
            vFlip: true,
        },
        'caret-right': {
            parent: 'caret-left',
            hFlip: true,
        },
    },
    width: 32,
    height: 32,
 });

// Add few categories
 iconSet.toggleCategory('arrow-down', 'Arrows', true);
 iconSet.toggleCategory('arrow-left', 'Arrows', true);
 iconSet.toggleCategory('caret-down', 'Arrows', true);
 iconSet.toggleCategory('caret-left', 'Arrows', true);
 iconSet.toggleCategory('bookmark-filled', 'Bookmarks', true);
 iconSet.toggleCategory('bookmark-filled', 'Filled', true);

// List icons in category
// [ 'arrow-down', 'arrow-left', 'caret-down', 'caret-left' ]
console.log(iconSet.listCategory('Arrows'));

// Rename category using \`categories\` property
 iconSet.categories.forEach((item) => {
    if (item.title === 'Arrows') {
        item.title = 'Simple Icons';
    }
 });

// List icons in category (no longer exists)
// null
console.log(iconSet.listCategory('Arrows'));
```

[Page 142](https://iconify.design/docs/libraries/tools/icon-set/categories.html "Current Page.")

This property is part of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") class in [Iconify Tools](https://iconify.design/).

Property categories contains list of categories.

## Structure

Property categories is a Set of [IconCategory](https://iconify.design/docs/libraries/tools/icon-set/categories.html#type "IconCategory documentation") entries.

## IconCategory type

Type [IconCategory](https://iconify.design/docs/libraries/tools/icon-set/categories.html#type "IconCategory documentation") has the following properties:

- title, string. Category title.
- count, number. Number of icons.

Number of icons is approximate, to get exact number use [listCategory()](https://iconify.design/docs/libraries/tools/icon-set/list-category.html "listCategory() documentation") function. Running [listCategory()](https://iconify.design/docs/libraries/tools/icon-set/list-category.html "listCategory() documentation") updates [IconCategory](https://iconify.design/docs/libraries/tools/icon-set/categories.html#type "IconCategory documentation") entry and deletes empty categories.

[Page 143](https://iconify.design/docs/libraries/tools/icon-set/check-theme.html "Current Page.")

## checkTheme()

This function is part of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") class in [Iconify Tools](https://iconify.design/).

Function checkTheme() finds all icons that belong to theme. It can be used to validate themes to make sure there are no empty or missing themes.

## Usage

Function has the following parameter:

- prefix, boolean. What to check. If true, function checks [prefixes](https://iconify.design/docs/libraries/tools/icon-set/themes.html "prefixes() documentation"). If false, function checks [suffixes](https://iconify.design/docs/libraries/tools/icon-set/themes.html "suffixes() documentation").

Function returns an object with the following properties:

- valid, Record<string,string\[\]>. Icons that match theme. Key is theme name (not title!), value is array of icon names.
- invalid, string\[\]. Icons that do not match any theme.

## Example

ts
```
import { IconSet } from '@iconify/tools';

// Import icon set
const iconSet = new IconSet({
    prefix: 'carbon',
    icons: {
        'add': {
            body: '<path d="M17 15V8h-2v7H8v2h7v7h2v-7h7v-2z" fill="currentColor"/>',
        },
        'arrow-down-regular': {
            body: '<path d="M24.59 16.59L17 24.17V4h-2v20.17l-7.59-7.58L6 18l10 10l10-10l-1.41-1.41z" fill="currentColor"/>',
        },
        'arrow-left-regular': {
            body: '<path d="M14 26l1.41-1.41L7.83 17H28v-2H7.83l7.58-7.59L14 6L4 16l10 10z" fill="currentColor"/>',
        },
        'back-to-top-regular': {
            body: '<path d="M16 14L6 24l1.4 1.4l8.6-8.6l8.6 8.6L26 24z" fill="currentColor"/><path d="M4 8h24v2H4z" fill="currentColor"/>',
        },
        'bookmark-filled': {
            body: '<path d="M24 2H8a2 2 0 0 0-2 2v26l10-5.054L26 30V4a2 2 0 0 0-2-2z" fill="currentColor"/>',
        },
        'caret-down-regular': {
            body: '<path d="M24 12l-8 10l-8-10z" fill="currentColor"/>',
        },
        'caret-left-regular': {
            body: '<path d="M20 24l-10-8l10-8z" fill="currentColor"/>',
        },
    },
    aliases: {
        'add-regular': {
            parent: 'add',
        },
        'arrow-up-regular': {
            parent: 'arrow-down-regular',
            vFlip: true,
        },
        'arrow-right-regular': {
            parent: 'arrow-left-regular',
            hFlip: true,
        },
        'caret-up-regular': {
            parent: 'caret-down-regular',
            vFlip: true,
        },
        'caret-right-regular': {
            parent: 'caret-left-regular',
            hFlip: true,
        },
    },
    width: 32,
    height: 32,
    prefixes: {
        arrow: 'Arrows',
        caret: 'Carets',
    },
    suffixes: {
        'filled': 'Filled',
        'regular': 'Regular',
        '': 'Other',
    },
 });

// Check all prefixes
console.log(iconSet.checkTheme(true));

// Check all suffixes
console.log(iconSet.checkTheme(false));
```

json
```
{
    "valid": {
        "arrow": [
            "arrow-down-regular",
            "arrow-left-regular",
            "arrow-up-regular",
            "arrow-right-regular"
        ],
        "caret": [
            "caret-down-regular",
            "caret-left-regular",
            "caret-up-regular",
            "caret-right-regular"
        ]
    },
    "invalid": ["add", "back-to-top-regular", "bookmark-filled"]
}
```

json
```
{
    "valid": {
        "regular": [
            "arrow-down-regular",
            "arrow-left-regular",
            "back-to-top-regular",
            "caret-down-regular",
            "caret-left-regular",
            "arrow-up-regular",
            "arrow-right-regular",
            "caret-up-regular",
            "caret-right-regular"
        ],
        "filled": ["bookmark-filled"],
        "": ["add"]
    },
    "invalid": []
}
```

[Page 144](https://iconify.design/docs/libraries/tools/icon-set/themes.html "Current Page.")

## Themes

Theme properties are part of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") class in [Iconify Tools](https://iconify.design/).

Themes are used to quickly place icons in categories based on part of icon name without listing every single icon.

There are two properties:

- prefix is for prefixes, such as "baseline" in "baseline-home".
- suffix is for suffixes, such as "twotone" in "home-twotone".

You can write to properties directly to update values.

## Structure

Both are simple objects Record<string,string>, where:

- key is part of icon name, can be empty string
- value is title

## Examples

Examples below show suffixes. Prefixes work just like suffixes, but compare first part of icon.

Example of suffixes list:

json
```
{
    "line": "Line",
    "solid": "Solid"
}
```

Prefixes and suffixes should not start or end with "-".

All icons that end with "-line" belong to "Line" category, all icons that end with "-solid" belong to "Solid" category.

If icon ends with something else, like "-outline", it will not belong to "Line" category because icons are checked for '-' + suffix (or prefix + '-' for prefixes).

### Multiple similar items

There can be multiple matching suffixes, such as "24-line" and "line".

There can also be empty suffix (and prefix), which matches icons that do not match other suffixes.

Example of suffixes:

json
```
{
    "24-line": "Line 24",
    "line": "Line",
    "": "Other"
}
```

Icon "home-24-line" will belong to "Line 24" suffix, icon "home-20-line" will belong to "Line" suffix, icon "home-solid" will belong to "Other" suffix.

Order of suffixes and prefixes does not matter. They are sorted by length (longest first) before matching icons to make sure icons are placed in correct theme regardless of order.

## Finding icons

To find which icons belong to which theme, use [checkTheme()](https://iconify.design/docs/libraries/tools/icon-set/check-theme.html "checkTheme() documentation") function.

[Page 145](https://iconify.design/docs/libraries/tools/icon-set/merge.html "Current Page.")

## mergeIconSets()

This function is part of [Iconify Tools package](https://iconify.design/).

Function mergeIconSets() merges to icon sets, creating new [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") instance.

## Why merge icon sets?

When you update an icon set, often old icons are lost. If someone is using an old icon, which no longer exists or was renamed, removing that icon will result in a broken UI. This is why icons should never be removed.

Merging new icon set and old icon set ensures that icons are never removed. Merge process adds missing icons, but marks them as hidden, so they are not shown in icons list, but are available to anyone using old icons.

This function attempts to detect renamed icons, creating aliases for those icons.

## Usage

Function has the following parameters:

- oldIcons, [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation"). Old version of icon set.
- newIcons, [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation"). New version of icon set.

Function does not modify icon sets passed in parameters, it creates new [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") instance and returns it.

## Example

ts
```
import { IconSet, mergeIconSets } from '@iconify/tools';

// Merge 2 icon sets
const merged = mergeIconSets(
    new IconSet({
        // Prefix, info, categories, characters are not copied from old icon set
        prefix: 'foo',
        icons: {
            'chrome-maximize': {
                body: '<g fill="currentColor"><path d="M3 3v10h10V3H3zm9 9H4V4h8v8z"/></g>',
            },
            'chrome-minimize': {
                body: '<g fill="currentColor"><path d="M14 8v1H3V8h11z"/></g>',
            },
        },
        width: 24,
        height: 24,
    }),
    new IconSet({
        prefix: 'bar',
        icons: {
            remove: {
                body: '<g fill="currentColor"><path d="M15 8H1V7h14v1z"/></g>',
            },
        },
    })
 );

// Log merged icon set
console.log(merged.export());
```

json
```
{
    "prefix": "bar",
    "icons": {
        "remove": {
            "body": "<g fill=\"currentColor\"><path d=\"M15 8H1V7h14v1z\"/></g>",
            "width": 16,
            "height": 16
        },
        "chrome-maximize": {
            "body": "<g fill=\"currentColor\"><path d=\"M3 3v10h10V3H3zm9 9H4V4h8v8z\"/></g>",
            "hidden": true
        },
        "chrome-minimize": {
            "body": "<g fill=\"currentColor\"><path d=\"M14 8v1H3V8h11z\"/></g>",
            "hidden": true
        }
    },
    "width": 24,
    "height": 24
}
```

[Page 146](https://iconify.design/docs/libraries/tools/icon/cleanup.html "Current Page.")

## Icon cleanup and validation

Cleanup functions are used in [Iconify Tools](https://iconify.design/) to validate and clean up imported icons.

Unfortunately, many editors leave lots of junk in SVG files, sometimes multiplying icon file size several times.

SVG files might also contain scripts and links to external resources.

## Usage

To clean up and validate icon, run cleanupSVG().

Function has one required parameter:

- svg, [SVG](https://iconify.design/docs/libraries/tools/svg/ "SVG documentation"). Icon instance.

and one optional parameter:

- options, object. Options, see below.

Function does not return anything, it applies changes to [SVG](https://iconify.design/docs/libraries/tools/svg/ "SVG documentation") instance.

On error function will throw an exception.

### Options

The options parameter has the following properties:

- keepTitles, boolean. If set to true, titles are not removed.

Titles are removed by default because almost all icons can represent many things, therefore, hardcoded titles are not usable for most users. The option to keep titles is intended for working with custom icon sets that are specific to one website.

## Clean up process

Clean up process runs several functions that do various tasks:

- cleanupInlineStyle() checks inline styles and removes unneeded styles.
- convertStyleToAttrs() converts style to attributes.
- cleanupSVGRoot() cleans up <svg> element.
- checkBadTags() checks icon for bad tags.
- removeBadAttributes() removes bad attributes.

If you want to, you can run functions listed above, in order listed above. It will be identical to running cleanupSVG().

## Optimisation

Clean up functions do not optimise icon data, they do not rewrite any shapes. Functions only remove most dead code, making it easier to process icon.

Optimisation should be done separately. See [icon manipulation functions](https://iconify.design/icon/).

## Opinionated validation

Validation is opinionated. It is intended to be used to produce icons that are available to anyone, therefore, it is rather strict.

Icon validation fails if icon:

- Contains any scripts. Untrusted scripts are dangerous.
- Contains any text. This is heavily opinionated. Reasoning is usually icons that use text are exported by designers not realising that they are using fonts that are not installed on every computer, therefore, icon will look different than intended. Convert text to shapes before exporting it from your editor.
- Contains any raster images. Raster images in vector shapes are unacceptable because they do not scale. Icons are meant to scale without limitations.

## Example

ts
```
import { SVG, cleanupSVG } from '@iconify/tools';

const reallyBadIcon = \`<?xml version="1.0" encoding="UTF-8" standalone="no"?>
 <!-- Created with Inkscape (http://www.inkscape.org/) -->

 <svg
   xmlns:dc="http://purl.org/dc/elements/1.1/"
   xmlns:cc="http://creativecommons.org/ns#"
   xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#"
   xmlns:svg="http://www.w3.org/2000/svg"
   xmlns="http://www.w3.org/2000/svg"
   xmlns:sodipodi="http://sodipodi.sourceforge.net/DTD/sodipodi-0.dtd"
   xmlns:inkscape="http://www.inkscape.org/namespaces/inkscape"
   width="2048"
   height="2048"
   id="svg3891"
   version="1.1"
   inkscape:version="0.91 r13725"
   sodipodi:docname="trash.svg"
   inkscape:export-filename="/home/nikku/camunda/projects/bpmn.io/bpmn-font/raw/trash.png"
   inkscape:export-xdpi="0.88"
   inkscape:export-ydpi="0.88">
  <defs
     id="defs3893">
    <inkscape:path-effect
       effect="spiro"
       id="path-effect4094"
       is_visible="true" />
    <inkscape:path-effect
       effect="spiro"
       id="path-effect4094-0"
       is_visible="true" />
  </defs>
  <sodipodi:namedview
     id="base"
     pagecolor="#ffffff"
     bordercolor="#666666"
     borderopacity="1.0"
     inkscape:pageopacity="0.0"
     inkscape:pageshadow="2"
     inkscape:zoom="0.175"
     inkscape:cx="307.67263"
     inkscape:cy="1030.7415"
     inkscape:document-units="px"
     inkscape:current-layer="layer1-6"
     showgrid="false"
     inkscape:window-width="1596"
     inkscape:window-height="807"
     inkscape:window-x="0"
     inkscape:window-y="91"
     inkscape:window-maximized="0"
     inkscape:snap-page="false"
     inkscape:snap-object-midpoints="false"
     inkscape:snap-nodes="false"
     inkscape:snap-to-guides="false"
     inkscape:snap-grids="false" />
  <metadata
     id="metadata3896">
    <rdf:RDF>
      <cc:Work
         rdf:about="">
        <dc:format>image/svg+xml</dc:format>
        <dc:type
           rdf:resource="http://purl.org/dc/dcmitype/StillImage" />
        <dc:title />
      </cc:Work>
    </rdf:RDF>
  </metadata>
  <g
     inkscape:label="Layer 1"
     inkscape:groupmode="layer"
     id="layer1"
     transform="translate(0,995.63783)">
    <g
       transform="matrix(96.752895,0,0,96.752895,55.328158,-100816.34)"
       id="layer1-6"
       inkscape:label="Layer 1"
       style="display:inline">
      <path
         style="color:#000000;font-style:normal;font-variant:normal;font-weight:normal;font-stretch:normal;font-size:medium;line-height:normal;font-family:sans-serif;text-indent:0;text-align:start;text-decoration:none;text-decoration-line:none;text-decoration-style:solid;text-decoration-color:#000000;letter-spacing:normal;word-spacing:normal;text-transform:none;direction:ltr;block-progression:tb;writing-mode:lr-tb;baseline-shift:baseline;text-anchor:start;white-space:normal;clip-rule:nonzero;display:inline;overflow:visible;visibility:visible;opacity:1;isolation:auto;mix-blend-mode:normal;color-interpolation:sRGB;color-interpolation-filters:linearRGB;fill:#000000;fill-opacity:1;fill-rule:nonzero;stroke:none;stroke-width:1.343629;stroke-linecap:round;stroke-linejoin:miter;stroke-miterlimit:4;stroke-dasharray:none;stroke-dashoffset:0;stroke-opacity:1;color-rendering:auto;image-rendering:auto;shape-rendering:auto;text-rendering:auto;enable-background:accumulate"
         d="m 3.4296875,1038.3672 1.3325877,12.7308 10.5912408,0 1.228186,-12.7284 -13.1520736,0 z m 1.4921875,1.3437 10.185547,0 -0.972656,10.0411 -8.1582035,0 z"
         id="rect4089"
         inkscape:connector-curvature="0"
         sodipodi:nodetypes="ccccccccccc" />
      <g
         id="g4275"
         transform="matrix(1,0,0,0.90111263,0,103.41515)">
        <path
           sodipodi:nodetypes="cc"
           inkscape:connector-curvature="0"
           inkscape:original-d="m 7.0333918,1040.9794 0.9432241,7.504"
           inkscape:path-effect="#path-effect4094"
           id="path4092"
           d="m 7.0333918,1040.9794 0.9432241,7.504"
           style="fill:none;stroke:#000000;stroke-width:1.343629;stroke-linecap:round;stroke-linejoin:miter;stroke-miterlimit:4;stroke-opacity:1;stroke-dasharray:none" />
        <path
           sodipodi:nodetypes="cc"
           inkscape:connector-curvature="0"
           inkscape:original-d="m 12.990235,1040.9794 -0.943224,7.504"
           inkscape:path-effect="#path-effect4094-0"
           id="path4092-2"
           d="m 12.990235,1040.9794 -0.943224,7.504"
           style="fill:none;stroke:#000000;stroke-width:1.343629;stroke-linecap:round;stroke-linejoin:miter;stroke-miterlimit:4;stroke-opacity:1;stroke-dasharray:none" />
      </g>
      <path
         style="fill:#000000;fill-opacity:1;stroke:none"
         d="m 7.2638322,1035.194 -4.2854023,1.2542 0,0.6276 14.0667651,0 0,-0.6276 -4.337726,-1.2542 z"
         id="rect4121"
         inkscape:connector-curvature="0"
         sodipodi:nodetypes="ccccccc" />
      <path
         style="display:inline;fill:#000000;fill-opacity:1;stroke:#000000;stroke-width:0.72291225;stroke-linecap:round;stroke-linejoin:round;stroke-miterlimit:4;stroke-dasharray:none;stroke-dashoffset:0;stroke-opacity:1"
         d="m 7.6269598,1033.8929 4.7697062,0 0,1.737 -4.7697062,0 z"
         id="rect4121-6" />
    </g>
  </g>
 </svg>\`;

const svg = new SVG(reallyBadIcon);
cleanupSVG(svg);
console.log(svg.toMinifiedString());
```

svg
```
<svg xmlns="http://www.w3.org/2000/svg" width="2048" height="2048" viewBox="0 0 2048 2048"><defs id="defs3893"></defs><g id="layer1" transform="translate(0,995.63783)"><g transform="matrix(96.752895,0,0,96.752895,55.328158,-100816.34)" id="layer1-6" display="inline"><path d="m 3.4296875,1038.3672 1.3325877,12.7308 10.5912408,0 1.228186,-12.7284 -13.1520736,0 z m 1.4921875,1.3437 10.185547,0 -0.972656,10.0411 -8.1582035,0 z" id="rect4089" color="#000000" display="inline" visibility="visible" opacity="1" color-interpolation="sRGB" fill="#000000" fill-opacity="1" fill-rule="nonzero" stroke="none" stroke-width="1.343629" stroke-linecap="round" stroke-linejoin="miter" stroke-miterlimit="4" stroke-dasharray="none" stroke-dashoffset="0" stroke-opacity="1" color-rendering="auto"/><g id="g4275" transform="matrix(1,0,0,0.90111263,0,103.41515)"><path id="path4092" d="m 7.0333918,1040.9794 0.9432241,7.504" fill="none" stroke="#000000" stroke-width="1.343629" stroke-linecap="round" stroke-linejoin="miter" stroke-miterlimit="4" stroke-opacity="1" stroke-dasharray="none"/><path sodipodi:nodetypes="cc" inkscape:connector-curvature="0" inkscape:original-d="m 12.990235,1040.9794 -0.943224,7.504" inkscape:path-effect="#path-effect4094-0" id="path4092-2" d="m 12.990235,1040.9794 -0.943224,7.504" fill="none" stroke="#000000" stroke-width="1.343629" stroke-linecap="round" stroke-linejoin="miter" stroke-miterlimit="4" stroke-opacity="1" stroke-dasharray="none"/></g><path d="m 7.2638322,1035.194 -4.2854023,1.2542 0,0.6276 14.0667651,0 0,-0.6276 -4.337726,-1.2542 z" id="rect4121" inkscape:connector-curvature="0" sodipodi:nodetypes="ccccccc" fill="#000000" fill-opacity="1" stroke="none"/><path d="m 7.6269598,1033.8929
```

[Page 147](https://iconify.design/docs/libraries/tools/icon/ "Current Page.")

## Changing icon content

Before exporting icons, you need to properly fix them. [Iconify Tools](https://iconify.design/docs/) offers many functions for manipulating icon content: fixing various issues, optimising code, changing palette.

## Usage

All functions listed below work with [SVG](https://iconify.design/docs/libraries/tools/svg/ "SVG documentation") instances.

### Working with icon sets

How to use functions to parse all icons in an icon set?

It can be done by using [forEach()](https://iconify.design/docs/libraries/tools/icon-set/for-each.html "forEach() documentation") and forEachSync() methods:

ts
```
iconSet.forEach(async (name, type) => {
    if (type !== 'icon') {
        // Ignore aliases and variations: they inherit content from parent icon, so there is nothing to change
        return;
    }

    const svg = iconSet.toSVG(name);
    if (svg) {
        // Change colors to red
        parseColors(svg, {
            defaultColor: 'red',
            callback: (attr, colorStr, color) => {
                return !color || isEmptyColor(color) ? colorStr : 'red';
            },
        });

        // Update icon from SVG instance
        iconSet.fromSVG(name, svg);
    }
 });

// The rest of code here
```

## Cleanup

Before running any icon manipulation function, you should validate and clean up icon. See [cleanupSVG()](https://iconify.design/docs/libraries/tools/icon/cleanup.html "cleanupSVG() documentation") function.

## Functions

There are several functions for manipulating icons:

### runSVGO()

Function [runSVGO()](https://iconify.design/docs/libraries/tools/icon/svgo.html "runSVGO() documentation") optimises icon.

Cleaning up icons with [cleanupSVG()](https://iconify.design/docs/libraries/tools/icon/cleanup.html "cleanupSVG() documentation") is not enough. That function is very basic; it does bare minimum to get rid of bad stuff. It is mostly for validation.

Use [runSVGO()](https://iconify.design/docs/libraries/tools/icon/svgo.html "runSVGO() documentation") to properly clean up and optimise icons.

### parseColors()

Function [parseColors()](https://iconify.design/docs/libraries/tools/icon/colors.html "parseColors() documentation") is used to analyze icon's palette or change it.

Usually icons either do not have palette, relying on fill style or use black colors. Neither option is acceptable for using icons with Iconify. Iconify all icons that do not have hardcoded palette should use currentColor.

This function can be used to change colors, make sure icon does not have colors it is not supposed to have, add colors to shapes that rely on default colors.

### deOptimisePaths()

Function [deOptimisePaths()](https://iconify.design/docs/libraries/tools/icon/paths.html "deOptimisePaths() documentation") makes sure icon would work with old software.

All browsers support modern SVG, which include compressed arcs in <path> elements. However, there is plenty of software that does not. Usually it is image editing software that rely on ancient SVG parsing libraries.

### scaleSVG()

Function [scaleSVG()](https://iconify.design/docs/libraries/tools/icon/scale.html "scaleSVG() documentation") changes icon dimensions.

### resetSVGOrigin()

Function resetSVGOrigin() shifts top left corner of viewBox to 0.

### removeFigmaClipPathFromSVG()

Function removeFigmaClipPathFromSVG() attempts to remove unnecessary clip paths, which are often added when icon is exported in Figma.

### convertSVGToMask()

Function [convertSVGToMask()](https://iconify.design/docs/libraries/tools/icon/mask.html "convertSVGToMask() documentation") converts icon content to mask.

This is useful if you want to change icon with multiple colors into a monotone icon, using source colors as shades.

[Page 148](https://iconify.design/docs/libraries/tools/icon/svgo.html "Current Page.")

## Optimising icon with SVGO

This function is part of [icon manipulation functions](https://iconify.design/docs/) in [Iconify Tools](https://iconify.design/).

Function runSVGO() optimises icon using popular SVG optimisation tool SVGO.

It is meant to be used on icons that have already been processed with [cleanupSVG()](https://iconify.design/docs/libraries/tools/icon/cleanup.html "cleanupSVG() documentation"), which does most of the cleanup.

This function is used to do advanced stuff that SVGO is good at: converting transformations, cleaning up numbers, removing unused SVG elements, and so on.

## Plugins

By default, function uses a pre-configured list of SVGO plugins, which excludes some bugged plugins.

If an icon contains SVG animations, plugins that modify shapes are excluded.

## Usage

Function has the following parameters:

- svg, [SVG](https://iconify.design/docs/libraries/tools/svg/ "SVG documentation"). Icon instance.
- options, object. Options (optional).

## Options

There are two ways to set options:

- Using a custom list of SVGO plugins.
- Toggle groups of plugins using several options.

### Custom plugins list

You can set custom plugins using plugins property of options. Value is array of plugins, passed directly to SVGO (see SVGO documentation).

Example:

ts
```
runSVGO(svg, {
    plugins: ['convertStyleToAttrs', 'inlineStyles'],
    multipass: true,
 });
```

### Plugin options

You can also pick from a preset list of plugins by setting these options:

- animated, boolean. If true, SVGO plugins that are known to bug out with animated icons are not used.
- keepShapes, boolean. If true, plugins that modify shapes are not used. This is useful if you need to keep shapes as-is, for example, when animating shapes, but it is not as strict as setting animated option.
- cleanupIDs, string|false|function. Custom prefix for rewriting IDs, false to disable plugins that change IDs. Can be a callback that returns new ID based on old ID.

These options cannot be used together with plugins option.

### Other options

Options that can be used with any options listed above:

- multipass, boolean. If true, plugins are ran multiple times for better optimisation. Enabled by default.

## Example

ts
```
import { SVG, runSVGO } from '@iconify/tools';

const reallyBadIcon = \`<?xml version="1.0" encoding="UTF-8" standalone="no"?>
 <!-- Created with Inkscape (http://www.inkscape.org/) -->

 <svg
   xmlns:dc="http://purl.org/dc/elements/1.1/"
   xmlns:cc="http://creativecommons.org/ns#"
   xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#"
   xmlns:svg="http://www.w3.org/2000/svg"
   xmlns="http://www.w3.org/2000/svg"
   xmlns:sodipodi="http://sodipodi.sourceforge.net/DTD/sodipodi-0.dtd"
   xmlns:inkscape="http://www.inkscape.org/namespaces/inkscape"
   width="2048"
   height="2048"
   id="svg3891"
   version="1.1"
   inkscape:version="0.91 r13725"
   sodipodi:docname="trash.svg"
   inkscape:export-filename="/home/nikku/camunda/projects/bpmn.io/bpmn-font/raw/trash.png"
   inkscape:export-xdpi="0.88"
   inkscape:export-ydpi="0.88">
  <defs
     id="defs3893">
    <inkscape:path-effect
       effect="spiro"
       id="path-effect4094"
       is_visible="true" />
    <inkscape:path-effect
       effect="spiro"
       id="path-effect4094-0"
       is_visible="true" />
  </defs>
  <sodipodi:namedview
     id="base"
     pagecolor="#ffffff"
     bordercolor="#666666"
     borderopacity="1.0"
     inkscape:pageopacity="0.0"
     inkscape:pageshadow="2"
     inkscape:zoom="0.175"
     inkscape:cx="307.67263"
     inkscape:cy="1030.7415"
     inkscape:document-units="px"
     inkscape:current-layer="layer1-6"
     showgrid="false"
     inkscape:window-width="1596"
     inkscape:window-height="807"
     inkscape:window-x="0"
     inkscape:window-y="91"
     inkscape:window-maximized="0"
     inkscape:snap-page="false"
     inkscape:snap-object-midpoints="false"
     inkscape:snap-nodes="false"
     inkscape:snap-to-guides="false"
     inkscape:snap-grids="false" />
  <metadata
     id="metadata3896">
    <rdf:RDF>
      <cc:Work
         rdf:about="">
        <dc:format>image/svg+xml</dc:format>
        <dc:type
           rdf:resource="http://purl.org/dc/dcmitype/StillImage" />
        <dc:title />
      </cc:Work>
    </rdf:RDF>
  </metadata>
  <g
     inkscape:label="Layer 1"
     inkscape:groupmode="layer"
     id="layer1"
     transform="translate(0,995.63783)">
    <g
       transform="matrix(96.752895,0,0,96.752895,55.328158,-100816.34)"
       id="layer1-6"
       inkscape:label="Layer 1"
       style="display:inline">
      <path
         style="color:#000000;font-style:normal;font-variant:normal;font-weight:normal;font-stretch:normal;font-size:medium;line-height:normal;font-family:sans-serif;text-indent:0;text-align:start;text-decoration:none;text-decoration-line:none;text-decoration-style:solid;text-decoration-color:#000000;letter-spacing:normal;word-spacing:normal;text-transform:none;direction:ltr;block-progression:tb;writing-mode:lr-tb;baseline-shift:baseline;text-anchor:start;white-space:normal;clip-rule:nonzero;display:inline;overflow:visible;visibility:visible;opacity:1;isolation:auto;mix-blend-mode:normal;color-interpolation:sRGB;color-interpolation-filters:linearRGB;fill:#000000;fill-opacity:1;fill-rule:nonzero;stroke:none;stroke-width:1.343629;stroke-linecap:round;stroke-linejoin:miter;stroke-miterlimit:4;stroke-dasharray:none;stroke-dashoffset:0;stroke-opacity:1;color-rendering:auto;image-rendering:auto;shape-rendering:auto;text-rendering:auto;enable-background:accumulate"
         d="m 3.4296875,1038.3672 1.3325877,12.7308 10.5912408,0 1.228186,-12.7284 -13.1520736,0 z m 1.4921875,1.3437 10.185547,0 -0.972656,10.0411 -8.1582035,0 z"
         id="rect4089"
         inkscape:connector-curvature="0"
         sodipodi:nodetypes="ccccccccccc" />
      <g
         id="g4275"
         transform="matrix(1,0,0,0.90111263,0,103.41515)">
        <path
           sodipodi:nodetypes="cc"
           inkscape:connector-curvature="0"
           inkscape:original-d="m 7.0333918,1040.9794 0.9432241,7.504"
           inkscape:path-effect="#path-effect4094"
           id="path4092"
           d="m 7.0333918,1040.9794 0.9432241,7.504"
           style="fill:none;stroke:#000000;stroke-width:1.343629;stroke-linecap:round;stroke-linejoin:miter;stroke-miterlimit:4;stroke-opacity:1;stroke-dasharray:none" />
        <path
           sodipodi:nodetypes="cc"
           inkscape:connector-curvature="0"
           inkscape:original-d="m 12.990235,1040.9794 -0.943224,7.504"
           inkscape:path-effect="#path-effect4094-0"
           id="path4092-2"
           d="m 12.990235,1040.9794 -0.943224,7.504"
           style="fill:none;stroke:#000000;stroke-width:1.343629;stroke-linecap:round;stroke-linejoin:miter;stroke-miterlimit:4;stroke-opacity:1;stroke-dasharray:none" />
      </g>
      <path
         style="fill:#000000;fill-opacity:1;stroke:none"
         d="m 7.2638322,1035.194 -4.2854023,1.2542 0,0.6276 14.0667651,0 0,-0.6276 -4.337726,-1.2542 z"
         id="rect4121"
         inkscape:connector-curvature="0"
         sodipodi:nodetypes="ccccccc" />
      <path
         style="display:inline;fill:#000000;fill-opacity:1;stroke:#000000;stroke-width:0.72291225;stroke-linecap:round;stroke-linejoin:round;stroke-miterlimit:4;stroke-dasharray:none;stroke-dashoffset:0;stroke-opacity:1"
         d="m 7.6269598,1033.8929 4.7697062,0 0,1.737 -4.7697062,0 z"
         id="rect4121-6" />
    </g>
  </g>
 </svg>\`;

const svg = new SVG(reallyBadIcon);
runSVGO(svg);
console.log(svg.toMinifiedString());
```

svg
```
<svg xmlns="http://www.w3.org/2000/svg" width="2048" height="2048" viewBox="0 0 2048 2048"><metadata/><path d="m3.43 1038.367 1.332 12.731h10.592l1.228-12.728H3.43zm1.492 1.344h10.185l-.972 10.041H5.977z" color="#000" enable-background="accumulate" font-family="sans-serif" overflow="visible" style="line-height:normal;text-indent:0;text-align:start;text-decoration-line:none;text-decoration-style:solid;text-decoration-color:#000000;text-transform:none;block-progression:tb;white-space:normal;isolation:auto;mix-blend-mode:normal" transform="translate(55.328 -99820.702) scale(96.7529)"/><path fill="none" stroke="#000" stroke-linecap="round" stroke-width="1.344" d="m7.033 1040.98.944 7.503m5.013-7.503-.943 7.503" transform="matrix(96.7529 0 0 87.185 55.328 -89815)"/><path d="M758.141 337.32 343.458 458.648v60.76h1361.023v-60.76L1284.767 337.32z"/><path stroke="#000" stroke-linecap="round" stroke-linejoin="round" stroke-width="69.952" d="M793.262 211.444h461.512v168.06H793.262z"/></svg>
```

That example shows running SVGO on icon that has not been cleaned up and validated. Not all useless attributes have been removed, and SVGO doesn't check for some content that should not be in icon, such as text, raster images and events.

Therefore, all icons must be cleaned up after loading.

Same code with clean up:

ts
```
import { SVG, runSVGO, cleanupSVG } from '@iconify/tools';

const reallyBadIcon = \`<?xml version="1.0" encoding="UTF-8" standalone="no"?>
 <!-- Created with Inkscape (http://www.inkscape.org/) -->

 <svg
   xmlns:dc="http://purl.org/dc/elements/1.1/"
   xmlns:cc="http://creativecommons.org/ns#"
   xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#"
   xmlns:svg="http://www.w3.org/2000/svg"
   xmlns="http://www.w3.org/2000/svg"
   xmlns:sodipodi="http://sodipodi.sourceforge.net/DTD/sodipodi-0.dtd"
   xmlns:inkscape="http://www.inkscape.org/namespaces/inkscape"
   width="2048"
   height="2048"
   id="svg3891"
   version="1.1"
   inkscape:version="0.91 r13725"
   sodipodi:docname="trash.svg"
   inkscape:export-filename="/home/nikku/camunda/projects/bpmn.io/bpmn-font/raw/trash.png"
   inkscape:export-xdpi="0.88"
   inkscape:export-ydpi="0.88">
  <defs
     id="defs3893">
    <inkscape:path-effect
       effect="spiro"
       id="path-effect4094"
       is_visible="true" />
    <inkscape:path-effect
       effect="spiro"
       id="path-effect4094-0"
       is_visible="true" />
  </defs>
  <sodipodi:namedview
     id="base"
     pagecolor="#ffffff"
     bordercolor="#666666"
     borderopacity="1.0"
     inkscape:pageopacity="0.0"
     inkscape:pageshadow="2"
     inkscape:zoom="0.175"
     inkscape:cx="307.67263"
     inkscape:cy="1030.7415"
     inkscape:document-units="px"
     inkscape:current-layer="layer1-6"
     showgrid="false"
     inkscape:window-width="1596"
     inkscape:window-height="807"
     inkscape:window-x="0"
     inkscape:window-y="91"
     inkscape:window-maximized="0"
     inkscape:snap-page="false"
     inkscape:snap-object-midpoints="false"
     inkscape:snap-nodes="false"
     inkscape:snap-to-guides="false"
     inkscape:snap-grids="false" />
  <metadata
     id="metadata3896">
    <rdf:RDF>
      <cc:Work
         rdf:about="">
        <dc:format>image/svg+xml</dc:format>
        <dc:type
           rdf:resource="http://purl.org/dc/dcmitype/StillImage" />
        <dc:title />
      </cc:Work>
    </rdf:RDF>
  </metadata>
  <g
     inkscape:label="Layer 1"
     inkscape:groupmode="layer"
     id="layer1"
     transform="translate(0,995.63783)">
    <g
       transform="matrix(96.752895,0,0,96.752895,55.328158,-100816.34)"
       id="layer1-6"
       inkscape:label="Layer 1"
       style="display:inline">
      <path
         style="color:#000000;font-style:normal;font-variant:normal;font-weight:normal;font-stretch:normal;font-size:medium;line-height:normal;font-family:sans-serif;text-indent:0;text-align:start;text-decoration:none;text-decoration-line:none;text-decoration-style:solid;text-decoration-color:#000000;letter-spacing:normal;word-spacing:normal;text-transform:none;direction:ltr;block-progression:tb;writing-mode:lr-tb;baseline-shift:baseline;text-anchor:start;white-space:normal;clip-rule:nonzero;display:inline;overflow:visible;visibility:visible;opacity:1;isolation:auto;mix-blend-mode:normal;color-interpolation:sRGB;color-interpolation-filters:linearRGB;fill:#000000;fill-opacity:1;fill-rule:nonzero;stroke:none;stroke-width:1.343629;stroke-linecap:round;stroke-linejoin:miter;stroke-miterlimit:4;stroke-dasharray:none;stroke-dashoffset:0;stroke-opacity:1;color-rendering:auto;image-rendering:auto;shape-rendering:auto;text-rendering:auto;enable-background:accumulate"
         d="m 3.4296875,1038.3672 1.3325877,12.7308 10.5912408,0 1.228186,-12.7284 -13.1520736,0 z m 1.4921875,1.3437 10.185547,0 -0.972656,10.0411 -8.1582035,0 z"
         id="rect4089"
         inkscape:connector-curvature="0"
         sodipodi:nodetypes="ccccccccccc" />
      <g
         id="g4275"
         transform="matrix(1,0,0,0.90111263,0,103.41515)">
        <path
           sodipodi:nodetypes="cc"
           inkscape:connector-curvature="0"
           inkscape:original-d="m 7.0333918,1040.9794 0.9432241,7.504"
           inkscape:path-effect="#path-effect4094"
           id="path4092"
           d="m 7.0333918,1040.9794 0.9432241,7.504"
           style="fill:none;stroke:#000000;stroke-width:1.343629;stroke-linecap:round;stroke-linejoin:miter;stroke-miterlimit:4;stroke-opacity:1;stroke-dasharray:none" />
        <path
           sodipodi:nodetypes="cc"
           inkscape:connector-curvature="0"
           inkscape:original-d="m 12.990235,1040.9794 -0.943224,7.504"
           inkscape:path-effect="#path-effect4094-0"
           id="path4092-2"
           d="m 12.990235,1040.9794 -0.943224,7.504"
           style="fill:none;stroke:#000000;stroke-width:1.343629;stroke-linecap:round;stroke-linejoin:miter;stroke-miterlimit:4;stroke-opacity:1;stroke-dasharray:none" />
      </g>
      <path
         style="fill:#000000;fill-opacity:1;stroke:none"
         d="m 7.2638322,1035.194 -4.2854023,1.2542 0,0.6276 14.0667651,0 0,-0.6276 -4.337726,-1.2542 z"
         id="rect4121"
         inkscape:connector-curvature="0"
         sodipodi:nodetypes="ccccccc" />
      <path
         style="display:inline;fill:#000000;fill-opacity:1;stroke:#000000;stroke-width:0.72291225;stroke-linecap:round;stroke-linejoin:round;stroke-miterlimit:4;stroke-dasharray:none;stroke-dashoffset:0;stroke-opacity:1"
         d="m 7.6269598,1033.8929 4.7697062,0 0,1.737 -4.7697062,0 z"
         id="rect4121-6" />
    </g>
  </g>
 </svg>\`;

const svg = new SVG(reallyBadIcon);

// Clean up and validate icon
cleanupSVG(svg);

// Optimise icon
runSVGO(svg);

console.log(svg.toMinifiedString());
```

svg
```
<svg xmlns="http://www.w3.org/2000/svg" width="2048" height="2048" viewBox="0 0 2048 2048"><path d="m387.19 644.317 128.875 1231.76h1024.807l118.813-1231.47H387.19zm144.356 130.035h985.428l-94.044 971.496H633.62z" color="#000"/><path fill="none" stroke="#000" stroke-linecap="round" stroke-width="1.344" d="m7.033 1040.98.944 7.503m5.013-7.503-.943 7.503" transform="matrix(96.7529 0 0 87.185 55.328 -89815)"/><path d="M758.141 337.32 343.458 458.648v60.76h1361.023v-60.76L1284.767 337.32z"/><path stroke="#000" stroke-linecap="round" stroke-linejoin="round" stroke-width="69.952" d="M793.262 211.444h461.512v168.06H793.262z"/></svg>
```

[Page 149](https://iconify.design/docs/libraries/tools/icon/colors.html "Current Page.")

## Parsing colors in SVG

This function is part of [icon manipulation functions](https://iconify.design/docs/) in [Iconify Tools](https://iconify.design/).

Function parseColors() parses colors in SVG.

It can:

- Find all colors.
- Replace colors.
- Add missing default color.

Function parses colors in:

- Stylesheets.
- Inline styles.
- Shapes, including gradients and filters.
- SVG animations that animate one of color attributes.

Function does not parse colors in:

- Masks.

## Usage

Function has the following parameters:

- svg, [SVG](https://iconify.design/docs/libraries/tools/svg/ "SVG documentation"). Icon instance.
- options, object. Options.

Function returns array of colors.

## Colors

Colors used in callback and returned by function can be two types:

- [Color](https://iconify.design/docs/libraries/utils/color.html "Color documentation") object, same as in [Iconify Utils](https://iconify.design/utils/).
- string. Value is a string if color cannot be parsed.

## Options

The options object has the following properties:

- defaultColor, [Color](https://iconify.design/docs/libraries/utils/color.html "Color documentation") |string. Default color to add to shapes that use system default color. See below.
- callback, function. Callback to call for each color. See below.

### Default color

Some icons use system color. Example:

xml
```
<svg viewBox="0 0 1200 400" xmlns="http://www.w3.org/2000/svg" width="1200" height="400">
    <path d="M300 200H150A150 150 0 10300 50z"/>
</svg>
```

In that icon path uses default fill. In Iconify all icons should use colors set by color attribute, which means shapes should use "currentColor" for fill.

If you set defaultColor option, parser will automatically set color for shapes that use default color.

Example:

ts
```
import { SVG, parseColors } from '@iconify/tools';

 (async () => {
    const svg = new SVG(
        '<svg viewBox="0 0 1200 400" xmlns="http://www.w3.org/2000/svg" width="1200" height="400"><path d="M300 200H150A150 150 0 10300 50z"/></svg>'
    );

    // Add 'currentColor' to shapes that use default color
    await parseColors(svg, {
        defaultColor: 'currentColor',
    });

    console.log(svg.toMinifiedString());
 })();
```

svg
```
<svg viewBox="0 0 1200 400" xmlns="http://www.w3.org/2000/svg" width="1200" height="400"><path d="M300 200H150A150 150 0 10300 50z" fill="currentColor"/></svg>
```

### Replacing colors

With callback option you can replace colors.

Callback has the following parameters:

- attr, string. Attribute where color is used, such as "fill" or "stroke".
- colorStr, string. Color value as string.
- color, [Color](https://iconify.design/docs/libraries/utils/color.html "Color documentation") |null. Parsed color value. If color can be parsed, callback will have [Color](https://iconify.design/docs/libraries/utils/color.html "Color documentation") value. If color cannot be parsed, callback will have null value.
- tagName, string. Optional parameter. Name of tag where color is found. If color is found in stylesheet, parameter will be undefined.

Callback should return:

- [Color](https://iconify.design/docs/libraries/utils/color.html "Color documentation") or string to set new color. If you do not want to change color, return color passed to callback (either colorStr or non-null color object).
- "remove" to remove the current element. This is used to remove stuff like white background rectangle left by some editors.
- "unset" to remove color.

Example

ts
```
import { compareColors, stringToColor } from '@iconify/utils/lib/colors';
import { IconSet, parseColors, isEmptyColor } from '@iconify/tools';

const iconSet = new IconSet({
    prefix: 'codicon',
    icons: {
        'add': {
            body: '<path d="M14 7v1H8v6H7V8H1V7h6V1h1v6h6z"/>',
        },
        'debug-pause': {
            body: '<path d="M4.5 3H6v10H4.5V3zm7 0v10H10V3h1.5z" fill="#000"/>',
            hidden: true,
        },
        'triangle-left': {
            body: '<path d="M10.44 2l.56.413v11.194l-.54.393L5 8.373v-.827L10.44 2z" fill="#000"/>',
        },
    },
    aliases: {
        'plus': {
            parent: 'add',
        },
        'triangle-right': {
            parent: 'triangle-left',
            hFlip: true,
        },
    },
 });

// Parse all icons in icon set
 iconSet.forEach((name, type) => {
    if (type !== 'icon') {
        // Ignore aliases and variations: they inherit content from parent icon, so there is nothing to change
        return;
    }

    // Get icon as SVG class instance
    const svg = iconSet.toSVG(name);
    if (svg) {
        // Parse colors in SVG instance
        parseColors(svg, {
            // Change default color to 'currentColor'
            defaultColor: 'currentColor',

            // Callback to parse each color
            callback: (attr, colorStr, color) => {
                if (!color) {
                    // color === null, so color cannot be parsed
                    // Return colorStr to keep old value
                    return colorStr;
                }

                if (isEmptyColor(color)) {
                    // Color is empty: 'none' or 'transparent'
                    // Return color object to keep old value
                    return color;
                }

                // Black color: change to 'currentColor'
                if (compareColors(color, stringToColor('black'))) {
                    return 'currentColor';
                }

                // White color: belongs to white background rectangle: remove rectangle
                if (compareColors(color, stringToColor('white'))) {
                    return 'remove';
                }

                // Unexpected color. Add code to check for it
                throw new Error(
                    \`Unexpected color "${colorStr}" in attribute ${attr}\`
                );
            },
        });

        // Update icon in icon set
        iconSet.fromSVG(name, svg);
    }
 });

// Export icon set
console.log(iconSet.export());
```

json
```
{
    "prefix": "codicon",
    "icons": {
        "add": {
            "body": "<path d=\"M14 7v1H8v6H7V8H1V7h6V1h1v6h6z\" fill=\"currentColor\"/>"
        },
        "debug-pause": {
            "body": "<path d=\"M4.5 3H6v10H4.5V3zm7 0v10H10V3h1.5z\" fill=\"currentColor\"/>",
            "hidden": true
        },
        "triangle-left": {
            "body": "<path d=\"M10.44 2l.56.413v11.194l-.54.393L5 8.373v-.827L10.44 2z\" fill=\"currentColor\"/>"
        }
    },
    "aliases": {
        "plus": {
            "parent": "add"
        },
        "triangle-right": {
            "parent": "triangle-left",
            "hFlip": true
        }
    }
}
```

[Page 150](https://iconify.design/docs/libraries/tools/icon/paths.html "Current Page.")

## Compatibility with old SVG parsers

This function is part of [icon manipulation functions](https://iconify.design/docs/) in [Iconify Tools](https://iconify.design/).

Function deOptimisePaths() checks <path> elements for syntax that might not be supported by older software and automatically fixes it.

Unfortunately, a lot of software, such as image editing software, uses old libraries for parsing SVG. Those libraries do not support compressing arcs in paths, resulting in incorrectly imported icons. Compressing arcs doesn't make much different in icon size, so better to have icons usable in all software than save a couple of bytes.

## Usage

Function has only one parameter:

- svg, [SVG](https://iconify.design/docs/libraries/tools/svg/ "SVG documentation"). Icon instance.

Function does not return anything, it applies changes to [SVG](https://iconify.design/docs/libraries/tools/svg/ "SVG documentation") instance.

## Example

ts
```
import { SVG, deOptimisePaths } from '@iconify/tools';

const svg = new SVG(
    '<svg viewBox="0 0 1200 400" xmlns="http://www.w3.org/2000/svg" width="1200" height="400"><path d="M300 200H150A150 150 0 10300 50z"/></svg>'
 );

// Update path
deOptimisePaths(svg);

console.log(svg.toMinifiedString());
```

svg
```
<svg viewBox="0 0 1200 400" xmlns="http://www.w3.org/2000/svg" width="1200" height="400"><path d="M300 200H150A150 150 0 1 0 300 50z"/></svg>
```

As you can see from an example, changes are minor. However, not applying these minor changes might break icon for many users that use old software, so better run this function on all icons before exporting.

Make sure you do not run SVGO optimisation after running this function because SVGO might compress paths.

[Page 151](https://iconify.design/docs/libraries/tools/icon/scale.html "Current Page.")

## Scaling SVG

This function is part of [icon manipulation functions](https://iconify.design/docs/) in [Iconify Tools](https://iconify.design/).

Function scaleSVG() changes icon size.

For most icons this function is not needed, you can change size by changing width and height properties, but it is available anyway.

## Usage

Function has the following parameters:

- svg, [SVG](https://iconify.design/docs/libraries/tools/svg/ "SVG documentation"). Icon instance.
- scale, number. Amount to multiply icon dimensions by.

## Example

ts
```
import { SVG, scaleSVG, runSVGO } from '@iconify/tools';

const svg = new SVG(
    '<svg xmlns="http://www.w3.org/2000/svg" width="2048" height="2048" viewBox="0 0 2048 2048"><path d="m387.19 644.317 128.875 1231.76h1024.807l118.813-1231.47H387.19zm144.356 130.035h985.428l-94.044 971.496H633.62z" color="#000"/><path fill="none" stroke="#000" stroke-linecap="round" stroke-width="1.344" d="m7.033 1040.98.944 7.503m5.013-7.503-.943 7.503" transform="matrix(96.7529 0 0 87.185 55.328 -89815)"/><path d="M758.141 337.32 343.458 458.648v60.76h1361.023v-60.76L1284.767 337.32z"/><path stroke="#000" stroke-linecap="round" stroke-linejoin="round" stroke-width="69.952" d="M793.262 211.444h461.512v168.06H793.262z"/></svg>'
 );

// Reduce size by 64 to get 32x32 icon
scaleSVG(svg, 1 / 64);

// Optimize icon
runSVGO(svg);

// Output result
console.log(svg.toString());
```

svg
```
<svg width="32" height="32" viewBox="0 0 32 32"><path d="m6.052 10.07 2.014 19.253h16.018l1.857-19.248H6.05zm2.256 2.033H23.71l-1.47 15.185H9.903z" color="#000"/><path fill="none" stroke="#000" stroke-linecap="round" stroke-width="1.344" d="m7.033 1040.98.944 7.503m5.013-7.503-.943 7.503" transform="matrix(1.5122 0 0 1.3627 .865 -1403.808)"/><path d="M11.85 5.272 5.368 7.17v.95h21.273v-.95l-6.56-1.897z"/><path stroke="#000" stroke-linecap="round" stroke-linejoin="round" stroke-width="1.093" d="M12.399 3.305h7.213v2.627H12.4z"/></svg>
```

[Page 152](https://iconify.design/docs/libraries/tools/icon/mask.html "Current Page.")

## Converting SVG to mask

This function is part of [icon manipulation functions](https://iconify.design/docs/) in [Iconify Tools](https://iconify.design/).

Function convertSVGToMask() converts icon content to an alpha mask and masks a rectangle that has the same dimensions as icon's viewBox.

This function is intended to be used in two scenarios:

- When changing icon with multiple colors to a monotone icon, using different shades for different colors.
- When fixing badly designed icon, which has white shapes instead of transparent parts.

## How masks work

Masks help in a situation when there are multiple shapes, some of which should be solid, some transparent. Image in a mask is treated as an alpha channel for shape that is being masked.

Color in shapes is treated as an alpha channel: white (255) has opacity of 1, black (0) has opacity of 0. Other colors are converted to alpha channel by combining their red, green and blue channels are dividing it by 255\*3.

For example, this icon has multiple shapes with different colors (using black background to make sure white shapes are visible):

Here is the same icon used as a mask for rectangle, rendered using various colors:

Code used to create this sample is available below in the examples section, in "Converting as is" demo.

## Usage

Function has the following parameters:

- svg, [SVG](https://iconify.design/docs/libraries/tools/svg/ "SVG documentation"). Icon instance.
- options, object. Optional options.

Function returns true on success, false if icon was not converted to mask.

### False result

When can function fail to convert icon to mask?

- If icon contains unexpected color(s). Make sure all colors are handled by solid, transparent and/or custom options.
- If there is nothing to mask (icon has one color) and force option is not enabled. Use parseColors to change color in such icons.

## Options

Options is an object with the following optional properties:

- id, string. Mask id, default value is "mask".
- force, boolean. If enabled, forces function to apply mask even if there is nothing to mask.
- color, string. Color to fill mask, default value is "#000".

To tell function which colors should be treated as solid, transparent or semi-transparent, use the following options:

- solid, string|string\[\]|function. Solid colors: string, array of strings or a callback.
- transparent, string|string\[\]|function. Transparent colors: string, array of strings or a callback.
- custom, function. Callback that should return mask color or opacity for a color found in icon.

By default, black color is considered to be solid, white color is considered to be transparent (opposite of how masks work, but exactly how most bugged icons are designed), all other colors found in an icon will cause function to fail.

When using custom option, you might want to disable default values for solid and transparent options if custom does not handle unknown colors. To do that, set them to empty arrays.

### Solid and transparent

solid and transparent can be:

- string, such as "#fff"
- string\[\], such as \["#fff", "black"\]
- function, which takes color string as parameter and returns true (if color should be solid/transparent) or false (if color should not be solid/transparent)

Color values and color passed to callback are always in lower case. So, if your icon uses "#FFF", check for "#fff".

### Custom

custom property is used when both solid and transparent return false.

It is a function with 2 parameters:

- Color as string, in lower case, such as "#fff".
- Color as Color instance.

Function can return:

- Color as string, such as "#fff" for solid shapes, "#000" for transparent shapes, any other valid color for semi-transparent shapes.
- Opacity as number between 0 and 1. Function will convert opacity returned by callback to a grayscale color.

Default values for solid and transparent properties might interfere with custom property, so set them to either an empty array or a callback that always returns false.

## Examples

The following examples show how to use function.

### Fix black/white

This example fixes badly designed icons, which use black color for solid shapes, white color for transparent shapes.

Such icons are widespread in icon sets available in Figma community resources: designers use white background for pages and don't notice that shapes contain white colors because outside of an icon background is also white.

ts
```
import { SVG, convertSVGToMask } from '@iconify/tools';

const svg = new SVG(
    \`<svg width="24" height="24" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
    <path d="M14 4H10C6.22876 4 4.34315 4 3.17157 5.17157C2.32803 6.01511 2.09185 7.22882 2.02572 9.25H21.9743C21.9082 7.22882 21.672 6.01511 20.8284 5.17157C19.6569 4 17.7712 4 14 4Z" fill="black"/>
    <path d="M10 20H14C17.7712 20 19.6569 20 20.8284 18.8284C22 17.6569 22 15.7712 22 12C22 11.5581 22 11.142 21.9981 10.75H2.00189C2 11.142 2 11.5581 2 12C2 15.7712 2 17.6569 3.17157 18.8284C4.34315 20 6.22876 20 10 20Z" fill="black"/>
    <path fill-rule="evenodd" clip-rule="evenodd" d="M5.25 16C5.25 15.5858 5.58579 15.25 6 15.25H10C10.4142 15.25 10.75 15.5858 10.75 16C10.75 16.4142 10.4142 16.75 10 16.75H6C5.58579 16.75 5.25 16.4142 5.25 16Z" fill="white"/>
    <path fill-rule="evenodd" clip-rule="evenodd" d="M11.75 16C11.75 15.5858 12.0858 15.25 12.5 15.25H14C14.4142 15.25 14.75 15.5858 14.75 16C14.75 16.4142 14.4142 16.75 14 16.75H12.5C12.0858 16.75 11.75 16.4142 11.75 16Z" fill="white"/>
 </svg>\`
 );

// Convert to mask, converting black color to solid, white to transparent (default options)
convertSVGToMask(svg);

// Output result
console.log(svg.toString());
```

svg
```
<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
    <defs>
        <mask id="mask">
            <path d="M14 4H10C6.22876 4 4.34315 4 3.17157 5.17157C2.32803 6.01511 2.09185 7.22882 2.02572 9.25H21.9743C21.9082 7.22882 21.672 6.01511 20.8284 5.17157C19.6569 4 17.7712 4 14 4Z" fill="#fff"/>
            <path d="M10 20H14C17.7712 20 19.6569 20 20.8284 18.8284C22 17.6569 22 15.7712 22 12C22 11.5581 22 11.142 21.9981 10.75H2.00189C2 11.142 2 11.5581 2 12C2 15.7712 2 17.6569 3.17157 18.8284C4.34315 20 6.22876 20 10 20Z" fill="#fff"/>
            <path fill-rule="evenodd" clip-rule="evenodd" d="M5.25 16C5.25 15.5858 5.58579 15.25 6 15.25H10C10.4142 15.25 10.75 15.5858 10.75 16C10.75 16.4142 10.4142 16.75 10 16.75H6C5.58579 16.75 5.25 16.4142 5.25 16Z" fill="#000"/>
            <path fill-rule="evenodd" clip-rule="evenodd" d="M11.75 16C11.75 15.5858 12.0858 15.25 12.5 15.25H14C14.4142 15.25 14.75 15.5858 14.75 16C14.75 16.4142 14.4142 16.75 14 16.75H12.5C12.0858 16.75 11.75 16.4142 11.75 16Z" fill="#000"/>
        </mask>
    </defs>
    <rect mask="url(#mask)" width="24" height="24" fill="currentColor"/>
</svg>
```

If instead of black color, icon is designed using another color, such as "#1C274C", add it to solid option in lower case:

ts
```
convertSVGToMask(svg, {
    solid: ['#000', 'black', '#1c274c']
 });
```

### Converting as is

This example masks an icon without changing any colors. It is used to create mask sample used at the beginning of this page:

ts
```
import { SVG, convertSVGToMask } from '@iconify/tools';

const svg = new SVG(
    \`<svg width="24" height="24" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg">
        <path d="M6.5 20C4.98 20 3.68333 19.4767 2.61 18.43C1.53667 17.3767 1 16.0933 1 14.58C1 13.28 1.39 12.12 2.17 11.1C2.95667 10.08 3.98333 9.43 5.25 9.15C5.67 7.61667 6.50333 6.37667 7.75 5.43C9.00333 4.47667 10.42 4 12 4C13.9533 4 15.6067 4.68 16.96 6.04C18.32 7.39333 19 9.04667 19 11C20.1533 11.1333 21.1067 11.6333 21.86 12.5C22.62 13.3533 23 14.3533 23 15.5C23 16.7533 22.5633 17.8167 21.69 18.69C20.8167 19.5633 19.7533 20 18.5 20" fill="white"/>
        <path d="M6.5 18H18.5C19.2 18 19.79 17.7567 20.27 17.27C20.7567 16.79 21 16.2 21 15.5C21 14.8 20.7567 14.21 20.27 13.73C19.79 13.2433 19.2 13 18.5 13H17V11C17 9.62 16.5133 8.44 15.54 7.46C14.5667 6.48667 13.3867 6 12 6C10.62 6 9.44 6.48667 8.46 7.46C7.48667 8.44 7 9.62 7 11H6.5C5.53333 11 4.71 11.3433 4.03 12.03C3.34333 12.71 3 13.5333 3 14.5C3 15.4667 3.34333 16.3 4.03 17C4.71 17.6667 5.53333 18 6.5 18Z" fill="#444"/>
        <circle cx="19" cy="19" r="5" fill="red"/>
        <path d="M18 16H20V18H22V20H20V22H18V20H16V18H18V16Z" fill="white"/>
    </svg>\`
 );

// Convert to mask without changing any colors, use them as an alpha channel
convertSVGToMask(svg, {
    // Set rectangle color to currentColor
    color: 'currentColor',
    // Use custom option, returning color as is
    custom: (color) => color,
 });

// Output result
console.log(svg.toString());
```

Demo of this icon is available above in "How masks work" section.

### Multiple colors

Sometimes icons are designed with multiple colors. This function can be used to convert them to monotone icons, using different colors as solid, semi-transparent or transparent colors.

This can be done using custom option.

Example (using gray background for original icon to make sure both black and white shapes are visible):

The following code converts icon to monotone icon, rendering black shapes as solid, blue and white as different semi-transparent:

ts
```
import { SVG, convertSVGToMask } from '@iconify/tools';

const svg = new SVG(
    \`<svg xmlns="http://www.w3.org/2000/svg" width="48" height="48" viewBox="0 0 48 48">
    <g fill="none" stroke-linecap="round" stroke-linejoin="round" stroke-width="4">
        <path fill="#2F88FF" stroke="#000" d="M44.0001 24C44.0001 35.0457 35.0458 44 24.0001 44C18.0266 44 4.00006 44 4.00006 44C4.00006 44 4.00006 29.0722 4.00006 24C4.00006 12.9543 12.9544 4 24.0001 4C35.0458 4 44.0001 12.9543 44.0001 24Z"/>
        <path stroke="#fff" d="M14 18L32 18"/>
        <path stroke="#fff" d="M14 26H32"/>
        <path stroke="#fff" d="M14 34H24"/>
    </g>
 </svg>\`
 );

// Convert to mask
convertSVGToMask(svg, {
    // Treat black as solid
    solid: '#000',
    // No transparent colors
    transparent: [],
    // Custom opacity for other colors
    custom: (color) => {
        switch (color) {
            case '#fff':
                return 0.75; // same as returning '#bfbfbf'

            case '#2f88ff':
                return 0.25; // same as returning '#404040'
        }
    },
 });

// Output result
console.log(svg.toString());
```

Result:

### Advanced example

How to parse an entire icon set and check for errors?

This can be done using functions forEach() or forEachSync() of [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") instance. Both functions are suitable, but because masks are applied synchronously, there is no reason to use async functions, so forEachSync() is a better choice.

See [very long example for importing icon set from Figma](https://iconify.design/examples/import-figma.html) for code.

In that example, convertSVGToMask() is used after all colors are parsed with parseColors(). If, when parsing colors, white or semi-transparent colors are found, convertSVGToMask() is called to convert icon to mask.

[Page 153](https://iconify.design/docs/libraries/tools/import/ "Current Page.")

## Importing icons

[Iconify Tools](https://iconify.design/) can import icons from several sources.

## Usage

All functions listed below are asynchronous. Most functions create [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") instances.

Before using Iconify Tools, you should be aware that package is opinionated. Certain SVG elements are not allowed and will cause import to fail. See [SVG import limitations](https://iconify.design/tags.html).

### Async

Most functions are asynchronous.

If you are not familiar with asynchronous functions in JavaScript, read up on Promise class, async and await keywords.

The simplest way to use asynchronous functions is to wrap all your code in anonymous asynchronous function, then await functions:

ts
```
const iconSet = await importDirectory('files/svg', {
    prefix: 'test',
 });
```

To catch errors, use try and catch:

ts
```
let iconSet: IconSet;
try {
    iconSet = await importDirectory('files/svg', {
        prefix: 'test',
    });
 } catch (err) {
    console.error(\`Failed to import directory:\`, err);
    return;
 }
```

Check out various tutorials for async and await. There are many free good tutorials on YouTube.

## Cleanup

After importing icons, make sure you validate them. See [cleanupSVG()](https://iconify.design/docs/libraries/tools/icon/cleanup.html "cleanupSVG() documentation") function.

## Import functions

There are several functions for importing icons:

### importDirectory()

Functions [importDirectory()](https://iconify.design/docs/libraries/tools/import/directory.html "importDirectory() documentation") and [importDirectorySync()](https://iconify.design/docs/libraries/tools/import/directory.html "importDirectorySync() documentation") import SVG files from directory.

### importFromFigma()

Function [importFromFigma()](https://iconify.design/docs/libraries/tools/import/figma/ "importFromFigma() documentation") imports icons from Figma document.

### Importing single icon

Making a function for importing a single file is redundant. All you have to do is read file and create [SVG](https://iconify.design/docs/libraries/tools/svg/ "SVG documentation") instance.

See [importing SVG](https://iconify.design/docs/svg.html) documentation.

### Importing Iconify icon set

Making a function for importing [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") data is also redundant. All you have to do is read file and create [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") instance.

See [importing Iconify icon set](https://iconify.design/docs/json.html) documentation.

[Page 154](https://iconify.design/docs/libraries/tools/import/json.html "Current Page.")

## Importing Iconify icon set

This tutorial is part of [import functions documentation](https://iconify.design/docs/) in [Iconify Tools](https://iconify.design/).

There is no special function for importing an icon set because it is redundant. All you have to do is read content from file, parse JSON data and create new [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") instance.

## Example

ts
```
import { promises as fs } from 'fs';
import { IconSet, exportToDirectory } from '@iconify/tools';
import { validateIconSet } from '@iconify/utils';

 (async () => {
    // Read data, parse JSON
    const rawData = JSON.parse(
        await fs.readFile('files/arty-animated.json', 'utf8')
    );

    // Validate icon set (optional step)
    const validatedData = validateIconSet(rawData);

    // Create new IconSet instance
    const iconSet = new IconSet(validatedData);

    // Done. Do something with icon set...
    // For example, export as SVG files
    await exportToDirectory(iconSet, {
        target: 'output'
    })
 })();
```

[Page 155](https://iconify.design/docs/libraries/tools/import/svg.html "Current Page.")

## Importing SVG

This tutorial is part of [import functions documentation](https://iconify.design/docs/) in [Iconify Tools](https://iconify.design/).

There is no special function for importing one icon because it is redundant. All you have to do is read content and create new [SVG](https://iconify.design/docs/libraries/tools/svg/ "SVG documentation") instance:

## Example

ts
```
import { promises as fs } from 'fs';
import {
    SVG,
    blankIconSet,
    cleanupSVG,
    runSVGO,
    parseColors,
    isEmptyColor,
 } from '@iconify/tools';

 (async () => {
    // Create an empty icon set
    const iconSet = blankIconSet('test');

    // Read icon, create SVG instance
    const content = await fs.readFile('files/home.svg', 'utf8');
    const svg = new SVG(content);

    // Clean up icon code
    cleanupSVG(svg);

    // Assume icon is monotone: replace color with currentColor, add if missing
    // If icons are not monotone, remove this code
    parseColors(svg, {
        defaultColor: 'currentColor',
        callback: (attr, colorStr, color) => {
            return !color || isEmptyColor(color) ? colorStr : 'currentColor';
        },
    });

    // Optimise
    runSVGO(svg);

    // Add icon to icon set
    iconSet.fromSVG('home', svg);
 })();
```

[Page 156](https://iconify.design/docs/libraries/tools/import/directory.html "Current Page.")

## Importing SVG from directory

This function is part of [import functions](https://iconify.design/docs/) in [Iconify Tools](https://iconify.design/).

Functions importDirectory() and importDirectorySync() find and import all SVG files from a directory.

Both functions are identical, the only difference is in how they read files. Function importDirectorySync() reads files synchronously, importDirectory() reads files asynchronously.

Functions create [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") instance, which [can be exported to various formats](https://iconify.design/export/).

## Usage

Function has the following parameters:

- dir, string. Directory to import from.
- options, object. Options (optional).

Function returns [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") instance.

## Options

The options object has the following optional properties:

- prefix, string. Icon set prefix.
- includeSubDirs, boolean. Scans files in subdirectories. Enabled by default.
- keyword, function. Callback that returns keyword for icon based on file name.
- ignoreImportErrors, boolean|"warn". Does not throw an error when an icon fails to load. Enabled by default. Disable for strict error checking. If set to "warn", will log warning, but will not throw an error.
- keepTitles, boolean. If enabled, keeps titles in SVG. Disabled by default.

Keyword callback can be asynchronous in importDirectory(), but must be synchronous in importDirectorySync(). It has 3 parameters: file name, default generated keyword, icon set. It should return string with keyword or undefined if file should be skipped.

## Validation

After importing icons, they need to be:

- Cleaned up and validated using [cleanupSVG()](https://iconify.design/docs/libraries/tools/icon/cleanup.html "cleanupSVG() documentation").
- In some cases palette needs to be fixed using [parseColors()](https://iconify.design/docs/libraries/tools/icon/colors.html "parseColors() documentation").
- Optimised using [runSVGO()](https://iconify.design/docs/libraries/tools/icon/svgo.html "runSVGO() documentation").

See example below.

## Examples

Asynchronous example:

ts
```
import {
    importDirectory,
    cleanupSVG,
    runSVGO,
    parseColors,
    isEmptyColor,
 } from '@iconify/tools';

 (async () => {
    // Import icons
    const iconSet = await importDirectory('files/svg', {
        prefix: 'test',
    });

    // Validate, clean up, fix palette and optimise
    iconSet.forEach((name, type) => {
        if (type !== 'icon') {
            return;
        }

        const svg = iconSet.toSVG(name);
        if (!svg) {
            // Invalid icon
            iconSet.remove(name);
            return;
        }

        // Clean up and optimise icons
        try {
            // Clean up icon code
            cleanupSVG(svg);

            // Assume icon is monotone: replace color with currentColor, add if missing
            // If icon is not monotone, remove this code
            parseColors(svg, {
                defaultColor: 'currentColor',
                callback: (attr, colorStr, color) => {
                    return !color || isEmptyColor(color)
                        ? colorStr
                        : 'currentColor';
                },
            });

            // Optimise
            runSVGO(svg);
        } catch (err) {
            // Invalid icon
            console.error(\`Error parsing ${name}:\`, err);
            iconSet.remove(name);
            return;
        }

        // Update icon
        iconSet.fromSVG(name, svg);
    });

    // Export
    console.log(iconSet.export());
 })();
```

Synchronous example:

ts
```
import {
    importDirectorySync,
    cleanupSVG,
    runSVGO,
    parseColors,
    isEmptyColor,
 } from '@iconify/tools';

// Import icons
const iconSet = importDirectorySync('files/svg', {
    prefix: 'test',
 });

// Validate, clean up, fix palette and optimise
 iconSet.forEachSync((name, type) => {
    if (type !== 'icon') {
        return;
    }

    const svg = iconSet.toSVG(name);
    if (!svg) {
        // Invalid icon
        iconSet.remove(name);
        return;
    }

    // Clean up and optimise icons
    try {
        // Clean up icon code
        cleanupSVG(svg);

        // Assume icon is monotone: replace color with currentColor, add if missing
        // If icon is not monotone, remove this code
        parseColors(svg, {
            defaultColor: 'currentColor',
            callback: (attr, colorStr, color) => {
                return !color || isEmptyColor(color)
                    ? colorStr
                    : 'currentColor';
            },
        });

        // Optimise
        runSVGO(svg);
    } catch (err) {
        // Invalid icon
        console.error(\`Error parsing ${name}:\`, err);
        iconSet.remove(name);
        return;
    }

    // Update icon
    iconSet.fromSVG(name, svg);
 });

// Export
console.log(iconSet.export());
```

[Page 157](https://iconify.design/docs/libraries/tools/import/figma/ "Current Page.")

## Importing icons from Figma

This function is part of [import functions](https://iconify.design/) in [Iconify Tools](https://iconify.design/).

Function importFromFigma() imports SVG files from a Figma file.

It creates [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") instance, which [can be exported to various formats](https://iconify.design/export/).

## Requirements

To import Figma file, you need to have:

- Figma file ID. See [how to get Figma file ID](https://iconify.design/docs/file-id.html) article.
- Access to document.
- Figma API access token. See [how to get Figma API access token](https://iconify.design/docs/token.html) article.

## Limitations

Import function has few limitations on Figma document structure:

Icon must be one of the following Figma node types:

- Frame
- Component
- Instance of a component

Parent layers can only be the following Figma node types:

- Page (in some Figma documentation it is called Canvas)
- Frame
- Group

Icons cannot be:

- Placed inside components or component instances
- Shapes without frame or component container

Icons cannot contain:

- Raster images
- Text. Convert text to shapes

## Usage

Function has the following parameter:

- options, object. Options.

Function returns:

- [FigmaImportResult](https://iconify.design/docs/libraries/tools/import/figma/types.html#result "FigmaImportResult documentation") object on success.
- "not\_modified" string if file has not been modified since last run (can be returned only if ifModifiedSince option is set).

In case of error, import might throw an exception, which you can catch using try and catch.

Function is asynchronous. That means you need to handle it as Promise instance, usually by adding await before function call.

## Options

Options object has many properties, most are not required.

Required options used in all parts of import process are:

- file, string. Figma file ID. See [how to get Figma file ID](https://iconify.design/docs/file-id.html) article.
- token, string. Figma API access token. See [how to get Figma API access token](https://iconify.design/docs/token.html) article.

Required option used when traversing document:

- iconNameForNode, function. Callback that checks if node is an icon.

Required option used when generating icon set:

- prefix, string. Prefix for imported icon set. It is used in [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") instance when exporting to [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation").

Other options are split in several groups:

### Cache options

These options are for caching data:

- cacheDir, string. Directory where cache should be stored. Use it to avoid retrieving same files every time you run your script.
- cacheAPITTL, string. TTL for API queries cache, in seconds. Used only if cacheDir is set, default value is 3 days.
- cacheSVGTTL, string. TTL for SVG cache, in seconds. Used only if cacheDir is set, default value is 30 days.

If you are expecting to run your script more than once, it is a good idea to cache API responses to avoid retrieving the same data multiple times. Set cacheDir to a writable directory.

TTL options usually do not need changing from default values. Each SVG has unique link, so if icon changes, it will have new cache file, so TTL for icons can be high.

If you set cache options, also consider setting ifModifiedSince option to true. This will tell import function to retrieve shallow copy of document from Figma, bypassing cache, then comparing if document in Figma has been updated since last cache. If document has been updated, function will clear cache.

js
```
const options = {
    // ... other options here
    cacheDir: 'cache/api',
    ifModifiedSince: true,
 };
```

### Options for retrieving Figma document

These options are used when retrieving document:

- version, string. Document version. Set it to parse specific version of document.
- ifModifiedSince, string|Date|true. If set, function will check if document has been updated.

#### ifModifiedSince

Option ifModifiedSince is used when you want to retrieve data only if icon set has been updated.

Value can be one of the following:

- Last modification time as string. You can get it from lastModified property of parse result.
- Last modification time as Date.
- true. This is special value, it compares time to time stored in cached data (see cacheDir option above).

If Figma document has not been modified, function will return string "not\_modified".

If option is not set, function cannot return "not\_modified".

### Options for finding icons in Figma document

Function cannot reliably detect which element is an icon and which is not.

These options tell function where to look for icons:

- ids, string\[\]. Array of node IDs to check. Useful if you know your document structure and want to limit Figma API query to specific nodes.
- depth, number. Depth of nodes tree to retrieve from API. See below.
- pages, string\[\]. List of page names that should be checked for icons.
- filterParentNode, function. Callback to filter parent nodes. Alternative to pages property, but also checks child nodes, such as frames and groups.
- iconNameForNode, function. Required. Callback that checks if node is an icon.

#### depth

Option depth tells function how deep it should scan Figma document. Scanning large documents results in slow parsing, so it is recommended to set this option.

Value is number of layers to reach icons.

For example, if icons are placed directly on page without parent group, depth value is 2.

![Figma tree depth: 2](https://iconify.design/assets/images/tools/figma_depth_2.png)

If icons are placed using the following tree:

- Page.
- Container frame or group.
- Icon frame or component or component instance.

Then depth value is 3.

![Figma tree depth: 3](https://iconify.design/assets/images/tools/figma_depth_3.png)

#### pages

Option pages tells function which pages of Figma document contain icons. Value is list of page titles.

Example:

js
```
const options = {
    // ... other options here
    pages: ['Icons'],
 };
```

If you set option pages, option filterParentNode is ignored.

#### filterParentNode

Option filterParentNode is a callback function that filters potential parent nodes.

If possible, it should be used to filter parent nodes, otherwise parser might unexpectedly find and export nodes that match icon, but are on wrong page, that you forgot about.

It is an alternative to pages option. This option is ignored if pages option is set.

Callback has the following parameters:

- node, [FigmaParentNodeData](https://iconify.design/docs/libraries/tools/import/figma/types.html#parent-node-data "FigmaParentNodeData documentation"). Node to check.
- document is Figma document structure, as returned by Figma API. TypeScript interface for document is limited because currently Figma does not provide typings for API responses.

Callback should return:

- true if node is a valid parent node.
- false if node should be ignored.

Callback can be asynchronous.

Example:

js
```
const options = {
    // ... other options here

    // 3 levels: page 'Icons' -> frame 'Regular -> icon
    depth: 3,

    // Import icons only from 'Icons' -> 'Regular'
    filterParentNode: (nodes) => {
        switch (nodes.length) {
            case 1: {
                // Page: 'Icons'
                const node = nodes[0];
                return node.name === 'Icons';
            }

            case 2: {
                // Frame: 'Regular'
                const node = nodes[1];
                return node.name === 'Regular';
            }
        }
        return false;
    },
 };
```

#### iconNameForNode

Option iconNameForNode is a callback that checks if node is an icon.

Function should return:

- string icon name if icon should be exported from node. Name is used when adding icon to [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") instance.
- null if node is not a valid icon.

Callback parameters are:

- node, [FigmaImportNodeData](https://iconify.design/docs/libraries/tools/import/figma/types.html#import-node-data "FigmaImportNodeData documentation"). Information about node.
- nodes is an object that contains number of nodes and list of nodes that callback has marked as icons.
- document is Figma document structure, as returned by Figma API. TypeScript interface for document is limited because currently Figma does not provide typings for API responses.

Example of callback:

js
```
const options = {
    // ... other options here
    iconNameForNode: (node) => {
        if (
            // Icons are stored after 2 parents: page -> container frame -> icon
            node.parents.length !== 2 ||
            // Icons use frames
            node.type !== 'FRAME' ||
            // Icon should be 32x32
            node.width !== 32 ||
            node.height !== 32
        ) {
            return null;
        }

        // Return node name as keyword for icon
        return node.name;
    },
 };
```

Callback can be asynchronous.

### Options for generating SVG

These options are identical to export settings when you export SVG from Figma:

- includeID, boolean. Set to true to include id attributes for all SVG elements (disabled by default).
- simplifyStroke, boolean. Simplifies inside/outside strokes and use stroke attribute if possible instead of <mask> (enabled by default).
- useAbsoluteBounds, boolean. Use the full dimensions of the node regardless of whether or not it is cropped or the space around it is empty. Use this to export text nodes without cropping (disabled by default).

### Options for importing icons

Function imports icons to [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") instance. These options are for customising import:

- prefix, string. Required. Prefix for icon set. It is used in [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") instance when exporting to [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation").
- beforeImportingIcon, function. Callback to call before importing each icon.
- afterImportingIcon, function. Callback to call after importing each icon.

Callback functions are identical, the only difference is one is called before importing icon, another one is used after importing icons.

Callbacks have the following parameters:

- item, [FigmaIconNode](https://iconify.design/docs/libraries/tools/import/figma/types.html#icon-node "FigmaIconNode documentation"). Item that is about to be imported or was imported. In beforeImportingIcon callback you can change its contents.
- iconSet, [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation"). Icon set instance.

Callbacks don't need to return anything.

Callbacks can be asynchronous.

## Example

The following example imports simple icon set from Figma, where all icons have color "#2e4454", then replaces color with "currentColor".

ts
```
import { importFromFigma, parseColors } from '@iconify/tools';

/**
 * Important: set 'token' option before running this code. Token is mandatory.
 *
 * You can get your API token from Figma account page. Do not share your API token with anyone!
 */

// Cache directory. Used to avoid retrieving same files multiple times.
const cacheDir = 'cache/quill';

 (async () => {
    const result = await importFromFigma({
        // Icon set prefix, used for creating icon set instance.
        prefix: 'quill',

        // Community link: https://www.figma.com/community/file/1034432054377533052/Quill-Iconset
        // Community link does not have document ID and cannot be used. To parse a community file,
        // either copy link from file (if you are author) or duplicate it.

        // Figma document. Get document id by clicking "Share" button when editing it,
        // click "Copy link" and get id from link.
        file: '9lvc7JGhqpNnpF3OK9kjnG',

        // Figma API token. You can get it from your Figma account settings.
        token: '', // process.env.FIGMA_API_TOKEN,

        // If enabled, will stop import process if Figma document has not been updated since last parse.
        // ifModifiedSince: true,

        // Directory for cache
        cacheDir,

        // Depth of layers tree where icons are located.
        // 2 = page -> icon
        // 3 = page -> frame/group -> icon
        depth: 3,

        // Function to filter parent layers. Used to avoid scanning pages and nodes
        // that do not contain icons for export.
        filterParentNode: (nodes) => {
            switch (nodes.length) {
                case 1: {
                    // Page: 'Icons'
                    const node = nodes[0];
                    return node.name === 'Icons';
                }

                case 2: {
                    // Frame: 'Regular'
                    const node = nodes[1];
                    return node.name === 'Regular';
                }
            }
            return false;
        },

        // Check if node is an icon. Returns icon name on success, null on failure.
        iconNameForNode: (node) => {
            if (
                // Icons are stored after 2 parents: page -> container frame -> icon
                node.parents.length !== 2 ||
                // Icons use frames
                node.type !== 'FRAME' ||
                // Icon should be 32x32
                node.width !== 32 ||
                node.height !== 32
            ) {
                return null;
            }

            // Return node name as keyword for icon
            return node.name;
        },
    });

    /*
    // 'not_modified' can be returned only if 'ifModifiedSince' option was set, so uncomment ifModifiedSince option
    // and this code, otherwise TypeScript will complain that result cannot be 'not_modified'
    if (result === 'not_modified') {
        // This result is possible if ifModifiedSince option is set
        console.log('Not modified');
        return;
    }
    */

    const iconSet = result.iconSet;

    // Check colors in icons
    iconSet.forEachSync((name) => {
        const svg = iconSet.toSVG(name);
        if (!svg) {
            return;
        }

        parseColors(svg, {
            // Change default color to 'currentColor'
            defaultColor: 'currentColor',

            // Callback to parse each color
            callback: (attr, colorStr) => {
                switch (colorStr.toLowerCase()) {
                    case '#2e4454':
                        // Change to currentColor
                        return 'currentColor';

                    case 'none':
                        return colorStr;
                }

                // Should not happen
                console.error(\`Unexpected ${attr} "${colorStr}" in ${name}\`);
                return colorStr;
            },
        });

        // Update icon in icon set
        iconSet.fromSVG(name, svg);
    });

    // Export icon set in IconifyJSON format
    console.log(iconSet.export());
    console.log('Found', iconSet.count(), 'icons');
 })();
```

[Page 158](https://iconify.design/docs/libraries/tools/import/figma/file-id.html "Current Page.")

## How to get Figma document ID

This article is part of [importFromFigma()](https://iconify.design/docs/libraries/tools/import/figma/ "importFromFigma() documentation") documentation.

How to get Figma file ID:

1. Open file in Figma.
2. Click the "Share" button in the top right corner.
3. Click "Copy link".

![How to get file ID in Figma](https://iconify.design/assets/images/tools/figma_id.png)

In your clipboard you will have a link to Figma file, which looks like this:

```
https://www.figma.com/file/9lvc7JGhqpNnpF3OK9kjnG/Quill-Iconset-(Community)?node-id=0%3A1
```

File ID is between "/file/" and next "/". In example above, file ID is "9lvc7JGhqpNnpF3OK9kjnG".

## Community files

Community files contain "/community/" in the file link:

```
https://www.figma.com/community/file/1034432054377533052/Quill-Iconset
```

It cannot be used to get file ID.

You need to get ID from actual file. If someone else published file to community, you need to clone it, then follow steps above to get file ID.

[Page 159](https://iconify.design/docs/libraries/tools/import/figma/token.html "Current Page.")

## How to get Figma API access token

This article is part of [importFromFigma()](https://iconify.design/docs/libraries/tools/import/figma/ "importFromFigma() documentation") documentation.

How to get Figma API access token:

1. Open Figma.
2. Select "Home" button in top left corner if you are not on home page.
3. Click your name in top right corner to see account menu.
4. Select "Settings".
5. In settings window click "Account".
6. Scroll to "Personal access tokens", in token name type something then hit enter key.

You should see new token. Copy it.

If you at some point would want to remove token, follow steps above. Below form to generate new tokens, you'll see list of all tokens. From there you can remove tokens.

Never commit token to a repository or publish it anywhere! Keep it secret. There are many ways to keep token secret, most common is using environmental variables to pass token to script. There are plenty of tutorials available that explain different methods.

[Page 160](https://iconify.design/docs/libraries/tools/import/figma/types.html "Current Page.")

## Types used in importFromFigma()

This article is part of [importFromFigma()](https://iconify.design/docs/libraries/tools/import/figma/ "importFromFigma() documentation") documentation.

## FigmaImportResult

On success, [importFromFigma()](https://iconify.design/docs/libraries/tools/import/figma/ "importFromFigma() documentation") returns [FigmaImportResult](https://iconify.design/docs/libraries/tools/import/figma/types.html#result "FigmaImportResult documentation") object, which has the following properties:

- name, string. Document name.
- version, string. Document version.
- lastModified, string. Time of last modification as string. You can pass it to ifModifiedSince to check if document has been modified since last parse.
- iconSet, [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation"). Icon set instance.
- nodesCount, number. Number of icons that were found (that iconNameForNode marked as icons).
- generatedIconsCount, number. Number of icons that Figma API generated. If not identical to nodesCount, some layers were marked as icons incorrectly.
- downloadedIconsCount, number. Number of icons that were downloaded. If not identical to generatedIconsCount, there were some errors, most likely caused by bad internet connection.
- missing, [FigmaIconNode](https://iconify.design/docs/libraries/tools/import/figma/types.html#icon-node "FigmaIconNode documentation"). List of icons that were not retrieved. See below.

## FigmaIconNode

Type [FigmaIconNode](https://iconify.design/docs/libraries/tools/import/figma/types.html#icon-node "FigmaIconNode documentation") is used in callback and in missing property of [FigmaImportResult](https://iconify.design/docs/libraries/tools/import/figma/types.html#result "FigmaImportResult documentation").

It represents one icon and has the following properties:

- id, string. Node ID in Figma document.
- name, string. Node name.
- keyword, string. Keyword for icon, returned by iconNameForNode callback.

On various stages of parsing icons, the following properties are added to object:

- url, string. URL of generated image. If missing, Figma API could not export icon.
- content, string. Icon content, downloaded from url. If missing, import function could not retrieve exported icon data.

## FigmaImportNodeData

Type [FigmaImportNodeData](https://iconify.design/docs/libraries/tools/import/figma/types.html#import-node-data "FigmaImportNodeData documentation") is used in first parameter for iconNameForNode callback.

It is a simple object with the following properties:

- id, string. Node id.
- type, string. Node type: "FRAME", "COMPONENT" or "INSTANCE".
- name, string. Node name.
- width and height, number. Dimensions of node.
- parents, [FigmaParentNodeData](https://iconify.design/docs/libraries/tools/import/figma/types.html#parent-node-data "FigmaParentNodeData documentation") \[\]. List of parent nodes (first item is page, last item is parent node of icon).

Example of node data passed to callback:

json
```
{
    "id": "12:724",
    "type": "FRAME",
    "name": "arrow-down",
    "width": 32,
    "height": 32,
    "parents": [
        { "id": "0:1", "type": "CANVAS", "name": "Icons" },
        { "id": "12:479", "type": "FRAME", "name": "Regular" }
    ]
}
```

## FigmaParentNodeData

Type [FigmaParentNodeData](https://iconify.design/docs/libraries/tools/import/figma/types.html#parent-node-data "FigmaParentNodeData documentation") is used in [FigmaImportNodeData](https://iconify.design/docs/libraries/tools/import/figma/types.html#import-node-data "FigmaImportNodeData documentation") and in first parameter for filterParentNode callback.

It is a simple object with the following properties:

- id, string. Node id.
- type, string. Node type: "CANVAS", "FRAME" or "GROUP".
- name, string. Node name.

Examples:

json
```
{
    "id": "0:1",
    "type": "CANVAS",
    "name": "Icons"
}
```

json
```
{
    "id": "12:479",
    "type": "FRAME",
    "name": "Regular"
}
```

[Page 161](https://iconify.design/docs/libraries/tools/export/ "Current Page.")

## Exporting icons

[Iconify Tools](https://iconify.design/) can export icons to several formats.

## Usage

All functions listed below work with [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") instances. You need to create instance using [blankIconSet()](https://iconify.design/docs/libraries/tools/icon-set/ "blankIconSet() documentation") or by [using one of import functions](https://iconify.design/import/).

## Cleanup and optimisation

Before exporting icons, make sure you clean them up and optimise.

See [icon manipulation functions](https://iconify.design/icon/).

## Export functions

There are several functions for exporting icons:

### Exporting Iconify icon set

[IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") instance has [export()](https://iconify.design/docs/libraries/tools/icon-set/export.html "export() documentation") function that creates [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") data. All you have to do is write it to file.

See [exporting Iconify icon set](https://iconify.design/docs/json.html) documentation.

### Exporting SVG (simplified version)

Function [exportToDirectory()](https://iconify.design/docs/libraries/tools/export/directory.html "exportToDirectory() documentation") exports all icons as SVG to a directory.

### Exporting as SVG

[IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") instance has [toString()](https://iconify.design/docs/libraries/tools/icon-set/to-string.html "toString() documentation") function that generates string for icon. You can use [forEach()](https://iconify.design/docs/libraries/tools/icon-set/for-each.html "forEach() documentation") to loop all icons in icon set.

See [exporting icons as SVG](https://iconify.design/docs/svg.html) documentation.

### Exporting NPM packages

There are different types of icon packages published at NPM, there are functions for exporting each type:

- Function [exportIconPackage()](https://iconify.design/docs/libraries/tools/export/icon-package.html "exportIconPackage() documentation") creates NPM package with one file per icon. This is used when a user needs only a few icons. This method is deprecated, but function is still maintained because some developers use it.
- Function [exportJSONPackage()](https://iconify.design/docs/libraries/tools/export/json-package.html "exportJSONPackage() documentation") creates NPM package with an entire icon set in one file. This is used to get an entire icon set.

Functions do not publish packages, they only generate contents. Run npm publish to publish generated packages.

[Page 162](https://iconify.design/docs/libraries/tools/export/json.html "Current Page.")

## Exporting Iconify icon set

This tutorial is part of [export functions documentation](https://iconify.design/docs/) in [Iconify Tools](https://iconify.design/).

[IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") instance has [export()](https://iconify.design/docs/libraries/tools/icon-set/export.html "export() documentation") function that exports icon set in [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") format.

Then you need to convert it to string using JSON.stringify() and save it to file.

## Example

ts
```
import { promises as fs } from 'fs';
import {
    importDirectory,
    cleanupSVG,
    runSVGO,
    parseColors,
    isEmptyColor,
 } from '@iconify/tools';

 (async () => {
    // Import icons
    const iconSet = await importDirectory('svg/test', {
        prefix: 'test',
    });

    // Validate, clean up, fix palette and optimise
    iconSet.forEach((name, type) => {
        if (type !== 'icon') {
            return;
        }

        const svg = iconSet.toSVG(name);
        if (!svg) {
            // Invalid icon
            iconSet.remove(name);
            return;
        }

        // Clean up and optimise icons
        try {
            // Clean up icon code
            cleanupSVG(svg);

            // Assume icon is monotone: replace color with currentColor, add if missing
            // If icon is not monotone, remove this code
            parseColors(svg, {
                defaultColor: 'currentColor',
                callback: (attr, colorStr, color) => {
                    return !color || isEmptyColor(color) ? colorStr : 'currentColor';
                },
            });

            // Optimise
            runSVGO(svg);
        } catch (err) {
            // Invalid icon
            console.error(\`Error parsing ${name}:\`, err);
            iconSet.remove(name);
            return;
        }

        // Update icon
        iconSet.fromSVG(name, svg);
    });

    // Export as IconifyJSON
    const exported = JSON.stringify(iconSet.export(), null, '\t') + '\n';

    // Save to file
    await fs.writeFile(\`output/${iconSet.prefix}.json\`, exported, 'utf8');
 })();
```

[Page 163](https://iconify.design/docs/libraries/tools/export/svg.html "Current Page.")

## Exporting SVG

This tutorial is part of [export functions documentation](https://iconify.design/docs/) in [Iconify Tools](https://iconify.design/).

[IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") instance has [toString()](https://iconify.design/docs/libraries/tools/icon-set/to-string.html "toString() documentation") function that exports icon as string. You can use [forEach()](https://iconify.design/docs/libraries/tools/icon-set/for-each.html "forEach() documentation") to loop all icons in icon set.

## Example

ts
```
import { promises as fs } from 'fs';
import {
    importDirectory,
    cleanupSVG,
    runSVGO,
    parseColors,
    isEmptyColor,
 } from '@iconify/tools';

 (async () => {
    // Import icons
    const iconSet = await importDirectory('files/svg', {
        prefix: 'test',
    });

    // Validate, clean up, fix palette and optimise
    iconSet.forEach((name, type) => {
        if (type !== 'icon') {
            return;
        }

        const svg = iconSet.toSVG(name);
        if (!svg) {
            // Invalid icon
            iconSet.remove(name);
            return;
        }

        // Clean up and optimise icons
        try {
            // Cleanup icon code
            cleanupSVG(svg);

            // Assume icon is monotone: replace color with currentColor, add if missing
            // If icon is not monotone, remove this code
            parseColors(svg, {
                defaultColor: 'currentColor',
                callback: (attr, colorStr, color) => {
                    return !color || isEmptyColor(color) ? colorStr : 'currentColor';
                },
            });

            // Optimise
            runSVGO(svg);
        } catch (err) {
            // Invalid icon
            console.error(\`Error parsing ${name}:\`, err);
            iconSet.remove(name);
            return;
        }

        // Update icon
        iconSet.fromSVG(name, svg);
    });

    // Export all icons
    await iconSet.forEach(async (name) => {
        const svg = iconSet.toString(name);
        if (!svg) {
            return;
        }

        // Save to file
        await fs.writeFile(\`output/${name}.svg\`, svg, 'utf8');
        console.log(\`Saved output/${name}.svg (${svg.length} bytes)\`);
    });
 })();
```

[Page 164](https://iconify.design/docs/libraries/tools/export/directory.html "Current Page.")

## Exporting icons to directory

This tutorial is part of [export functions documentation](https://iconify.design/docs/) in [Iconify Tools](https://iconify.design/).

Function exportToDirectory() writes all icons in [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation") instance to a specified directory.

## Usage

Function has the following parameters:

- iconSet, [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation"). Icon set to export.
- options, object. Options. See below.

Function returns array of stored icons.

Function is asynchronous. That means you need to handle it as Promise instance, usually by adding await before function call.

### Options

The options object has the following mandatory property:

- target, string. Target directory. If a directory is missing, it will be created.

and the following optional properties:

- cleanup, boolean. If true, target directory will be emptied before exporting icons. Default is false.
- autoHeight, boolean. If true, icons will have dimensions matching viewBox. If false, icons will have height set to "1em". Default is true.
- includeAliases, boolean. Generates files for aliases. Default is true.
- includeChars, boolean. Generates files for characters, such as f00.svg for icon that has character "f00" assigned to it. Default is false.
- log, boolean. If true, function logs process. Default is false.

## Example

ts
```
import { exportToDirectory, IconSet } from '@iconify/tools';

 (async () => {
    // Import icons
    const iconSet = new IconSet({
        prefix: 'test',
        icons: {
            maximize: {
                body: '<g fill="currentColor"><path d="M3 3v10h10V3H3zm9 9H4V4h8v8z"/></g>',
            },
            minimize: {
                body: '<g fill="currentColor"><path d="M14 8v1H3V8h11z"/></g>',
            },
        },
        width: 24,
        height: 24,
    });

    // Export all icons
    await exportToDirectory(iconSet, {
        target: \`output/${iconSet.prefix}\`,
        log: true,
    });
 })();
```

[Page 165](https://iconify.design/docs/libraries/tools/export/json-package.html "Current Page.")

## Exporting icon set as JSON package

This tutorial is part of [export functions documentation](https://iconify.design/docs/) in [Iconify Tools](https://iconify.design/).

Function exportJSONPackage() creates an icon package in specified directory.

These packages are used to load an entire icon sets, like this:

js
```
import { addCollection, Icon } from '@iconify/react';
import { icons as mdiLightIcons } from '@iconify-json/mdi-light';
import { icons as tablerIcons } from '@iconify-json/tabler';

addCollection(mdiLightIcons);
addCollection(tablerIcons);

// Demo using some of imported icons
export function renderHomeIcon() {
    return <Icon icon="mdi-light:home" />;
 }

export function renderAlertIcon() {
    return <Icon icon="tabler:alert-octagon" />;
 }
```

@iconify-json/mdi-light and @iconify-json/tabler are packages generated by this function, used in example above.

See [individual icon set packages documentation](https://iconify.design/docs/icons/json.html) for details.

## Usage

Function has the following parameters:

- iconSet, [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation"). Icon set to export.
- options, object. Options. See below.

Function returns array of generated files.

Function is asynchronous. That means you need to handle it as Promise instance, usually by adding await before function call.

### Options

Options object has the following mandatory property:

- target, string. Target directory. If directory is missing, it will be created.

and the following optional properties:

- cleanup, boolean. If true, target directory will be emptied before exporting icons. Default is false.
- package, object. Properties for package.json. Use this to set at least package name and version.
- customFiles, Record<string,unknown>. Custom files to export. Key is filename, value is content. See below.

### customFiles

customFiles option contains additional files you want to add to package. Key is filename, value can be one of these types:

- string. Content of file.
- object. JSON content that will be serialized before writing file.
- null. If value is null, file is deleted.

## Example

ts
```
import { exportJSONPackage, IconSet/* , execAsync */ } from '@iconify/tools';

// Import icon set
const iconSet = new IconSet({
    prefix: 'carbon',
    icons: {
        'add': {
            body: '<path d="M17 15V8h-2v7H8v2h7v7h2v-7h7v-2z" fill="currentColor"/>',
        },
        'arrow-down-regular': {
            body: '<path d="M24.59 16.59L17 24.17V4h-2v20.17l-7.59-7.58L6 18l10 10l10-10l-1.41-1.41z" fill="currentColor"/>',
        },
        'arrow-left-regular': {
            body: '<path d="M14 26l1.41-1.41L7.83 17H28v-2H7.83l7.58-7.59L14 6L4 16l10 10z" fill="currentColor"/>',
        },
        'back-to-top-regular': {
            body: '<path d="M16 14L6 24l1.4 1.4l8.6-8.6l8.6 8.6L26 24z" fill="currentColor"/><path d="M4 8h24v2H4z" fill="currentColor"/>',
        },
        'bookmark-filled': {
            body: '<path d="M24 2H8a2 2 0 0 0-2 2v26l10-5.054L26 30V4a2 2 0 0 0-2-2z" fill="currentColor"/>',
        },
        'caret-down-regular': {
            body: '<path d="M24 12l-8 10l-8-10z" fill="currentColor"/>',
        },
        'caret-left-regular': {
            body: '<path d="M20 24l-10-8l10-8z" fill="currentColor"/>',
        },
    },
    aliases: {
        'add-regular': {
            parent: 'add',
        },
        'arrow-up-regular': {
            parent: 'arrow-down-regular',
            vFlip: true,
        },
        'arrow-right-regular': {
            parent: 'arrow-left-regular',
            hFlip: true,
        },
        'caret-up-regular': {
            parent: 'caret-down-regular',
            vFlip: true,
        },
        'caret-right-regular': {
            parent: 'caret-left-regular',
            hFlip: true,
        },
    },
    width: 32,
    height: 32,
 });

 (async () => {
    // Target directory
    const target = \`output/${iconSet.prefix}\`;

    // Export package
    await exportJSONPackage(iconSet, {
        target,
        package: {
            name: \`@iconify-json/${iconSet.prefix}\`,
            version: '1.0.0',
            bugs: 'https://github.com/iconify/iconify/issues',
            homepage: 'https://github.com/iconify/iconify',
        },
        cleanup: true,
        /*
        customFiles: {
            'README.md': 'README!',
        },
        */
    });

    // Publish NPM package
    /*
    await execAsync('npm publish --access=public --silent', {
        cwd: target,
    });
    */
 })();
```

[Page 166](https://iconify.design/docs/libraries/tools/export/icon-package.html "Current Page.")

## Exporting icon set as icon package

This tutorial is part of [export functions documentation](https://iconify.design/docs/) in [Iconify Tools](https://iconify.design/).

Function exportIconPackage() creates icon package in specified directory.

These packages are used in offline icon components, like this:

jsx
```
import { Icon, addIcon/* , addCollection */ } from '@iconify/react/dist/offline';
import bellFill from '@iconify-icons/bi/bell-fill';

// Assign icon data to name "bell" used in first example
addIcon('bell', bellFill);

// Test component
export function iconDemo() {
    return (
        <div>
            <div>
                Icon referenced by name: <Icon icon="bell" />
            </div>
            <div>
                Icon referenced by object: <Icon icon={bellFill} />
            </div>
        </div>
    );
 }
```

@iconify-icons/bi is a package generated by this function, used in example above.

See [split icon packages documentation](https://iconify.design/docs/icons/icons.html) for details.

### Deprecation notice

This function is deprecated, but it is still maintained for developers that do rely on it.

Single icon packages were needed in the early stages of Iconify project. In the modern Node ecosystem, this is no longer needed. Tools like Vite can be used to generate content on demand, including single file packages. Packages like Unplugin Icons dynamically generate icon components.

Single icon packages are no longer needed and should be avoided. If you need to extract data for few icons, do it during the build process of your app as either a custom script or a Vite plugin.

## Usage

Function has the following parameters:

- iconSet, [IconSet](https://iconify.design/docs/libraries/tools/icon-set/ "IconSet documentation"). Icon set to export.
- options, object. Options. See below.

Function returns array of generated files.

Function is asynchronous. That means you need to handle it as Promise instance, usually by adding await before function call.

### Options

The options object has the following mandatory property:

- target, string. Target directory. If a directory is missing, it will be created.

and the following optional properties:

- cleanup, boolean. If true, target directory will be emptied before exporting icons. Default is false.
- package, object. Properties for package.json. Use this to set at least package name and version.
- module, boolean. If true, function generates package with ES modules, if false, function generates package with CommonJS modules. Default is true.
- typesContent, string. Custom content of.d.ts files.
- customFiles, Record<string,unknown>. Custom files to export. Key is filename, value is content. See below.

### customFiles

customFiles option contains additional files you want to add to package. Key is filename, value can be one of these types:

- string. Content of file.
- object. JSON content that will be serialized before writing file.
- null. If value is null, file is deleted.

## Example

ts
```
import { exportIconPackage, IconSet/* , execAsync */ } from '@iconify/tools';

// Import icon set
const iconSet = new IconSet({
    prefix: 'carbon',
    icons: {
        'add': {
            body: '<path d="M17 15V8h-2v7H8v2h7v7h2v-7h7v-2z" fill="currentColor"/>',
        },
        'arrow-down-regular': {
            body: '<path d="M24.59 16.59L17 24.17V4h-2v20.17l-7.59-7.58L6 18l10 10l10-10l-1.41-1.41z" fill="currentColor"/>',
        },
        'arrow-left-regular': {
            body: '<path d="M14 26l1.41-1.41L7.83 17H28v-2H7.83l7.58-7.59L14 6L4 16l10 10z" fill="currentColor"/>',
        },
        'back-to-top-regular': {
            body: '<path d="M16 14L6 24l1.4 1.4l8.6-8.6l8.6 8.6L26 24z" fill="currentColor"/><path d="M4 8h24v2H4z" fill="currentColor"/>',
        },
        'bookmark-filled': {
            body: '<path d="M24 2H8a2 2 0 0 0-2 2v26l10-5.054L26 30V4a2 2 0 0 0-2-2z" fill="currentColor"/>',
        },
        'caret-down-regular': {
            body: '<path d="M24 12l-8 10l-8-10z" fill="currentColor"/>',
        },
        'caret-left-regular': {
            body: '<path d="M20 24l-10-8l10-8z" fill="currentColor"/>',
        },
    },
    aliases: {
        'add-regular': {
            parent: 'add',
        },
        'arrow-up-regular': {
            parent: 'arrow-down-regular',
            vFlip: true,
        },
        'arrow-right-regular': {
            parent: 'arrow-left-regular',
            hFlip: true,
        },
        'caret-up-regular': {
            parent: 'caret-down-regular',
            vFlip: true,
        },
        'caret-right-regular': {
            parent: 'caret-left-regular',
            hFlip: true,
        },
    },
    width: 32,
    height: 32,
 });

 (async () => {
    // Target directory
    const target = \`output/${iconSet.prefix}\`;

    // Export package
    await exportIconPackage(iconSet, {
        target,
        module: true,
        package: {
            name: \`@iconify-icons/${iconSet.prefix}\`,
            version: '1.0.0',
            bugs: 'https://github.com/iconify/iconify/issues',
            homepage: 'https://github.com/iconify/iconify',
        },
        cleanup: true,
        /*
        customFiles: {
            'README.md': 'README!',
        },
        */
    });

    // Publish NPM package
    /*
    await execAsync('npm publish --access=public --silent', {
        cwd: target,
    });
    */
 })();
```

[Page 167](https://iconify.design/docs/libraries/tools/package/ "Current Page.")

## Managing packages

[Iconify Tools](https://iconify.design/) has several functions to help automate downloading, comparing and updating packages.

## Async

Most functions listed below are asynchronous.

If you are not familiar with asynchronous functions in JavaScript, read up on Promise class, async and await keywords.

The simplest way to use asynchronous functions is to wrap all your code in anonymous asynchronous function, then await functions:

ts
```
const iconSet = await importDirectory('files/svg', {
    prefix: 'test',
 });
```

To catch errors, use try and catch:

ts
```
let iconSet: IconSet;
try {
    iconSet = await importDirectory('files/svg', {
        prefix: 'test',
    });
 } catch (err) {
    console.error(\`Failed to import directory:\`, err);
    return;
 }
```

Check out various tutorials for async and await. There are many free good tutorials on YouTube.

## Downloading packages

These functions download packages from various sources.

Functions can be used to download source for icon sets, which can be imported using [importDirectory()](https://iconify.design/docs/libraries/tools/import/directory.html "importDirectory() documentation") function.

Functions can also be used to compare exported data with previously published data, then publish new version if package was changed.

- [downloadGitRepo()](https://iconify.design/docs/libraries/tools/package/git.html "downloadGitRepo() documentation") creates a shallow clone of Git repository.
- [downloadGitHubRepo()](https://iconify.design/docs/libraries/tools/package/github.html "downloadGitHubRepo() documentation") downloads a GitHub repository using GitHub API. It is similar to [downloadGitRepo()](https://iconify.design/docs/libraries/tools/package/git.html "downloadGitRepo() documentation"), but uses API instead of Git client.
- [downloadGitLabRepo()](https://iconify.design/docs/libraries/tools/package/gitlab.html "downloadGitLabRepo() documentation") downloads a GitLab repository using GitLab API. It is similar to [downloadGitRepo()](https://iconify.design/docs/libraries/tools/package/git.html "downloadGitRepo() documentation"), but uses API instead of Git client.
- [downloadNPMPackage()](https://iconify.design/docs/libraries/tools/package/npm.html "downloadNPMPackage() documentation") downloads NPM package from registry.

Additionally, there are few functions to download files by URL:

- [sendAPIQuery()](https://iconify.design/docs/libraries/tools/package/api-query.html "sendAPIQuery() documentation") is a wrapper for fetch with support for cache. It is used by functions like [importFromFigma()](https://iconify.design/docs/libraries/tools/import/figma/ "importFromFigma() documentation").
- [downloadFile()](https://iconify.design/docs/libraries/tools/package/download-file.html "downloadFile() documentation") is also a wrapper for fetch that simplifies downloading of binary files, such as archives. It is used by GitHub, GitLab and NPM downloaders.

## Versions

When publishing packages, you might want to change package version. Iconify Tools offers several functions to help you automate process:

- [bumpVersion()](https://iconify.design/docs/libraries/tools/package/bump-version.html "bumpVersion() documentation") increases version number.

Functions to get version number or commit hash from local files:

- [getPackageVersion()](https://iconify.design/docs/libraries/tools/package/package-version.html "getPackageVersion() documentation") retrieves version number from package.json.
- [getGitRepoHash()](https://iconify.design/docs/libraries/tools/package/git-repo-hash.html "getGitRepoHash() documentation") retrieves hash of local git repository.

Functions to get version number or commit hash from remote package/repository:

- [getNPMVersion()](https://iconify.design/docs/libraries/tools/package/npm-version.html "getNPMVersion() documentation") retrieves latest version of package from NPM registry.
- [getGitHubRepoHash()](https://iconify.design/docs/libraries/tools/package/github-commit.html "getGitHubRepoHash() documentation") retrieves hash of last commit from remote GitHub repository.
- [getGitLabRepoHash()](https://iconify.design/docs/libraries/tools/package/gitlab-commit.html "getGitLabRepoHash() documentation") retrieves hash of last commit from remote GitLab repository.

## Comparing directories

When automating build process, publishing new package when nothing was changed makes no sense. There is a function in Iconify Tools to check for changes:

- [compareDirectories()](https://iconify.design/docs/libraries/tools/package/compare.html "compareDirectories() documentation") compares contents of two directories.

Unlike simple comparison, this function ignores version numbers in package.json, hidden files and different line endings.

[Page 168](https://iconify.design/docs/libraries/tools/package/git.html "Current Page.")

## Downloading Git repository

This tutorial is part of [package functions documentation](https://iconify.design/docs/) in [Iconify Tools](https://iconify.design/).

Function downloadGitRepo() creates a shallow clone of Git repository.

## Git executable

This function uses Git to clone repository. Make sure Git is installed on your computer.

## Usage

Function has the following parameter:

- options, object. Options, see below.

Function returns:

- [DownloadGitRepoResult](https://iconify.design/docs/libraries/tools/package/git.html#result "DownloadGitRepoResult documentation") object on success.
- "not\_modified" string if repository has not been updated since last run (can be returned only if ifModifiedSince option is set).

In case of error, function might throw an exception, which you can catch using try and catch.

Function is asynchronous. That means you need to handle it as Promise instance, usually by adding await before function call.

### Options

Options object has the following mandatory properties:

- target, string. Target directory. If directory is missing, it will be created. Value can contain "{hash}" that will be replaced with latest commit hash.
- remote, string. Git repository, such as " [\[email protected\]](https://iconify.design/cdn-cgi/l/email-protection):iconify/tools.git".
- branch, string. Branch, such as "master".

and the following optional properties:

- cleanup, boolean. If true, target directory will be emptied before exporting icons. Default is false.
- ifModifiedSince, string|true| [DownloadGitRepoResult](https://iconify.design/docs/libraries/tools/package/git.html#result "DownloadGitRepoResult documentation"). If set, function will check if repository has been updated.

#### ifModifiedSince

Option ifModifiedSince is used when you want to retrieve data only if repository has been updated.

Value can be one of the following:

- Commit hash as string. You can get it from hash property of result of previous run.
- If value is true, function compare hash in remote repository with hash from previously downloaded files in target directory.
- [DownloadGitRepoResult](https://iconify.design/docs/libraries/tools/package/git.html#result "DownloadGitRepoResult documentation") value from previous run.

If repository has not been modified, function will return string "not\_modified".

If option is not set, function cannot return "not\_modified".

### Result

Result object has the following properties:

- downloadType = "git".
- contentsDir, string. Directory where repository was cloned to. It is normalized version of target option, without trailing "/" and with "{hash}" replaced with commit hash.
- hash, string. Last commit hash.

## Example

ts
```
import { downloadGitRepo } from '@iconify/tools';

 (async () => {
    console.log(
        await downloadGitRepo({
            target: 'downloads/boxicons-{hash}',
            remote: '[email protected]:atisawd/boxicons.git',
            branch: 'master',
            ifModifiedSince: true,
            log: true,
        })
    );
 })();
```

[Page 169](https://iconify.design/docs/libraries/tools/package/github.html "Current Page.")

## Downloading GitHub repository using API

This tutorial is part of [package functions documentation](https://iconify.design/docs/) in [Iconify Tools](https://iconify.design/).

Function downloadGitHubRepo() downloads files from GitHub repository using GitHub API.

## Usage

Function has the following parameter:

- options, object. Options, see below.

Function returns:

- [DownloadGitHubRepoResult](https://iconify.design/docs/libraries/tools/package/github.html#result "DownloadGitHubRepoResult documentation") object on success.
- "not\_modified" string if repository has not been updated since last run (can be returned only if ifModifiedSince option is set).

In case of error, function might throw an exception, which you can catch using try and catch.

Function is asynchronous. That means you need to handle it as Promise instance, usually by adding await before function call.

### Options

Options object has the following mandatory properties:

- target, string. Target directory. If directory is missing, it will be created. Value can contain "{hash}" that will be replaced with latest commit hash.
- user, string. GitHub user or organisation, such as "iconify" for " [\[email protected\]](https://iconify.design/cdn-cgi/l/email-protection):iconify/tools.git".
- repo, string. Repository name, such as "tools" for " [\[email protected\]](https://iconify.design/cdn-cgi/l/email-protection):iconify/tools.git".
- branch, string. Branch, such as "master".
- token, string. GitHub API token. See below.

and the following optional properties:

- cleanup, boolean. If true, target directory will be emptied before exporting icons. Default is false.
- ifModifiedSince, string| [DownloadGitHubRepoResult](https://iconify.design/docs/libraries/tools/package/github.html#result "DownloadGitHubRepoResult documentation"). If set, function will check if repository has been updated.

Function downloads archive, puts it in target directory, then unpacks it in sub-directory. There are two optional properties that allow you remove outdated files without removing everything. Options do not work if cleanup is enabled because cleanup removes everything.

- cleanupOldFiles, boolean. If true, old zip files in target directory will be removed. Default is false.
- cleanupOldDirectories, boolean. If true, old unpacked archives in target directory will be removed. Default is true.

#### token

You can get GitHub API token from [developer settings on GitHub](https://github.com/settings/tokens).

Token does not need write or admin access, access to workflows, it requires only read access to repository you want to clone.

If you are accessing public repositories, checking "repo:status" and "public\_repo" is enough.

If you are accessing private repositories, check "repo" section.

Never commit token to a repository or publish it anywhere! Keep it secret. There are many ways to keep token secret, most common is using environmental variables to pass token to script. There are plenty of tutorials available that explain different methods.

#### ifModifiedSince

Option ifModifiedSince is used when you want to retrieve data only if repository has been updated.

Value can be one of the following:

- Commit hash as string. You can get it from hash property of result of previous run.
- [DownloadGitHubRepoResult](https://iconify.design/docs/libraries/tools/package/github.html#result "DownloadGitHubRepoResult documentation") value from previous run.

If repository has not been modified, function will return string "not\_modified".

If option is not set, function cannot return "not\_modified".

### Result

Result object has the following properties:

- downloadType = "github".
- rootDir, string. Target directory. It is normalized version of target option, without trailing "/" and with "{hash}" replaced with commit hash.
- contentsDir, string. Directory where archive was unpacked.
- hash, string. Last commit hash.

Value is contentsDir always contains rootDir because archives are unpacked in sub-directory of rootDir. For example:

json
```
{
    "downloadType": "github",
    "rootDir": "output/github-test",
    "contentsDir": "output/github-test/iconify-collections-json-4049946",
    "hash": "40499460e21011478a64c1cb1212f3308168462c"
}
```

## Example

ts
```
import { downloadGitHubRepo } from '@iconify/tools';

// GITHUB_TOKEN=ghp_12345 node example.js
const token = process.env.GITHUB_TOKEN || '';

 (async () => {
    console.log(
        await downloadGitHubRepo({
            target: 'downloads/jam',
            user: 'michaelampr',
            repo: 'jam',
            branch: 'master',
            token,
        })
    );
 })();
```

[Page 170](https://iconify.design/docs/libraries/tools/package/gitlab.html "Current Page.")

## Downloading GitLab repository using API

This tutorial is part of [package functions documentation](https://iconify.design/docs/) in [Iconify Tools](https://iconify.design/).

Function downloadGitLabRepo() downloads files from GitLab repository using GitLab API.

## Usage

Function has the following parameter:

- options, object. Options, see below.

Function returns:

- [DownloadGitLabRepoResult](https://iconify.design/docs/libraries/tools/package/gitlab.html#result "DownloadGitLabRepoResult documentation") object on success.
- "not\_modified" string if repository has not been updated since last run (can be returned only if ifModifiedSince option is set).

In case of error, function might throw an exception, which you can catch using try and catch.

Function is asynchronous. That means you need to handle it as Promise instance, usually by adding await before function call.

### Options

Options object has the following mandatory properties:

- target, string. Target directory. If directory is missing, it will be created. Value can contain "{hash}" that will be replaced with latest commit hash.
- project, string. GitLab project ID. You can find it on project page on GitLab website.
- branch, string. Branch, such as "master".
- token, string. GitLab API token. See below.
- uri, string. Optional URI for custom GitLab host, default value is https://gitlab.com/api/v4/projects.

and the following optional properties:

- cleanup, boolean. If true, target directory will be emptied before exporting icons. Default is false.
- ifModifiedSince, string| [DownloadGitLabRepoResult](https://iconify.design/docs/libraries/tools/package/gitlab.html#result "DownloadGitLabRepoResult documentation"). If set, function will check if repository has been updated.

Function downloads archive, puts it in target directory, then unpacks it in sub-directory. There are two optional properties that allow you remove outdated files without removing everything. Options do not work if cleanup is enabled because cleanup removes everything.

- cleanupOldFiles, boolean. If true, old zip files in target directory will be removed. Default is false.
- cleanupOldDirectories, boolean. If true, old unpacked archives in target directory will be removed. Default is true.

#### token

You can get GitLab API token from [access tokens page on GitLab](https://gitlab.com/-/profile/personal_access_tokens).

If you are creating a new token, set scope to "read\_api".

Never commit token to a repository or publish it anywhere! Keep it secret. There are many ways to keep token secret, most common is using environmental variables to pass token to script. There are plenty of tutorials available that explain different methods.

#### ifModifiedSince

Option ifModifiedSince is used when you want to retrieve data only if repository has been updated.

Value can be one of the following:

- Commit hash as string. You can get it from hash property of result of previous run.
- [DownloadGitLabRepoResult](https://iconify.design/docs/libraries/tools/package/gitlab.html#result "DownloadGitLabRepoResult documentation") value from previous run.

If repository has not been modified, function will return string "not\_modified".

If option is not set, function cannot return "not\_modified".

### Result

Result object has the following properties:

- downloadType = "gitlab".
- rootDir, string. Target directory. It is normalized version of target option, without trailing "/" and with "{hash}" replaced with commit hash.
- contentsDir, string. Directory where archive was unpacked.
- hash, string. Last commit hash.

Value is contentsDir always contains rootDir because archives are unpacked in sub-directory of rootDir. For example:

json
```
{
    "downloadType": "gitlab",
    "rootDir": "output/gitlab-test",
    "contentsDir": "output/gitlab-test/iconify-collections-json-4049946",
    "hash": "40499460e21011478a64c1cb1212f3308168462c"
}
```

## Example

ts
```
import { downloadGitLabRepo } from '@iconify/tools';

// GITLAB_TOKEN=qwertyuiop node example.js
const token = process.env.GITLAB_TOKEN || '';

 (async () => {
    console.log(
        await downloadGitLabRepo({
            target: 'downloads/eos-icons',
            project: '4600360',
            branch: 'master',
            token,
        })
    );
 })();
```

[Page 171](https://iconify.design/docs/libraries/tools/package/npm.html "Current Page.")

## Downloading NPM package

This tutorial is part of [package functions documentation](https://iconify.design/docs/) in [Iconify Tools](https://iconify.design/).

Function downloadNPMPackage() downloads NPM package.

Unlike npm install, this function downloads and extracts only requested NPM package, it does not install dependencies and does not run any scripts.

## Usage

Function has the following parameter:

- options, object. Options, see below.

Function returns:

- [DownloadNPMPackageResult](https://iconify.design/docs/libraries/tools/package/npm.html#result "DownloadNPMPackageResult documentation") object on success.
- "not\_modified" string if repository has not been updated since last run (can be returned only if ifModifiedSince option is set).

In case of error, function might throw an exception, which you can catch using try and catch.

Function is asynchronous. That means you need to handle it as Promise instance, usually by adding await before function call.

### Options

Options object has the following mandatory properties:

- target, string. Target directory. If directory is missing, it will be created.
- package, string. Package name.

and the following optional properties:

- tag, string. NPM tag. Default is "latest".
- cleanup, boolean. If true, target directory will be emptied before exporting icons. Default is false.
- ifModifiedSince, string|true| [DownloadNPMPackageResult](https://iconify.design/docs/libraries/tools/package/npm.html#result "DownloadNPMPackageResult documentation"). If set, function will check if repository has been updated.

#### ifModifiedSince

Option ifModifiedSince is used when you want to retrieve data only if repository has been updated.

Value can be one of the following:

- Version as string. You can get it from version property of result of previous run.
- If value is true, function compare latest version in NPM registry with version from previously downloaded files in target directory.
- [DownloadNPMPackageResult](https://iconify.design/docs/libraries/tools/package/npm.html#result "DownloadNPMPackageResult documentation") value from previous run.

If package has not been updated, function will return string "not\_modified".

If option is not set, function cannot return "not\_modified".

### Result

Result object has the following properties:

- downloadType = "npm".
- rootDir, string. Target directory. It is normalized version of target option, without trailing "/".
- contentsDir, string. Directory where archive was unpacked.
- version, string. Package version.

Value is contentsDir always contains rootDir because archives are unpacked in sub-directory of rootDir. For example:

json
```
{
    "downloadType": "npm",
    "rootDir": "output/npm-test",
    "contentsDir": "output/npm-test/package",
    "version": "1.0.1"
}
```

## Example

ts
```
import { downloadNPMPackage } from '@iconify/tools';

 (async () => {
    console.log(
        await downloadNPMPackage({
            target: 'downloads/icon-sets/mdi-light',
            package: '@iconify-json/mdi-light',
        })
    );
 })();
```

[Page 172](https://iconify.design/docs/libraries/tools/package/bump-version.html "Current Page.")

## Increasing version number

This tutorial is part of [package functions documentation](https://iconify.design/docs/) in [Iconify Tools](https://iconify.design/).

Function bumpVersion() is a simple function that increases version number.

It can be used to automatically increase version number when updating existing package.

## Usage

Function has the following parameter:

- version, string. Old version

Function returns updated version number.

## Example

ts
```
import { bumpVersion } from '@iconify/tools';

console.log(bumpVersion('1.0.0')); // 1.0.1
console.log(bumpVersion('2.1.3')); // 2.1.4
console.log(bumpVersion('2.0.0-beta.1')); // 2.0.0-beta.2
```

[Page 173](https://iconify.design/docs/libraries/tools/package/npm-version.html "Current Page.")

## Getting NPM package version and URL

This tutorial is part of [package functions documentation](https://iconify.design/docs/) in [Iconify Tools](https://iconify.design/).

Function [getNPMVersion()](https://iconify.design/docs/libraries/tools/package/package-version.html "getNPMVersion() documentation") retrieves latest version of package from NPM registry and URL to download package.

## Usage

Function has the following parameter:

- options, NPMPackageOptions. Options, same as in downloadNPMPackage() function (only package and tag properties are used).

Function returns object with the following properties:

- version, string. Version number.
- file, string. URL of archive, if available.

## Example

ts
```
import { getNPMVersion } from '@iconify/tools';

 (async () => {
    console.log(
        await getNPMVersion({
            package: '@iconify-json/mdi-light',
            // tag: 'latest',
        })
    );
 })();
```

json
```
{
    "version": "1.0.1",
    "file": "https://registry.npmjs.org/@iconify-json/mdi-light/-/mdi-light-1.0.1.tgz"
}
```

[Page 174](https://iconify.design/docs/libraries/tools/package/package-version.html "Current Page.")

## Getting version number of package

This tutorial is part of [package functions documentation](https://iconify.design/docs/) in [Iconify Tools](https://iconify.design/).

Function getPackageVersion() is a simple function that retrieves version number from package.json in target directory.

It is used by [downloadNPMPackage()](https://iconify.design/docs/libraries/tools/package/npm.html "downloadNPMPackage() documentation") to retrieve version number of package that has already been downloaded and extracted. It can also be used to get version number of package downloaded from Git repository (as shown in example below).

## Usage

Function has the following parameter:

- target, string. Target directory, without "/package.json".

Function returns version number as string.

Also see [getNPMVersion()](https://iconify.design/docs/libraries/tools/package/npm-version.html "getNPMVersion() documentation").

Function is asynchronous.

## Example

ts
```
import { downloadGitHubRepo, getPackageVersion } from '@iconify/tools';

// GITHUB_TOKEN=ghp_12345 node example.js
const token = process.env.GITHUB_TOKEN || '';

 (async () => {
    // Download GitHub repository
    const result = await downloadGitHubRepo({
        target: 'downloads/bi',
        user: 'twbs',
        repo: 'icons',
        branch: 'main',
        token,
    });

    // Get version from downloaded package
    const version = await getPackageVersion(result.contentsDir);

    // '1.7.0'
    console.log('Version:', version);
 })();
```

[Page 175](https://iconify.design/docs/libraries/tools/package/git-repo-hash.html "Current Page.")

## Getting Git repository hash

This tutorial is part of [package functions documentation](https://iconify.design/docs/) in [Iconify Tools](https://iconify.design/).

Function getGitRepoHash() retrieves last commit hash from local Git repository.

It is used by [downloadGitRepo()](https://iconify.design/docs/libraries/tools/package/git.html "downloadGitRepo() documentation").

## Usage

Function has the following parameter:

- options, DownloadGitRepoOptions. Options, same as in downloadGitRepo() function (only target property is used).

Function returns last commit hash as string.

Function is asynchronous.

[Page 176](https://iconify.design/docs/libraries/tools/package/github-commit.html "Current Page.")

## Getting last commit hash for GitHub repository

This tutorial is part of [package functions documentation](https://iconify.design/docs/) in [Iconify Tools](https://iconify.design/).

Function getGitHubRepoHash() retrieves last commit hash from remote GitHub repository using GitHub API.

It is used by [downloadGitHubRepo()](https://iconify.design/docs/libraries/tools/package/github.html "downloadGitHubRepo() documentation") to check if repository has been updated and to generate download link for archive.

## Usage

Function has the following parameter:

- options, DownloadGitHubRepoOptions. Options, same as in downloadGitHubRepo() function (only properties relevant to accessing GitHub API are used).

Function returns last commit hash as string.

Function is asynchronous.

[Page 177](https://iconify.design/docs/libraries/tools/package/gitlab-commit.html "Current Page.")

## Getting last commit hash for GitLab repository

This tutorial is part of [package functions documentation](https://iconify.design/docs/) in [Iconify Tools](https://iconify.design/).

Function getGitLabRepoHash() retrieves last commit hash from remote GitLab repository using GitLab API.

It is used by [downloadGitLabRepo()](https://iconify.design/docs/libraries/tools/package/gitlab.html "downloadGitLabRepo() documentation") to check if repository has been updated and to generate download link for archive.

## Usage

Function has the following parameter:

- options, DownloadGitLabRepoOptions. Options, same as in downloadGitLabRepo() function (only properties relevant to accessing GitLab API are used).

Function returns last commit hash as string.

Function is asynchronous.

[Page 178](https://iconify.design/docs/libraries/tools/package/compare.html "Current Page.")

## Comparing directories

This tutorial is part of [package functions documentation](https://iconify.design/docs/) in [Iconify Tools](https://iconify.design/).

Function compareDirectories() compares contents of two directories.

It is used to check if package generated by one of [export functions](https://iconify.design/export/) and package downloaded from elsewhere, such as NPM package are identical. If packages are identical, there is no need to publish a new version.

## Usage

Function has the following parameters:

- dir1, string. Directory.
- dir2, string. Another directory.
- options, object. Optional options.

Function returns:

- true if contents of directories are identical.
- false if contents are different.

Function is asynchronous. That means you need to handle it as Promise instance, usually by adding await before function call.

### Options

Options object has the following optional properties:

- ignoreVersions, boolean. If true, version numbers in package.json are ignored when comparing packages. Default is true.
- ignoreNewLine, boolean. If true, differences in new line in text files are ignored when comparing text files. Default is true.
- textExtensions, string\[\]. List of extensions to treat as text files. Default list includes all formats exported by various functions, but you can use this to add other extensions. Extensions should be in lower case.

[Page 179](https://iconify.design/docs/libraries/tools/package/api-query.html "Current Page.")

## Sending API query

This tutorial is part of [package functions documentation](https://iconify.design/docs/) in [Iconify Tools](https://iconify.design/).

Function sendAPIQuery() is a wrapper for fetch with caching.

It is used by functions that retrieve text data from remote sources, such as [importFromFigma()](https://iconify.design/docs/libraries/tools/import/figma/ "importFromFigma() documentation") and [downloadGitHubRepo()](https://iconify.design/docs/libraries/tools/package/github.html "downloadGitHubRepo() documentation").

To retrieve binary files, see [downloadFile()](https://iconify.design/docs/libraries/tools/package/download-file.html "downloadFile() documentation").

## Usage

Function has the following parameters:

- query, APIQueryParams. URI and parameters.
- cache, APICacheOptions. Cache options.

Function returns:

- Content as string on success.
- Error as number on error.

Function is asynchronous. That means you need to handle it as Promise instance, usually by adding await before function call.

### APIQueryParams

APIQueryParams object has the following properties:

- uri, string. Base URI.
- params, URLSearchParams. Optional parameters.
- header, Record<string,string>. Optional headers.

Example:

js
```
const params = {
    uri: 'https://api.whatever.com/some-file/',
    params: new URLSearchParams({
        version: '123',
    }),
    headers: {
        Accept: 'application/json',
    },
 };
```

### APICacheOptions

APICacheOptions object has the following properties:

- dir, string. Directory where cache should be stored.
- ttl, number. How long can data be cached, in seconds.

## Cache management

If cache property is not set, data is not cached.

If cache property is set, function will generate unique hash for query, will check if file with that hash already exists, if it has not expired. On success it will return cached data instead of fetching new data.

You can purge cache at any time using clearAPICache() function:

ts
```
import { clearAPICache } from '@iconify/tools/lib/download/api/cache';

const cacheDir = 'cache';

// Asynchronous function, so wrapping it in anonymous async function.
// Not needed for Node 17+ that supports top level await.
 (async () => {
    await clearAPICache(cacheDir);
 })();
```

## Example

ts
```
import { sendAPIQuery } from '@iconify/tools';
import type { APICacheOptions } from '@iconify/tools/lib/download/api/types';

// 3 days cache
const ttl = 60 * 60 * 24 * 3;
const dir = 'cache/api';
const options: APICacheOptions = {
    dir,
    ttl,
 };

 (async () => {
    const data = await sendAPIQuery(
        {
            uri: 'https://api.iconify.design/collections',
        },
        options
    );
    console.log(typeof data === 'string' ? JSON.parse(data) : data);
 })();
```

[Page 180](https://iconify.design/docs/libraries/tools/package/download-file.html "Current Page.")

## Download binary file

This tutorial is part of [package functions documentation](https://iconify.design/docs/) in [Iconify Tools](https://iconify.design/).

Function downloadFile() is a wrapper for fetch that downloads binary file.

It is used by functions that retrieve archives in download functions, such as [downloadGitHubRepo()](https://iconify.design/docs/libraries/tools/package/github.html "downloadGitHubRepo() documentation") and [downloadNPMPackage()](https://iconify.design/docs/libraries/tools/package/npm.html "downloadNPMPackage() documentation").

To retrieve text files, see [sendAPIQuery()](https://iconify.design/docs/libraries/tools/package/api-query.html "sendAPIQuery() documentation").

## Usage

Function has the following parameters:

- query, APIQueryParams. URI and parameters.
- filename, string. Where to store file.

Function is asynchronous. That means you need to handle it as Promise instance, usually by adding await before function call.

### APIQueryParams

APIQueryParams object has the following properties:

- uri, string. Base URI.
- params, URLSearchParams. Optional parameters.
- header, Record<string,string>. Optional headers.

[Page 181](https://iconify.design/docs/libraries/tools/examples/ "Current Page.")

## Iconify Tools code examples

## Short examples

Code samples are included in documentation for various functions. Some are short, some are longer.

The following code samples are short, yet complete enough to be usable:

- [importDirectory() documentation](https://iconify.design/import/directory.html#examples) shows how to import all SVG files in a directory, clean them up, export as [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation").
- [exportToDirectory() documentation](https://iconify.design/export/directory.html#example) shows how to export icon set as single SVG files.
- [Import SVG files, clean them up, export as single SVG files](https://iconify.design/export/svg.html).

## Long examples

Several examples for specific icon sets:

- [Export all Iconify icon sets as SVG](https://iconify.design/docs/export-svg.html).
- [Import icon set from Figma, clean it up (also shows how to work with two-tone icons), export as IconifyJSON and SVG](https://iconify.design/docs/import-figma.html).
- [Convert Material Design Icons to Iconify JSON format](https://iconify.design/docs/import-mdi.html).
- [Convert FontAwesome Pro to Iconify JSON format](https://iconify.design/docs/import-fa-pro.html).

[Page 182](https://iconify.design/docs/libraries/tools/examples/export-svg.html "Current Page.")

## Export all Iconify icons as SVG

This example shows how to generate SVG files for all icons from @iconify/json package.

First, create a blank Node project, add @iconify/tools as a dependency.

Then create file export-files.mjs and put this content:

mjs
```
import { readFile } from 'node:fs/promises';
import { downloadNPMPackage, IconSet, exportToDirectory } from '@iconify/tools';

// Directories
const cacheDir = 'cache';
const outDir = 'svg';

// Download all icon sets
console.log('Downloading latest package');
const downloaded = await downloadNPMPackage({
    package: '@iconify/json',
    target: cacheDir,
 });
console.log('Downloaded version', downloaded.version);

// Get a list of icon sets
const list = JSON.parse(
    await readFile(downloaded.contentsDir + '/collections.json', 'utf8')
 );
const prefixes = Object.keys(list);
console.log('Got', prefixes.length, 'icon sets');

// Export each icon set
for (let i = 0; i < prefixes.length; i++) {
    const prefix = prefixes[i];

    // Read file
    const data = JSON.parse(
        await readFile(
            downloaded.contentsDir + '/json/' + prefix + '.json',
            'utf8'
        )
    );

    // Create IconSet
    const iconSet = new IconSet(data);

    // Export it
    console.log('Exporting', iconSet.info.name);
    await exportToDirectory(iconSet, {
        target: outDir + '/' + prefix,
    });
 }

console.log('Done');
```

Then run that file:

```
node export-files.mjs
```

[Page 183](https://iconify.design/docs/libraries/tools/examples/import-figma.html "Current Page.")

## Exporting icons from Figma

This example shows how to import icon set from Figma, clean up all icons (including two-tone icons), export icon set as IconifyJSON and SVG.

This specific code is designed to import and clean up Solar icon set.

## Process

What is shown in this example?

This code has 3 parts:

- Importing icons from Figma using Figma API.
- Cleaning up icons.
- Exporting icon set as IconifyJSON and individual SVG files.

What is happening in the clean-up process? For each icon it:

- Retrieves icon from IconSet instance as SVG instance.
- Attempts to remove a clip path, if present, which Figma often adds to SVG.
- Parses all colors: replaces known icon colors with black, known two-tone color as gray, keeps white as white. In Figma document icons use many colors, not just black.
- If an icon contains white or two-tone color, applies mask to it.

## Code

mjs
```
import { writeFileSync } from 'node:fs';
import {
    cleanupIconKeyword,
    convertSVGToMask,
    importFromFigma,
    isEmptyColor,
    parseColors,
    removeFigmaClipPathFromSVG,
    exportToDirectory,
 } from '@iconify/tools';

// Figma file ID. Replace it with your clone of Solar icon set
const file = '';

// Figma API token. Replace it with your API token
const token = '';

// Two-tone color
const twoToneColor = '#808080'; // 50% opacity

// Suffixes for themes
/** @type {Record<string, string>} */
const suffixes = {
    'Broken': '-broken',
    'Line Duotone': '-line-duotone',
    'Linear': '-linear',
    'Outline': '-outline',
    'Bold': '-bold',
    'Bold Duotone': '-bold-duotone',
 };

 (async () => {
    /**
     * Import icon set from Figma
     */
    const { iconSet } = await importFromFigma({
        file,
        token,
        cacheDir: 'cache',
        prefix: 'solar',
        depth: 3,
        pages: ['🔥 Icon Library'],
        iconNameForNode: (node) => {
            if (node.type !== 'COMPONENT') {
                return null;
            }

            const parts = node.name.split('/');
            if (parts.length < 3) {
                return null;
            }

            const theme = parts.shift().trim();
            if (!suffixes[theme]) {
                throw new Error(\`Unknown theme in name: "${node.name}"\`);
            }

            const category = parts.shift().trim();
            const name = parts.shift().trim();
            if (parts.length) {
                throw new Error(\`Too many elements in name: "${node.name}"\`);
            }

            const keyword = cleanupIconKeyword(name) + suffixes[theme];
            return keyword;
        },
        afterImportingIcon: (node, iconSet) => {
            // Add category
            const parts = node.name.split('/');
            if (parts.length < 3) {
                return;
            }

            const theme = parts.shift().trim();
            if (!suffixes[theme]) {
                throw new Error(\`Unknown theme in name: "${node.name}"\`);
            }

            const category = parts.shift().trim();
            const name = parts.shift().trim();
            if (parts.length) {
                throw new Error(\`Too many elements in name: "${node.name}"\`);
            }

            const keyword = cleanupIconKeyword(name) + suffixes[theme];
            iconSet.toggleCategory(keyword, category, true);
        },
    });

    /**
     * Parse all icons
     */
    iconSet.forEachSync((name, type) => {
        if (type !== 'icon') {
            return;
        }
        const svg = iconSet.toSVG(name);
        if (!svg) {
            return;
        }
        const backup = svg.toString();

        // Remove clip path
        removeFigmaClipPathFromSVG(svg);

        // Check colors
        let hasWhite = false;
        let hasDuotone = false;
        parseColors(svg, {
            callback: (attr, colorString, color) => {
                if (color && isEmptyColor(color)) {
                    return color;
                }
                switch (colorString.toLowerCase()) {
                    case '#000':
                    case 'black':
                    case '#1c274c':
                    case '#1c274d':
                        return '#000';

                    case '#8e93a6':
                        hasDuotone = true;
                        return twoToneColor;

                    case '#fff':
                    case 'white':
                        hasWhite = true;
                        return '#fff';
                }

                // Unknown color
                console.log(backup);
                throw new Error(\`Bad color in ${name}: ${colorString}\`);
            },
        });

        // Mask icon
        if (hasWhite || hasDuotone) {
            if (
                !convertSVGToMask(svg, {
                    color: '#000',
                    custom: (color) => {
                        switch (color) {
                            case twoToneColor:
                                return color;
                        }
                    },
                })
            ) {
                console.log(backup);
                throw new Error(\`Failed to convert "${name}" to mask\`);
            }
        }

        if (svg.toString() !== backup) {
            iconSet.fromSVG(name, svg);
        }
    });

    /**
     * Export icon set
     */

    // Export icon set as IconifyJSON
    writeFileSync(
        'solar.json',
        JSON.stringify(iconSet.export(), null, '\t'),
        'utf8'
    );

    // Export icons as SVG
    await exportToDirectory(iconSet, {
        target: 'svg',
    });
 })();
```

[Page 184](https://iconify.design/docs/libraries/tools/examples/import-mdi.html "Current Page.")

## Converting SVG set to Iconify JSON

This example shows how to convert directory full of SVG files to Iconify JSON format.

As a source, this example uses Material Design icons from [Templarian/MaterialDesign-SVG](https://github.com/Templarian/MaterialDesign-SVG) repository that is also available as @mdi/svg NPM package.

Install dependencies:

```
npm install @iconify/tools @mdi/svg --save
```

Then create file convert-mdi.ts and put this content:

ts
```
import { promises as fs } from 'fs';
import { dirname } from 'path';

// Installation: npm install --save-dev @iconify/tools @mdi/svg
import {
    importDirectory,
    cleanupSVG,
    parseColors,
    isEmptyColor,
    runSVGO,
    cleanupIconKeyword,
 } from '@iconify/tools';
import type { IconifyInfo } from '@iconify/types';

// File to save icon set to
const target = 'json/mdi.json';

// SVG files location
const sourcePackageJSON = require.resolve('@mdi/svg/package.json');
const sourceSVGDir = dirname(sourcePackageJSON) + '/svg';

// Metadata (specific to MDI example, remove this for your code)
const metadataSource: string | null = require.resolve('@mdi/svg/meta.json');

// Prefix to use for icon set
const prefix = 'mdi';

// Expected icon size. Used in validating icons, remove if you do not need to validate icons
const expectedSize = 24;

// Icon set information
const info: IconifyInfo = {
    name: 'Material Design Icons',
    : {
        name: 'Austin Andrews',
        url: 'https://github.com/Templarian/MaterialDesign',
    },
    license: {
        title: 'Open Font License',
        url: 'https://raw.githubusercontent.com/Templarian/MaterialDesign/master/LICENSE',
        spdx: 'OFL-1.1',
    },
    height: 24,
    samples: ['account-check', 'bell-alert-outline', 'calendar-edit'],
 };

// Import icons
 (async function () {
    // Import icons
    const iconSet = await importDirectory(sourceSVGDir, {
        prefix,
    });

    // Set info
    iconSet.info = info;

    // Validate, clean up, fix palette and optimise
    await iconSet.forEach((name, type) => {
        if (type !== 'icon') {
            return;
        }

        // Get SVG instance for parsing
        const svg = iconSet.toSVG(name);
        if (!svg) {
            // Invalid icon
            iconSet.remove(name);
            return;
        }

        // Check icon size
        const viewBox = svg.viewBox;
        if (viewBox.width !== expectedSize || viewBox.height !== expectedSize) {
            console.error(
                \`Icon ${name} has invalid dimensions: ${viewBox.width} x ${viewBox.height}\`
            );
            iconSet.remove(name);
            return;
        }

        // Clean up and optimise icons
        try {
            // Clean up icon code
            cleanupSVG(svg);

            // Replace color with currentColor, add if missing
            parseColors(svg, {
                defaultColor: 'currentColor',
                callback: (attr, colorStr, color) => {
                    return !color || isEmptyColor(color) ? colorStr : 'currentColor';
                },
            });

            // Optimise
            runSVGO(svg);
        } catch (err) {
            // Invalid icon
            console.error(\`Error parsing ${name}:\`, err);
            iconSet.remove(name);
            return;
        }

        // Update icon from SVG instance
        iconSet.fromSVG(name, svg);
    });
    console.log(\`Imported ${iconSet.count()} icons\`);

    // Add metadata from meta.json
    if (metadataSource) {
        interface MDIMetaDataItem {
            id: string;
            name: string;
            codepoint: string;
            aliases: string[];
            tags: string[];
            : string;
            version: string;
        }

        const metaContent = JSON.parse(
            await fs.readFile(metadataSource, 'utf8')
        ) as MDIMetaDataItem[];
        metaContent.forEach((entry) => {
            const { name, aliases, tags } = entry;
            const cleanName = cleanupIconKeyword(name);
            if (iconSet.entries[cleanName] === void 0) {
                console.error(\`Missing icon: ${cleanName}\`);
                return;
            }

            // Add categories
            tags.forEach((category) => {
                iconSet.toggleCategory(cleanName, category, true);
            });

            // Add aliases
            aliases.forEach((alias) => {
                const cleanAlias = cleanupIconKeyword(alias);
                if (iconSet.entries[cleanAlias] === void 0) {
                    iconSet.setAlias(cleanAlias, cleanName);
                }
            });
        });
    }

    // Export to IconifyJSON, convert to string
    const output = JSON.stringify(iconSet.export(), null, '\t');

    // Create directory for output if missing
    const dir = dirname(target);
    try {
        await fs.mkdir(dir, {
            recursive: true,
        });
    } catch (err) {
        //
    }

    // Save to file
    await fs.writeFile(target, output, 'utf8');

    console.log(\`Saved ${target} (${output.length} bytes)\`);
 })().catch((err) => {
    console.error(err);
 });
```

Assuming that TypeScript is set to compile to lib, compile file to JavaScript and run it:

```
node lib/convert-mdi
```

If you are not using TypeScript, remove types from code. If should not be hard because there aren't many lines to remove.

Prepared project is available in [Iconify Tools GitHub repository](https://github.com/iconify/tools/tree/main/%40iconify-demo/create-bundle).

## How does it work?

There are comments in the code above that explain what is going on.

The process is simple:

1. importDirectory() imports all icons from directory "svg" of @mdi/svg package.
2. iconSet.forEach() is used to iterate all icons to:
	- toSVG() is used to get SVG instance that can be manipulated by various functions.
		- cleanupSVG() is used to clean up code (MDI has clean code, so nothing to clean up there, but for other icon sets it is needed).
		- parseColors() is used to change default color to "currentColor".
		- runSVGO() is used to optimise icon code.
		- iconSet.fromSVG() is used to update icon data in icon set.
3. Then script handles metadata: adds categories and aliases for all icons.
4. iconSet.export() is used to export icon set to JSON file.

[Page 185](https://iconify.design/docs/libraries/tools/examples/import-fa-pro.html "Current Page.")

## Converting Font Awesome Pro to Iconify JSON

## Using the FontAwesome Pro git repository

This example shows how to convert FontAwesome Pro SVG files to Iconify JSON format.

Example assumes you have access to FontAwesome Pro repository. If you do have a valid license, you should have access to it.

Create file convert-fa-pro.ts and put this content:

ts
```
import { promises as fs } from 'fs';
import {
    downloadGitRepo,
    importDirectory,
    cleanupSVG,
    parseColors,
    isEmptyColor,
    runSVGO,
 } from '@iconify/tools';
import type { IconifyInfo } from '@iconify/types';

// Clone repository?
// Set to false if repository is already unpacked to directory set in 'faRepoDir' variable.
const cloneFromGitHub = true;
const faRepoURL: string | null =
    '[email protected]:FortAwesome/Font-Awesome-Pro.git';
const faRepoBranch = 'master';

// Directory for FontAwesome Pro repository (automatically downloaded if information above is set)
const faRepoDir = 'fa-pro';

// Themes to parse
const themes = ['brands', 'duotone', 'light', 'regular', 'solid'];

// Directory to export icon sets to
const targetDirectory = 'json';

// Information
const baseInfo: IconifyInfo = {
    name: 'Font Awesome',
    : {
        name: 'Font Awesome',
    },
    license: {
        title: 'Commercial License',
        url: 'https://fontawesome.com/license',
    },
    height: 32,
 };

// Base prefix without theme
const basePrefix = 'fa-pro-';

// Do stuff
 (async function () {
    // Download repository
    let sourceDir = faRepoDir;
    if (cloneFromGitHub) {
        const downloadResult = await downloadGitRepo({
            target: faRepoDir,
            remote: faRepoURL,
            branch: faRepoBranch,
            log: true,
        });
        sourceDir = downloadResult.contentsDir;
    }

    // Create directory for output if missing
    try {
        await fs.mkdir(targetDirectory, {
            recursive: true,
        });
    } catch (err) {
        //
    }

    // Parse all configured themes
    for (let i = 0; i < themes.length; i++) {
        const theme = themes[i];
        const source = sourceDir + '/svgs/' + theme;
        const prefix = basePrefix + theme;

        // Import icons
        const iconSet = await importDirectory(source, {
            prefix,
        });

        // Set info
        const info: IconifyInfo = JSON.parse(JSON.stringify(baseInfo));
        const themeName = theme.toUpperCase().slice(0, 1) + theme.slice(1);
        info.name += ' ' + themeName;
        iconSet.info = info;

        // Validate, clean up, fix palette and optimise
        iconSet.forEachSync((name, type) => {
            if (type !== 'icon') {
                return;
            }

            // Get SVG instance for parsing
            const svg = iconSet.toSVG(name);
            if (!svg) {
                // Invalid icon
                iconSet.remove(name);
                return;
            }

            // Clean up and optimise icons
            try {
                // Clean up icon code
                cleanupSVG(svg);

                // Replace color with currentColor, add if missing
                parseColors(svg, {
                    defaultColor: 'currentColor',
                    callback: (attr, colorStr, color) => {
                        return !color || isEmptyColor(color) ? colorStr : 'currentColor';
                    },
                });

                // Optimise
                runSVGO(svg);
            } catch (err) {
                // Invalid icon
                console.error(\`Error parsing ${name}:\`, err);
                iconSet.remove(name);
                return;
            }

            // Update icon from SVG instance
            iconSet.fromSVG(name, svg);
        });
        console.log(\`Imported ${iconSet.count()} icons for ${info.name}\`);

        // Export to IconifyJSON, convert to string
        const output = JSON.stringify(iconSet.export(), null, '\t');

        // Save to file
        const target = targetDirectory + '/' + prefix + '.json';
        await fs.writeFile(target, output, 'utf8');

        console.log(\`Saved ${target} (${output.length} bytes)\`);
    }
 })().catch((err) => {
    console.error(err);
 });
```

Assuming that TypeScript is set to compile to lib, compile file to JavaScript and run it:

```
node lib/convert-fa-pro
```

If you are not using TypeScript, remove types from code. It should not be hard because there aren't many lines to remove.

Prepared project is available in [Iconify Tools GitHub repository](https://github.com/iconify/tools/tree/main/%40iconify-demo/create-bundle).

## Using the FontAwesome Pro npm libraries

An alternative way to generate the JSON files is using the NPM libraries provided by FontAwesome.

Example assumes you have access to FontAwesome Pro npm libraries. [See the offficial guide if you don't have access to the libraries yet.](https://docs.fontawesome.com/web/setup/packages#1-configure-pro-package-access)

Create file convert-fa-pro-npm.ts and put this content:

ts
```
import fs from 'fs';
import { blankIconSet } from '@iconify/tools';
import { dirname, join } from 'path';
// import the fonts you want to convert
import {
  far as faProRegularIcons,
  prefix as faProRegularPrefix,
 } from '@fortawesome/pro-regular-svg-icons';
import {
  fas as faProSolidIcons,
  prefix as faProSolidPrefix,
 } from '@fortawesome/pro-solid-svg-icons';

import {
  fat as faProThinIcons,
  prefix as faProThinPrefix,
 } from '@fortawesome/pro-thin-svg-icons';
import {
  fal as faProLightIcons,
  prefix as faProLightPrefix,
 } from '@fortawesome/pro-light-svg-icons';

import type { IconifyInfo } from '@iconify/types';

// put the icons and the prefix you want them to have together in one object.
const icons = [
  { icons: faProRegularIcons, prefix: /* faProRegularPrefix */ 'fa' },
  { icons: faProSolidIcons, prefix: faProSolidPrefix },
  { icons: faProThinIcons, prefix: faProThinPrefix },
  { icons: faProLightIcons, prefix: faProLightPrefix },
 ] as const;

// set the location where you want the generated json files to appear.
const collectionTargetDir = join(
  import.meta.dirname,
'font-awesome-iconify'
 );

// set the base info
const baseInfo = {
  name: 'Font Awesome',
  : {
    name: 'Font Awesome',
  },
  license: {
    title: 'Commercial License',
    url: 'https://fontawesome.com/license',
  },
  height: 512,
 } as const satisfies IconifyInfo;

// iterate through the icons and generate the json files
for (const iconData of icons) {
  const iconSet = blankIconSet(iconData.prefix);
  iconSet.info = structuredClone(baseInfo);
  for (const { icon, iconName } of Object.values(iconData.icons)) {
    const [width, height, ligatures, unicode, svgPathData] = icon;

    // handle strings and array differently from each other
    const body =
      typeof svgPathData === 'string'
        ? \`<path fill="currentColor" d="${svgPathData}" />\`
        : \`<g fill="currentColor">${svgPathData.map((x) => \`<path d="${x}" />\`).join('')}</g>\`;

    iconSet.setIcon(iconName, {
      body,
      height,
      width,
    });

    ligatures.forEach((x) => {
      // ignore the aliases that are numbers.
      if (Number.isNaN(+x)) iconSet.setAlias(x, iconName);
    });
  }

  // generate the json
  const data = iconSet.export();
  const dataJson = JSON.stringify(data, null, 2);

  // set the path target for the json file
  const jsonTargetDir = join(collectionTargetDir, iconData.prefix);
  const fileName = join(jsonTargetDir, 'icons.json');

  // create the file
  fs.mkdirSync(jsonTargetDir, { recursive: true });
  fs.writeFileSync(fileName, dataJson, {
    encoding: 'utf-8',
  });
 }
```

If you are using NodeJs V22.6.0 or later you can run the TypeScript file natively.

```
node convert-fa-pro-npm.ts
```

If your NodeJs version is lower than v22.6.0 you need to add `--experimental-strip-types` to the command.

```
node --experimental-strip-types convert-fa-pro-npm.ts
```

Alternatively, you can manually remove the types from the code and run it as a JS file instead.

[Page 186](https://iconify.design/docs/libraries/tools/tags.html "Current Page.")

## SVG validation in Iconify Tools

When importing SVG in Iconify Tools, there are some limitations, which cannot be changed.

Any icons containing the following will not be imported:

- Scripts.
- External resources.
- Raster images.
- Text.

Iconify is very strict when it comes to security and quality. Icons should look identical for all users, regardless of browser and operating system.

## Scripts

Not allowing scripts should be obvious. Scripts can be malicious. Also, scripts are not executed when icon is used as url(), so they might not even work.

## External resources

Relying on external resources is not ok:

- Those resources might not be available for all users.
- It might be used for tracking.

There are no valid use cases for external resources in public SVG.

## Raster images

SVGs are meant to scale. Raster images do not belong in SVG.

## Text

Text is rendered differently in different browsers and operating systems. This is not acceptable. Icons should render identically for all users.

Convert text to vector shapes.

[Page 187](https://iconify.design/docs/libraries/utils/ "Current Page.")

## Iconify Utils

Iconify Utils is a set of reusable functions that are used by various Iconify icon components and related packages:

- Parsing Iconify icon sets in [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") format.
- Exporting icons from [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") format (can be extracted from an icon set) as SVG.
- Basic parser for SVG.
- Parsing and validating icon names.
- Parsing and validating basic colors.
- Parsing emoji sequences, generating regular expressions to find emojis in text.

Library is written in TypeScript, is available as ES modules for modern development and CommonJS for older scripts.

## Installation

To install library run:

```
npm install @iconify/utils --save
```

## Examples

Documentation for each function below includes code samples.

In addition to that, [there are several bigger code samples for specific commonly used tasks](https://iconify.design/docs/examples/) to help you figure out what functions to use.

## Functions

Icon sets are stored in [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") format. Functions for working with icon sets:

- [validateIconSet(data)](https://iconify.design/docs/libraries/utils/validate-icon-set.html "validateIconSet() documentation") validates an icon set. If you are not sure if the source is a valid icon set, run this function to validate an icon set. It will convert data to correct [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") and will attempt to fix errors.
- [quicklyValidateIconSet(data)](https://iconify.design/docs/libraries/utils/quickly-validate-icon-set.html "quicklyValidateIconSet() documentation") same as above, but does basic validation. Use it if you do not care about metadata being invalid, if you do not want to attempt to fix errors in an icon set, or if you want to reduce bundle size.
- [getIcons(data, icons)](https://iconify.design/docs/libraries/utils/get-icons.html "getIcons() documentation") extracts few icons from an icon set. It can be used to reduce an icon set to few icons that are used by your project.
- [getIconData(data, icon)](https://iconify.design/docs/libraries/utils/get-icon-data.html "getIconData() documentation") extracts data for one icon from an icon set.
- [minifyIconSet(data)](https://iconify.design/docs/libraries/utils/minify-icon-set.html "minifyIconSet() documentation") minifies icon set, removing redundant data. Used to reduce file size.
- [expandIconSet(data)](https://iconify.design/docs/libraries/utils/expand-icon-set.html "expandIconSet() documentation") is the opposite of function above.
- [convertIconSetInfo(data)](https://iconify.design/docs/libraries/utils/convert-info.html "convertIconSetInfo() documentation") converts a legacy icon set format to correct [IconifyInfo](https://iconify.design/docs/types/iconify-info.html "IconifyInfo documentation") type.
- [parseIconSet(data, callback)](https://iconify.design/docs/libraries/utils/parse-icon-set.html "parseIconSet() documentation") parses icon set, calling callback function for every icon. Can be used to extract all icons from an icon set. Validate icon set before parsing it.
- [parseIconSetAsync(data, callback)](https://iconify.design/docs/libraries/utils/parse-icon-set.html "parseIconSetAsync() documentation") is async version of [parseIconSet()](https://iconify.design/docs/libraries/utils/parse-icon-set.html "parseIconSet() documentation"), where both function and callback are asynchronous.

Functions for working with [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") format that represents one icon:

- [mergeIconData(icon, alias)](https://iconify.design/docs/libraries/utils/merge-icon-data.html "mergeIconData() documentation") merges data for icon and alias. Used by functions that extract icon data from an icon set.
- [defaultIconProps](https://iconify.design/docs/libraries/utils/default-icon-props.html "defaultIconProps() documentation") contains default values for optional properties to [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") object.
- [convertParsedSVG(data)](https://iconify.design/docs/libraries/utils/convert-parsed-svg.html "convertParsedSVG() documentation") can be used to convert SVG string to [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") object.

When rendering icon, customisations can be applied to it. For example, changing dimensions, rotating or flipping icon. They are represented by [IconCustomisations](https://iconify.design/docs/libraries/utils/icon-customisations.html "IconCustomisations documentation") type. Functions for working with customisations:

- [mergeCustomisations(defaultIconCustomisations, custom)](https://iconify.design/docs/libraries/utils/merge-customisations.html "mergeCustomisations() documentation") function converts an object to [FullIconCustomisations](https://iconify.design/docs/libraries/utils/icon-customisations.html "FullIconCustomisations documentation") type. It also validates types, so it can be used to clean up user input.
- [defaultIconCustomisations](https://iconify.design/docs/libraries/utils/default-icon-customisations.html "defaultIconCustomisations() documentation") exported from lib/customisations/defaults contains default customisations.
- [toBoolean(name, value, defaultValue)](https://iconify.design/docs/libraries/utils/to-boolean.html "toBoolean() documentation") converts various strings to boolean. Used by icon components to clean up parameters that can be boolean or string.
- [rotateFromString(value)](https://iconify.design/docs/libraries/utils/rotate-from-string.html "rotateFromString() documentation") converts various methods of rotating icon (such as "90deg" or "25%") to a number.
- [flipFromString(customisations, value)](https://iconify.design/docs/libraries/utils/flip-from-string.html "flipFromString() documentation") applies flip string (such as flip="horizontal,vertical") to customisations.

Functions for rendering icon:

- [iconToSVG(icon, customisations)](https://iconify.design/docs/libraries/utils/icon-to-svg.html "iconToSVG() documentation") generates data needed to render SVG. It does not generate full SVG, only content and list of attributes to add to the SVG element, making it easy to use in custom components.
- [iconToHTML(body, attributes)](https://iconify.design/docs/libraries/utils/icon-to-html.html "iconToHTML() documentation") converts result of [iconToSVG()](https://iconify.design/docs/libraries/utils/icon-to-svg.html "iconToSVG() documentation") to SVG string.
- [calculateSize(size, ratio)](https://iconify.design/docs/libraries/utils/calculate-size.html "calculateSize() documentation") calculates icon dimensions. It is used when building icons using [iconToSVG()](https://iconify.design/docs/libraries/utils/icon-to-svg.html "iconToSVG() documentation").
- [replaceIDs(content)](https://iconify.design/docs/libraries/utils/replace-ids.html "replaceIDs() documentation") replaces IDs in SVG with unique IDs. IDs used in elements like masks, and they must be unique, so multiple icons displayed on the same page using the same IDs will result in chaos. This function prevents that chaos.
- [getIconCSS(icon)](https://iconify.design/docs/libraries/utils/get-icon-css.html "getIconCSS() documentation") generates stylesheet for using icon as background image or mask image.
- [getIconsCSS(iconSet, names)](https://iconify.design/docs/libraries/utils/get-icons-css.html "getIconsCSS() documentation") generates stylesheet for using multiple icons from the same icon set as background images or mask images.
- [getIconContentCSS(icon, options)](https://iconify.design/docs/libraries/utils/get-icon-content-css.html "getIconContentCSS() documentation") generates stylesheet for using icon as content of pseudo-element.
- [getIconsContentCSS(iconSet, names, options)](https://iconify.design/docs/libraries/utils/get-icons-content-css.html "getIconsContentCSS() documentation") generates stylesheet for using multiple icons from the same icon set as content of pseudo-elements.
- [cleanUpInnerHTML()](https://iconify.design/docs/libraries/utils/clean-up-inner-html.html "cleanUpInnerHTML() documentation") allows using innerHTML to assign SVG to an existing DOM element in strict environments.

Functions for parsing icons:

- [parseSVGContent(content)](https://iconify.design/docs/libraries/utils/parse-svg-content.html "parseSVGContent() documentation") parses SVG string, extracting <svg> attributes and body.
- [buildParsedSVG(data)](https://iconify.design/docs/libraries/utils/build-parsed-svg.html "buildParsedSVG() documentation") converts result of [parseSVGContent(content)](https://iconify.design/docs/libraries/utils/parse-svg-content.html "parseSVGContent() documentation") to the same data as generated by [iconToSVG()](https://iconify.design/docs/libraries/utils/icon-to-svg.html "iconToSVG() documentation").
- [convertParsedSVG(data)](https://iconify.design/docs/libraries/utils/convert-parsed-svg.html "convertParsedSVG() documentation") converts result of [parseSVGContent(content)](https://iconify.design/docs/libraries/utils/parse-svg-content.html "parseSVGContent() documentation") to [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") object.
- [splitSVGDefs(content)](https://iconify.design/docs/libraries/utils/split-svg-defs.html "splitSVGDefs() documentation") split icon content in definitions and other data. It is used by [wrapSVGContent()](https://iconify.design/docs/libraries/utils/wrap-svg-content.html "wrapSVGContent() documentation").
- [mergeDefsAndContent(defs, content)](https://iconify.design/docs/libraries/utils/merge-defs-and-content.html "mergeDefsAndContent() documentation") merges back definitions and content in one string.
- [wrapSVGContent(body, start, end)](https://iconify.design/docs/libraries/utils/wrap-svg-content.html "wrapSVGContent() documentation") wraps icon content, without wrapping definition. It is used to wrap content in groups by various functions.
- [getSVGViewBox(value)](https://iconify.design/docs/libraries/utils/get-svg-viewbox.html "getSVGViewBox() documentation") parses and validates viewBox attribute, returning it as an array of numbers on success, undefined on error.

Functions for working with icon names:

- [matchIconName](https://iconify.design/docs/libraries/utils/match-name.html "matchIconName() documentation") constant is a regular expression to test parts of icon name.
- [stringToIcon(value)](https://iconify.design/docs/libraries/utils/string-to-icon.html "stringToIcon() documentation") converts icon name, such as "mdi-light:home" into an [IconifyIconName](https://iconify.design/docs/libraries/utils/icon-name.html "IconifyIconName documentation") object and optionally validates it.
- [validateIconName(icon)](https://iconify.design/docs/libraries/utils/validate-icon.html "validateIconName() documentation") validates [IconifyIconName](https://iconify.design/docs/libraries/utils/icon-name.html "IconifyIconName documentation") object.

Functions for working with colors:

- [stringToColor(value)](https://iconify.design/docs/libraries/utils/string-to-color.html "stringToColor() documentation") converts string to [Color](https://iconify.design/docs/libraries/utils/color.html "Color documentation") object, returns null on error. This can be used to validate user input. It supports color keywords, hexadecimal colors, RGB, HSL, LAB and LCH colors. Variables are not supported because this is meant for parsing SVGs, which should not reference any external variables.
- [compareColors(color1, color2)](https://iconify.design/docs/libraries/utils/compare-colors.html "compareColors() documentation") compares colors. It also converts RGB to HSL if needed.
- [colorToString(color)](https://iconify.design/docs/libraries/utils/color-to-string.html "colorToString() documentation") converts [Color](https://iconify.design/docs/libraries/utils/color.html "Color documentation") object to string. Combined with [stringToColor()](https://iconify.design/docs/libraries/utils/string-to-color.html "stringToColor() documentation"), this can be used to validate and clean up user input.

## Advanced usage

Iconify Utils can do only basic parsing of [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") and [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") data. It is not meant for more complex stuff.

For more complex stuff, such as importing icons, validating icon code, changing palette, cleaning up, exporting to various formats, see [Iconify Tools package](https://iconify.design/tools/).

[Page 188](https://iconify.design/docs/libraries/utils/validate-icon-set.html "Current Page.")

## validateIconSet()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function validateIconSet() validates icon set, returning cleaned up [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") object.

If there are errors in provided data:

- If error is critical, function will throw an exception.
- If error can be fixed, function will throw an exception, unless fix option is provided.

This function checks everything, including metadata.

## Usage

Function has the following parameters:

- data, object. Data to validate.
- options, object. Optional options object.

Function returns:

- [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") object on success (same as passed in first parameter).

If function encounters an error that cannot be fixed, function will throw an exception.

### Options

Options object has the following properties:

- fix, boolean. If set to true, function will attempt to fix errors whenever possible instead of throwing exception. Default value is false.
- prefix, string. Default value for prefix property of icon set. If set, function will overwrite prefix in icon set with your value.
- provider, string. Default value for provider property of icon set. If set, function will overwrite provider in icon set with your value.

## Example

ts
```
import { promises as fs } from 'fs';
import { validateIconSet } from '@iconify/utils';

 (async () => {
    // Load data from file
    const data = JSON.parse(
        await fs.readFile(
            './node_modules/@iconify-json/mdi-light/icons.json',
            'utf8'
        )
    );

    // Validate data
    const iconSet = validateIconSet(data);

    // Count icons (simple calculation)
    const count =
        Object.keys(iconSet.icons).length +
        (iconSet.aliases ? Object.keys(iconSet.aliases).length : 0);
    console.log(\`Found ${count} icons\`);
 })();
```

## Quick validation

This function is quite big, so it is not recommended to bundle it for browser usage.

If you want to validate icon set in browser, such as when loading data from API in an icon component, use [quicklyValidateIconSet()](https://iconify.design/docs/libraries/utils/quickly-validate-icon-set.html "quicklyValidateIconSet() documentation") instead. It is smaller and faster because it does not check metadata, does not attempt to fix errors.

[Page 189](https://iconify.design/docs/libraries/utils/quickly-validate-icon-set.html "Current Page.")

## quicklyValidateIconSet()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function quicklyValidateIconSet() validates icon set, returning cleaned up [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") object.

If there are errors in provided data, it will return null.

This function does not check metadata.

## Usage

Function has the following parameter:

- data, object. Data to validate.

Function returns:

- [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") object on success (same as passed in first parameter).
- null on error.

## Example

ts
```
import { promises as fs } from 'fs';
import { quicklyValidateIconSet } from '@iconify/utils';

 (async () => {
    // Load data from file
    const data = JSON.parse(
        await fs.readFile(
            './node_modules/@iconify-json/mdi-light/icons.json',
            'utf8'
        )
    );

    // Validate data
    const iconSet = quicklyValidateIconSet(data);
    if (!iconSet) {
        console.error('Bad icon set');
        return;
    }

    // Count icons (simple calculation)
    const count =
        Object.keys(iconSet.icons).length +
        (iconSet.aliases ? Object.keys(iconSet.aliases).length : 0);
    console.log(\`Found ${count} icons\`);
 })();
```

## Advanced validation

This function is optimised for bundle size and performance, therefore it does only basic validation.

If you want to fully validate icon set, use [validateIconSet()](https://iconify.design/docs/libraries/utils/validate-icon-set.html "validateIconSet() documentation") instead.

[Page 190](https://iconify.design/docs/libraries/utils/get-icons.html "Current Page.")

## getIcons()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function getIcons() retrieves few icons from icon set.

## Usage

Function has the following parameters:

- data, [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation"). Icon set data.
- icons, string\[\]. List of icon names to retrieve.
- nof\_found, boolean. Optional. If set, icons that are not available in icon set will be added to not\_found property of result. Default value is false.

## Example

ts
```
import { icons } from '@iconify-json/mdi-light';
import { getIcons } from '@iconify/utils';

// Get few icons
const reducedIconSet = getIcons(icons, [
    'alarm',
    'arrow-down',
    'home',
    'home-outline',
 ]);

// Log it
console.log(reducedIconSet);
```

json
```
{
    "prefix": "mdi-light",
    "icons": {
        "alarm": {
            "body": "<path d=\"M11.5 6a7.5 7.5 0 1 1 0 15a7.5 7.5 0 0 1 0-15zm0 1a6.5 6.5 0 1 0 0 13a6.5 6.5 0 0 0 0-13zM11 9h1v4.363l3.048 1.421l-.423.906L11 14V9zm4.25-3.75l.643-.766l3.83 3.214l-.643.766l-3.83-3.214zm-7.5 0L3.92 8.464l-.643-.766l3.83-3.214l.643.766z\" fill=\"currentColor\"/>"
        },
        "arrow-down": {
            "body": "<path d=\"M12 5v12.25L17.25 12l.75.664l-6.5 6.5l-6.5-6.5l.75-.664L11 17.25V5h1z\" fill=\"currentColor\"/>"
        },
        "home": {
            "body": "<path d=\"M16 8.414l-4.5-4.5L4.414 11H6v8h3v-6h5v6h3v-8h1.586L17 9.414V6h-1v2.414zM2 12l9.5-9.5L15 6V5h3v4l3 3h-3v7.998h-5v-6h-3v6H5V12H2z\" fill=\"currentColor\"/>"
        }
    },
    "width": 24,
    "height": 24
}
```

[Page 191](https://iconify.design/docs/libraries/utils/get-icon-data.html "Current Page.")

## getIconData()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function getIconData() retrieves data for one icon from icon set.

## Usage

Function has the following parameters:

- data, [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation"). Icon set data.
- name, string. Icon name.

Function returns icon data with type [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation"), null on error.

## Example

ts
```
import { icons } from '@iconify-json/codicon';
import { getIconData, iconToSVG, iconToHTML, replaceIDs } from '@iconify/utils';

const iconName = 'debug-console';

// Get content for icon
const iconData = getIconData(icons, iconName);
if (!iconData) {
    throw new Error(\`Icon "${iconName}" is missing\`);
 }

// Use it to render icon
const renderData = iconToSVG(iconData, {
    height: 'auto',
 });

// Generate SVG string
const svg = iconToHTML(replaceIDs(renderData.body), renderData.attributes);

// Log SVG
console.log(svg);
```

Result:

[Page 192](https://iconify.design/docs/libraries/utils/minify-icon-set.html "Current Page.")

## minifyIconSet()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function minifyIconSet() optimises icon set, reducing file size.

## Usage

Function has only one parameter:

- data, [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation"). Icon set data.

Function does not create a new object, it modifies object passed to function.

## What exactly does it do?

Icons in icon set have common properties, such as width and height:

json
```
{
    "prefix": "foo",
    "icons": {
        "icon1": {
            "body": "<path d=\"M7 6v12l10-6z\" fill=\"currentColor\"/>",
            "width": 24,
            "height": 24
        },
        "icon2": {
            "body": "<path d=\"M5 13v-1h6V6h1v6h6v1h-6v6h-1v-6H5z\" fill=\"currentColor\"/>",
            "width": 24,
            "height": 24
        },
        "icon3": {
            "body": "<path d=\"M10 8a2 2 0 1 1-4 0a2 2 0 0 1 4 0z\" fill=\"currentColor\"/>",
            "width": 16,
            "height": 16
        }
    }
}
```

In example above, icons "icon1" and "icon2" have identical width and height. To avoid duplication, these values can be moved to root object:

json
```
{
    "prefix": "foo",
    "icons": {
        "icon1": {
            "body": "<path d=\"M7 6v12l10-6z\" fill=\"currentColor\"/>"
        },
        "icon2": {
            "body": "<path d=\"M5 13v-1h6V6h1v6h6v1h-6v6h-1v-6H5z\" fill=\"currentColor\"/>"
        },
        "icon3": {
            "body": "<path d=\"M10 8a2 2 0 1 1-4 0a2 2 0 0 1 4 0z\" fill=\"currentColor\"/>",
            "width": 16,
            "height": 16
        }
    },
    "width": 24,
    "height": 24
}
```

Function minifyIconSet() finds common properties in icon set and moves them to root object.

What properties can be minified? Properties defined in [IconifyDimensions](https://iconify.design/docs/types/iconify-icon.html#iconify-optional "IconifyDimensions documentation") type: left, top, width and height.

See [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") type for more information.

In this example difference between original and minified files isn't big, but for large icon sets with thousands of icons it does make a big difference in file size.

## Example

ts
```
import type { IconifyJSON } from '@iconify/types';
import { minifyIconSet } from '@iconify/utils';

// Original data
const data: IconifyJSON = {
    prefix: 'foo',
    icons: {
        icon1: {
            body: '<path d="M7 6v12l10-6z" fill="currentColor"/>',
            width: 24,
            height: 24,
        },
        icon2: {
            body: '<path d="M5 13v-1h6V6h1v6h6v1h-6v6h-1v-6H5z" fill="currentColor"/>',
            width: 24,
            height: 24,
        },
        icon3: {
            body: '<path d="M10 8a2 2 0 1 1-4 0a2 2 0 0 1 4 0z" fill="currentColor"/>',
            width: 16,
            height: 16,
        },
    },
 };

// Minify it
minifyIconSet(data);

// Log data
console.log(data);
```

json
```
{
    "prefix": "foo",
    "icons": {
        "icon1": {
            "body": "<path d=\"M7 6v12l10-6z\" fill=\"currentColor\"/>"
        },
        "icon2": {
            "body": "<path d=\"M5 13v-1h6V6h1v6h6v1h-6v6h-1v-6H5z\" fill=\"currentColor\"/>"
        },
        "icon3": {
            "body": "<path d=\"M10 8a2 2 0 1 1-4 0a2 2 0 0 1 4 0z\" fill=\"currentColor\"/>",
            "width": 16,
            "height": 16
        }
    },
    "width": 24,
    "height": 24
}
```

[Page 193](https://iconify.design/docs/libraries/utils/expand-icon-set.html "Current Page.")

## expandIconSet()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function expandIconSet() de-optimises icon set, opposite of [minifyIconSet()](https://iconify.design/docs/libraries/utils/minify-icon-set.html "minifyIconSet() documentation").

## Usage

Function has only one parameter:

- data, [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation"). Icon set data.

Function does not create a new object, it de-optimises object passed to function.

## What exactly does it do?

See [minifyIconSet()](https://iconify.design/docs/libraries/utils/minify-icon-set.html "minifyIconSet() documentation") for details.

## Example

ts
```
import type { IconifyJSON } from '@iconify/types';
import { expandIconSet } from '@iconify/utils';

// Original data
const data: IconifyJSON = {
    prefix: 'foo',
    icons: {
        icon1: {
            body: '<path d="M7 6v12l10-6z" fill="currentColor"/>',
        },
        icon2: {
            body: '<path d="M5 13v-1h6V6h1v6h6v1h-6v6h-1v-6H5z" fill="currentColor"/>',
        },
        icon3: {
            body: '<path d="M10 8a2 2 0 1 1-4 0a2 2 0 0 1 4 0z" fill="currentColor"/>',
            width: 16,
            height: 16,
        },
    },
    width: 24,
    height: 24,
 };

// Expand it
expandIconSet(data);

// Log data
console.log(data);
```

json
```
{
    "prefix": "foo",
    "icons": {
        "icon1": {
            "body": "<path d=\"M7 6v12l10-6z\" fill=\"currentColor\"/>",
            "width": 24,
            "height": 24
        },
        "icon2": {
            "body": "<path d=\"M5 13v-1h6V6h1v6h6v1h-6v6h-1v-6H5z\" fill=\"currentColor\"/>",
            "width": 24,
            "height": 24
        },
        "icon3": {
            "body": "<path d=\"M10 8a2 2 0 1 1-4 0a2 2 0 0 1 4 0z\" fill=\"currentColor\"/>",
            "width": 16,
            "height": 16
        }
    }
}
```

[Page 194](https://iconify.design/docs/libraries/utils/convert-info.html "Current Page.")

## convertIconSetInfo()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function convertIconSetInfo() converts and validates icon set information.

Some old icon sets might have information in legacy format, which was created before Iconify projects moved to TypeScript. This function will accept both old and new formats, will convert and validate it and will return correct [IconifyInfo](https://iconify.design/docs/types/iconify-info.html "IconifyInfo documentation") data.

## Usage

Function has the following parameters:

- data, unknown. Icon set information, which can be legacy object or [IconifyInfo](https://iconify.design/docs/types/iconify-info.html "IconifyInfo documentation").
- expectedPrefix, string. Optional. If set, and source object has prefix property with different value, function will throw an error. This can be used legacy information might be incorrect.

Function returns:

- [IconifyInfo](https://iconify.design/docs/types/iconify-info.html "IconifyInfo documentation") object on success.
- null on error.

## Example

ts
```
import { convertIconSetInfo } from '@iconify/utils';

// Original data
const data = {
    name: 'Remix Icon',
    total: 2271,
    : 'Remix Design',
    url: 'https://github.com/Remix-Design/RemixIcon',
    license: 'Apache 2.0',
    licenseURL: 'https://github.com/Remix-Design/RemixIcon/blob/master/License',
    height: 24,
    samples: ['lock-2-line', 'mark-pen-fill', 'moon-line'],
    palette: 'Colorless',
    category: 'General',
 };

// Convert it
const converted = convertIconSetInfo(data);

// Log result
console.log(converted);
```

json
```
{
    "name": "Remix Icon",
    "total": 2271,
    "author": {
        "name": "Remix Design",
        "url": "https://github.com/Remix-Design/RemixIcon"
    },
    "license": {
        "title": "Apache 2.0",
        "url": "https://github.com/Remix-Design/RemixIcon/blob/master/License"
    },
    "samples": ["lock-2-line", "mark-pen-fill", "moon-line"],
    "height": 24,
    "displayHeight": 24,
    "category": "General",
    "palette": false
}
```

[Page 195](https://iconify.design/docs/libraries/utils/parse-icon-set.html "Current Page.")

## parseIconSet()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Functions parseIconSet() and parseIconSetAsync() parse icon set, calling custom function for every icon.

## Usage

Function has the following parameters:

- data, [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation"). Icon set data.
- callback, function. Callback, called for each icon found in icon set.

Function returns names of parsed icons as string\[\].

### Callback

Callback function has 2 parameters:

- name, string. Icon name.
- data, [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") |null. Icon data, null if icon is invalid.

Callback is called for each entry in icon set: all icons, aliases and all entries in not\_found property.

If data parameter in callback is null, icon is invalid or missing.

## parseIconSetAsync

Function parseIconSetAsync() is identical to parseIconSet(), except that it is asynchronous and callback is also an asynchronous function:

js
```
await parseIconSetAsync(iconSet, async (name, data) => {
    // do async stuff
 });
```

## Example

Exporting all icons from icon set:

ts
```
import { promises as fs } from 'fs';
import { icons } from '@iconify-json/codicon';
import { validateIconSet, parseIconSet, iconToSVG } from '@iconify/utils';

// Storage for all icons
const exportedSVG: Record<string, string> = Object.create(null);

// Validate icon set before parsing it. Will throw an exception on error
validateIconSet(icons);

// Parse all icons
parseIconSet(icons, (iconName, iconData) => {
    if (!iconData) {
        // Invalid icon
        console.error(\`Error parsing icon ${iconName}\`);
        return;
    }

    // Render icon
    const renderData = iconToSVG(iconData, {
        height: 'auto',
    });

    // Generate attributes for SVG element
    const svgAttributes: Record<string, string> = {
        'xmlns': 'http://www.w3.org/2000/svg',
        'xmlns:xlink': 'http://www.w3.org/1999/xlink',
        ...renderData.attributes,
    };
    const svgAttributesStr = Object.keys(svgAttributes)
        .map(
            (attr) =>
                // No need to check attributes for special characters, such as quotes,
                // they cannot contain anything that needs escaping.
                \`${attr}="${svgAttributes[attr as keyof typeof svgAttributes]}"\`
        )
        .join(' ');

    // Generate SVG
    const svg = \`<svg ${svgAttributesStr}>${renderData.body}</svg>\`;

    // Save SVG
    exportedSVG[iconName] = svg;
 });

// Save all icons
 (async () => {
    for (const name in exportedSVG) {
        const svg = exportedSVG[name];
        await fs.writeFile(\`svg/${name}.svg\`, svg, 'utf8');
    }
    console.log(\`Saved ${Object.keys(exportedSVG).length} icons\`);
 })();
```

Counting icons in icon set:

ts
```
import type { ExtendedIconifyIcon } from '@iconify/types';
import { icons } from '@iconify-json/codicon';
import { parseIconSet } from '@iconify/utils';

// Count icons by parsing them
let count = 0;
parseIconSet(icons, (iconName, iconData) => {
    if (iconData && !(iconData as ExtendedIconifyIcon).hidden) {
        // Check if it is an alias.
        // Aliases without modifications should not count as they are just another name for same icon.
        const isAlias = !icons.icons[iconName];
        if (isAlias && icons.aliases) {
            const aliasData = icons.aliases[iconName];
            if (Object.keys(aliasData).length > 1) {
                // Alias has more than just 'parent' property: assume it overrides something

                // This is a quick way, proper function that accounts for all possibilities
                // is in @iconify/tools package in IconSet class.
                return;
            }
        }

        // Valid icon, not hidden, not basic alias
        count++;
    }
 });

console.log(\`Found ${count} icons\`);
```

Code used in example above should be used to count icons in icon set when calculating number of icons for [IconifyInfo](https://iconify.design/docs/types/iconify-info.html "IconifyInfo documentation") data. It counts all icons, excluding hidden icons and basic aliases.

### Validation

Function does not check icon set for errors. Before using it, validate icon set using [validateIconSet()](https://iconify.design/docs/libraries/utils/validate-icon-set.html "validateIconSet() documentation") or [quicklyValidateIconSet()](https://iconify.design/docs/libraries/utils/quickly-validate-icon-set.html "quicklyValidateIconSet() documentation").

### JSON Modules

When using ES modules, examples above might require running node with "--experimental-json-modules" flag.

Until JSON modules support in Node.js becomes stable, you can avoid using flag by replacing import with require() because require() supports JSON files:

js
```
const { icons } = require('@iconify-json/codicon');
```

[Page 196](https://iconify.design/docs/libraries/utils/merge-icon-data.html "Current Page.")

## mergeIconData()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function mergeIconData() merges data for icon and alias.

## Merging logic

When combining icon and alias, properties cannot be simply merged. This is because transformations for alias are relative to parent icons' transformations.

For example, if icon has 90 degrees rotation and alias also has 90 degrees rotation, result is 180 degrees rotation. Same for horizontal and vertical flip.

## Usage

Function has the following parameters:

- icon, [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation"). Icon data.
- alias, [IconifyOptional](https://iconify.design/docs/types/iconify-icon.html#iconify-optional "IconifyOptional documentation"). Alias data.

Function returns merged icon data.

## Example

ts
```
import type { IconifyIcon, FullIconifyIcon } from '@iconify/utils';
import { mergeIconData, defaultIconProps } from '@iconify/utils';

// Rotate icon
const icon1: IconifyIcon = {
    body: '<path d="M7 6v12l10-6z" fill="currentColor"/>',
    width: 24,
    height: 24,
 };
const result1 = mergeIconData(icon1, {
    rotate: 1,
 });
console.log(result1);

// Merge full icon
const icon2: FullIconifyIcon = {
    ...defaultIconProps,
    body: '<path d="M7 6v12l10-6z" fill="currentColor"/>',
    width: 24,
    height: 24,
    hFlip: true,
 };
// Result has the same type as first parameter, so in this case Required<IconifyIcon>
const result2 = mergeIconData(icon2, {
    hFlip: true,
 });
console.log(result2);
```

json
```
{
    "body": "<path d=\"M7 6v12l10-6z\" fill=\"currentColor\"/>",
    "width": 24,
    "height": 24,
    "rotate": 1
}
```

json
```
{
    "left": 0,
    "top": 0,
    "width": 24,
    "height": 24,
    "rotate": 0,
    "vFlip": false,
    "hFlip": false,
    "body": "<path d=\"M7 6v12l10-6z\" fill=\"currentColor\"/>"
}
```

[Page 197](https://iconify.design/docs/libraries/utils/default-icon-props.html "Current Page.")

## defaultIconProps

This constant is part of [Iconify Utils package](https://iconify.design/docs/).

Constant defaultIconProps contains default values for optional [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") properties.

It is merged from 2 parts:

### defaultIconDimensions

Constant defaultIconDimensions contains default values for icon dimensions:

js
```
const defaultIconDimensions = {
    left: 0,
    top: 0,
    width: 16,
    height: 16,
 };
```

### defaultIconTransformations

Constant defaultIconTransformations contains default values for icon transformations:

js
```
const defaultIconTransformations = {
    rotate: 0,
    vFlip: false,
    hFlip: false,
 };
```

## Usage

Function has the following parameter:

- icon, [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation"). Icon data.

Function returns full icon data with type [FullIconifyIcon](https://iconify.design/docs/libraries/utils/full-iconify-icon.html "FullIconifyIcon documentation").

## Example

ts
```
import { defaultIconProps } from '@iconify/utils';

const icon = {
    ...defaultIconProps,
    body: '<path d="M7 6v12l10-6z" fill="currentColor"/>',
    width: 24,
    height: 24,
    hFlip: true,
 };
console.log(icon);
```

json
```
{
    "left": 0,
    "top": 0,
    "width": 24,
    "height": 24,
    "rotate": 0,
    "vFlip": false,
    "hFlip": true,
    "body": "<path d=\"M7 6v12l10-6z\" fill=\"currentColor\"/>"
}
```

It is used in functions that require only partial icon data, such as [iconToSVG()](https://iconify.design/docs/libraries/utils/icon-to-svg.html "iconToSVG() documentation"), but internally actually use full icon.

[Page 198](https://iconify.design/docs/libraries/utils/merge-customisations.html "Current Page.")

## mergeCustomisations()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function mergeCustomisations() merges default customisations, presented as [FullIconCustomisations](https://iconify.design/docs/libraries/utils/icon-customisations.html "FullIconCustomisations documentation") object and partial customisations. It also validates types, so it can be used to clean up user input.

## Usage

Function has the following parameters:

- defaults, [FullIconCustomisations](https://iconify.design/docs/libraries/utils/icon-customisations.html "FullIconCustomisations documentation"). Full customisations.
- item, [IconifyIconCustomisations](https://iconify.design/docs/libraries/utils/icon-customisations.html "IconifyIconCustomisations documentation"). Partial customisations that need to be merged with defaults.

Function returns merged customisations with same type as passed in first parameter (which makes it possible to use function with extended types).

## Example

ts
```
import type { IconifyIconCustomisations } from '@iconify/utils';
import { defaultIconCustomisations, mergeCustomisations } from '@iconify/utils';

const customisations: IconifyIconCustomisations = {
    hFlip: true,
 };
const fullCustomisations = mergeCustomisations(
    defaultIconCustomisations,
    customisations
 );

console.log(fullCustomisations);
```

## Merge

Why not just merge objects, like this?

ts
```
import type { IconifyIconCustomisations } from '@iconify/utils';
import { defaultIconCustomisations } from '@iconify/utils';

const customisations: IconifyIconCustomisations = {
    hFlip: true,
 };
const fullCustomisations = {
    ...defaultIconCustomisations,
    ...customisations,
 };

console.log(fullCustomisations);
```

That works only with default customisations, but not if both objects have transformations.

Function mergeCustomisations() should be used when, for example, you are merging customisations from icon, which might include transformations and user's customisations. It can also be used to merge customisations when resolving icon alias.

[Page 199](https://iconify.design/docs/libraries/utils/default-icon-customisations.html "Current Page.")

## defaultIconCustomisations

This constant is part of [Iconify Utils package](https://iconify.design/docs/).

Constant defaultIconCustomisations is used for default [FullIconifyIconCustomisations](https://iconify.design/docs/libraries/utils/icon-customisations.html "FullIconifyIconCustomisations documentation") values.

It is merged from 2 parts:

### defaultIconSizeCustomisations

Constant defaultIconSizeCustomisations represents size customisations: width and height:

js
```
const defaultIconSizeCustomisations = {
    width: null,
    height: null,
 };
```

### defaultIconTransformations

Constant defaultIconTransformations represents transformations:

js
```
const defaultIconTransformations = {
    rotate: 0,
    vFlip: false,
    hFlip: false,
 };
```

Default values for transformations are shared with [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") type.

## Usage

ts
```
import { defaultIconCustomisations, mergeCustomisations } from '@iconify/utils';

// Add horizontal flip and custom height
const fullCustomisations = {
    ...defaultIconCustomisations,
    hFlip: true,
    height: 24,
 };

// Add horizontal flip again, but merge it properly using mergeCustomisations(), resulting in hFlip = false
const mergedCustomisations = mergeCustomisations(fullCustomisations, {
    hFlip: true,
 });
```

Usually it is used with [mergeCustomisations()](https://iconify.design/docs/libraries/utils/merge-customisations.html "mergeCustomisations() documentation") function.

It is also used in functions that require only partial customisations, such as [iconToSVG()](https://iconify.design/docs/libraries/utils/icon-to-svg.html "iconToSVG() documentation"), but internally actually uses full customisations.

[Page 200](https://iconify.design/docs/libraries/utils/to-boolean.html "Current Page.")

## toBoolean()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function toBoolean() converts strings to boolean. It is used to parse various possible component property values to use them in [IconCustomisations](https://iconify.design/docs/libraries/utils/icon-customisations.html "IconCustomisations documentation") properties.

## Usage

Function has the following parameters:

- name, string. Property name.
- value, unknown. Value to parse.
- defaultValue, boolean. Value to return if value cannot be parsed.

Function returns boolean value.

## Example

ts
```
import { toBoolean } from '@iconify/utils';

/**
 * Using React or Svelte syntax for attributes for demo
 *
 * For default value using the opposite of expected value to make sure that value has been parsed
 */

// Returns true
console.log(\`Testing hFlip={true}:\`, toBoolean('hFlip', true, false));
console.log(\`Testing hFlip="true":\`, toBoolean('hFlip', 'true', false));
console.log(\`Testing hFlip="hFlip":\`, toBoolean('hFlip', 'hFlip', false));
console.log(\`Testing hFlip={1}:\`, toBoolean('hFlip', 1, false));

// Returns false
console.log(\`Testing hFlip={false}:\`, toBoolean('hFlip', false, true));
console.log(\`Testing hFlip={0}:\`, toBoolean('hFlip', 0, true));
console.log(\`Testing hFlip="false":\`, toBoolean('hFlip', 'false', true));
console.log(\`Testing hFlip="":\`, toBoolean('hFlip', '', true));
```

```
Testing hFlip={true}: true
 Testing hFlip="true": true
 Testing hFlip="hFlip": true
 Testing hFlip={1}: true
 Testing hFlip={false}: false
 Testing hFlip={0}: false
 Testing hFlip="false": false
 Testing hFlip="": false
```

[Page 201](https://iconify.design/docs/libraries/utils/rotate-from-string.html "Current Page.")

## rotateFromString()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function rotateFromString() cleans up various possible values for ration passed by user to valid rotate property of [IconCustomisations](https://iconify.design/docs/libraries/utils/icon-customisations.html "IconCustomisations documentation") type.

## Usage

Function has the following parameter:

- value, string. Value to parse.
- defaultValue, number. Value to return if value cannot be parsed.

Function returns number value in 0 to 3 range.

## Example

ts
```
import { rotateFromString } from '@iconify/utils';

/**
 * Function returns value in 0-3 range.
 *
 * If value is outside of range, function returns \`value % 4\`. So if value is 5, which is 450deg, which equals 90deg, so result is 1
 */

// Returns 1 (90 degrees)
console.log(\`Testing rotate="1":\`, rotateFromString('1', 0));
console.log(\`Testing rotate="5":\`, rotateFromString('5', 0));
console.log(\`Testing rotate="-3":\`, rotateFromString('-3', 0));
console.log(\`Testing rotate="90deg":\`, rotateFromString('90deg', 0));
console.log(\`Testing rotate="25%":\`, rotateFromString('25%', 0));

// Returns 2 (180 degrees)
console.log(\`Testing rotate="2":\`, rotateFromString('2', 0));
console.log(\`Testing rotate="-2":\`, rotateFromString('-2', 0));
console.log(\`Testing rotate="180deg":\`, rotateFromString('180deg', 0));
console.log(\`Testing rotate="50%":\`, rotateFromString('50%', 0));

// Returns 3 (270 degrees)
console.log(\`Testing rotate="3":\`, rotateFromString('3', 0));
console.log(\`Testing rotate="-1":\`, rotateFromString('-1', 0));
console.log(\`Testing rotate="270deg":\`, rotateFromString('270deg', 0));
console.log(\`Testing rotate="-90deg":\`, rotateFromString('-90deg', 0));
console.log(\`Testing rotate="75%":\`, rotateFromString('75%', 0));
console.log(\`Testing rotate="-25%":\`, rotateFromString('-25%', 0));

// Returns 0 (0 degrees)
console.log(\`Testing rotate="0":\`, rotateFromString('0', 3));
console.log(\`Testing rotate="0deg":\`, rotateFromString('0deg', 2));
console.log(\`Testing rotate="360deg":\`, rotateFromString('360deg', 2));
console.log(\`Testing rotate="0%":\`, rotateFromString('0%', 2));
console.log(\`Testing rotate="100%":\`, rotateFromString('100%', 2));

// Bad values, returns default value set in second parameter
console.log(\`Testing rotate="100deg":\`, rotateFromString('100deg', 0));
console.log(\`Testing rotate="40%":\`, rotateFromString('40%', 0));
console.log(\`Testing rotate="none":\`, rotateFromString('none', 0));
```

```
Testing rotate="1": 1
 Testing rotate="5": 1
 Testing rotate="-3": 1
 Testing rotate="90deg": 1
 Testing rotate="25%": 1
 Testing rotate="2": 2
 Testing rotate="-2": 2
 Testing rotate="180deg": 2
 Testing rotate="50%": 2
 Testing rotate="3": 3
 Testing rotate="-1": 3
 Testing rotate="270deg": 3
 Testing rotate="-90deg": 3
 Testing rotate="75%": 3
 Testing rotate="-25%": 3
 Testing rotate="0": 0
 Testing rotate="0deg": 0
 Testing rotate="360deg": 0
 Testing rotate="0%": 0
 Testing rotate="100%": 0
 Testing rotate="100deg": 0
 Testing rotate="40%": 0
 Testing rotate="none": 0
```

[Page 202](https://iconify.design/docs/libraries/utils/flip-from-string.html "Current Page.")

## flipFromString()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function flipFromString() applies flip shorthand property to [IconCustomisations](https://iconify.design/docs/libraries/utils/icon-customisations.html "IconCustomisations documentation") object.

## Usage

Function has the following parameters:

- custom, [IconCustomisations](https://iconify.design/docs/libraries/utils/icon-customisations.html "IconCustomisations documentation"). Customisations.
- value, string. Value to parse.

Function does not return anything, it applies changes to object passed in first parameter.

## Value

Value can be set of the following strings, separated by space and/or comma:

- "horizontal" sets hFlip to true.
- "vertical" sets vFlip to true.

## Example

ts
```
import type { IconifyIconCustomisations } from '@iconify/utils';
import { flipFromString } from '@iconify/utils';

let customisations: IconifyIconCustomisations;

 customisations = {};
flipFromString(customisations, 'horizontal');
// { hFlip: true }
console.log(customisations);

 customisations = {};
flipFromString(customisations, 'horizontal,vertical');
// { hFlip: true, vFlip: true }
console.log(customisations);

// Function does not toggle existing value, so this code does not change anything
 customisations = { vFlip: true };
flipFromString(customisations, 'vertical');
// { vFlip: true }
console.log(customisations);
```

[Page 203](https://iconify.design/docs/libraries/utils/icon-to-svg.html "Current Page.")

## iconToSVG()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function iconToSVG() generates data required to render SVG.

## Usage

This function has the following parameters:

- icon, [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation"). Icon data.
- customisations, [IconifyIconCustomisations](https://iconify.design/docs/libraries/utils/icon-customisations.html "IconifyIconCustomisations documentation"). Icon customisations. Optional.

This function returns data with type [IconifyIconBuildResult](https://iconify.design/docs/libraries/utils/icon-to-svg.html#build-result "IconifyIconBuildResult documentation"). See below.

### Parsing SVG

This function uses [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") as a source. If you want to parse a string that contains SVG, use [parseSVGContent()](https://iconify.design/docs/libraries/utils/parse-svg-content.html "parseSVGContent() documentation") and [buildParsedSVG()](https://iconify.design/docs/libraries/utils/build-parsed-svg.html "buildParsedSVG() documentation") functions instead.

## Result

The result is an object with the following properties:

- body, string. Icon content.
- attributes, object. Attributes for <svg> element.
- viewBox, [SVGViewBox](https://iconify.design/docs/libraries/utils/get-svg-viewbox.html "SVGViewBox documentation"). viewBox as array of numbers.

List of attributes in the result does not include xmlns because it is identical in all SVG. It always includes viewBox, usually includes width and height.

You can use [iconToHTML()](https://iconify.design/docs/libraries/utils/icon-to-html.html "iconToHTML() documentation") to convert the result to string.

### Examples of result

json
```
{
    "attributes": {
        "width": "24",
        "height": "24",
        "viewBox": "0 0 24 24"
    },
    "viewBox": [0, 0, 24, 24],
    "body": "<path d=\"M7 6v12l10-6z\" fill=\"currentColor\"/>"
}
```

## Example

ts
```
import { icons } from '@iconify-json/codicon';
import { getIconData, iconToSVG, iconToHTML, replaceIDs } from '@iconify/utils';

const iconName = 'debug-console';

// Get content for icon
const iconData = getIconData(icons, iconName);
if (!iconData) {
    throw new Error(\`Icon "${iconName}" is missing\`);
 }

// Use it to render icon
const renderData = iconToSVG(iconData, {
    height: 'auto',
 });

// Generate SVG string
const svg = iconToHTML(replaceIDs(renderData.body), renderData.attributes);

// Log SVG
console.log(svg);
```

## Icon dimensions

By default, resulting attributes include width and height, where height is set to "1em".

If you want to remove dimensions, set height to "unset" or "none" in customisations parameter:

js
```
const result = iconToSVG(data, {
    // Setting only height will also remove width
    height: 'unset',
 });
```

[Page 204](https://iconify.design/docs/libraries/utils/icon-to-html.html "Current Page.")

## iconToHTML()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function iconToHTML() generates SVG from a list of attributes for <svg> element and icon content.

It can be used with results of [iconToSVG()](https://iconify.design/docs/libraries/utils/icon-to-svg.html "iconToSVG() documentation"), [parseSVGContent()](https://iconify.design/docs/libraries/utils/parse-svg-content.html "parseSVGContent() documentation") or [buildParsedSVG()](https://iconify.design/docs/libraries/utils/build-parsed-svg.html "buildParsedSVG() documentation").

## Usage

Function has the following parameters:

- body, string. Icon content, without <svg> tag.
- attributes, Record<string,string>. Attributes to add, such as viewBox.

Function returns string.

## Notes

Function adds the following attributes automatically, do not add them in attributes parameter:

- "xmlns": always added.
- "xmlns:xlink": added if body contains "xlink:". Modern icons should not contain "xlink:" attributes.

Attribute values are not modified. Make sure they are escaped before calling function.

## Example

ts
```
import { icons } from '@iconify-json/codicon';
import { getIconData, iconToSVG, iconToHTML, replaceIDs } from '@iconify/utils';

const iconName = 'debug-console';

// Get content for icon
const iconData = getIconData(icons, iconName);
if (!iconData) {
    throw new Error(\`Icon "${iconName}" is missing\`);
 }

// Use it to render icon
const renderData = iconToSVG(iconData, {
    height: 'auto',
 });

// Generate SVG string
const svg = iconToHTML(replaceIDs(renderData.body), renderData.attributes);

// Log SVG
console.log(svg);
```

[Page 205](https://iconify.design/docs/libraries/utils/calculate-size.html "Current Page.")

## calculateSize()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function calculateSize() is used for calculating icon's width or height when only one property is provided.

For example, if you have icon with viewBox="0 0 36 24" and height is set to "1em", this function is used to calculate width property, which will be "1.5em".

Function is used by [iconToSVG()](https://iconify.design/docs/libraries/utils/icon-to-svg.html "iconToSVG() documentation") to generate attributes. It can also be used by things like icon pickers, where you can show hint for width value when user inputs height value.

## Usage

Function has the following parameters:

- size, string|number. One dimension, such as height.
- ratio, number. Dimensions ratio. If you provide height in first parameter, second parameter should be width / height of icon's viewBox. If you provider width in first parameter, second parameter should be height / width of icon's viewBox.
- precision, number. Optional, default is 100.

Function returns calculated size.

## Example

ts
```
import { icons } from '@iconify-json/fa-regular';
import { getIconData, calculateSize, defaultIconProps } from '@iconify/utils';

// Get 384 x 512 icon
const iconData = getIconData(icons, 'bookmark');
if (!iconData) {
    throw new Error('Icon is missing');
 }

// Add default values by merging default props and partial icon data
// Otherwise width and height might be missing
const fullIconData = {
    ...defaultIconProps,
    ...iconData,
 };

// Calculate width when height is set
const calculateWidth = (height: number | string) => {
    const width = calculateSize(height, fullIconData.width / fullIconData.height);
    console.log(\`For height="${height}", width value is "${width}"\`);
 };
calculateWidth('1em');
calculateWidth(24);
calculateWidth('calc(1em + 8px)');
calculateWidth('3.25rem');

// Calculate height when width is set
const calculateHeight = (width: number | string) => {
    const height = calculateSize(width, fullIconData.height / fullIconData.width);
    console.log(\`For width="${width}", height value is "${height}"\`);
 };
calculateHeight('2em');
calculateHeight(20);
```

```
For height="1em", width value is "0.75em"
 For height="24", width value is "18"
 For height="calc(1em + 8px)", width value is "calc(0.75em + 6px)"
 For height="3.25rem", width value is "2.44rem"
 For width="2em", height value is "2.67em"
 For width="20", height value is "26.67"
```

[Page 206](https://iconify.design/docs/libraries/utils/replace-ids.html "Current Page.")

## replaceIDs()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function replaceIDs() is used for replacing IDs for icon content with randomly generated strings.

All icon components use this function for each rendered icon.

## Why is it needed?

IDs are used in icon elements, such as reusable paths, masks, animations. They are supposed to be unique.

When you export SVG from image editor, often editors generate IDs based on layer name, so if layer named "Mask", ID for shape will most likely be "mask". Icon optimisers, such as SVGO, by default shorten IDs, so icons end up with IDs like "a".

When icons are linked as external resources, this is not an issue. However, when icons are embedded in document, having multiple elements with the same ID from different icons can and will cause chaos. Even using the same icon in multiple places in document without changing IDs can cause errors.

This is why when embedding icons, it is important for each icon have different IDs for elements that do not exist in other icons.

## Usage

Function has the following parameters:

- content, string. Icon content.
- prefix, string|function. Optional prefix for generated IDs. Use this option if you want to customise IDs to make them less random.

Function returns content with replaced IDs.

In first parameter you can pass body property of data generated by [iconToSVG()](https://iconify.design/docs/libraries/utils/icon-to-svg.html "iconToSVG() documentation") or you can pass an entire <svg>.

## Example

ts
```
import type { FullIconifyIcon } from '@iconify/utils';
import {
    defaultIconProps,
    defaultIconCustomisations,
    iconToSVG,
    replaceIDs,
 } from '@iconify/utils';

const iconData: FullIconifyIcon = {
    ...defaultIconProps,
    body: '<defs><linearGradient id="a" x1="4.416" y1="-1909.341" x2="13.909" y2="-1892.9" gradientTransform="translate(0 1917.121)" gradientUnits="userSpaceOnUse"><stop offset="0" stop-color="#b72c3f"/><stop offset=".5" stop-color="#b12334"/><stop offset="1" stop-color="#9d1623"/></linearGradient></defs><path d="M8.512 20v6.667c0 1.84 4.81 3.333 10.744 3.333S30 28.507 30 26.667V20z" fill="#881421"/><path d="M8.512 12.667V20c0 1.841 4.81 3.333 10.744 3.333S30 21.841 30 20v-7.333z" fill="#af2031"/><path d="M8.512 5.333v7.334c0 1.84 4.81 3.333 10.744 3.333S30 14.507 30 12.667V5.333z" fill="#c94f60"/><ellipse cx="19.256" cy="5.333" rx="10.744" ry="3.333" fill="#e08095"/><path d="M16.434 8H8.512v16.667h7.922a1.212 1.212 0 0 0 1.194-1.222V9.222A1.212 1.212 0 0 0 16.434 8z" opacity=".1"/><path d="M15.783 8.667H8.512v16.666h7.271a1.212 1.212 0 0 0 1.194-1.222V9.889a1.212 1.212 0 0 0-1.194-1.222z" opacity=".2"/><path d="M15.783 8.667H8.512V24h7.271a1.212 1.212 0 0 0 1.194-1.222V9.889a1.212 1.212 0 0 0-1.194-1.222z" opacity=".2"/><path d="M15.132 8.667h-6.62V24h6.62a1.213 1.213 0 0 0 1.194-1.222V9.889a1.213 1.213 0 0 0-1.194-1.222z" opacity=".2"/><path d="M3.194 8.667h11.938a1.208 1.208 0 0 1 1.194 1.222v12.222a1.208 1.208 0 0 1-1.194 1.222H3.194A1.208 1.208 0 0 1 2 22.111V9.889a1.208 1.208 0 0 1 1.194-1.222z" fill="url(#a)"/><path d="M8.305 12.027h1.758l2.825 7.945h-1.66l-.623-1.895H7.7l-.611 1.895H5.437zm1.926 4.826-.9-2.875a3.812 3.812 0 0 1-.165-.649H9.13a3.729 3.729 0 0 1-.162.671l-.912 2.859z" fill="#fff"/>',
    width: 32,
    height: 32,
 };

// Use it to render icon
const renderData = iconToSVG(iconData, defaultIconCustomisations);

// Generate attributes for SVG element
const svgAttributes: Record<string, string> = {
    'xmlns': 'http://www.w3.org/2000/svg',
    'xmlns:xlink': 'http://www.w3.org/1999/xlink',
    ...renderData.attributes,
 };
const svgAttributesStr = Object.keys(svgAttributes)
    .map(
        (attr) =>
            // No need to check attributes for special characters, such as quotes,
            // they cannot contain anything that needs escaping.
            \`${attr}="${svgAttributes[attr as keyof typeof svgAttributes]}"\`
    )
    .join(' ');

// Generate SVG
const svg = replaceIDs(\`<svg ${svgAttributesStr}>${renderData.body}</svg>\`);

// Log SVG
console.log(svg);
```

svg
```
<svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="1em" height="1em" viewBox="0 0 32 32"><defs><linearGradient id="IconifyId-17c762189ff-239667-0" x1="4.416" y1="-1909.341" x2="13.909" y2="-1892.9" gradientTransform="translate(0 1917.121)" gradientUnits="userSpaceOnUse"><stop offset="0" stop-color="#b72c3f"/><stop offset=".5" stop-color="#b12334"/><stop offset="1" stop-color="#9d1623"/></linearGradient></defs><path d="M8.512 20v6.667c0 1.84 4.81 3.333 10.744 3.333S30 28.507 30 26.667V20z" fill="#881421"/><path d="M8.512 12.667V20c0 1.841 4.81 3.333 10.744 3.333S30 21.841 30 20v-7.333z" fill="#af2031"/><path d="M8.512 5.333v7.334c0 1.84 4.81 3.333 10.744 3.333S30 14.507 30 12.667V5.333z" fill="#c94f60"/><ellipse cx="19.256" cy="5.333" rx="10.744" ry="3.333" fill="#e08095"/><path d="M16.434 8H8.512v16.667h7.922a1.212 1.212 0 0 0 1.194-1.222V9.222A1.212 1.212 0 0 0 16.434 8z" opacity=".1"/><path d="M15.783 8.667H8.512v16.666h7.271a1.212 1.212 0 0 0 1.194-1.222V9.889a1.212 1.212 0 0 0-1.194-1.222z" opacity=".2"/><path d="M15.783 8.667H8.512V24h7.271a1.212 1.212 0 0 0 1.194-1.222V9.889a1.212 1.212 0 0 0-1.194-1.222z" opacity=".2"/><path d="M15.132 8.667h-6.62V24h6.62a1.213 1.213 0 0 0 1.194-1.222V9.889a1.213 1.213 0 0 0-1.194-1.222z" opacity=".2"/><path d="M3.194 8.667h11.938a1.208 1.208 0 0 1 1.194 1.222v12.222a1.208 1.208 0 0 1-1.194 1.222H3.194A1.208 1.208 0 0 1 2 22.111V9.889a1.208 1.208 0 0 1 1.194-1.222z" fill="url(#IconifyId-17c762189ff-239667-0)"/><path d="M8.305 12.027h1.758l2.825 7.945h-1.66l-.623-1.895H7.7l-.611 1.895H5.437zm1.926 4.826-.9-2.875a3.812 3.812 0 0 1-.165-.649H9.13a3.729 3.729 0 0 1-.162.671l-.912 2.859z" fill="#fff"/></svg>
```

## Prefix

For second parameter you can use string, which will be used as prefix.

If in example above, this code:

ts
```
const svg = replaceIDs(\`<svg ${svgAttributesStr}>${renderData.body}</svg>\`);
```

is replaced with this:

ts
```
const svg = replaceIDs(
    \`<svg ${svgAttributesStr}>${renderData.body}</svg>\`,
    'my-prefix-'
 );
```

result will contain something like this:

html
```
<svg ...>
    <linearGradient id="my-prefix-0" x1="4.416" ...>...</linearGradient>
    <path ... fill="url(#my-prefix-0)" />
</svg>
```

Icons will use custom prefix and a number added after it. Counter is not reset, so each icon will have different IDs.

## Callback

You can also use a callback for second parameter. Callback function accepts old ID as parameter and should return new ID:

ts
```
let counter = 0;
const svg = replaceIDs(
    \`<svg ${svgAttributesStr}>${renderData.body}</svg>\`,
    () => {
        return 'my-prefix-' + counter++;
    }
 );
```

result will be identical to example above that uses prefix string.

Another example:

ts
```
let counter = 0;
const svg = replaceIDs(
    \`<svg ${svgAttributesStr}>${renderData.body}</svg>\`,
    (id: string) => {
        switch (id) {
            case 'a':
                // Replace id="a" with id="b"
                return 'b';

            default:
                // Use 'whatever-' prefix for other IDs
                return 'whatever-' + counter++;
        }
    }
 );
```

## Notes

Each icon can have any number of elements with IDs. If you are using callback to generate new IDs, make sure callback returns different values on each call.

[Page 207](https://iconify.design/docs/libraries/utils/parse-svg-content.html "Current Page.")

## parseSVGContent()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function parseSVGContent() parses string that contains SVG, extracts attributes for <svg> element and icon content.

## Usage

This function has the following parameter:

- content, string. SVG.

This function returns data with type ParsedSVGContent, undefined on error. See below.

## Result

The result is an object with the following properties:

- body, string. Icon content.
- attributes, object. Attributes for <svg> element.

Attributes are not checked.

The result should be passed to either [buildParsedSVG()](https://iconify.design/docs/libraries/utils/build-parsed-svg.html "buildParsedSVG() documentation") or [convertParsedSVG()](https://iconify.design/docs/libraries/utils/convert-parsed-svg.html "convertParsedSVG() documentation"). Both functions do simple validation of attributes in <svg> element and convert it to usable data.

## Iconify Tools

This function is very basic. For advanced parsing and clean up, use [Iconify Tools](https://iconify.design/tools/).

## Examples

Example using parseSVGContent() with [buildParsedSVG()](https://iconify.design/docs/libraries/utils/build-parsed-svg.html "buildParsedSVG() documentation") and [iconToHTML()](https://iconify.design/docs/libraries/utils/icon-to-html.html "iconToHTML() documentation") to clean up icon:

ts
```
import { buildParsedSVG, parseSVGContent, iconToHTML } from '@iconify/utils';

// Source SVG with many attributes on <svg> element
const svg = \`<svg xmlns="http://www.w3.org/2000/svg" class="icon icon-tabler icon-tabler-3d-rotate" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">
  <path d="M12 3a7 7 0 0 1 7 7v4l-3 -3" />
  <path d="M22 11l-3 3" />
  <path d="M8 15.5l-5 -3l5 -3l5 3v5.5l-5 3z" />
  <path d="M3 12.5v5.5l5 3" />
  <path d="M8 15.545l5 -3.03" />
 </svg>\`

// Split SVG in <svg> attributes and body
const parsed = parseSVGContent(svg);
if (!parsed) {
    throw new Error('Invalid icon')
 }

// Validate and clean up attributes, return object with attributes and body
const built = buildParsedSVG(parsed);
if (!built) {
    throw new Error('Invalid icon')
 }

/*
 {
  attributes: { width: '24', height: '24', viewBox: '0 0 24 24' },
  viewBox: [ 0, 0, 24, 24 ],
  body: '<g stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path d="M12 3a7 7 0 0 1 7 7v4l-3 -3" />\n' +
    '  <path d="M22 11l-3 3" />\n' +
    '  <path d="M8 15.5l-5 -3l5 -3l5 3v5.5l-5 3z" />\n' +
    '  <path d="M3 12.5v5.5l5 3" />\n' +
    '  <path d="M8 15.545l5 -3.03" /></g>'
 }
 */

// Build cleaned-up SVG
const html = iconToHTML(built.body, built.attributes);
console.log(html);

/*

 <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24">
  <g stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">
    <path d="M12 3a7 7 0 0 1 7 7v4l-3 -3" />
    <path d="M22 11l-3 3" />
    <path d="M8 15.5l-5 -3l5 -3l5 3v5.5l-5 3z" />
    <path d="M3 12.5v5.5l5 3" />
    <path d="M8 15.545l5 -3.03" />
  </g>
 </svg>

 */
```

Example using parseSVGContent() with [convertParsedSVG()](https://iconify.design/docs/libraries/utils/convert-parsed-svg.html "convertParsedSVG() documentation") to get icon data in [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") format, which can be used by various icon components:

ts
```
import { convertParsedSVG, parseSVGContent } from '@iconify/utils';

// Source SVG with many attributes on <svg> element
const svg = \`<svg xmlns="http://www.w3.org/2000/svg" class="icon icon-tabler icon-tabler-3d-rotate" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">
  <path d="M12 3a7 7 0 0 1 7 7v4l-3 -3" />
  <path d="M22 11l-3 3" />
  <path d="M8 15.5l-5 -3l5 -3l5 3v5.5l-5 3z" />
  <path d="M3 12.5v5.5l5 3" />
  <path d="M8 15.545l5 -3.03" />
 </svg>\`

// Split SVG in <svg> attributes and body
const parsed = parseSVGContent(svg);
if (!parsed) {
    throw new Error('Invalid icon')
 }

// Validate and clean up attributes, return IconifyIcon object
const icon = convertParsedSVG(parsed);
if (!icon) {
    throw new Error('Invalid icon')
 }

console.log(icon);

/*

 {
  left: 0,
  top: 0,
  width: 24,
  height: 24,
  body: '<g stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path d="M12 3a7 7 0 0 1 7 7v4l-3 -3" />\n' +
    '  <path d="M22 11l-3 3" />\n' +
    '  <path d="M8 15.5l-5 -3l5 -3l5 3v5.5l-5 3z" />\n' +
    '  <path d="M3 12.5v5.5l5 3" />\n' +
    '  <path d="M8 15.545l5 -3.03" /></g>'
 }

 */
```

[Page 208](https://iconify.design/docs/libraries/utils/build-parsed-svg.html "Current Page.")

## buildParsedSVG()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function buildParsedSVG() parses result of [parseSVGContent()](https://iconify.design/docs/libraries/utils/parse-svg-content.html "parseSVGContent() documentation").

It validates and cleans up <svg> attributes, extracts and validates viewBox and returns data as a list of attributes for <svg> element and content.

Result can be used by functions like [iconToHTML()](https://iconify.design/docs/libraries/utils/icon-to-html.html "iconToHTML() documentation") to generate SVG or to generate various components.

## Usage

This function has the following parameter:

- data, object. Result of buildParsedSVG() function.

This function returns data with type ParsedSVGContent, undefined on error. See below.

## Result

The result is an object with the following properties:

- body, string. Icon content.
- attributes, object. Attributes for <svg> element.
- viewBox, [SVGViewBox](https://iconify.design/docs/libraries/utils/get-svg-viewbox.html "SVGViewBox documentation"). viewBox as array of numbers.

List of attributes in the result does not include xmlns because it is identical in all SVG. It always includes viewBox, usually includes width and height.

You can use [iconToHTML()](https://iconify.design/docs/libraries/utils/icon-to-html.html "iconToHTML() documentation") to convert the result to string.

## Example

Example using [parseSVGContent()](https://iconify.design/docs/libraries/utils/parse-svg-content.html "parseSVGContent() documentation") with buildParsedSVG() and [iconToHTML()](https://iconify.design/docs/libraries/utils/icon-to-html.html "iconToHTML() documentation") to clean up icon:

ts
```
import { buildParsedSVG, parseSVGContent, iconToHTML } from '@iconify/utils';

// Source SVG with many attributes on <svg> element
const svg = \`<svg xmlns="http://www.w3.org/2000/svg" class="icon icon-tabler icon-tabler-3d-rotate" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">
  <path d="M12 3a7 7 0 0 1 7 7v4l-3 -3" />
  <path d="M22 11l-3 3" />
  <path d="M8 15.5l-5 -3l5 -3l5 3v5.5l-5 3z" />
  <path d="M3 12.5v5.5l5 3" />
  <path d="M8 15.545l5 -3.03" />
 </svg>\`

// Split SVG in <svg> attributes and body
const parsed = parseSVGContent(svg);
if (!parsed) {
    throw new Error('Invalid icon')
 }

// Validate and clean up attributes, return object with attributes and body
const built = buildParsedSVG(parsed);
if (!built) {
    throw new Error('Invalid icon')
 }

/*
 {
  attributes: { width: '24', height: '24', viewBox: '0 0 24 24' },
  viewBox: [ 0, 0, 24, 24 ],
  body: '<g stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path d="M12 3a7 7 0 0 1 7 7v4l-3 -3" />\n' +
    '  <path d="M22 11l-3 3" />\n' +
    '  <path d="M8 15.5l-5 -3l5 -3l5 3v5.5l-5 3z" />\n' +
    '  <path d="M3 12.5v5.5l5 3" />\n' +
    '  <path d="M8 15.545l5 -3.03" /></g>'
 }
 */

// Build cleaned-up SVG
const html = iconToHTML(built.body, built.attributes);
console.log(html);

/*

 <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24">
  <g stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">
    <path d="M12 3a7 7 0 0 1 7 7v4l-3 -3" />
    <path d="M22 11l-3 3" />
    <path d="M8 15.5l-5 -3l5 -3l5 3v5.5l-5 3z" />
    <path d="M3 12.5v5.5l5 3" />
    <path d="M8 15.545l5 -3.03" />
  </g>
 </svg>

 */
```

[Page 209](https://iconify.design/docs/libraries/utils/convert-parsed-svg.html "Current Page.")

## convertParsedSVG()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function convertParsedSVG() converts result of [parseSVGContent()](https://iconify.design/docs/libraries/utils/parse-svg-content.html "parseSVGContent() documentation") to [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation").

Function also does basic validation and cleanup of <svg> attributes.

Result can be used by various functions and icon components that use [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") type.

## Usage

This function has the following parameter:

- data, object. Result of [buildParsedSVG()](https://iconify.design/docs/libraries/utils/build-parsed-svg.html "buildParsedSVG() documentation") function.

This function returns data with type [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation"), undefined on error.

## Iconify Tools

This function is very basic. For advanced parsing and clean up, use [Iconify Tools](https://iconify.design/tools/).

## Example

Example using [parseSVGContent()](https://iconify.design/docs/libraries/utils/parse-svg-content.html "parseSVGContent() documentation") with convertParsedSVG() to get icon data in [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") format, which can be used by various icon components:

ts
```
import { convertParsedSVG, parseSVGContent } from '@iconify/utils';

// Source SVG with many attributes on <svg> element
const svg = \`<svg xmlns="http://www.w3.org/2000/svg" class="icon icon-tabler icon-tabler-3d-rotate" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round">
  <path d="M12 3a7 7 0 0 1 7 7v4l-3 -3" />
  <path d="M22 11l-3 3" />
  <path d="M8 15.5l-5 -3l5 -3l5 3v5.5l-5 3z" />
  <path d="M3 12.5v5.5l5 3" />
  <path d="M8 15.545l5 -3.03" />
 </svg>\`

// Split SVG in <svg> attributes and body
const parsed = parseSVGContent(svg);
if (!parsed) {
    throw new Error('Invalid icon')
 }

// Validate and clean up attributes, return IconifyIcon object
const icon = convertParsedSVG(parsed);
if (!icon) {
    throw new Error('Invalid icon')
 }

console.log(icon);

/*

 {
  left: 0,
  top: 0,
  width: 24,
  height: 24,
  body: '<g stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path d="M12 3a7 7 0 0 1 7 7v4l-3 -3" />\n' +
    '  <path d="M22 11l-3 3" />\n' +
    '  <path d="M8 15.5l-5 -3l5 -3l5 3v5.5l-5 3z" />\n' +
    '  <path d="M3 12.5v5.5l5 3" />\n' +
    '  <path d="M8 15.545l5 -3.03" /></g>'
 }

 */
```

[Page 210](https://iconify.design/docs/libraries/utils/get-svg-viewbox.html "Current Page.")

## getSVGViewBox() and SVGViewBox type

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function getSVGViewBox() is a helper function that parses viewBox attribute value.

Result is represented by SVGViewBox type, used in various functions in Iconify Utils.

## Usage

The function has the following parameter:

- value, string. Attribute value.

Function returns SVGViewBox with parsed viewBox value or undefined on error.

Function validates numbers to make sure values are valid numbers and there are exactly 4 numbers. On failure, it will return undefined.

## SVGViewBox type

Type SVGViewBox is an array of four numbers:

- x (or left)
- y (or top)
- width
- height

## Example

ts
```
import { getSVGViewBox } from '@iconify/utils';

const viewBox = getSVGViewBox('0 0 24 24');
console.log(viewBox);
```

json
```
[0, 0, 24, 24]
```

## Convert to string

To get viewBox attribute as a string from SVGViewBox, use join function:

js
```
const value = viewBox.join(' ');
```

[Page 211](https://iconify.design/docs/libraries/utils/split-svg-defs.html "Current Page.")

## splitSVGDefs()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function splitSVGDefs() splits SVG body in contents of <defs> and other content.

This function is used by [wrapSVGContent()](https://iconify.design/docs/libraries/utils/wrap-svg-content.html "wrapSVGContent() documentation") to wrap icon content, which is used by [iconToSVG()](https://iconify.design/docs/libraries/utils/icon-to-svg.html "iconToSVG() documentation") to apply flip and rotation to icon, by [buildParsedSVG()](https://iconify.design/docs/libraries/utils/build-parsed-svg.html "buildParsedSVG() documentation") and [convertParsedSVG()](https://iconify.design/docs/libraries/utils/convert-parsed-svg.html "convertParsedSVG() documentation") to move presentational attributes from <svg> element to a group element.

## Usage

This function has the following parameter:

- content, string. Icon content.

This function returns an object with 2 properties:

- defs, string. Contents of <defs> element(s).
- content, string. The rest of icon.

To merge back definitions and content, use [mergeDefsAndContent()](https://iconify.design/docs/libraries/utils/merge-defs-and-content.html "mergeDefsAndContent() documentation").

## Example

ts
```
import type { IconifyIcon } from '@iconify/types';
import { splitSVGDefs, mergeDefsAndContent, wrapSVGContent } from '@iconify/utils';

// Source icon, which contains definitions block
// This code works for icons without definitions block too, so no need to check if an icon actually has <defs>
const icon: IconifyIcon = {
    width: 128,
    height: 128,
    body: \`<defs><path id="notoCrossMarkButton0" fill="#ABC884" d="M40.16 12.86c0-2.3-1.6-3-10.8-2.7c-7.7.3-11.5 1.2-13.8 4s-2.9 8.5-3 15.3c0 4.8 0 9.3 2.5 9.3c3.4 0 3.4-7.9 6.2-12.3c5.4-8.7 18.9-10.6 18.9-13.6z" opacity=".65"/></defs><path fill="#689F38" d="M116.46 3.96h-104c-4.42 0-8 3.58-8 8v104c0 4.42 3.58 8 8 8h104c4.42 0 8-3.58 8-8v-104c0-4.42-3.58-8-8-8z"/><path fill="#7CB342" d="M110.16 3.96h-98.2a7.555 7.555 0 0 0-7.5 7.5v97.9c-.01 4.14 3.34 7.49 7.48 7.5h98.12c4.14.01 7.49-3.34 7.5-7.48V11.46c.09-4.05-3.13-7.41-7.18-7.5h-.22z"/><use href="#notoCrossMarkButton0" opacity=".65"/><path fill="#FBF9F9" d="M108.71 95.08L77.54 64.2l30.88-31.17c3.5-3.53 3.47-9.23-.06-12.73s-9.23-3.47-12.73.06L64.75 51.53L33.57 20.65c-3.53-3.5-9.23-3.47-12.73.06c-3.5 3.53-3.47 9.23.06 12.73l31.18 30.88L21.19 95.5c-3.5 3.53-3.47 9.23.06 12.73a8.95 8.95 0 0 0 6.33 2.61c2.32 0 4.63-.89 6.39-2.67l30.89-31.18l31.18 30.88a8.95 8.95 0 0 0 6.33 2.61c2.32 0 4.63-.89 6.39-2.67c3.51-3.53 3.48-9.23-.05-12.73z"/><use href="#notoCrossMarkButton0" opacity=".35"/>\`
 }

//
// Rotate by 90 degrees using splitSVGDefs() and mergeDefsAndContent()
//

// Extract defs
const defs = splitSVGDefs(icon.body);

/*
 {
  defs: '<path id="notoCrossMarkButton0" fill="#ABC884" d="M40.16 12.86c0-2.3-1.6-3-10.8-2.7c-7.7.3-11.5 1.2-13.8 4s-2.9 8.5-3 15.3c0 4.8 0 9.3 2.5 9.3c3.4 0 3.4-7.9 6.2-12.3c5.4-8.7 18.9-10.6 18.9-13.6z" opacity=".65"/>',
  content: '<path fill="#689F38" d="M116.46 3.96h-104c-4.42 0-8 3.58-8 8v104c0 4.42 3.58 8 8 8h104c4.42 0 8-3.58 8-8v-104c0-4.42-3.58-8-8-8z"/><path fill="#7CB342" d="M110.16 3.96h-98.2a7.555 7.555 0 0 0-7.5 7.5v97.9c-.01 4.14 3.34 7.49 7.48 7.5h98.12c4.14.01 7.49-3.34 7.5-7.48V11.46c.09-4.05-3.13-7.41-7.18-7.5h-.22z"/><use href="#notoCrossMarkButton0" opacity=".65"/><path fill="#FBF9F9" d="M108.71 95.08L77.54 64.2l30.88-31.17c3.5-3.53 3.47-9.23-.06-12.73s-9.23-3.47-12.73.06L64.75 51.53L33.57 20.65c-3.53-3.5-9.23-3.47-12.73.06c-3.5 3.53-3.47 9.23.06 12.73l31.18 30.88L21.19 95.5c-3.5 3.53-3.47 9.23.06 12.73a8.95 8.95 0 0 0 6.33 2.61c2.32 0 4.63-.89 6.39-2.67l30.89-31.18l31.18 30.88a8.95 8.95 0 0 0 6.33 2.61c2.32 0 4.63-.89 6.39-2.67c3.51-3.53 3.48-9.23-.05-12.73z"/><use href="#notoCrossMarkButton0" opacity=".35"/>'
 }
 */

// Rotate icon by 90 degrees, relative to the middle of icon
const rotatedBody = \`<g transform="rotate(90 64 64)">${defs.content}</g>\`;

// Merge it
const mergedBody = mergeDefsAndContent(defs.defs, rotatedBody);

/*
 <defs><path id="notoCrossMarkButton0" fill="#ABC884" d="M40.16 12.86c0-2.3-1.6-3-10.8-2.7c-7.7.3-11.5 1.2-13.8 4s-2.9 8.5-3 15.3c0 4.8 0 9.3 2.5 9.3c3.4 0 3.4-7.9 6.2-12.3c5.4-8.7 18.9-10.6 18.9-13.6z" opacity=".65"/></defs><g transform="rotate(90 64 64)"><path fill="#689F38" d="M116.46 3.96h-104c-4.42 0-8 3.58-8 8v104c0 4.42 3.58 8 8 8h104c4.42 0 8-3.58 8-8v-104c0-4.42-3.58-8-8-8z"/><path fill="#7CB342" d="M110.16 3.96h-98.2a7.555 7.555 0 0 0-7.5 7.5v97.9c-.01 4.14 3.34 7.49 7.48 7.5h98.12c4.14.01 7.49-3.34 7.5-7.48V11.46c.09-4.05-3.13-7.41-7.18-7.5h-.22z"/><use href="#notoCrossMarkButton0" opacity=".65"/><path fill="#FBF9F9" d="M108.71 95.08L77.54 64.2l30.88-31.17c3.5-3.53 3.47-9.23-.06-12.73s-9.23-3.47-12.73.06L64.75 51.53L33.57 20.65c-3.53-3.5-9.23-3.47-12.73.06c-3.5 3.53-3.47 9.23.06 12.73l31.18 30.88L21.19 95.5c-3.5 3.53-3.47 9.23.06 12.73a8.95 8.95 0 0 0 6.33 2.61c2.32 0 4.63-.89 6.39-2.67l30.89-31.18l31.18 30.88a8.95 8.95 0 0 0 6.33 2.61c2.32 0 4.63-.89 6.39-2.67c3.51-3.53 3.48-9.23-.05-12.73z"/><use href="#notoCrossMarkButton0" opacity=".35"/></g>
 */

// Update icon
const newIcon1 = {
    ...icon,
    body: mergedBody
 }

//
// Rotate by 90 degrees using wrapSVGContent()
//
const newIcon2 = {
    ...icon,
    body: wrapSVGContent(icon.body, '<g transform="rotate(90 64 64)">', '</g>')
 }

// newIcon1 and newIcon2 are identical
```

[Page 212](https://iconify.design/docs/libraries/utils/merge-defs-and-content.html "Current Page.")

## mergeDefsAndContent()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function [splitSVGDefs()](https://iconify.design/docs/libraries/utils/split-svg-defs.html "splitSVGDefs() documentation") merges definitions and other SVG content in a string.

This function is used by [wrapSVGContent()](https://iconify.design/docs/libraries/utils/wrap-svg-content.html "wrapSVGContent() documentation") to wrap icon content, which is used by [iconToSVG()](https://iconify.design/docs/libraries/utils/icon-to-svg.html "iconToSVG() documentation") to apply flip and rotation to icon, by [buildParsedSVG()](https://iconify.design/docs/libraries/utils/build-parsed-svg.html "buildParsedSVG() documentation") and [convertParsedSVG()](https://iconify.design/docs/libraries/utils/convert-parsed-svg.html "convertParsedSVG() documentation") to move presentational attributes from <svg> element to a group element.

## Usage

This function has the following parameters:

- defs, string. Definitions.
- content, string. Icon content.

This function returns merged icon as a string.

## Example

ts
```
import type { IconifyIcon } from '@iconify/types';
import { splitSVGDefs, mergeDefsAndContent, wrapSVGContent } from '@iconify/utils';

// Source icon, which contains definitions block
// This code works for icons without definitions block too, so no need to check if an icon actually has <defs>
const icon: IconifyIcon = {
    width: 128,
    height: 128,
    body: \`<defs><path id="notoCrossMarkButton0" fill="#ABC884" d="M40.16 12.86c0-2.3-1.6-3-10.8-2.7c-7.7.3-11.5 1.2-13.8 4s-2.9 8.5-3 15.3c0 4.8 0 9.3 2.5 9.3c3.4 0 3.4-7.9 6.2-12.3c5.4-8.7 18.9-10.6 18.9-13.6z" opacity=".65"/></defs><path fill="#689F38" d="M116.46 3.96h-104c-4.42 0-8 3.58-8 8v104c0 4.42 3.58 8 8 8h104c4.42 0 8-3.58 8-8v-104c0-4.42-3.58-8-8-8z"/><path fill="#7CB342" d="M110.16 3.96h-98.2a7.555 7.555 0 0 0-7.5 7.5v97.9c-.01 4.14 3.34 7.49 7.48 7.5h98.12c4.14.01 7.49-3.34 7.5-7.48V11.46c.09-4.05-3.13-7.41-7.18-7.5h-.22z"/><use href="#notoCrossMarkButton0" opacity=".65"/><path fill="#FBF9F9" d="M108.71 95.08L77.54 64.2l30.88-31.17c3.5-3.53 3.47-9.23-.06-12.73s-9.23-3.47-12.73.06L64.75 51.53L33.57 20.65c-3.53-3.5-9.23-3.47-12.73.06c-3.5 3.53-3.47 9.23.06 12.73l31.18 30.88L21.19 95.5c-3.5 3.53-3.47 9.23.06 12.73a8.95 8.95 0 0 0 6.33 2.61c2.32 0 4.63-.89 6.39-2.67l30.89-31.18l31.18 30.88a8.95 8.95 0 0 0 6.33 2.61c2.32 0 4.63-.89 6.39-2.67c3.51-3.53 3.48-9.23-.05-12.73z"/><use href="#notoCrossMarkButton0" opacity=".35"/>\`
 }

//
// Rotate by 90 degrees using splitSVGDefs() and mergeDefsAndContent()
//

// Extract defs
const defs = splitSVGDefs(icon.body);

/*
 {
  defs: '<path id="notoCrossMarkButton0" fill="#ABC884" d="M40.16 12.86c0-2.3-1.6-3-10.8-2.7c-7.7.3-11.5 1.2-13.8 4s-2.9 8.5-3 15.3c0 4.8 0 9.3 2.5 9.3c3.4 0 3.4-7.9 6.2-12.3c5.4-8.7 18.9-10.6 18.9-13.6z" opacity=".65"/>',
  content: '<path fill="#689F38" d="M116.46 3.96h-104c-4.42 0-8 3.58-8 8v104c0 4.42 3.58 8 8 8h104c4.42 0 8-3.58 8-8v-104c0-4.42-3.58-8-8-8z"/><path fill="#7CB342" d="M110.16 3.96h-98.2a7.555 7.555 0 0 0-7.5 7.5v97.9c-.01 4.14 3.34 7.49 7.48 7.5h98.12c4.14.01 7.49-3.34 7.5-7.48V11.46c.09-4.05-3.13-7.41-7.18-7.5h-.22z"/><use href="#notoCrossMarkButton0" opacity=".65"/><path fill="#FBF9F9" d="M108.71 95.08L77.54 64.2l30.88-31.17c3.5-3.53 3.47-9.23-.06-12.73s-9.23-3.47-12.73.06L64.75 51.53L33.57 20.65c-3.53-3.5-9.23-3.47-12.73.06c-3.5 3.53-3.47 9.23.06 12.73l31.18 30.88L21.19 95.5c-3.5 3.53-3.47 9.23.06 12.73a8.95 8.95 0 0 0 6.33 2.61c2.32 0 4.63-.89 6.39-2.67l30.89-31.18l31.18 30.88a8.95 8.95 0 0 0 6.33 2.61c2.32 0 4.63-.89 6.39-2.67c3.51-3.53 3.48-9.23-.05-12.73z"/><use href="#notoCrossMarkButton0" opacity=".35"/>'
 }
 */

// Rotate icon by 90 degrees, relative to the middle of icon
const rotatedBody = \`<g transform="rotate(90 64 64)">${defs.content}</g>\`;

// Merge it
const mergedBody = mergeDefsAndContent(defs.defs, rotatedBody);

/*
 <defs><path id="notoCrossMarkButton0" fill="#ABC884" d="M40.16 12.86c0-2.3-1.6-3-10.8-2.7c-7.7.3-11.5 1.2-13.8 4s-2.9 8.5-3 15.3c0 4.8 0 9.3 2.5 9.3c3.4 0 3.4-7.9 6.2-12.3c5.4-8.7 18.9-10.6 18.9-13.6z" opacity=".65"/></defs><g transform="rotate(90 64 64)"><path fill="#689F38" d="M116.46 3.96h-104c-4.42 0-8 3.58-8 8v104c0 4.42 3.58 8 8 8h104c4.42 0 8-3.58 8-8v-104c0-4.42-3.58-8-8-8z"/><path fill="#7CB342" d="M110.16 3.96h-98.2a7.555 7.555 0 0 0-7.5 7.5v97.9c-.01 4.14 3.34 7.49 7.48 7.5h98.12c4.14.01 7.49-3.34 7.5-7.48V11.46c.09-4.05-3.13-7.41-7.18-7.5h-.22z"/><use href="#notoCrossMarkButton0" opacity=".65"/><path fill="#FBF9F9" d="M108.71 95.08L77.54 64.2l30.88-31.17c3.5-3.53 3.47-9.23-.06-12.73s-9.23-3.47-12.73.06L64.75 51.53L33.57 20.65c-3.53-3.5-9.23-3.47-12.73.06c-3.5 3.53-3.47 9.23.06 12.73l31.18 30.88L21.19 95.5c-3.5 3.53-3.47 9.23.06 12.73a8.95 8.95 0 0 0 6.33 2.61c2.32 0 4.63-.89 6.39-2.67l30.89-31.18l31.18 30.88a8.95 8.95 0 0 0 6.33 2.61c2.32 0 4.63-.89 6.39-2.67c3.51-3.53 3.48-9.23-.05-12.73z"/><use href="#notoCrossMarkButton0" opacity=".35"/></g>
 */

// Update icon
const newIcon1 = {
    ...icon,
    body: mergedBody
 }

//
// Rotate by 90 degrees using wrapSVGContent()
//
const newIcon2 = {
    ...icon,
    body: wrapSVGContent(icon.body, '<g transform="rotate(90 64 64)">', '</g>')
 }

// newIcon1 and newIcon2 are identical
```

[Page 213](https://iconify.design/docs/libraries/utils/wrap-svg-content.html "Current Page.")

## wrapSVGContent()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function wrapSVGContent() wraps icon body in custom code.

It is used by [iconToSVG()](https://iconify.design/docs/libraries/utils/icon-to-svg.html "iconToSVG() documentation") to apply flip and rotation to icon, by [buildParsedSVG()](https://iconify.design/docs/libraries/utils/build-parsed-svg.html "buildParsedSVG() documentation") and [convertParsedSVG()](https://iconify.design/docs/libraries/utils/convert-parsed-svg.html "convertParsedSVG() documentation") to move presentational attributes from <svg> element to a group element.

## Usage

This function has the following parameters:

- body, string. Icon content.
- start, string. Start of wrapper, such as <g>.
- end, string. End of wrapper, such as </g>.

This function extracts definitions from icon content, merges the rest of icon as "start + content + end", merges it with previously extracted definitions.

## Example

ts
```
import type { IconifyIcon } from '@iconify/types';
import { splitSVGDefs, mergeDefsAndContent, wrapSVGContent } from '@iconify/utils';

// Source icon, which contains definitions block
// This code works for icons without definitions block too, so no need to check if an icon actually has <defs>
const icon: IconifyIcon = {
    width: 128,
    height: 128,
    body: \`<defs><path id="notoCrossMarkButton0" fill="#ABC884" d="M40.16 12.86c0-2.3-1.6-3-10.8-2.7c-7.7.3-11.5 1.2-13.8 4s-2.9 8.5-3 15.3c0 4.8 0 9.3 2.5 9.3c3.4 0 3.4-7.9 6.2-12.3c5.4-8.7 18.9-10.6 18.9-13.6z" opacity=".65"/></defs><path fill="#689F38" d="M116.46 3.96h-104c-4.42 0-8 3.58-8 8v104c0 4.42 3.58 8 8 8h104c4.42 0 8-3.58 8-8v-104c0-4.42-3.58-8-8-8z"/><path fill="#7CB342" d="M110.16 3.96h-98.2a7.555 7.555 0 0 0-7.5 7.5v97.9c-.01 4.14 3.34 7.49 7.48 7.5h98.12c4.14.01 7.49-3.34 7.5-7.48V11.46c.09-4.05-3.13-7.41-7.18-7.5h-.22z"/><use href="#notoCrossMarkButton0" opacity=".65"/><path fill="#FBF9F9" d="M108.71 95.08L77.54 64.2l30.88-31.17c3.5-3.53 3.47-9.23-.06-12.73s-9.23-3.47-12.73.06L64.75 51.53L33.57 20.65c-3.53-3.5-9.23-3.47-12.73.06c-3.5 3.53-3.47 9.23.06 12.73l31.18 30.88L21.19 95.5c-3.5 3.53-3.47 9.23.06 12.73a8.95 8.95 0 0 0 6.33 2.61c2.32 0 4.63-.89 6.39-2.67l30.89-31.18l31.18 30.88a8.95 8.95 0 0 0 6.33 2.61c2.32 0 4.63-.89 6.39-2.67c3.51-3.53 3.48-9.23-.05-12.73z"/><use href="#notoCrossMarkButton0" opacity=".35"/>\`
 }

//
// Rotate by 90 degrees using splitSVGDefs() and mergeDefsAndContent()
//

// Extract defs
const defs = splitSVGDefs(icon.body);

/*
 {
  defs: '<path id="notoCrossMarkButton0" fill="#ABC884" d="M40.16 12.86c0-2.3-1.6-3-10.8-2.7c-7.7.3-11.5 1.2-13.8 4s-2.9 8.5-3 15.3c0 4.8 0 9.3 2.5 9.3c3.4 0 3.4-7.9 6.2-12.3c5.4-8.7 18.9-10.6 18.9-13.6z" opacity=".65"/>',
  content: '<path fill="#689F38" d="M116.46 3.96h-104c-4.42 0-8 3.58-8 8v104c0 4.42 3.58 8 8 8h104c4.42 0 8-3.58 8-8v-104c0-4.42-3.58-8-8-8z"/><path fill="#7CB342" d="M110.16 3.96h-98.2a7.555 7.555 0 0 0-7.5 7.5v97.9c-.01 4.14 3.34 7.49 7.48 7.5h98.12c4.14.01 7.49-3.34 7.5-7.48V11.46c.09-4.05-3.13-7.41-7.18-7.5h-.22z"/><use href="#notoCrossMarkButton0" opacity=".65"/><path fill="#FBF9F9" d="M108.71 95.08L77.54 64.2l30.88-31.17c3.5-3.53 3.47-9.23-.06-12.73s-9.23-3.47-12.73.06L64.75 51.53L33.57 20.65c-3.53-3.5-9.23-3.47-12.73.06c-3.5 3.53-3.47 9.23.06 12.73l31.18 30.88L21.19 95.5c-3.5 3.53-3.47 9.23.06 12.73a8.95 8.95 0 0 0 6.33 2.61c2.32 0 4.63-.89 6.39-2.67l30.89-31.18l31.18 30.88a8.95 8.95 0 0 0 6.33 2.61c2.32 0 4.63-.89 6.39-2.67c3.51-3.53 3.48-9.23-.05-12.73z"/><use href="#notoCrossMarkButton0" opacity=".35"/>'
 }
 */

// Rotate icon by 90 degrees, relative to the middle of icon
const rotatedBody = \`<g transform="rotate(90 64 64)">${defs.content}</g>\`;

// Merge it
const mergedBody = mergeDefsAndContent(defs.defs, rotatedBody);

/*
 <defs><path id="notoCrossMarkButton0" fill="#ABC884" d="M40.16 12.86c0-2.3-1.6-3-10.8-2.7c-7.7.3-11.5 1.2-13.8 4s-2.9 8.5-3 15.3c0 4.8 0 9.3 2.5 9.3c3.4 0 3.4-7.9 6.2-12.3c5.4-8.7 18.9-10.6 18.9-13.6z" opacity=".65"/></defs><g transform="rotate(90 64 64)"><path fill="#689F38" d="M116.46 3.96h-104c-4.42 0-8 3.58-8 8v104c0 4.42 3.58 8 8 8h104c4.42 0 8-3.58 8-8v-104c0-4.42-3.58-8-8-8z"/><path fill="#7CB342" d="M110.16 3.96h-98.2a7.555 7.555 0 0 0-7.5 7.5v97.9c-.01 4.14 3.34 7.49 7.48 7.5h98.12c4.14.01 7.49-3.34 7.5-7.48V11.46c.09-4.05-3.13-7.41-7.18-7.5h-.22z"/><use href="#notoCrossMarkButton0" opacity=".65"/><path fill="#FBF9F9" d="M108.71 95.08L77.54 64.2l30.88-31.17c3.5-3.53 3.47-9.23-.06-12.73s-9.23-3.47-12.73.06L64.75 51.53L33.57 20.65c-3.53-3.5-9.23-3.47-12.73.06c-3.5 3.53-3.47 9.23.06 12.73l31.18 30.88L21.19 95.5c-3.5 3.53-3.47 9.23.06 12.73a8.95 8.95 0 0 0 6.33 2.61c2.32 0 4.63-.89 6.39-2.67l30.89-31.18l31.18 30.88a8.95 8.95 0 0 0 6.33 2.61c2.32 0 4.63-.89 6.39-2.67c3.51-3.53 3.48-9.23-.05-12.73z"/><use href="#notoCrossMarkButton0" opacity=".35"/></g>
 */

// Update icon
const newIcon1 = {
    ...icon,
    body: mergedBody
 }

//
// Rotate by 90 degrees using wrapSVGContent()
//
const newIcon2 = {
    ...icon,
    body: wrapSVGContent(icon.body, '<g transform="rotate(90 64 64)">', '</g>')
 }

// newIcon1 and newIcon2 are identical
```

[Page 214](https://iconify.design/docs/libraries/utils/get-icon-css.html "Current Page.")

## getIconCSS()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function getIconCSS() generates stylesheet to render an icon as a background or mask image.

It generates code only for one icon. To generate code for multiple icons at the same time, see [getIconsCSS()](https://iconify.design/docs/libraries/utils/get-icons-css.html "getIconsCSS() documentation").

If instead of using icon as a background or mask image, you want to use icon as content of a pseudo-element, see [getIconContentCSS()](https://iconify.design/docs/libraries/utils/get-icon-content-css.html "getIconContentCSS() documentation").

To use icon in HTML, all you need to do is create any element, such as <span> with class name that you passed in iconSelector option.

## Color

Monotone icons are rendered as mask image with background color set to currentColor. That means icon will use same color as text.

To change icon color, simply change text color.

Monotone icon used as mask: (hover to see color change)

Icons with palette used as background:

Icons with palette are rendered as background image.

You can also use color option to convert monotone icon to icon with palette. See "Color option" section below.

## Usage

Function has the following parameters:

- icon, [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation"). Icon data.
- options. Options object, optional.

Function returns string with stylesheet for icon.

## Options

The options object has the following properties:

- iconSelector, string. Selector for icon, defaults to ".icon".
- pseudoSelector, boolean. Set it to true if selector for icon is a pseudo-selector, such as ".icon-home:after".
- varName, string. Name for variable to use for icon, defaults ti "svg". Set to null to disable.
- forceSquare, boolean. Forces icon to have width of 1em.
- color: string. Sets color for monotone icons. Also renders icons as background images.
- mode: "mask" or "background". Forces icon to render as mask image or background image. If not set, mode will be detected from icon content: icons that contain currentColor will be rendered as mask image, other icons as background image.
- format. Stylesheet formatting option. Matches options used in Sass. Supported values: "expanded", "compact", "compressed".
- rules, Record<string,string>. Extra rules to add to CSS.

## Result

Example of generated stylesheet:

css
```
.icon {
    display: inline-block;
    width: 1em;
    height: 1em;
    background-color: currentColor;
    -webkit-mask: no-repeat center / 100%;
    mask: no-repeat center / 100%;
    -webkit-mask-image: var(--svg);
    mask-image: var(--svg);
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cpath fill='black' d='M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5Z'/%3E%3C/svg%3E");
 }
```

That code can be used in HTML with any element, such as <span> with class name that you passed in iconSelector option:

html
```
<span class="icon"></span>
```

## Color option

Important note about color option: you cannot use CSS variables. Color is not added to style, it is changed inside icon. Icon is not inlined in HTML, it is treated as an external resource. Elements of icon cannot be targeted or styled, just like any other image linked with url(), therefore, CSS variables are not available in icon.

If you want to use a CSS variable for color, do not use color option, add color to icon in your stylesheet or inline style by changing text color:

html
```
<span class="icon" style="color: var(--icon-color)"></span>
```

## Examples

Generating CSS for a monotone icon:

ts
```
import { getIconCSS } from '@iconify/utils';

// Icon data. This example uses monotone icon that will be used as mask-image
const iconData = {
    body: '<path fill="currentColor" d="M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5Z"/>',
    width: 24,
    height: 24,
 };

// Generate CSS
const css = getIconCSS(iconData, {
    iconSelector: '.icon-home',
 });

// Log stylesheet
console.log(css);
```

css
```
.icon-home {
    display: inline-block;
    width: 1em;
    height: 1em;
    background-color: currentColor;
    -webkit-mask: no-repeat center / 100%;
    mask: no-repeat center / 100%;
    -webkit-mask-image: var(--svg);
    mask-image: var(--svg);
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cpath fill='%23000' d='M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5Z'/%3E%3C/svg%3E");
 }
```

html
```
<span class="icon-home"></span>
```

Generating CSS for an icon with palette:

ts
```
import { getIconCSS } from '@iconify/utils';

// Icon data. This example uses icon with palette that will be used as background-image
const iconData = {
    body: '<path fill="#fcea2b" d="M36.2 13.3A22.8 22.8 0 1 0 59 36.1a22.79 22.79 0 0 0-22.8-22.8Z"/><path fill="#ea5a47" d="M40.5 41.7c-1.8 4.3-2 6-5.5 8.9c-5.6 4.8-7.6-4.1-5.7-8.9Z"/><g fill="none" stroke="#000"><circle cx="36" cy="36" r="23" stroke-miterlimit="10" stroke-width="2"/><path stroke-miterlimit="10" stroke-width="2" d="M40.5 42.25c-1.8 5.8-6 10.7-9 9.8s-4-4.9-2.3-10.8"/><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2.001" d="M46.8 39.7a4 4 0 0 0 0 6m-23-3c2.3-.8 6.8-1 10.5-1s8.3.2 10.5 1"/><path stroke-linecap="round" stroke-miterlimit="10" stroke-width="2" d="M48.9 32.4a4.7 4.7 0 0 0-8.6 0m-8.6 0a4.7 4.7 0 0 0-8.6 0"/></g>',
    width: 72,
    height: 72,
 };

// Generate CSS
const css = getIconCSS(iconData, {
    iconSelector: '.emoji--annoyed-face-with-tongue',
    varName: null,
 });

// Log stylesheet
console.log(css);
```

css
```
.emoji--annoyed-face-with-tongue {
    display: inline-block;
    width: 1em;
    height: 1em;
    background: no-repeat center / 100%;
    background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 72 72' width='72' height='72'%3E%3Cpath fill='%23fcea2b' d='M36.2 13.3A22.8 22.8 0 1 0 59 36.1a22.79 22.79 0 0 0-22.8-22.8Z'/%3E%3Cpath fill='%23ea5a47' d='M40.5 41.7c-1.8 4.3-2 6-5.5 8.9c-5.6 4.8-7.6-4.1-5.7-8.9Z'/%3E%3Cg fill='none' stroke='%23000'%3E%3Ccircle cx='36' cy='36' r='23' stroke-miterlimit='10' stroke-width='2'/%3E%3Cpath stroke-miterlimit='10' stroke-width='2' d='M40.5 42.25c-1.8 5.8-6 10.7-9 9.8s-4-4.9-2.3-10.8'/%3E%3Cpath stroke-linecap='round' stroke-linejoin='round' stroke-width='2.001' d='M46.8 39.7a4 4 0 0 0 0 6m-23-3c2.3-.8 6.8-1 10.5-1s8.3.2 10.5 1'/%3E%3Cpath stroke-linecap='round' stroke-miterlimit='10' stroke-width='2' d='M48.9 32.4a4.7 4.7 0 0 0-8.6 0m-8.6 0a4.7 4.7 0 0 0-8.6 0'/%3E%3C/g%3E%3C/svg%3E");
 }
```

html
```
<span class="emoji--annoyed-face-with-tongue"></span>
```

Using pseudo-element for icon:

ts
```
import { getIconCSS } from '@iconify/utils';

// Icon data. This example uses icon with 'currentColor' that will be used as mask-image
const iconData = {
    body: '<path fill="currentColor" d="m10 15.172l9.192-9.193l1.415 1.414L10 18l-6.364-6.364l1.414-1.414z"/>',
    width: 24,
    height: 24,
 };

// Generate CSS
const css = getIconCSS(iconData, {
    pseudoSelector: true,
    iconSelector: '.checkbox-checked:before',
 });

// Log stylesheet
console.log(css);
```

css
```
.checkbox-checked:before {
    display: inline-block;
    width: 1em;
    height: 1em;
    content: '';
    background-color: currentColor;
    -webkit-mask: no-repeat center / 100%;
    mask: no-repeat center / 100%;
    -webkit-mask-image: var(--svg);
    mask-image: var(--svg);
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cpath fill='%23000' d='m10 15.172l9.192-9.193l1.415 1.414L10 18l-6.364-6.364l1.414-1.414z'/%3E%3C/svg%3E");
 }
```

html
```
<a href="#" class="checkbox-checked">Checkbox (icon is shown before it)</a>
```

[Page 215](https://iconify.design/docs/libraries/utils/get-icons-css.html "Current Page.")

## getIconsCSS()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function getIconsCSS() generates stylesheet for several icons from an icon set to render them as background or mask images.

It generates code multiple icons from an icon set, splitting common code and icon-specific code. To generate code for one icon without splitting code, see [getIconCSS()](https://iconify.design/docs/libraries/utils/get-icon-css.html "getIconCSS() documentation").

If instead of using icons as background or mask images, you want to use icons as content of pseudo-elements, see [getIconsContentCSS()](https://iconify.design/docs/libraries/utils/get-icons-content-css.html "getIconsContentCSS() documentation").

To use icons in HTML, all you need to do is create any element, such as <span> with class names for an icon set and icon.

## Color

Monotone icons are rendered as mask image with background color set to currentColor. That means icon will use the same color as text.

To change icon color, simply change text color.

Monotone icon used as mask: (hover to see color change)

Icons with palette used as background:

Icons with palette are rendered as background image.

You can also use color option to convert monotone icon to icon with palette. See "Color option" section below.

## Usage

Function has the following parameters:

- iconSet, [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation"). Icon set data.
- names, string\[\]. Array of icon names.
- options. Options object, optional.

Function returns string with stylesheet for icons.

## Options

The options object has the following properties:

- iconSelector, string. Selector for icon, defaults to ".icon--{prefix}--{name}". Variable "{prefix}" is replaced with icon set prefix, "{name}" with icon name.
- commonSelector, string. Common selector for icons, defaults to ".icon--{prefix}". Set it to empty to disable common code (see one of examples below). Variable "{prefix}" is replaced with icon set prefix.
- overrideSelector, string. Selector that mixes iconSelector and commonSelector to generate icon specific style that overrides common style. See below. Default value is ".icon--{prefix}.icon--{prefix}--{name}".
- pseudoSelector, boolean. Set it to true if selector for icon is a pseudo-selector, such as ".icon--{prefix}--{name}::after".
- varName, string. Name for variable to use for icon, defaults to "svg" for monotone icons, null for icons with palette. Set to null to disable.
- forceSquare, boolean. Forces icon to have width of 1em.
- color: string. Sets color for monotone icons. Also renders icons as background images.
- mode: "mask" or "background". Forces icon to render as mask image or background image. If not set, mode will be detected from icon content: icons that contain currentColor will be rendered as mask image, other icons as background image.
- format. Stylesheet formatting option. Matches options used in Sass. Supported values: "expanded", "compact", "compressed".
- rules, Record<string,string>. Extra rules to add to CSS.

## Result

Example of generated stylesheet:

css
```
/* Common code is combined in one class that should be added to each icon */
.icon--tabler {
    display: inline-block;
    width: 1em;
    height: 1em;
    background-color: currentColor;
    -webkit-mask: no-repeat center / 100%;
    mask: no-repeat center / 100%;
    -webkit-mask-image: var(--svg);
    mask-image: var(--svg);
 }

/* SVG for each icon. Class name should be combined with common class name used above */
.icon--tabler--code {
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cpath fill='none' stroke='black' stroke-linecap='round' stroke-linejoin='round' stroke-width='2' d='m7 8l-4 4l4 4m10-8l4 4l-4 4M14 4l-4 16'/%3E%3C/svg%3E");
 }

.icon--tabler--crystal-ball {
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cg fill='none' stroke='black' stroke-linecap='round' stroke-linejoin='round' stroke-width='2'%3E%3Cpath d='M6.73 17.018a8 8 0 1 1 10.54 0'/%3E%3Cpath d='M5 19a2 2 0 0 0 2 2h10a2 2 0 1 0 0-4H7a2 2 0 0 0-2 2zm6-12a3 3 0 0 0-3 3'/%3E%3C/g%3E%3C/svg%3E");
 }

.icon--tabler--view-360 {
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cg fill='none' stroke='black' stroke-linecap='round' stroke-linejoin='round' stroke-width='2'%3E%3Ccircle cx='12' cy='12' r='9'/%3E%3Cellipse cx='12' cy='12' rx='4' ry='9'/%3E%3Cpath d='M3 12c0 2.21 4.03 4 9 4s9-1.79 9-4s-4.03-4-9-4s-9 1.79-9 4z'/%3E%3C/g%3E%3C/svg%3E");
 }
```

That code can be used in HTML with any element, such as <span> with class names for both common code and icon specific code:

html
```
<span class="icon--tabler icon--tabler--code"></span>
```

## Color option

Important note about color option: you cannot use CSS variables. Color is not added to style, it is changed inside icon. Icon is not inlined in HTML, it is treated as an external resource. Elements of icon cannot be targeted or styled, just like any other image linked with url(), therefore, CSS variables are not available in icon.

If you want to use a CSS variable for color, do not use color option, add color to icon in your stylesheet or inline style by changing text color:

html
```
<span
    class="icon--tabler icon--tabler--view-360"
    style="color: var(--icon-color)"
 ></span>
```

## Selectors

### Simple selector

If you want to change selectors to something simple, like ".icon-home" for "home" icon, use the following options:

json
```
{
    "iconSelector": ".icon-{name}",
    "commonSelector": ""
}
```

It will result in stylesheet like this:

css
```
.icon-code,
.icon-crystal-ball,
.icon-view-360 {
    display: inline-block;
    width: 1em;
    height: 1em;
    background-color: currentColor;
    -webkit-mask: no-repeat center / 100%;
    mask: no-repeat center / 100%;
    -webkit-mask-image: var(--svg);
    mask-image: var(--svg);
 }

.icon-code {
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cpath fill='none' stroke='black' stroke-linecap='round' stroke-linejoin='round' stroke-width='2' d='m7 8l-4 4l4 4m10-8l4 4l-4 4M14 4l-4 16'/%3E%3C/svg%3E");
 }

.icon-crystal-ball {
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cg fill='none' stroke='black' stroke-linecap='round' stroke-linejoin='round' stroke-width='2'%3E%3Cpath d='M6.73 17.018a8 8 0 1 1 10.54 0'/%3E%3Cpath d='M5 19a2 2 0 0 0 2 2h10a2 2 0 1 0 0-4H7a2 2 0 0 0-2 2zm6-12a3 3 0 0 0-3 3'/%3E%3C/g%3E%3C/svg%3E");
 }

.icon-view-360 {
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cg fill='none' stroke='black' stroke-linecap='round' stroke-linejoin='round' stroke-width='2'%3E%3Ccircle cx='12' cy='12' r='9'/%3E%3Cellipse cx='12' cy='12' rx='4' ry='9'/%3E%3Cpath d='M3 12c0 2.21 4.03 4 9 4s9-1.79 9-4s-4.03-4-9-4s-9 1.79-9 4z'/%3E%3C/g%3E%3C/svg%3E");
 }
```

### Old browsers

If you need to support ancient browsers that do not support variables, set varName to null:

json
```
{
    "varName": null
}
```

It will result in CSS like this:

css
```
.icon--tabler {
    display: inline-block;
    width: 1em;
    height: 1em;
    background-color: currentColor;
    -webkit-mask: no-repeat center / 100%;
    mask: no-repeat center / 100%;
 }

.icon--tabler--code {
    -webkit-mask-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cpath fill='none' stroke='black' stroke-linecap='round' stroke-linejoin='round' stroke-width='2' d='m7 8l-4 4l4 4m10-8l4 4l-4 4M14 4l-4 16'/%3E%3C/svg%3E");
    mask-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cpath fill='none' stroke='black' stroke-linecap='round' stroke-linejoin='round' stroke-width='2' d='m7 8l-4 4l4 4m10-8l4 4l-4 4M14 4l-4 16'/%3E%3C/svg%3E");
 }

.icon--tabler--crystal-ball {
    -webkit-mask-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cg fill='none' stroke='black' stroke-linecap='round' stroke-linejoin='round' stroke-width='2'%3E%3Cpath d='M6.73 17.018a8 8 0 1 1 10.54 0'/%3E%3Cpath d='M5 19a2 2 0 0 0 2 2h10a2 2 0 1 0 0-4H7a2 2 0 0 0-2 2zm6-12a3 3 0 0 0-3 3'/%3E%3C/g%3E%3C/svg%3E");
    mask-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cg fill='none' stroke='black' stroke-linecap='round' stroke-linejoin='round' stroke-width='2'%3E%3Cpath d='M6.73 17.018a8 8 0 1 1 10.54 0'/%3E%3Cpath d='M5 19a2 2 0 0 0 2 2h10a2 2 0 1 0 0-4H7a2 2 0 0 0-2 2zm6-12a3 3 0 0 0-3 3'/%3E%3C/g%3E%3C/svg%3E");
 }
```

With monotone icons it will cause duplication because some browsers still require prefix for masks.

Not needed for icons for palette because default value for icons with palette is null (see example below that uses icons with palette).

### Wide and thin icons

Not all icons are square. Some icon sets use variable width for icons, this mostly applies to icon sets that were designed to be used as fonts.

By default, common code will have width set to 1em and it will be overridden by using selectors with higher specificity for each icon:

css
```
.icon--fa6-solid {
    display: inline-block;
    width: 1em;
    height: 1em;
    background-color: currentColor;
    -webkit-mask: no-repeat center / 100%;
    mask: no-repeat center / 100%;
    -webkit-mask-image: var(--svg);
    mask-image: var(--svg);
 }

.icon--fa6-solid.icon--fa6-solid--angle-left {
    width: 0.63em;
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 320 512' width='320' height='512'%3E%3Cpath fill='black' d='M41.4 233.4c-12.5 12.5-12.5 32.8 0 45.3l160 160c12.5 12.5 32.8 12.5 45.3 0s12.5-32.8 0-45.3L109.3 256l137.3-137.4c12.5-12.5 12.5-32.8 0-45.3s-32.8-12.5-45.3 0l-160 160z'/%3E%3C/svg%3E");
 }

.icon--fa6-solid.icon--fa6-solid--arrow-left {
    width: 0.88em;
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 448 512' width='448' height='512'%3E%3Cpath fill='black' d='M9.4 233.4c-12.5 12.5-12.5 32.8 0 45.3l160 160c12.5 12.5 32.8 12.5 45.3 0s12.5-32.8 0-45.3L109.2 288H416c17.7 0 32-14.3 32-32s-14.3-32-32-32H109.3l105.3-105.4c12.5-12.5 12.5-32.8 0-45.3s-32.8-12.5-45.3 0l-160 160z'/%3E%3C/svg%3E");
 }
```

But what if you want icons to be square? Use forceSquare option:

json
```
{
    "forceSquare": true
}
```

css
```
.icon--fa6-solid {
    display: inline-block;
    width: 1em;
    height: 1em;
    background-color: currentColor;
    -webkit-mask: no-repeat center / 100%;
    mask: no-repeat center / 100%;
    -webkit-mask-image: var(--svg);
    mask-image: var(--svg);
 }

.icon--fa6-solid--angle-left {
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 320 512' width='320' height='512'%3E%3Cpath fill='black' d='M41.4 233.4c-12.5 12.5-12.5 32.8 0 45.3l160 160c12.5 12.5 32.8 12.5 45.3 0s12.5-32.8 0-45.3L109.3 256l137.3-137.4c12.5-12.5 12.5-32.8 0-45.3s-32.8-12.5-45.3 0l-160 160z'/%3E%3C/svg%3E");
 }

.icon--fa6-solid--arrow-left {
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 448 512' width='448' height='512'%3E%3Cpath fill='black' d='M9.4 233.4c-12.5 12.5-12.5 32.8 0 45.3l160 160c12.5 12.5 32.8 12.5 45.3 0s12.5-32.8 0-45.3L109.2 288H416c17.7 0 32-14.3 32-32s-14.3-32-32-32H109.3l105.3-105.4c12.5-12.5 12.5-32.8 0-45.3s-32.8-12.5-45.3 0l-160 160z'/%3E%3C/svg%3E");
 }
```

### Custom selectors

If you want to use custom selectors, such as ".iconify-{name}" for icons, specify 3 options:

- iconSelector with value for icons, where you can use "{prefix}" for icon set prefix and "{name}" for icon name.
- commonSelector with value for common code, where you can use "{prefix}" for icon set prefix. You can set it to empty or same value as iconSelector.
- overrideSelector with value for mix of selectors. Why is it a separate option? In case if mix selector is different from simply combining common and icon selectors.

If you set only iconSelector, other 2 options will be ignored.

Examples:

#### Using only 1 option

json
```
{
    "iconSelector": ".iconify-{name}"
}
```

Results in:

css
```
.iconify-alien,
.iconify-balance-scale {
    display: inline-block;
    width: 1em;
    height: 1em;
    background: no-repeat center / 100%;
 }

.iconify-alien {
    background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 32 32' width='32' height='32'%3E%3Cg fill='none'%3E%3Cpath fill='%2386D72F' d='M29.84 15.92C29.84 23.61 18.92 30 15.92 30S2 23.61 2 15.92S8.23 2 15.92 2c7.69 0 13.92 6.23 13.92 13.92Z'/%3E%3Cpath fill='%23212121' d='M13.368 24.225a1 1 0 0 1 1.407.143c.376.461.825.645 1.225.645c.4 0 .85-.184 1.225-.645a1 1 0 1 1 1.55 1.264c-.724.889-1.726 1.38-2.775 1.38c-1.05 0-2.05-.491-2.775-1.38a1 1 0 0 1 .143-1.407Z'/%3E%3Cpath fill='%23533566' d='M6.474 19.527c2.254 2.253 4.6 3.549 6.845 1.306c2.253-2.242 2.233-5.905-.01-8.147c-2.244-2.243-5.898-2.253-8.142 0c-2.243 2.253-.946 4.588 1.307 6.84Zm19.051 0c-2.255 2.253-4.602 3.549-6.847 1.306c-2.244-2.242-2.234-5.905.01-8.147c2.245-2.243 5.9-2.253 8.144 0c2.245 2.253.947 4.588-1.307 6.84Z'/%3E%3Cpath fill='%23fff' d='M12.62 15.62c.61-.61.47-1.73-.31-2.51c-.78-.77-1.9-.92-2.51-.31c-.61.61-.47 1.73.31 2.51c.78.78 1.9.92 2.51.31Zm13.28 0c.61-.61.47-1.73-.31-2.51c-.77-.77-1.9-.92-2.51-.31c-.61.61-.47 1.73.31 2.51c.78.78 1.9.92 2.51.31Z'/%3E%3C/g%3E%3C/svg%3E");
 }

.iconify-balance-scale {
    background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 32 32' width='32' height='32'%3E%3Cg fill='none'%3E%3Cpath fill='%239B9B9B' d='M19.949 11.75h4.02a.749.749 0 1 0 0-1.5h-4.02c-.38 0-.73-.18-.95-.48l-2.37-3.25a.765.765 0 0 0-.705-.296a.747.747 0 0 0-.585.306l-2.37 3.24c-.22.3-.58.48-.95.48h-4.02c-.41 0-.75.34-.75.75s.34.75.75.75h4.02c.85 0 1.66-.41 2.16-1.09l1.809-2.473l1.801 2.463c.5.69 1.31 1.1 2.16 1.1Z'/%3E%3Cpath fill='%23D3D3D3' d='M15.249 4h1.5v24h-1.5V4Zm-2.21 16.73c.09.15.26.23.42.23c.09 0 .18-.02.24-.08a.5.5 0 0 0 .15-.69l-5.372-8.338A.494.494 0 0 0 8 11.5c-.16 0-.45.27-.45.27l-5.39 8.38c-.07.08-.11.19-.11.31c0 .28.22.5.5.5c.17 0 .33-.09.42-.23l4.53-7.034V20.8c0 .28.22.5.5.5s.5-.22.5-.5v-7.105l4.54 7.035Zm16 0c.09.15.26.23.42.23c.09 0 .18-.02.24-.08a.5.5 0 0 0 .15-.69l-5.372-8.338A.494.494 0 0 0 24 11.5c-.16 0-.359.155-.45.27l-5.39 8.38c-.07.08-.11.19-.11.31c0 .28.22.5.5.5c.17 0 .33-.09.42-.23l4.53-7.034V20.8c0 .28.22.5.5.5s.5-.22.5-.5v-7.105l4.54 7.035Z'/%3E%3Cpath fill='%23F9C23C' d='M17.59 3.59a1.59 1.59 0 1 1-3.18 0a1.59 1.59 0 0 1 3.18 0Zm-8 7.41a1.59 1.59 0 1 1-3.181 0a1.59 1.59 0 0 1 3.18 0Zm-7.571 9.64c-.09-.32.15-.64.49-.64h10.98c.34 0 .58.32.49.64c-.74 2.56-3.13 4.36-5.98 4.36c-2.85 0-5.24-1.8-5.98-4.36Zm16 0c-.09-.32.15-.64.49-.64h10.98c.34 0 .58.32.49.64c-.74 2.56-3.13 4.36-5.98 4.36c-2.85 0-5.24-1.8-5.98-4.36ZM23.4 30c.48 0 .71-.58.36-.91A11.216 11.216 0 0 0 16 26c-3.01 0-5.74 1.17-7.76 3.09c-.35.33-.12.91.36.91h14.8Zm.6-17.41a1.59 1.59 0 1 0-.001-3.18a1.59 1.59 0 0 0 0 3.18Z'/%3E%3C/g%3E%3C/svg%3E");
 }
```

### Pseudo-selector

This example shows why overrideSelector is an option and how to render icons with pseudo-selectors:

json
```
{
    "iconSelector": ".icon--{prefix}--{name}::after",
    "commonSelector": ".icon--{prefix}::after",
    "overrideSelector": ".icon--{prefix}.icon--{prefix}--{name}::after",
    "pseudoSelector": true
}
```

css
```
.icon--fa6-solid::after {
    display: inline-block;
    width: 1em;
    height: 1em;
    content: '';
    background-color: currentColor;
    -webkit-mask: no-repeat center / 100%;
    mask: no-repeat center / 100%;
    -webkit-mask-image: var(--svg);
    mask-image: var(--svg);
 }

.icon--fa6-solid.icon--fa6-solid--angle-left::after {
    width: 0.63em;
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 320 512' width='320' height='512'%3E%3Cpath fill='black' d='M41.4 233.4c-12.5 12.5-12.5 32.8 0 45.3l160 160c12.5 12.5 32.8 12.5 45.3 0s12.5-32.8 0-45.3L109.3 256l137.3-137.4c12.5-12.5 12.5-32.8 0-45.3s-32.8-12.5-45.3 0l-160 160z'/%3E%3C/svg%3E");
 }

.icon--fa6-solid.icon--fa6-solid--arrow-left::after {
    width: 0.88em;
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 448 512' width='448' height='512'%3E%3Cpath fill='black' d='M9.4 233.4c-12.5 12.5-12.5 32.8 0 45.3l160 160c12.5 12.5 32.8 12.5 45.3 0s12.5-32.8 0-45.3L109.2 288H416c17.7 0 32-14.3 32-32s-14.3-32-32-32H109.3l105.3-105.4c12.5-12.5 12.5-32.8 0-45.3s-32.8-12.5-45.3 0l-160 160z'/%3E%3C/svg%3E");
 }
```

## Example

Above examples show various options. This example shows actual code with options:

ts
```
import { readFile } from 'node:fs/promises';
import { getIconsCSS } from '@iconify/utils';

// Read icon set from 'tabler.json', parse JSON file
const iconSet = JSON.parse(await readFile('./tabler.json', 'utf8'));

// Get CSS for 3 icons
const css = getIconsCSS(iconSet, ['code', 'crystal-ball', 'view-360']);

// Log it
console.log(css);
```

css
```
.icon--tabler {
    display: inline-block;
    width: 1em;
    height: 1em;
    background-color: currentColor;
    -webkit-mask: no-repeat center / 100%;
    mask: no-repeat center / 100%;
    -webkit-mask-image: var(--svg);
    mask-image: var(--svg);
 }

.icon--tabler--code {
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cpath fill='none' stroke='%23000' stroke-linecap='round' stroke-linejoin='round' stroke-width='2' d='m7 8l-4 4l4 4m10-8l4 4l-4 4M14 4l-4 16'/%3E%3C/svg%3E");
 }

.icon--tabler--crystal-ball {
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cg fill='none' stroke='%23000' stroke-linecap='round' stroke-linejoin='round' stroke-width='2'%3E%3Cpath d='M6.73 17.018a8 8 0 1 1 10.54 0'/%3E%3Cpath d='M5 19a2 2 0 0 0 2 2h10a2 2 0 1 0 0-4H7a2 2 0 0 0-2 2zm6-12a3 3 0 0 0-3 3'/%3E%3C/g%3E%3C/svg%3E");
 }

.icon--tabler--view-360 {
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cg fill='none' stroke='%23000' stroke-linecap='round' stroke-linejoin='round' stroke-width='2'%3E%3Ccircle cx='12' cy='12' r='9'/%3E%3Cellipse cx='12' cy='12' rx='4' ry='9'/%3E%3Cpath d='M3 12c0 2.21 4.03 4 9 4s9-1.79 9-4s-4.03-4-9-4s-9 1.79-9 4z'/%3E%3C/g%3E%3C/svg%3E");
 }
```

html
```
<p>Code icon: <span class="icon--tabler icon--tabler--code"></span></p>
<p>
    Crystal ball icon:
    <span class="icon--tabler icon--tabler--crystal-ball"></span>
</p>
<p>
    360&deg; view icon: <span class="icon--tabler icon--tabler--view-360"></span>
</p>
```

[Page 216](https://iconify.design/docs/libraries/utils/get-icon-content-css.html "Current Page.")

## getIconContentCSS()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function getIconContentCSS() generates stylesheet to render an icon as content of pseudo-element.

It generates code only for one icon. To generate code for multiple icons at the same time, see [getIconsContentCSS()](https://iconify.design/docs/libraries/utils/get-icons-content-css.html "getIconsContentCSS() documentation").

If, instead of using icon as content of a pseudo-element, you want to use icon as a background or mask image, see [getIconCSS()](https://iconify.design/docs/libraries/utils/get-icon-css.html "getIconCSS() documentation").

To use icon in HTML, all you need to do is create any element, such as <span> with class name that you passed in iconSelector option.

## Color and size

When using icon as content of pseudo-element, currentColor cannot be used, so icon must have a hardcoded color.

Icon also must have fixed dimensions, which cannot be changed in CSS.

If you want to use an icon with currentColor in CSS or want to resize icon using CSS, you should use [getIconCSS()](https://iconify.design/docs/libraries/utils/get-icon-css.html "getIconCSS() documentation") instead.

## Usage

Function has the following parameters:

- icon, [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation"). Icon data.
- options. Options object.

Function returns string with stylesheet for icon.

## Options

The options object has the following properties:

- height, number. Icon height. Required.
- width, number. Icon width, optional. If not set, it is calculated using icon's width/height ratio and height option.
- color, string. Color to replace currentColor with. This should be used to change color of monotone icon, otherwise icon will be rendered black.
- iconSelector, string. Selector for icon, defaults to ".icon::after".
- format. Stylesheet formatting option. Matches options used in Sass. Supported values: "expanded", "compact", "compressed".
- rules, Record<string,string>. Extra rules to add to CSS.

## Result

Example of generated stylesheet:

css
```
.icon::after {
    content: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cpath fill='black' d='M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5Z'/%3E%3C/svg%3E");
 }
```

That code can be used in HTML with any element, such as <span> with class name that you passed in iconSelector option:

html
```
<span class="icon"></span>
```

## Color option

Important note about color option: you cannot use CSS variables. Color is not added to style, it is changed inside icon. Icon is not inlined in HTML, it is treated as an external resource. Elements of icon cannot be targeted or styled, just like any other image linked with url(), therefore, CSS variables are not available in icon.

## Example

ts
```
import { getIconContentCSS } from '@iconify/utils';

// Icon data
const iconData = {
    body: '<path fill="currentColor" d="M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5Z"/>',
    width: 24,
    height: 24,
 };

// Generate CSS
const css = getIconContentCSS(iconData, {
    iconSelector: '.icon-home::after',
    height: 24, // Required
    color: '#f00' // Changes \`currentColor\` to \`#f00\`
 });

// Log stylesheet
console.log(css);
```

css
```
.icon-home::after {
    content: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cpath fill='%23f00' d='M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5Z'/%3E%3C/svg%3E");
 }
```

html
```
<span class="icon-home"></span>
```

[Page 217](https://iconify.design/docs/libraries/utils/get-icons-content-css.html "Current Page.")

## getIconsCSS()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function [getIconsCSS()](https://iconify.design/docs/libraries/utils/get-icons-css.html "getIconsCSS() documentation") generates stylesheet for several icons from an icon set to render them as background or mask images.

It generates code multiple icons from an icon set, splitting common code and icon-specific code. To generate code for one icon without splitting code, see [getIconContentCSS()](https://iconify.design/docs/libraries/utils/get-icon-content-css.html "getIconContentCSS() documentation").

If, instead of using icons as content of a pseudo-elements, you want to use icons as background or mask images, see [getIconsCSS()](https://iconify.design/docs/libraries/utils/get-icons-css.html "getIconsCSS() documentation").

To use icons in HTML, all you need to do is create any element, such as <span> with class names for an icon set and icon.

## Color and size

When using icons as content of pseudo-elements, currentColor cannot be used, so icons must have a hardcoded color.

Icons also must have fixed dimensions, which cannot be changed in CSS.

If you want to use icons with currentColor in CSS or want to resize icons using CSS, you should use [getIconsCSS()](https://iconify.design/docs/libraries/utils/get-icons-css.html "getIconsCSS() documentation") instead.

## Usage

Function has the following parameters:

- iconSet, [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation"). Icon set data.
- names, string\[\]. Array of icon names.
- options. Options object, optional.

Function returns string with stylesheet for icons.

## Options

The options object has the following properties:

- height, number. Icon height. Required.
- width, number. Icon width, optional. If not set, it is calculated using icon's width/height ratio and height option.
- color, string. Color to replace currentColor with. This should be used to change color of monotone icon, otherwise icon will be rendered black.
- iconSelector, string. Selector for icon, defaults to ".icon--{prefix}--{name}::after". Variable "{prefix}" is replaced with icon set prefix, "{name}" with icon name.
- format. Stylesheet formatting option. Matches options used in Sass. Supported values: "expanded", "compact", "compressed".
- rules, Record<string,string>. Extra rules to add to CSS.

## Result

Example of generated stylesheet:

css
```
.icon--tabler--code::after {
    content: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cpath fill='none' stroke='black' stroke-linecap='round' stroke-linejoin='round' stroke-width='2' d='m7 8l-4 4l4 4m10-8l4 4l-4 4M14 4l-4 16'/%3E%3C/svg%3E");
 }

.icon--tabler--crystal-ball::after {
    content: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cg fill='none' stroke='black' stroke-linecap='round' stroke-linejoin='round' stroke-width='2'%3E%3Cpath d='M6.73 17.018a8 8 0 1 1 10.54 0'/%3E%3Cpath d='M5 19a2 2 0 0 0 2 2h10a2 2 0 1 0 0-4H7a2 2 0 0 0-2 2zm6-12a3 3 0 0 0-3 3'/%3E%3C/g%3E%3C/svg%3E");
 }

.icon--tabler--view-360::after {
    content: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cg fill='none' stroke='black' stroke-linecap='round' stroke-linejoin='round' stroke-width='2'%3E%3Ccircle cx='12' cy='12' r='9'/%3E%3Cellipse cx='12' cy='12' rx='4' ry='9'/%3E%3Cpath d='M3 12c0 2.21 4.03 4 9 4s9-1.79 9-4s-4.03-4-9-4s-9 1.79-9 4z'/%3E%3C/g%3E%3C/svg%3E");
 }
```

That code can be used in HTML with any element, such as <span> with class names for both common code and icon specific code:

html
```
<span class="icon--tabler--code"></span>
```

## Color option

Important note about color option: you cannot use CSS variables. Color is not added to style, it is changed inside icon. Icon is not inlined in HTML, it is treated as an external resource. Elements of icon cannot be targeted or styled, just like any other image linked with url(), therefore, CSS variables are not available in icon.

If you want to use different colors for different icons, you need to call getIconsContentCSS() multiple times with different values for the color option.

If you want to have several entries of the same monotone icon with different colors, you need to call getIconsContentCSS() multiple times with different values for the color and iconSelector options.

## Example

ts
```
import { readFile } from 'node:fs/promises';
import { getIconsContentCSS } from '@iconify/utils';

// Read icon set from 'tabler.json', parse JSON file
const iconSet = JSON.parse(await readFile('./tabler.json', 'utf8'));

// Get CSS for 3 icons
const css = getIconsContentCSS(
    iconSet,
    ['code', 'crystal-ball', 'view-360'],
    {
        height: 32
    }
 );

// Log it
console.log(css);
```

css
```
.icon--tabler--code::after {
    content: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='32' height='32'%3E%3Cpath fill='none' stroke='black' stroke-linecap='round' stroke-linejoin='round' stroke-width='2' d='m7 8l-4 4l4 4m10-8l4 4l-4 4M14 4l-4 16'/%3E%3C/svg%3E");
 }

.icon--tabler--crystal-ball::after {
    content: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='32' height='32'%3E%3Cg fill='none' stroke='black' stroke-linecap='round' stroke-linejoin='round' stroke-width='2'%3E%3Cpath d='M6.73 17.018a8 8 0 1 1 10.54 0'/%3E%3Cpath d='M5 19a2 2 0 0 0 2 2h10a2 2 0 1 0 0-4H7a2 2 0 0 0-2 2zm6-12a3 3 0 0 0-3 3'/%3E%3C/g%3E%3C/svg%3E");
 }

.icon--tabler--view-360::after {
    content: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='32' height='32'%3E%3Cg fill='none' stroke='black' stroke-linecap='round' stroke-linejoin='round' stroke-width='2'%3E%3Cpath d='M3 12a9 9 0 1 0 18 0a9 9 0 1 0-18 0'/%3E%3Cpath d='M8 12a4 9 0 1 0 8 0a4 9 0 1 0-8 0'/%3E%3Cpath d='M3 12c0 2.21 4.03 4 9 4s9-1.79 9-4s-4.03-4-9-4s-9 1.79-9 4z'/%3E%3C/g%3E%3C/svg%3E");
 }
```

html
```
<p>Code icon: <span class="icon--tabler icon--tabler--code"></span></p>
<p>
    Crystal ball icon:
    <span class="icon--tabler icon--tabler--crystal-ball"></span>
</p>
<p>
    360&deg; view icon: <span class="icon--tabler icon--tabler--view-360"></span>
</p>
```

[Page 218](https://iconify.design/docs/libraries/utils/match-name.html "Current Page.")

## matchIconName

This constant is part of [Iconify Utils package](https://iconify.design/docs/).

Constant matchIconName is used to validate all parts of icon name.

The only exception is provider. API provider can be empty, so additional check for empty provider is needed.

This constant is used by [validateIconName()](https://iconify.design/docs/libraries/utils/validate-icon.html "validateIconName() documentation").

## Usage

ts
```
import { matchIconName } from '@iconify/utils';

function checkIcon(name: string): boolean {
    return !!name.match(matchIconName);
 }

console.log(checkIcon('test-icon') ? 'passed' : 'failed');
```

[Page 219](https://iconify.design/docs/libraries/utils/string-to-icon.html "Current Page.")

## stringToIcon()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function stringToIcon() converts icon name string to [IconifyIconName](https://iconify.design/docs/libraries/utils/icon-name.html "IconifyIconName documentation") object.

## Usage

Function has the following parameters:

- value, string. Icon name.
- validate, boolean. Optional. If true, icon name will be validated using [validateIconName()](https://iconify.design/docs/libraries/utils/validate-icon.html "validateIconName() documentation").
- allowSimpleName, boolean. Optional. If true, simple names without prefix are considered valid.
- provider, string. Optional. API provider to add to icon name if provider is missing.

Function returns icon name with type [IconifyIconName](https://iconify.design/docs/libraries/utils/icon-name.html "IconifyIconName documentation") on success, null on failure.

## Example

ts
```
import { stringToIcon } from '@iconify/utils';

// { provider: '', prefix: 'mdi', name: 'home' }
console.log(stringToIcon('mdi:home'));

/* {
  provider: 'custom-api',
  prefix: 'icon-set-prefix',
  name: 'some-icon'
 } */
console.log(stringToIcon('@custom-api:icon-set-prefix:some-icon'));

// { provider: '', prefix: 'mdi', name: 'home' }
console.log(stringToIcon('mdi-home'));

// null
console.log(stringToIcon('alert'));

// null
console.log(stringToIcon('alert', true));

// { provider: '', prefix: '', name: 'alert' }
console.log(stringToIcon('alert', true, true));

// { provider: '', prefix: '', name: 'alert' } - provider is ignored because there is no prefix
console.log(stringToIcon('alert', true, true, 'test'));

// { provider: 'test', prefix: 'some-icon-set', name: 'alert' }
console.log(stringToIcon('some-icon-set:alert', true, true, 'test'));
```

[Page 220](https://iconify.design/docs/libraries/utils/validate-icon.html "Current Page.")

## validateIconName()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function validateIconName() validates icon name.

## Usage

Function has the following parameters:

- name, [IconifyIconName](https://iconify.design/docs/libraries/utils/icon-name.html "IconifyIconName documentation") |null. Icon name.
- allowSimpleName, boolean. Optional. If true, simple names without provider and prefix are considered valid.

Function returns boolean value.

## Example

ts
```
import { validateIconName } from '@iconify/utils';

// Valid names: function returns \`true\`
validateIconName({
    provider: '',
    prefix: 'mdi-light',
    name: 'home',
 });

validateIconName({
    provider: 'my-api',
    prefix: 'awesome-test',
    name: 'alert-outline',
 });

validateIconName(
    {
        provider: '',
        prefix: '',
        name: 'home',
    },
    true
 );

// Invalid names: function returns \`false\`
validateIconName({
    provider: '',
    prefix: '', // Empty prefix
    name: 'home',
 });

validateIconName({
    provider: '',
    prefix: 'my_set', // \`_\` is not allowed
    name: 'home',
 });

validateIconName(
    {
        provider: 'my-api',
        prefix: '', // prefix cannot be empty if provider is set, even if second option is \`true\`
        name: 'home',
    },
    true
 );
```

[Page 221](https://iconify.design/docs/libraries/utils/string-to-color.html "Current Page.")

## stringToColor()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function stringToColor() converts string to [Color](https://iconify.design/docs/libraries/utils/color.html "Color documentation") object, returns null on error.

This function can be used to validate user input. It supports color keywords, hexadecimal colors, RGB, HSL, LAB and LCH colors. Variables are not supported because this is meant for parsing SVGs, which should not reference any external variables.

## Usage

Function has one parameter:

- value, string. Color string.

Function returns [Color](https://iconify.design/docs/libraries/utils/color.html "Color documentation") object on success, null on error.

## Possible values

Colors that function can convert:

- Keywords, such as "red".
- Hexadecimal colors, such as "#ff0000", also in short form and with alpha.
- Few functional notations:
	- RGB: "rgba(255, 0, 0, 1)".
		- HSL: "hsla(0, 50%, 50%, 1)".
		- LAB: "lab(50% 86 40 / 1)".
		- LCH: "lch(50% 86 40 / 1)".
- Several special keywords:
	- "transparent"
		- "none"
		- "currentColor"

See [Color](https://iconify.design/docs/libraries/utils/color.html "Color documentation") type description for details.

## Examples

ts
```
import { stringToColor } from '@iconify/utils';

// { type: 'rgb', r: 128, g: 0, b: 128, alpha: 1 }
console.log(stringToColor('purple'));

// { type: 'rgb', r: 255, g: 0, b: 0, alpha: 1 }
console.log(stringToColor('#f00'));

// { type: 'rgb', r: 136, g: 32, b: 50, alpha: 0.8784313725490196 }
console.log(stringToColor('#882032E0'));

// { type: 'rgb', r: 255, g: 48, b: 0, alpha: 0.5 }
console.log(stringToColor('rgba(255, 48, 0, 0.5)'));

// { type: 'rgb', r: 255, g: 127.5, b: 63.75, alpha: 0.25 }
console.log(stringToColor('rgba(100% 50% 25% 25%)'));

// { type: 'transparent' }
console.log(stringToColor('rgba(255, 0, 0, 0)'));

// { type: 'hsl', h: 0, s: 50, l: 50, alpha: 1 }
console.log(stringToColor('hsl(0, 50%, 50%)'));

// { type: 'hsl', h: 200, s: 20, l: 70, alpha: 0.5 }
console.log(stringToColor('hsla(200, 20%, 70%, .5)'));

// { type: 'lch', l: 54.292, c: 106.839, h: 40.853, alpha: 1 }
console.log(stringToColor('lch(54.292% 106.839 40.853)'));

// { type: 'lab', l: 52.2345, a: 40.1645, b: 59.9971, alpha: 0.5 }
console.log(stringToColor('lab(52.2345% 40.1645 59.9971 / .5)'));

// { type: 'transparent' }
console.log(stringToColor('transparent'));

// { type: 'none' }
console.log(stringToColor('none'));

// { type: 'current' }
console.log(stringToColor('currentColor'));

// null
console.log(stringToColor('whatever'));
console.log(stringToColor('inherit'));
console.log(stringToColor('color(display-p3 0 1 0)'));
```

[Page 222](https://iconify.design/docs/libraries/utils/compare-colors.html "Current Page.")

## compareColors()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function compareColors() compares two [Color](https://iconify.design/docs/libraries/utils/color.html "Color documentation") objects, returning true if colors are identical.

This function can be used to parse colors in SVG. When the same color is represented with different methods, this function can help find duplicate colors.

## Usage

Function has two parameters:

- color1, [Color](https://iconify.design/docs/libraries/utils/color.html "Color documentation"). First color.
- color2, [Color](https://iconify.design/docs/libraries/utils/color.html "Color documentation"). Second color.

Function returns true if colors are identical, false if not.

## Example

ts
```
import { compareColors, stringToColor } from '@iconify/utils';

// Identical colors, function returns \`true\`
compareColors(stringToColor('rgb(0, 0, 0, 1)')!, stringToColor('#000000')!);

compareColors(
    stringToColor('rgb(0, 0, 0, 1)')!,
    stringToColor('hsl(100, 0%, 0%)')!
 );

// All colors are transparent, function returns \`true\`
compareColors(
    stringToColor('rgb(0, 255, 0, 0)')!,
    stringToColor('hsl(100, 0%, 0%, 0)')!
 );

compareColors(
    stringToColor('transparent')!,
    stringToColor('hsl(80, 20%, 50%, 0)')!
 );

compareColors(stringToColor('transparent')!, stringToColor('#f8a0')!);

// Different colors, function returns \`false\`
compareColors(
    stringToColor('transparent')!,
    stringToColor('hsl(100, 0%, 0%, .1)')!
 );
```

[Page 223](https://iconify.design/docs/libraries/utils/color-to-string.html "Current Page.")

## colorToString()

This function is part of [Iconify Utils package](https://iconify.design/docs/).

Function colorToString() convert [Color](https://iconify.design/docs/libraries/utils/color.html "Color documentation") objects to string.

It is the opposite of [stringToColor()](https://iconify.design/docs/libraries/utils/string-to-color.html "stringToColor() documentation").

Converting color from string using [stringToColor()](https://iconify.design/docs/libraries/utils/string-to-color.html "stringToColor() documentation"), then back to string using this function can be used to validate and clean up color strings.

## Usage

Function has one parameter:

- color, [Color](https://iconify.design/docs/libraries/utils/color.html "Color documentation"). Color object to conver.

Function returns string.

## Example

ts
```
import { colorToString } from '@iconify/utils';

// #800080
console.log(colorToString({ type: 'rgb', r: 128, g: 0, b: 128, alpha: 1 }));

// #f00
console.log(colorToString({ type: 'rgb', r: 255, g: 0, b: 0, alpha: 1 }));

// rgba(136, 32, 50, 0.87)
console.log(
    colorToString({
        type: 'rgb',
        r: 136,
        g: 32,
        b: 50,
        alpha: 0.87,
    })
 );

// rgba(255, 48, 0, 0.5)
console.log(colorToString({ type: 'rgb', r: 255, g: 48, b: 0, alpha: 0.5 }));

// hsl(0, 50%, 50%)
console.log(colorToString({ type: 'hsl', h: 0, s: 50, l: 50, alpha: 1 }));

// hsla(200, 20%, 70%, 0.5)
console.log(colorToString({ type: 'hsl', h: 200, s: 20, l: 70, alpha: 0.5 }));

// lch(54.292% 106.839 40.853)
console.log(
    colorToString({ type: 'lch', l: 54.292, c: 106.839, h: 40.853, alpha: 1 })
 );

// lab(52.2345% 40.1645 59.9971 / 0.5)
console.log(
    colorToString({
        type: 'lab',
        l: 52.2345,
        a: 40.1645,
        b: 59.9971,
        alpha: 0.5,
    })
 );

// transparent
console.log(colorToString({ type: 'transparent' }));

// none
console.log(colorToString({ type: 'none' }));

// currentColor
console.log(colorToString({ type: 'current' }));
```

[Page 224](https://iconify.design/docs/libraries/utils/color.html "Current Page.")

## Color type

Color type is used in [Iconify Utils](https://iconify.design/docs/) in functions for parsing colors.

You can find this type in src/colors/types.ts of [Iconify Utils source code](https://github.com/iconify/iconify/tree/main/packages/utils).

Type is an object, with type property showing what color type it is, then optional properties for that type.

Browsers support various complex colors, which can contain CSS variables, functions. Iconify Utils parser is very basic, it supports only commonly used namespaces that have been supported by all browsers for many years.

## RGB

RGB color, usually converted from hexadecimal color like "#ff8080", color keyword "red" or RGBA color like "rgba(255, 128, 128, 0.5)".

It has the following properties:

- type = "rgb".
- r, g, b red, green and blue color components (0 - 255).
- alpha alpha (0 - 1).

## HSL

HSL color, usually converted from HSL or HSLA color like "hsla(90, 50%, 50%, 0.5)".

It has the following properties:

- type = "hsl".
- h hue that can be any number, but usually is in 0 - 360 range.
- s, l saturation and lightness components (0 - 100).
- alpha alpha (0 - 1).

## LAB

Lab color, currently being implemented by browsers, is converted from color strings like "lab(50% 50 50 / 1)".

It has the following properties:

- type = "lab".
- l lightness (0 - 100).
- a, b are distances along a and b axis in Lab color space.
- alpha alpha (0 - 1).

## LCH

LCH color, currently being implemented by browsers, is converted from color strings like "lch(50% 50 50 / 1)".

It has the following properties:

- type = "lab".
- l lightness (0 - 100).
- c chroma, usually in 0 - 230 range, but it can be higher.
- h hue angle.
- alpha alpha (0 - 1).

## Keywords

Several keywords have their own types that represent special colors.

They exist because functions for parsing colors can be used for cleaning up and parsing various icons, where finding values like "currentColor" and "none" could be important.

### transparent

Transparent color has a special type with only one property:

- type = "transparent".

When converting transparent colors like "rgba(0, 0, 0, 0)", conversion function will return transparent type, making it easier to compare various colors.

### none

"none" also has a special type with only one property:

- type = "none".

### currentColor

"currentColor" also has a special type with only one property:

- type = "current".

## Other colors

This type is meant for parsing basic colors in SVG, not full color parsing, so it is limited only to simple colors and keywords that are important when parsing icons.

[Page 225](https://iconify.design/docs/libraries/utils/examples/ "Current Page.")

## Code examples for Iconify Utils

Documentation for [each function in Iconify Utils](https://iconify.design/) includes code samples.

However, how to figure out which function to look at? Below are code samples for common use cases.

## Export icon set

Examples to export an entire icon set:

- [Export icon set as SVGs](https://iconify.design/docs/export-svgs-from-icon-set.html).

## Export single SVG

Examples of generating a single SVG file:

- [Export SVG from icon set](https://iconify.design/docs/export-svg-from-icon-set.html).
- [Export SVG from icon data](https://iconify.design/docs/export-svg-from-data.html).

## Export CSS

Examples to export icons as CSS:

- [Generate CSS for selected icons](https://iconify.design/docs/generate-css.html).

## Advanced import / export

Iconify Utils is a basic package that parses [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") and [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") data. It is not meant for more complex stuff.

For more complex stuff, such as importing icons, validating icon code, changing palette, cleaning up, exporting to various formats, see [Iconify Tools package](https://iconify.design/tools/).

[Page 226](https://iconify.design/docs/libraries/utils/examples/export-svgs-from-icon-set.html "Current Page.")

## Export SVGs using Iconify Utils

This tutorial is part of [code examples for Iconify Utils](https://iconify.design/docs/).

## Export SVGs

This is an example of using Iconify Utils to generate SVGs from the icon set:

ts
```
import type { IconifyJSON } from '@iconify/types';
import { readFileSync, writeFileSync, mkdirSync } from 'fs';

// Various functions from Iconify Utils
import { parseIconSet, iconToSVG } from '@iconify/utils';

// Source file and target directory
const source = 'icon-sets/mdi-light.json';
const target = 'svg/mdi-light';

// Read icon set from file
const iconSet = JSON.parse(readFileSync(source, 'utf8')) as IconifyJSON;

// Create directory for output if it does not exist
try {
    mkdirSync(target, {
        recursive: true,
    });
 } catch {}

// Parse all icons
parseIconSet(iconSet, (name, data) => {
    if (!data) {
        // Invalid icon
        return;
    }

    // Generate SVG
    const renderData = iconToSVG(data, {
        // 'auto' keyword uses viewBox width/height for icon width/height
        height: 'auto',
    });

    // Generate attributes for SVG element
    const svgAttributes = {
        xmlns: 'http://www.w3.org/2000/svg',
        ...renderData.attributes,
    } as Record<string, string>;
    const svgAttributesStr = Object.keys(svgAttributes)
        .map(
            (attr) =>
                // No need to check attributes for special characters, such as quotes,
                // they cannot contain anything that needs escaping.
                \`${attr}="${svgAttributes[attr as keyof typeof svgAttributes]}"\`
        )
        .join(' ');

    // Generate SVG
    const svg = \`<svg ${svgAttributesStr}>${renderData.body}</svg>\`;

    // Write SVG
    const filename = \`${target}/${name}.svg\`;
    writeFileSync(filename, svg, 'utf8');
    console.log('Written:', filename);
 });
```

## Functions

Functions used in this code sample:

- [parseIconSet()](https://iconify.design/docs/libraries/utils/parse-icon-set.html "parseIconSet() documentation") to parse icon set, calling callback for each icon.
- [iconToSVG()](https://iconify.design/docs/libraries/utils/icon-to-svg.html "iconToSVG() documentation") to generate attributes and HTML for SVG.
- [replaceIDs()](https://iconify.design/docs/libraries/utils/replace-ids.html "replaceIDs() documentation") to create unique IDs, though it is commented out. Use it if you are embedding output in HTML.

## Source

For icon set source, this example uses.json file in [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") format.

You can also use [individual icon set package](https://iconify.design/docs/icons/json.html) or [full icon sets package](https://iconify.design/docs/icons/all.html). Point source variable to.json file from one of those packages.

## Output

This example writes all SVGs to the file system. Change target variable to point to different directory.

[Page 227](https://iconify.design/docs/libraries/utils/examples/export-svg-from-icon-set.html "Current Page.")

## Export SVG using Iconify Utils

This tutorial is part of [code examples for Iconify Utils](https://iconify.design/docs/).

## Export SVG

This is an example of using Iconify Utils to generate SVG from an icon set:

ts
```
// Import full icon set
import { icons } from '@iconify-json/mdi-light';

// Various functions from Iconify Utils
import { getIconData, iconToSVG, iconToHTML } from '@iconify/utils';

// Get ful data for 'mdi-light:home'
const iconData = getIconData(icons, 'home');
if (!iconData) {
    throw new Error('Home icon does not exist');
 }

// Generate data for rendering SVG
// Second optional parameter is customisations
const renderData = iconToSVG(iconData);

/*

 Result of iconToSVG() can be used to either generate HTML code or to use in various components

 renderData = {
  attributes: {
    width: '1em',
    height: '1em',
    viewBox: '0 0 24 24'
  },
  body: '<path d="M16 8.414l-4.5-4.5L4.414 11H6v8h3v-6h5v6h3v-8h1.586L17 9.414V6h-1v2.414zM2 12l9.5-9.5L15 6V5h3v4l3 3h-3v7.998h-5v-6h-3v6H5V12H2z" fill="currentColor"/>'
 }

 */

// Generate SVG
const svg = iconToHTML(renderData.body, renderData.attributes);

// Log SVG
console.log(svg);
```

## Async example

This is another example that:

- Uses asynchronous functions to parse icon sets.
- Uses @iconify/json as source.
- Written in modern JavaScript, not TypeScript.

js
```
import { mkdir, readFile, writeFile } from 'node:fs/promises';
import { iconToSVG, iconToHTML, parseIconSetAsync } from '@iconify/utils';
import { locate } from '@iconify/json';

/**
 * Dimensions of generated SVG:
 * - '1em' -> 1em, easy to resize icons with font-size.
 * - 'auto' -> same as icon's viewBox.
 * - 'unset' -> no width/height in generated icons. You'll need to assign width and height in CSS.
 */
const height = '1em';

/**
 * List of icon sets you want to export
 *
 * @type {string[]}
 */
const prefixes = ['mdi', 'mdi-light'];

/**
 * Output directory for SVG
 */
const target = 'assets/svg';

// Parse each icon set
for (let i = 0; i < prefixes.length; i++) {
    const prefix = prefixes[i];

    // Find location of .json file
    const filename = locate(prefix);

    // Load file and parse it
    /** @type {import("@iconify/types").IconifyJSON} */
    const iconSet = JSON.parse(await readFile(filename, 'utf8'));

    // Create output directory if it doesn't exist
    const outDir = \`${target}/${prefix}\`;
    try {
        await mkdir(outDir, {
            recursive: true,
        });
    } catch {}

    // Get all icons
    let counter = 0;
    await parseIconSetAsync(iconSet, async (name, data) => {
        if (!data) {
            // Failed icon
            return;
        }

        // Generate SVG
        const { attributes, body } = iconToSVG(data, {
            height,
        });
        const svg = iconToHTML(body, attributes);

        // Save it
        await writeFile(\`${outDir}/${name}.svg\`, svg, 'utf8');
        counter++;
    });

    // Log it
    console.log(\`Exported ${counter} icons from ${iconSet.info?.name || prefix}\`);
 }
```

## Functions

Functions used in this code sample:

- [getIconData()](https://iconify.design/docs/libraries/utils/get-icon-data.html "getIconData() documentation") to extract data for one icon from the icon set.
- [iconToSVG()](https://iconify.design/docs/libraries/utils/icon-to-svg.html "iconToSVG() documentation") to generate attributes and HTML for SVG.
- [iconToHTML()](https://iconify.design/docs/libraries/utils/icon-to-html.html "iconToHTML() documentation") to convert the result of [iconToSVG()](https://iconify.design/docs/libraries/utils/icon-to-svg.html "iconToSVG() documentation") to string.

## Source

For icon set source, this example uses [individual icon set package](https://iconify.design/docs/icons/json.html).

If you need to read from a different file, replace that code with something like this:

ts
```
import { readFileSync } from 'fs';

const icons = JSON.parse(readFileSync('whatever.json', 'utf8'));
```

Typecast it to [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") if you are using TypeScript:

ts
```
import type { IconifyJSON } from '@iconify/types';
import { readFileSync } from 'fs';

const icons = JSON.parse(readFileSync('whatever.json', 'utf8')) as IconifyJSON;
```

## Output

Example outputs SVG to console.

If you need to write it to a file, use file system function, such as writeFileSync() or one of its asynchronous counterparts.

## Icon size

In this example all generated icons have height="1em".

You can remove that by adding customisations as second parameter to [iconToSVG()](https://iconify.design/docs/libraries/utils/icon-to-svg.html "iconToSVG() documentation"):

js
```
const renderData = iconToSVG(iconData, {
    // 'unset' removes dimensions from icon
    height: 'unset',
 });
```

[Page 228](https://iconify.design/docs/libraries/utils/examples/export-svg-from-data.html "Current Page.")

## Export SVG using Iconify Utils

This tutorial is part of [code examples for Iconify Utils](https://iconify.design/docs/).

## Export SVG

This is an example of using Iconify Utils to generate SVG from icon data:

ts
```
import type { IconifyIcon } from '@iconify/types';
import { iconToSVG/* , replaceIDs */ } from '@iconify/utils';

// Icon data in IconifyIcon format
const data: IconifyIcon = {
    body: '<path d="M16 8.414l-4.5-4.5L4.414 11H6v8h3v-6h5v6h3v-8h1.586L17 9.414V6h-1v2.414zM2 12l9.5-9.5L15 6V5h3v4l3 3h-3v7.998h-5v-6h-3v6H5V12H2z" fill="currentColor"/>',
    width: 24,
    height: 24,
 };

// Generate data for rendering SVG
const renderData = iconToSVG(data, { height: 'auto' });

/*

 Result of iconToSVG() can be used to either generate HTML code or to use in various components

 renderData = {
  attributes: {
    width: '24',
    height: '24',
    viewBox: '0 0 24 24'
  },
  body: '<path d="M16 8.414l-4.5-4.5L4.414 11H6v8h3v-6h5v6h3v-8h1.586L17 9.414V6h-1v2.414zM2 12l9.5-9.5L15 6V5h3v4l3 3h-3v7.998h-5v-6h-3v6H5V12H2z" fill="currentColor"/>'
 }

 */

// Generate attributes for SVG element
const svgAttributes: Record<string, string> = {
    xmlns: 'http://www.w3.org/2000/svg',
    ...renderData.attributes,
 };
const svgAttributesStr = Object.keys(svgAttributes)
    .map(
        (attr) =>
            // No need to check attributes for special characters, such as quotes,
            // they cannot contain anything that needs escaping.
            \`${attr}="${svgAttributes[attr as keyof typeof svgAttributes]}"\`
    )
    .join(' ');

// Generate SVG
const svg = \`<svg ${svgAttributesStr}>${renderData.body}</svg>\`;

/*

 Many icons have elements with unique IDs, such as masks. IDs are meant to be unique.
 If generated icon is embedded in HTML, it cannot have IDs that might be present in
 another icon. To solve that, replace IDs in content with randomly generated IDs
 using replaceIDs():

 const svg = \`<svg ${svgAttributesStr}>${replaceIDs(renderData.body)}</svg>\`;

 Uncomment import for replaceIDs() at start of this example.

 */

// Log SVG
console.log(svg);
```

## Functions

Functions used in this code sample:

- [iconToSVG()](https://iconify.design/docs/libraries/utils/icon-to-svg.html "iconToSVG() documentation") to generate attributes and HTML for SVG.
- [replaceIDs()](https://iconify.design/docs/libraries/utils/replace-ids.html "replaceIDs() documentation") to create unique IDs, though it is commented out. Use it if you are embedding output in HTML.

## Source

For icon data source, this example uses hardcoded [IconifyIcon](https://iconify.design/docs/types/iconify-icon.html "IconifyIcon documentation") data.

You can import individual icon from [split icon set package](https://iconify.design/docs/icons/icons.html).

## Output

This example outputs SVG to console.

If you need to write it to a file, use file system function, such as writeFileSync() or one of its asynchronous counterparts.

[Page 229](https://iconify.design/docs/libraries/utils/examples/generate-css.html "Current Page.")

## Generate CSS using Iconify Utils

This tutorial is part of [code examples for Iconify Utils](https://iconify.design/docs/).

## Generate CSS

This is an example of using Iconify Utils to generate CSS from icon data:

js
```
import { readFile, writeFile } from 'node:fs/promises';
import { getIconsCSS } from '@iconify/utils';
import { locate } from '@iconify/json';

/**
 * List of icons. Key is icon set prefix, value is array of icons
 *
 * @type {Record<string, string[]>}
 */
const icons = {
    'mdi': ['home', 'menu'],
    'mdi-light': ['alert-circle', 'circle', 'help-circle'],
 };

// Parse each icon set
let code = '';
for (const prefix in icons) {
    // Find location of .json file
    const filename = locate(prefix);

    // Load file and parse it
    /** @type {import("@iconify/types").IconifyJSON} */
    const iconSet = JSON.parse(await readFile(filename, 'utf8'));

    // Get CSS
    const css = getIconsCSS(iconSet, icons[prefix]);

    // Add it to code
    code += css;
 }

// Save CSS file
await writeFile('assets/style.css', code, 'utf8');
console.log(\`Saved CSS (${code.length} bytes)\`);
```

## Functions

Functions used in this code sample:

- [getIconsCSS()](https://iconify.design/docs/libraries/utils/get-icons-css.html "getIconsCSS() documentation") to generate CSS for icons.

## Source

For icon data source, this example uses @iconify/json package.

## Output

This example writes CSS to a file.

[Page 230](https://iconify.design/docs/api/ "Current Page.")

## Iconify API

Iconify API is an open source hosted (or self-hosted) service for developers.

What is it for?

- API provides icon data, which made it possible to create [Iconify icon components](https://iconify.design/icon-components/) that load icons demand.
- API [generates SVG](https://iconify.design/docs/svg.html), which developers can link to in HTML or stylesheet.
- API [generates CSS](https://iconify.design/docs/css.html) to render icons as background or mask images.
- API has a search engine for hosted icons, which can be used by icon pickers. Currently used by [Iconify plug-ins](https://iconify.design/design/) for various UI design tools.

API can be used to offer hundreds of thousands of icons in website builders or theme customisers. Host your own API, use API's search engine in custom icon picker to allow users select icons, use icon components in UI to render icons.

## Hosting API

You can host your own Iconify API service.

By hosting Iconify API yourself you:

- Have full control over servers instead of relying on third party service.
- Can choose which icon sets to host or host your own icon sets.

See [hosting Iconify API](https://iconify.design/docs/hosting.html) for more details.

API is available on:

- [GitHub](https://github.com/iconify/api/) - you can customise it before deploying.
- [NPM](https://www.npmjs.com/package/@iconify/api) - can be embedded in an app without running a full server.
- [Docker](https://hub.docker.com/r/iconify/api) - for quick deployment.

## Public API

Iconify project offers public API servers, which host over 275k icons from more than 200 open source icon sets.

To improve loading times, API is hosted on multiple servers in different parts of the world. Icons are usually loaded within fraction of a second.

Public API is available at https://api.iconify.design.

It is a public service, servers are free to use, but please do keep in mind that running those servers is not free. If you are using public API or API software, [please consider supporting Iconify](https://iconify.design/sponsors/) to help out with infrastructure, development and maintenance costs.

### Redundancy

Sometimes there are problems with internet connections. It happens. Maybe server has issues, maybe visitor's ISP has issues.

In case main API host cannot be reached, Iconify public API has backup host names:

- https://api.simplesvg.com
- https://api.unisvg.com

Each of backup host names points to half of API servers. For example, in western Europe there are currently 2 servers: in Frankfurt and in London. Main host points to both, one of backup hosts points to server in Frankfurt, another backup host points to server in London. If server in Frankfurt goes down, users that are using that server can be redirected to server in London using one of backup host names.

Redundancy built in Iconify icon components accounts for that. It tries to connect to main host first, then, if there was no response in reasonable time (timeout is 0.75 seconds), it attempts to connect to one of backup hosts, then to another backup host. Small delay caused by check only affects first query, all further API queries are sent to host that responded.

See [building redundant API](https://iconify.design/docs/cdn.html) for more details.

## Queries

Iconify API can be used to render SVG, to retrieve icon data, to browse and search icons.

For full list of supported queries, their parameters and API responses see [Iconify API queries documentation](https://iconify.design/docs/queries.html).

## API providers

Iconify icon components can retrieve icons from multiple API servers.

This allows you to run your own API to serve only custom icons, while using public Iconify API to get data for open source icon sets.

See [Iconify API providers](https://iconify.design/docs/providers.html) for details.

[Page 231](https://iconify.design/docs/api/queries.html "Current Page.")

## Iconify API queries

This tutorial is for developers that want to create their own tools to access Iconify API.

Iconify API supports the following basic queries:

- [/{prefix}/{icon}.svg](https://iconify.design/docs/svg.html) dynamically generates SVG.
- [/{prefix}.css?icons={icons}](https://iconify.design/docs/css.html) dynamically generates CSS for icons.
- [/{prefix}.json?icons={icons}](https://iconify.design/docs/icon-data.html) retrieves icon data.
- [/last-modified?prefixes={prefixes}](https://iconify.design/docs/last-modified.html) returns last modification time of requested icon sets, which can be used to invalidate old icon data cache.

If list of icons is enabled, custom icon pickers can use the following queries to browse icons:

- [/collections](https://iconify.design/docs/collections.html) returns list of available icon sets.
- [/collection?prefix={prefix}](https://iconify.design/docs/collection.html) returns list of icons in an icon set.

If search engine is enabled, icon pickers can implement search functionality using these queries:

- [/search?query={keyword}](https://iconify.design/docs/search.html) returns list of icons that match keyword.
- [/keywords?prefix={keyword}](https://iconify.design/docs/keywords.html) or [/keywords?keyword={keyword}](https://iconify.design/docs/keywords.html) returns list of keywords that contain requested keyword, which can be used for autocomplete.

Maintenance queries:

- [/version](https://iconify.design/docs/version.html) shows API version as plain text, unless disabled. If you are running multiple API servers, like public Iconify API does, this can be used to check which server visitor is connected to.
- /update updates icon sets from its source without restarting API. This can be used to automatically keep API up to date using GitHub hooks or similar methods.

### API versions

In code samples some queries above are marked as API v2, some as API v3.

Differences:

- API v2 queries existed since version 2 of Iconify API, but were not documented. They are supported and will continue being supported, but at some point improved v3 versions of same queries can be added.
- API v3 queries are available since version 3 of Iconify API.

You can use both versions at the same time. Improved versions of old queries might be added to solve various issues, but no need to switch to new version right away, old versions will continue to be supported.

API even supports v1 queries that aren't documented and should not be used. They are supported because they can still be found in some legacy applications, such as older versions of Iconify plug-in for Sketch.

## Common parameters

All queries that return JSON data have one common parameter:

- pretty is used to format JSON data, making it easy to read. Set to 1 or true to enable.

[Page 232](https://iconify.design/docs/api/svg.html "Current Page.")

## Rendering SVG

Iconify API can dynamically generate SVG, which can be used in HTML or CSS.

## Query

API URI that generates SVG is /{prefix}/{name}.svg, where:

- "{prefix}" is icon set prefix.
- "{name}" is icon name.

Optional parameters:

- color, string. Icon color. Replaces currentColor with specific color, resulting in icon with hardcoded palette.
- width and height, string|number. Icon dimensions. If only one dimension is specified, such as height, other dimension will be automatically set to match it.
- flip, string. Flip icon.
- rotate, string|number. Rotate icon by 90, 180 or 270 degrees.
- download, boolean. Forces browser to download file.
- box, boolean. Adds an empty rectangle to SVG that matches viewBox.

Examples:

html
```
<img src="https://api.iconify.design/fluent-emoji-flat/alarm-clock.svg" />
```

css
```
/* SVG with hardcoded palette as pseudo element's content */
.test:after {
    content: url('https://api.iconify.design/fluent-emoji-flat/alarm-clock.svg?height=16');
 }

/* SVG with hardcoded palette as background image */
.test-icon {
    display: inline-block;
    width: 1em;
    height: 1em;
    background-image: url('https://api.iconify.design/fluent-emoji-flat/alarm-clock.svg');
    background-repeat: no-repeat;
    background-size: 100% 100%;
 }

/* Monotone SVG as mask, using currentColor for color */
.test-icon {
    display: inline-block;
    width: 1em;
    height: 1em;
    background-color: currentColor;
    -webkit-mask-image: url('https://api.iconify.design/bi/bell-fill.svg');
    mask-image: url('https://api.iconify.design/bi/bell-fill.svg');
    -webkit-mask-repeat: no-repeat;
    mask-repeat: no-repeat;
    -webkit-mask-size: 100% 100%;
    mask-size: 100% 100%;
 }
```

See [how to use icons in CSS](https://iconify.design/usage/css/) on various ways to use icons in CSS.

### Color

One downside of using SVG as external resource is it cannot inherit color from parent element. Browsers will use black instead of currentColor.

There are 2 solutions to issue:

- Use monotone image in CSS as mask instead of background.
- Specify color using color attribute, changing image color from currentColor to hardcoded color.

css
```
.test:after {
    content: url('https://api.iconify.design/bi/bell-fill.svg?height=16&color=%23ba3329');
 }
```

This applies only to monotone icons. Icons that have hardcoded palette don't need color attribute.

URI cannot contain "#", so if you are using hexadecimal color, such as "#ba3329" used in example above, make sure to replace "#" with "%23":

```
https://api.iconify.design/bi/bell-fill.svg?color=%23ba3329
```

### Download

Parameter "download=1" forces browser to download generated SVG.

This can be used by websites that display icons to create links to download icon.

### Box

Parameter "box=1" adds an empty rectangle to generated SVG that matches icon's viewBox.

It is needed when importing SVG to various UI design tools that ignore viewBox. Those tools, such as Sketch, create layer groups that automatically resize to fit content. Icons usually have empty pixels around icon, so such software crops those empty pixels and icon's group ends up being smaller than actual icon, making it harder to align it in design.

Combined with download parameter, box parameter this can be used to download SVG that will be imported correctly in software that does not support viewBox: /mdi/home.svg?box=1&download=1.

### Dimensions

You can also specify dimensions to SVG URL as parameters. It is pointless if you are using background-size or mask-size to resize background or mask (see examples above), but it is needed for using SVG as pseudo element's content.

To specify custom dimensions add width and/or height parameters:

```
https://api.iconify.design/fa-solid/home.svg?width=24&height=24
```

Numbers without units are treated as pixels, so width=24 and width=24px are identical.

If you specify only one size attribute, other attribute is calculated using width/height ratio of icon. For example, if original icon is 512x1024, setting?height=16 will result in SVG containing width="8".

There are several special keywords:

- "auto" sets dimensions to value from viewBox.
- "unset" or "none" remove dimensions.

```
https://api.iconify.design/fa-solid/home.svg?height=unset
```

No need to set both width and height to special keyword, one parameter is enough (see above about width/height ratio).

### Transformations

You can transform SVG generated by Iconify API, same as with placeholder elements.

Possible transformations:

- Rotations: 90°, 180°, 270°
- Horizontal and vertical flip

#### Rotating icon

To rotate an icon, add rotate parameter. Value can be in degrees: rotate=90deg or as numbers: rotate=1 (where 1 = 90deg, 2 = 180deg, 3 = 270deg).

All transformations are done using SVG transforms, not CSS.

html
```
<span class="sample rotation-0">No rotation:</span><br />
<span class="sample rotation-90">90&deg; rotation:</span><br />
<span class="sample rotation-180">180&deg; rotation:</span><br />
<span class="sample rotation-270">270&deg; rotation:</span><br />
```

css
```
.sample:after {
    padding-left: 4px;
 }
.rotation-0:after {
    content: url('https://api.iconify.design/noto/spiral-calendar.svg?height=32');
 }
.rotation-90:after {
    content: url('https://api.iconify.design/noto/spiral-calendar.svg?height=32&rotate=90deg');
 }
.rotation-180:after {
    content: url('https://api.iconify.design/noto/spiral-calendar.svg?height=32&rotate=180deg');
 }
.rotation-270:after {
    /* 270deg = 3 */
    content: url('https://api.iconify.design/noto/spiral-calendar.svg?height=32&rotate=3');
 }
```

Demo:

No rotation:  
90° rotation:  
180° rotation:  
270° rotation:

#### Flipping icon

To flip an icon, add flip parameter. Value is "horizontal" or "vertical". If you want both, use "horizontal,vertical" or rotate icon by 180 degrees.

All transformations are done using SVG transforms, not CSS.

html
```
<span class="sample original-icon">Original icon:</span><br />
<span class="sample flip-horizontal">Horizontal flip:</span><br />
<span class="sample flip-vertical">Vertical flip:</span><br />
<span class="sample flip-both">Horizontal and vertical flip:</span><br />
<span class="sample flip-and-rotate">Mixing rotation and flip:</span><br />
```

css
```
.sample:after {
    padding-left: 4px;
 }
.original-icon:after {
    content: url('https://api.iconify.design/noto/spiral-calendar.svg?height=32');
 }
.flip-horizontal:after {
    content: url('https://api.iconify.design/noto/spiral-calendar.svg?height=32&flip=horizontal');
 }
.flip-vertical:after {
    content: url('https://api.iconify.design/noto/spiral-calendar.svg?height=32&flip=vertical');
 }
.flip-both:after {
    content: url('https://api.iconify.design/noto/spiral-calendar.svg?height=32&flip=horizontal,vertical');
 }
.flip-and-rotate:after {
    content: url('https://api.iconify.design/noto/spiral-calendar.svg?height=32&rotate=3&flip=horizontal');
 }
```

Demo:

Original icon:  
Horizontal flip:  
Vertical flip:  
Horizontal and vertical flip:  
Mixing rotation and flip:

You can use both rotation and flip on icon. Icon is flipped first, then rotated.

[Page 233](https://iconify.design/docs/api/css.html "Current Page.")

## CSS for icons

Iconify API can dynamically generate CSS for icons, where icons are used as background or mask image.

This allows rendering icons with a simple <span> tag without any components.

## Query

API URI that generates CSS is /{prefix}.css?icons={icons}, where:

- "{prefix}" is icon set prefix. To generate CSS for icons from multiple icon sets, send separate queries for each icon set.
- "{icons}" is list of icon names, separated by comma.

Examples:

css
```
.icon--openmoji {
    display: inline-block;
    width: 1em;
    height: 1em;
    background: no-repeat center / 100%;
 }

.icon--openmoji--axe {
    background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 72 72' width='72' height='72'%3E%3Cpath fill='%239b9b9a' d='m7.95 17.47l18.13-4.237s.217 2.51.541 4.237a19.196 19.196 0 0 0 3.561 6.474c.756.54-7.482 11.88-10.24 12.42c-4.92.954-13.4-18.33-11.99-18.89z'/%3E%3Cpath fill='%23a57939' d='M36.41 23.25c-1.189.792-2.352.923-1.771 2.228a7.128 7.128 0 0 1 .434 1.297c.501 2.172 1.503 3.675 5.345 5.847c3.412 1.929 10.38 15.58 11.9 18.61a2.94 2.94 0 0 1 .31 1.257l.13 5.842a2.963 2.963 0 0 0 .663 1.803l1.863 2.293a2.963 2.963 0 0 0 4.132.46l3.502-2.757a2.963 2.963 0 0 0 .703-3.86l-21.27-35.2c-.873-1.445-.81-1.416-2.215-.48z'/%3E%3Crect width='13.63' height='13.53' x='14.18' y='24.84' fill='%23d0cfce' rx='2.359' ry='2.359' transform='rotate(-30)'/%3E%3Cg fill='none' stroke='%23000' stroke-linecap='round' stroke-linejoin='round' stroke-width='2'%3E%3Cpath d='M34.66 24.76c-.04.204-.002.45.138.767a7.1 7.1 0 0 1 .432 1.29c.499 2.163 1.495 3.659 5.317 5.82c3.394 1.919 10.32 15.51 11.83 18.53c.195.388.3.816.31 1.25l.128 5.815a2.95 2.95 0 0 0 .66 1.794l1.852 2.283a2.946 2.946 0 0 0 4.11.457l3.483-2.744a2.95 2.95 0 0 0 .7-3.842L42.48 21.44c-.315-.52-.525-.808-.732-.918'/%3E%3Crect width='13.56' height='13.46' x='14.32' y='25.04' rx='2.359' ry='2.359' transform='rotate(-30.014) skewX(-.028)'/%3E%3Cpath d='m31.02 24.98l-9.465 11.24c-3.463 4.049-17.14-17.64-12.65-19.27l17.34-3.026'/%3E%3C/g%3E%3C/svg%3E");
 }

.icon--openmoji--balance-scale {
    background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 72 72' width='72' height='72'%3E%3Cpath fill='%239B9B9A' d='M48.063 62.92c0-3.314-5.597-6-12.5-6s-12.5 2.686-12.5 6h25z'/%3E%3Cpath fill='%23D0CFCE' d='M24.9 46.966c0 2.193-2.198 3.972-4.91 3.972s-4.91-1.779-4.91-3.972h9.82zm33-.041c0 2.194-2.198 3.972-4.91 3.972s-4.91-1.778-4.91-3.972h9.82z'/%3E%3Cpath fill='none' stroke='%23000' stroke-linecap='round' stroke-linejoin='round' stroke-miterlimit='10' stroke-width='2' d='M16 25.17c2.666 0 8.954-5.334 20-5.334s14.667 4 20 5.334m-20-1.264v28'/%3E%3Ccircle cx='36' cy='13.895' r='3'/%3E%3Cpath fill='none' stroke='%23000' stroke-linecap='round' stroke-linejoin='round' stroke-miterlimit='10' stroke-width='2' d='M48 61.906c0-3.313-5.596-6-12.5-6s-12.5 2.687-12.5 6m3-16a6 6 0 0 1-12 0h12zm-6-18l-5 18h10zm0 0v18m39 0a6 6 0 0 1-12 0h12zm-6-18l-5 18h10zm0 0v18'/%3E%3C/svg%3E");
 }
```

css
```
.icon--mdi {
    display: inline-block;
    width: 1em;
    height: 1em;
    background-color: currentColor;
    -webkit-mask: no-repeat center / 100%;
    mask: no-repeat center / 100%;
    -webkit-mask-image: var(--svg);
    mask-image: var(--svg);
 }

.icon--mdi--account-box {
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cpath fill='black' d='M6 17c0-2 4-3.1 6-3.1s6 1.1 6 3.1v1H6m9-9a3 3 0 0 1-3 3a3 3 0 0 1-3-3a3 3 0 0 1 3-3a3 3 0 0 1 3 3M3 5v14a2 2 0 0 0 2 2h14a2 2 0 0 0 2-2V5a2 2 0 0 0-2-2H5a2 2 0 0 0-2 2Z'/%3E%3C/svg%3E");
 }

.icon--mdi--account-cash {
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cpath fill='black' d='M11 8c0 2.21-1.79 4-4 4s-4-1.79-4-4s1.79-4 4-4s4 1.79 4 4m0 6.72V20H0v-2c0-2.21 3.13-4 7-4c1.5 0 2.87.27 4 .72M24 20H13V3h11v17m-8-8.5a2.5 2.5 0 0 1 5 0a2.5 2.5 0 0 1-5 0M22 7a2 2 0 0 1-2-2h-3c0 1.11-.89 2-2 2v9a2 2 0 0 1 2 2h3c0-1.1.9-2 2-2V7Z'/%3E%3C/svg%3E");
 }

.icon--mdi--account {
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cpath fill='black' d='M12 4a4 4 0 0 1 4 4a4 4 0 0 1-4 4a4 4 0 0 1-4-4a4 4 0 0 1 4-4m0 10c4.42 0 8 1.79 8 4v2H4v-2c0-2.21 3.58-4 8-4Z'/%3E%3C/svg%3E");
 }

.icon--mdi--home {
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cpath fill='black' d='M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5Z'/%3E%3C/svg%3E");
 }
```

Using icons in HTML is easy: use a placeholder element with 2 class names: class name for an icon set and class name for icon:

html
```
<span class="icon--openmoji icon--openmoji--axe"></span>
```

html
```
<span class="icon--mdi icon--mdi--account"></span>
```

Why 2 classes? This allows splitting common style in separate rule, reducing duplication and making it easier to target all icons from an icon set.

If you want to reference icons with 1 simple class, you can use selector and common options. See examples below.

### Options

Optional parameters:

- download. If set to "true" or "1", sends CSS as an attachment, forcing browser to download file.
- iconSelector or selector. Selector for icon, defaults to ".icon--{prefix}--{name}". Variable "{prefix}" is replaced with icon set prefix, "{name}" with icon name.
- commonSelector or common. Common selector for icons, defaults to ".icon--{prefix}". Set it to empty to disable common code (see one of examples below). Variable "{prefix}" is replaced with icon set prefix.
- overrideSelector or override. Selector that mixes iconSelector and commonSelector to generate icon specific style that overrides common style. See below. Default value is ".icon--{prefix}.icon--{prefix}--{name}".
- pseudoSelector or pseudo, boolean. Set it to true if selector for icon is a pseudo-selector, such as ".icon--{prefix}--{name}::after".
- varName or var. Name for variable to use for icon, defaults to "svg" for monotone icons, null for icons with palette. Set to null to disable.
- forceSquare or square, boolean. Forces icon to have width of 1em.
- color. Sets color for monotone icons. Also renders icons as background images.
- mode: "mask" or "background". Forces icon to render as mask image or background image. If not set, mode will be detected from icon content: icons that contain currentColor will be rendered as mask image, other icons as background image.
- format. Stylesheet formatting option. Matches options used in Sass. Supported values: "expanded", "compact", "compressed".

Other optional parameters are the same as in [getIconsCSS()](https://iconify.design/docs/libraries/utils/get-icons-css.html "getIconsCSS() documentation") function of [Iconify Utils](https://iconify.design/docs/libraries/utils/).

### Color and mode

There are two types of icons:

- Monotone icons, which use currentColor for color.
- Icons with hardcoded palette, where colors cannot be changed.

You can use both types in CSS.

Icons with hardcoded palette are rendered as background images:

[twemoji:clapper-board](https://icon-sets.iconify.design/twemoji/clapper-board/)

[twemoji:loudspeaker](https://icon-sets.iconify.design/twemoji/loudspeaker/)

Monotone icons are rendered as mask images with background color set to currentColor:

[bi:bell-fill](https://icon-sets.iconify.design/bi/bell-fill/)

[line-md:beer-alt-twotone-loop](https://icon-sets.iconify.design/line-md/beer-alt-twotone-loop/)

[mdi:material-design](https://icon-sets.iconify.design/mdi/material-design/)

Using currentColor as background color makes it easy to change icon color by changing text color:

html
```
<span class="icon--bi icon--bi--bell-fill" style="color: green"></span>
```

You can force background or mask mode by adding mode parameter: &mode=background or &mode=mask

You can also use color parameter to convert monotone icons to icons with palette: &color=green.

#### CSS variables

Important note about color option: you cannot use CSS variables. Color is not added to style, it is changed inside icon. Icon is not inlined in HTML, it is treated as an external resource. Elements of icon cannot be targeted or styled, just like any other image linked with url(), therefore, CSS variables are not available in icon.

If you want to use a CSS variable for color, do not use color option, add color to icon in your stylesheet or inline style by changing text color:

html
```
<span class="icon--mdi icon--mdi--home" style="color: var(--icon-color)"></span>
```

### More examples

You can customise generated stylesheet using various optional parameters.

Getting CSS for one icon with custom selector by adding selector parameter:

css
```
.axe-icon {
    display: inline-block;
    width: 1em;
    height: 1em;
    background: no-repeat center / 100%;
    background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 72 72' width='72' height='72'%3E%3Cpath fill='%239b9b9a' d='m7.95 17.47l18.13-4.237s.217 2.51.541 4.237a19.196 19.196 0 0 0 3.561 6.474c.756.54-7.482 11.88-10.24 12.42c-4.92.954-13.4-18.33-11.99-18.89z'/%3E%3Cpath fill='%23a57939' d='M36.41 23.25c-1.189.792-2.352.923-1.771 2.228a7.128 7.128 0 0 1 .434 1.297c.501 2.172 1.503 3.675 5.345 5.847c3.412 1.929 10.38 15.58 11.9 18.61a2.94 2.94 0 0 1 .31 1.257l.13 5.842a2.963 2.963 0 0 0 .663 1.803l1.863 2.293a2.963 2.963 0 0 0 4.132.46l3.502-2.757a2.963 2.963 0 0 0 .703-3.86l-21.27-35.2c-.873-1.445-.81-1.416-2.215-.48z'/%3E%3Crect width='13.63' height='13.53' x='14.18' y='24.84' fill='%23d0cfce' rx='2.359' ry='2.359' transform='rotate(-30)'/%3E%3Cg fill='none' stroke='%23000' stroke-linecap='round' stroke-linejoin='round' stroke-width='2'%3E%3Cpath d='M34.66 24.76c-.04.204-.002.45.138.767a7.1 7.1 0 0 1 .432 1.29c.499 2.163 1.495 3.659 5.317 5.82c3.394 1.919 10.32 15.51 11.83 18.53c.195.388.3.816.31 1.25l.128 5.815a2.95 2.95 0 0 0 .66 1.794l1.852 2.283a2.946 2.946 0 0 0 4.11.457l3.483-2.744a2.95 2.95 0 0 0 .7-3.842L42.48 21.44c-.315-.52-.525-.808-.732-.918'/%3E%3Crect width='13.56' height='13.46' x='14.32' y='25.04' rx='2.359' ry='2.359' transform='rotate(-30.014) skewX(-.028)'/%3E%3Cpath d='m31.02 24.98l-9.465 11.24c-3.463 4.049-17.14-17.64-12.65-19.27l17.34-3.026'/%3E%3C/g%3E%3C/svg%3E");
 }
```

CSS for one icon with a pseudo selector, using selector and selector parameters:

css
```
.checkbox-checked::after {
    display: inline-block;
    width: 1em;
    height: 1em;
    content: '';
    background-color: currentColor;
    -webkit-mask: no-repeat center / 100%;
    mask: no-repeat center / 100%;
    -webkit-mask-image: var(--svg);
    mask-image: var(--svg);
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cpath fill='black' d='M5 21q-.825 0-1.413-.587Q3 19.825 3 19V5q0-.825.587-1.413Q4.175 3 5 3h14q.825 0 1.413.587Q21 4.175 21 5v14q0 .825-.587 1.413Q19.825 21 19 21Zm0-2h14V5H5v14Zm5.6-3.225q.2 0 .375-.062q.175-.063.325-.213l5.675-5.675q.275-.275.275-.675t-.3-.7q-.275-.275-.7-.275q-.425 0-.7.275L10.6 13.4l-2.175-2.175q-.275-.275-.675-.275t-.7.3q-.275.275-.275.7q0 .425.275.7L9.9 15.5q.15.15.325.213q.175.062.375.062ZM5 19V5v14Z'/%3E%3C/svg%3E");
 }
```

Same as above, but sets icon color to green:

css
```
.checkbox-checked::after {
    display: inline-block;
    width: 1em;
    height: 1em;
    content: '';
    background: no-repeat center / 100%;
    background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cpath fill='green' d='M5 21q-.825 0-1.413-.587Q3 19.825 3 19V5q0-.825.587-1.413Q4.175 3 5 3h14q.825 0 1.413.587Q21 4.175 21 5v14q0 .825-.587 1.413Q19.825 21 19 21Zm0-2h14V5H5v14Zm5.6-3.225q.2 0 .375-.062q.175-.063.325-.213l5.675-5.675q.275-.275.275-.675t-.3-.7q-.275-.275-.7-.275q-.425 0-.7.275L10.6 13.4l-2.175-2.175q-.275-.275-.675-.275t-.7.3q-.275.275-.275.7q0 .425.275.7L9.9 15.5q.15.15.325.213q.175.062.375.062ZM5 19V5v14Z'/%3E%3C/svg%3E");
 }
```

CSS for multiple icons with pseudo selectors requires multiple parameters. It requires using at least icon and pseudo parameters, optionally with common and override parameters:

css
```
.icon--line-md--account-add::after,
.icon--line-md--account-delete::after {
    display: inline-block;
    width: 1em;
    height: 1em;
    content: '';
    background-color: currentColor;
    -webkit-mask: no-repeat center / 100%;
    mask: no-repeat center / 100%;
    -webkit-mask-image: var(--svg);
    mask-image: var(--svg);
 }

.icon--line-md--account-add::after {
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cg fill='none' stroke='black' stroke-linecap='round' stroke-width='2'%3E%3Cpath stroke-dasharray='20' stroke-dashoffset='20' d='M3 21V20C3 17.7909 4.79086 16 7 16H11C13.2091 16 15 17.7909 15 20V21'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' dur='0.4s' values='20;0'/%3E%3C/path%3E%3Cpath stroke-dasharray='20' stroke-dashoffset='20' d='M9 13C7.34315 13 6 11.6569 6 10C6 8.34315 7.34315 7 9 7C10.6569 7 12 8.34315 12 10C12 11.6569 10.6569 13 9 13Z'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' begin='0.5s' dur='0.4s' values='20;0'/%3E%3C/path%3E%3Cpath stroke-dasharray='8' stroke-dashoffset='8' d='M15 6H21'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' begin='1s' dur='0.2s' values='8;0'/%3E%3C/path%3E%3Cpath stroke-dasharray='8' stroke-dashoffset='8' d='M18 3V9'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' begin='1.2s' dur='0.2s' values='8;0'/%3E%3C/path%3E%3C/g%3E%3C/svg%3E");
 }

.icon--line-md--account-delete::after {
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cg fill='none' stroke='black' stroke-linecap='round' stroke-width='2'%3E%3Cpath stroke-dasharray='20' stroke-dashoffset='20' d='M3 21V20C3 17.7909 4.79086 16 7 16H11C13.2091 16 15 17.7909 15 20V21'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' dur='0.4s' values='20;0'/%3E%3C/path%3E%3Cpath stroke-dasharray='20' stroke-dashoffset='20' d='M9 13C7.34315 13 6 11.6569 6 10C6 8.34315 7.34315 7 9 7C10.6569 7 12 8.34315 12 10C12 11.6569 10.6569 13 9 13Z'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' begin='0.5s' dur='0.4s' values='20;0'/%3E%3C/path%3E%3Cpath stroke-dasharray='10' stroke-dashoffset='10' d='M15 3L21 9'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' begin='1s' dur='0.2s' values='10;0'/%3E%3C/path%3E%3Cpath stroke-dasharray='10' stroke-dashoffset='10' d='M21 3L15 9'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' begin='1.2s' dur='0.2s' values='10;0'/%3E%3C/path%3E%3C/g%3E%3C/svg%3E");
 }
```

css
```
.icon--line-md::after {
    display: inline-block;
    width: 1em;
    height: 1em;
    content: '';
    background-color: currentColor;
    -webkit-mask: no-repeat center / 100%;
    mask: no-repeat center / 100%;
    -webkit-mask-image: var(--svg);
    mask-image: var(--svg);
 }

.icon--line-md--account-add::after {
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cg fill='none' stroke='black' stroke-linecap='round' stroke-width='2'%3E%3Cpath stroke-dasharray='20' stroke-dashoffset='20' d='M3 21V20C3 17.7909 4.79086 16 7 16H11C13.2091 16 15 17.7909 15 20V21'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' dur='0.4s' values='20;0'/%3E%3C/path%3E%3Cpath stroke-dasharray='20' stroke-dashoffset='20' d='M9 13C7.34315 13 6 11.6569 6 10C6 8.34315 7.34315 7 9 7C10.6569 7 12 8.34315 12 10C12 11.6569 10.6569 13 9 13Z'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' begin='0.5s' dur='0.4s' values='20;0'/%3E%3C/path%3E%3Cpath stroke-dasharray='8' stroke-dashoffset='8' d='M15 6H21'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' begin='1s' dur='0.2s' values='8;0'/%3E%3C/path%3E%3Cpath stroke-dasharray='8' stroke-dashoffset='8' d='M18 3V9'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' begin='1.2s' dur='0.2s' values='8;0'/%3E%3C/path%3E%3C/g%3E%3C/svg%3E");
 }

.icon--line-md--account-delete::after {
    --svg: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cg fill='none' stroke='black' stroke-linecap='round' stroke-width='2'%3E%3Cpath stroke-dasharray='20' stroke-dashoffset='20' d='M3 21V20C3 17.7909 4.79086 16 7 16H11C13.2091 16 15 17.7909 15 20V21'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' dur='0.4s' values='20;0'/%3E%3C/path%3E%3Cpath stroke-dasharray='20' stroke-dashoffset='20' d='M9 13C7.34315 13 6 11.6569 6 10C6 8.34315 7.34315 7 9 7C10.6569 7 12 8.34315 12 10C12 11.6569 10.6569 13 9 13Z'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' begin='0.5s' dur='0.4s' values='20;0'/%3E%3C/path%3E%3Cpath stroke-dasharray='10' stroke-dashoffset='10' d='M15 3L21 9'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' begin='1s' dur='0.2s' values='10;0'/%3E%3C/path%3E%3Cpath stroke-dasharray='10' stroke-dashoffset='10' d='M21 3L15 9'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' begin='1.2s' dur='0.2s' values='10;0'/%3E%3C/path%3E%3C/g%3E%3C/svg%3E");
 }
```

Want to support old browsers? Add &var=null:

css
```
.icon--openmoji {
    display: inline-block;
    width: 1em;
    height: 1em;
    background: no-repeat center / 100%;
 }

.icon--openmoji--axe {
    background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 72 72' width='72' height='72'%3E%3Cpath fill='%239b9b9a' d='m7.95 17.47l18.13-4.237s.217 2.51.541 4.237a19.196 19.196 0 0 0 3.561 6.474c.756.54-7.482 11.88-10.24 12.42c-4.92.954-13.4-18.33-11.99-18.89z'/%3E%3Cpath fill='%23a57939' d='M36.41 23.25c-1.189.792-2.352.923-1.771 2.228a7.128 7.128 0 0 1 .434 1.297c.501 2.172 1.503 3.675 5.345 5.847c3.412 1.929 10.38 15.58 11.9 18.61a2.94 2.94 0 0 1 .31 1.257l.13 5.842a2.963 2.963 0 0 0 .663 1.803l1.863 2.293a2.963 2.963 0 0 0 4.132.46l3.502-2.757a2.963 2.963 0 0 0 .703-3.86l-21.27-35.2c-.873-1.445-.81-1.416-2.215-.48z'/%3E%3Crect width='13.63' height='13.53' x='14.18' y='24.84' fill='%23d0cfce' rx='2.359' ry='2.359' transform='rotate(-30)'/%3E%3Cg fill='none' stroke='%23000' stroke-linecap='round' stroke-linejoin='round' stroke-width='2'%3E%3Cpath d='M34.66 24.76c-.04.204-.002.45.138.767a7.1 7.1 0 0 1 .432 1.29c.499 2.163 1.495 3.659 5.317 5.82c3.394 1.919 10.32 15.51 11.83 18.53c.195.388.3.816.31 1.25l.128 5.815a2.95 2.95 0 0 0 .66 1.794l1.852 2.283a2.946 2.946 0 0 0 4.11.457l3.483-2.744a2.95 2.95 0 0 0 .7-3.842L42.48 21.44c-.315-.52-.525-.808-.732-.918'/%3E%3Crect width='13.56' height='13.46' x='14.32' y='25.04' rx='2.359' ry='2.359' transform='rotate(-30.014) skewX(-.028)'/%3E%3Cpath d='m31.02 24.98l-9.465 11.24c-3.463 4.049-17.14-17.64-12.65-19.27l17.34-3.026'/%3E%3C/g%3E%3C/svg%3E");
 }

.icon--openmoji--balance-scale {
    background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 72 72' width='72' height='72'%3E%3Cpath fill='%239B9B9A' d='M48.063 62.92c0-3.314-5.597-6-12.5-6s-12.5 2.686-12.5 6h25z'/%3E%3Cpath fill='%23D0CFCE' d='M24.9 46.966c0 2.193-2.198 3.972-4.91 3.972s-4.91-1.779-4.91-3.972h9.82zm33-.041c0 2.194-2.198 3.972-4.91 3.972s-4.91-1.778-4.91-3.972h9.82z'/%3E%3Cpath fill='none' stroke='%23000' stroke-linecap='round' stroke-linejoin='round' stroke-miterlimit='10' stroke-width='2' d='M16 25.17c2.666 0 8.954-5.334 20-5.334s14.667 4 20 5.334m-20-1.264v28'/%3E%3Ccircle cx='36' cy='13.895' r='3'/%3E%3Cpath fill='none' stroke='%23000' stroke-linecap='round' stroke-linejoin='round' stroke-miterlimit='10' stroke-width='2' d='M48 61.906c0-3.313-5.596-6-12.5-6s-12.5 2.687-12.5 6m3-16a6 6 0 0 1-12 0h12zm-6-18l-5 18h10zm0 0v18m39 0a6 6 0 0 1-12 0h12zm-6-18l-5 18h10zm0 0v18'/%3E%3C/svg%3E");
 }
```

... which might result in duplicate content for monotone icons:

css
```
.icon--line-md {
    display: inline-block;
    width: 1em;
    height: 1em;
    background-color: currentColor;
    -webkit-mask: no-repeat center / 100%;
    mask: no-repeat center / 100%;
 }

.icon--line-md--account-add {
    -webkit-mask-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cg fill='none' stroke='black' stroke-linecap='round' stroke-width='2'%3E%3Cpath stroke-dasharray='20' stroke-dashoffset='20' d='M3 21V20C3 17.7909 4.79086 16 7 16H11C13.2091 16 15 17.7909 15 20V21'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' dur='0.4s' values='20;0'/%3E%3C/path%3E%3Cpath stroke-dasharray='20' stroke-dashoffset='20' d='M9 13C7.34315 13 6 11.6569 6 10C6 8.34315 7.34315 7 9 7C10.6569 7 12 8.34315 12 10C12 11.6569 10.6569 13 9 13Z'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' begin='0.5s' dur='0.4s' values='20;0'/%3E%3C/path%3E%3Cpath stroke-dasharray='8' stroke-dashoffset='8' d='M15 6H21'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' begin='1s' dur='0.2s' values='8;0'/%3E%3C/path%3E%3Cpath stroke-dasharray='8' stroke-dashoffset='8' d='M18 3V9'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' begin='1.2s' dur='0.2s' values='8;0'/%3E%3C/path%3E%3C/g%3E%3C/svg%3E");
    mask-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cg fill='none' stroke='black' stroke-linecap='round' stroke-width='2'%3E%3Cpath stroke-dasharray='20' stroke-dashoffset='20' d='M3 21V20C3 17.7909 4.79086 16 7 16H11C13.2091 16 15 17.7909 15 20V21'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' dur='0.4s' values='20;0'/%3E%3C/path%3E%3Cpath stroke-dasharray='20' stroke-dashoffset='20' d='M9 13C7.34315 13 6 11.6569 6 10C6 8.34315 7.34315 7 9 7C10.6569 7 12 8.34315 12 10C12 11.6569 10.6569 13 9 13Z'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' begin='0.5s' dur='0.4s' values='20;0'/%3E%3C/path%3E%3Cpath stroke-dasharray='8' stroke-dashoffset='8' d='M15 6H21'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' begin='1s' dur='0.2s' values='8;0'/%3E%3C/path%3E%3Cpath stroke-dasharray='8' stroke-dashoffset='8' d='M18 3V9'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' begin='1.2s' dur='0.2s' values='8;0'/%3E%3C/path%3E%3C/g%3E%3C/svg%3E");
 }

.icon--line-md--account-delete {
    -webkit-mask-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cg fill='none' stroke='black' stroke-linecap='round' stroke-width='2'%3E%3Cpath stroke-dasharray='20' stroke-dashoffset='20' d='M3 21V20C3 17.7909 4.79086 16 7 16H11C13.2091 16 15 17.7909 15 20V21'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' dur='0.4s' values='20;0'/%3E%3C/path%3E%3Cpath stroke-dasharray='20' stroke-dashoffset='20' d='M9 13C7.34315 13 6 11.6569 6 10C6 8.34315 7.34315 7 9 7C10.6569 7 12 8.34315 12 10C12 11.6569 10.6569 13 9 13Z'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' begin='0.5s' dur='0.4s' values='20;0'/%3E%3C/path%3E%3Cpath stroke-dasharray='10' stroke-dashoffset='10' d='M15 3L21 9'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' begin='1s' dur='0.2s' values='10;0'/%3E%3C/path%3E%3Cpath stroke-dasharray='10' stroke-dashoffset='10' d='M21 3L15 9'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' begin='1.2s' dur='0.2s' values='10;0'/%3E%3C/path%3E%3C/g%3E%3C/svg%3E");
    mask-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 24 24' width='24' height='24'%3E%3Cg fill='none' stroke='black' stroke-linecap='round' stroke-width='2'%3E%3Cpath stroke-dasharray='20' stroke-dashoffset='20' d='M3 21V20C3 17.7909 4.79086 16 7 16H11C13.2091 16 15 17.7909 15 20V21'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' dur='0.4s' values='20;0'/%3E%3C/path%3E%3Cpath stroke-dasharray='20' stroke-dashoffset='20' d='M9 13C7.34315 13 6 11.6569 6 10C6 8.34315 7.34315 7 9 7C10.6569 7 12 8.34315 12 10C12 11.6569 10.6569 13 9 13Z'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' begin='0.5s' dur='0.4s' values='20;0'/%3E%3C/path%3E%3Cpath stroke-dasharray='10' stroke-dashoffset='10' d='M15 3L21 9'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' begin='1s' dur='0.2s' values='10;0'/%3E%3C/path%3E%3Cpath stroke-dasharray='10' stroke-dashoffset='10' d='M21 3L15 9'%3E%3Canimate fill='freeze' attributeName='stroke-dashoffset' begin='1.2s' dur='0.2s' values='10;0'/%3E%3C/path%3E%3C/g%3E%3C/svg%3E");
 }
```

See [getIconsCSS()](https://iconify.design/docs/libraries/utils/get-icons-css.html "getIconsCSS() documentation") function of [Iconify Utils](https://iconify.design/docs/libraries/utils/) for more examples.

[Page 234](https://iconify.design/docs/api/icon-data.html "Current Page.")

## Icon data on demand

Main feature of [Iconify icon components](https://iconify.design/icon-components/) is ability to load icon data on demand.

Instead of bundling icons, developer passes icon name to icon component, data for used icons is loaded from Iconify API. This approach has the following advantages:

- Only icons displayed on page are loaded.
- Easy to use. No bundling required.
- UI can be made configurable, such as allowing user to choose icons using icon picker.

## Process

How does loading icon data on demand work?

## Query

To load data for icons, use the following API query: /{prefix}.json?icons={icons}, where:

- "{prefix}" is icon set prefix. To request icons from multiple icon sets, send separate queries for each icon set.
- "{icons}" is list of icon names, separated by comma.

Response is [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") object.

json
```
{
    "prefix": "mdi",
    "icons": {
        "account-box": {
            "body": "<path d=\"M6 17c0-2 4-3.1 6-3.1s6 1.1 6 3.1v1H6m9-9a3 3 0 0 1-3 3a3 3 0 0 1-3-3a3 3 0 0 1 3-3a3 3 0 0 1 3 3M3 5v14a2 2 0 0 0 2 2h14a2 2 0 0 0 2-2V5a2 2 0 0 0-2-2H5a2 2 0 0 0-2 2z\" fill=\"currentColor\"/>"
        },
        "account-cash": {
            "body": "<path d=\"M11 8c0 2.21-1.79 4-4 4s-4-1.79-4-4s1.79-4 4-4s4 1.79 4 4m0 6.72V20H0v-2c0-2.21 3.13-4 7-4c1.5 0 2.87.27 4 .72M24 20H13V3h11v17m-8-8.5a2.5 2.5 0 0 1 5 0a2.5 2.5 0 0 1-5 0M22 7a2 2 0 0 1-2-2h-3c0 1.11-.89 2-2 2v9a2 2 0 0 1 2 2h3c0-1.1.9-2 2-2V7z\" fill=\"currentColor\"/>"
        },
        "account": {
            "body": "<path d=\"M12 4a4 4 0 0 1 4 4a4 4 0 0 1-4 4a4 4 0 0 1-4-4a4 4 0 0 1 4-4m0 10c4.42 0 8 1.79 8 4v2H4v-2c0-2.21 3.58-4 8-4z\" fill=\"currentColor\"/>"
        },
        "home": {
            "body": "<path d=\"M10 20v-6h4v6h5v-8h3L12 3L2 12h3v8h5z\" fill=\"currentColor\"/>"
        }
    },
    "width": 24,
    "height": 24
}
```

### Parameters

Query has one required parameter: icons, described above.

There are also optional parameters:

- pretty, boolean. Formats response, making it easy to read, like shown in example above.

### Error response

If icon set is not available, server returns 404 HTTP error.

Missing icons are added to not\_found property of response.

## Type

For full description of response, see [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") type documentation.

You can import type from @iconify/types package.

## Limitations

You cannot request data for multiple icon sets in same query. It is one query per icon set.

Number of icons per query is not limited, however be aware that browsers have limit on URL length. [Iconify icon components](https://iconify.design/icon-components/) limit URL length to 500. If URL is longer than 500 characters, API query should be split into multiple queries.

## Caching

To help browser cache responses, it is recommended to have the same URLs for queries. To achive that, sort icon names alphabetically, so instead of?icons=foo,bar or?icons=bar,foo component always requests?icons=bar,foo.

Additionally, cache responses in localStorage.

## Checking for update

To check if icons were updated since last time, no need to retrieve icons again.

Use [/last-modified](https://iconify.design/docs/last-modified.html) query. It returns lastModified property of icon set, which you can compare to values in cached responses.

[Page 235](https://iconify.design/docs/api/last-modified.html "Current Page.")

## Last icon set modification time

Most icon sets have last modification time in lastModified property of [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") object.

If you have cached icon data, you might want to see if it was updated. You can do that by requesting icon data again, but that is inefficient.

With /last-modified API query you can get lastModified value for multiple icon sets with one simple query!

## Query

API query is /last-modified.

Optional parameters:

- prefix, string. Icon set prefix if you want to get result only for one icon set.
- prefixes, string. Comma separated list of icon set prefixes. You can use partial prefixes that end with "-", such as "mdi-" matches "mdi-light".

Response contains lastModified object, where key is icon set prefix, value is lastModified property from that icon set.

json
```
{
    "lastModified": {
        "mdi": 1665726087,
        "tabler": 1667373464,
        "mdi-light": 1656182719
    }
}
```

### Error response

If requested icon sets are not found, server returns an empty object:

json
```
{
    "lastModified": {}
}
```

## Type

ts
```
export interface APIv3LastModifiedResponse {
    lastModified: Record<string, number>;
 }
```

[Page 236](https://iconify.design/docs/api/collections.html "Current Page.")

## List of icon sets

You can get list of available icon sets using /collections API query.

## Query

API query is /collections.

Optional parameters:

- prefix, string. Icon set prefix if you want to get the result only for one icon set.
- prefixes, string. Comma separated list of icon set prefixes. You can use partial prefixes that end with "-", such as "mdi-" matches "mdi-light".

Response is an object, where key is icon set prefix, value is [IconifyInfo](https://iconify.design/docs/types/iconify-info.html "IconifyInfo documentation") object.

Only icon sets that have info will be returned. If you want to hide an icon set, do not set the info object when importing it.

json
```
{
    "fa6-solid": {
        "name": "Font Awesome Solid",
        "total": 1388,
        "version": "6.2.0",
        "author": {
            "name": "Dave Gandy",
            "url": "https://github.com/FortAwesome/Font-Awesome"
        },
        "license": {
            "title": "CC BY 4.0",
            "spdx": "CC-BY-4.0",
            "url": "https://creativecommons.org/licenses/by/4.0/"
        },
        "samples": ["location-pin", "gem", "folder"],
        "height": 32,
        "displayHeight": 16,
        "category": "General",
        "palette": false
    },
    "fa6-regular": {
        "name": "Font Awesome Regular",
        "total": 163,
        "version": "6.2.0",
        "author": {
            "name": "Dave Gandy",
            "url": "https://github.com/FortAwesome/Font-Awesome"
        },
        "license": {
            "title": "CC BY 4.0",
            "spdx": "CC-BY-4.0",
            "url": "https://creativecommons.org/licenses/by/4.0/"
        },
        "samples": ["message", "clock", "folder"],
        "height": 32,
        "displayHeight": 16,
        "category": "General",
        "palette": false
    },
    "fa6-brands": {
        "name": "Font Awesome Brands",
        "total": 465,
        "version": "6.2.0",
        "author": {
            "name": "Dave Gandy",
            "url": "https://github.com/FortAwesome/Font-Awesome"
        },
        "license": {
            "title": "CC BY 4.0",
            "spdx": "CC-BY-4.0",
            "url": "https://creativecommons.org/licenses/by/4.0/"
        },
        "samples": ["strava", "css3", "y-combinator"],
        "height": 32,
        "displayHeight": 16,
        "category": "Brands / Social",
        "palette": false
    },
    "fa-solid": {
        "name": "Font Awesome 5 Solid",
        "total": 1001,
        "version": "5.15.4",
        "author": {
            "name": "Dave Gandy",
            "url": "https://github.com/FortAwesome/Font-Awesome"
        },
        "license": {
            "title": "CC BY 4.0",
            "spdx": "CC-BY-4.0",
            "url": "https://creativecommons.org/licenses/by/4.0/"
        },
        "samples": ["search-plus", "paste", "comment-dots"],
        "height": 32,
        "displayHeight": 16,
        "category": "Archive / Unmaintained",
        "palette": false
    },
    "fa-regular": {
        "name": "Font Awesome 5 Regular",
        "total": 151,
        "version": "5.15.4",
        "author": {
            "name": "Dave Gandy",
            "url": "https://github.com/FortAwesome/Font-Awesome"
        },
        "license": {
            "title": "CC BY 4.0",
            "spdx": "CC-BY-4.0",
            "url": "https://creativecommons.org/licenses/by/4.0/"
        },
        "samples": ["bell", "comment", "hand-point-left"],
        "height": 32,
        "displayHeight": 16,
        "category": "Archive / Unmaintained",
        "palette": false
    },
    "fa-brands": {
        "name": "Font Awesome 5 Brands",
        "total": 457,
        "version": "5.15.4",
        "author": {
            "name": "Dave Gandy",
            "url": "https://github.com/FortAwesome/Font-Awesome"
        },
        "license": {
            "title": "CC BY 4.0",
            "spdx": "CC-BY-4.0",
            "url": "https://creativecommons.org/licenses/by/4.0/"
        },
        "samples": ["amazon", "cc-visa", "chrome"],
        "height": 32,
        "displayHeight": 16,
        "category": "Archive / Unmaintained",
        "palette": false
    },
    "fa": {
        "name": "Font Awesome 4",
        "total": 678,
        "version": "4.7.0",
        "author": {
            "name": "Dave Gandy",
            "url": "https://github.com/FortAwesome/Font-Awesome/tree/fa-4"
        },
        "license": {
            "title": "Open Font License",
            "spdx": "OFL-1.1",
            "url": "https://scripts.sil.org/cms/scripts/page.php?site_id=nrsi&id=OFL"
        },
        "samples": ["wrench", "bell-o", "user-o"],
        "category": "Archive / Unmaintained",
        "palette": false
    }
}
```

### Error response

If browsing icons is disabled, route is not handled, server returns 404 HTTP error.

## Type

ts
```
import type { IconifyInfo } from '@iconify/types';

export type APIv2CollectionsList = Record<string, IconifyInfo>;
```

[Page 237](https://iconify.design/docs/api/collection.html "Current Page.")

## List of icons

You can get a list of icons in an icon set sets using /collection API query.

## Query

API query is /collection.

Required parameter:

- prefix, string. Icon set prefix.

Optional parameters:

- info, boolean. If enabled, the response will include icon set information.
- chars, boolean. If enabled, the response will include the character map. The character map exists only in icon sets that were imported from icon fonts.

## Response

Response is a complex object with the following required properties:

- prefix, string - icon set prefix.
- total, number - total number of visible icons.

Then there are many optional properties.

### Icons

Properties that are relevant for a list of icons:

- uncategorized, string\[\] - list of icon names that aren't in any category.
- categories, Record<string,string\[\]> - list of icons sorted by categories. Key is category title, value is a list of icon names that belong to that category.
- hidden, string\[\] - list of hidden icons. Usually icons are marked as hidden if at some point they were removed from the icon set. To prevent user apps from breaking, icons are never deleted, they are marked as hidden instead, but still can be used in apps.
- aliases, Record<string,string> - list of aliases. Key is alias, value is parent icon name.

To get a list of all icon names that should be shown, use the following logic:

- Get values from uncategorized property, if it exists.
- Traverse all categories from categories property, if it exists. One icon can exist in multiple categories, so check for duplicates, the easiest way to do that is to use Set class in JavaScript instead of Array.

To get all icon names, add to the result above:

- Keys of aliases object, if it exists. It should not be displayed in the list of icons because they are duplicate names for other icons.
- Values from hidden property, if it exists. It should not be displayed in the list of icons because these are hidden icons. To prevent user apps from breaking, icons are never deleted, they are marked as hidden instead, but still can be used in apps.

### Other properties

Other optional properties:

- info, [IconifyInfo](https://iconify.design/docs/types/iconify-info.html "IconifyInfo documentation") - icon set information, set if info parameter was enabled.
- title, string - icon set name, usually a duplicate of info.name.
- chars, Record<string,string> - map of characters, where key is a character as hexadecimal string, value is an icon name. It exists only for icon sets that were imported from icon fonts. It can be used to allow user to search icon name by character code.
- themes, prefixes and suffixes - icon set themes. Property themes is deprecated, so it can be ignored.

See [IconifyJSON](https://iconify.design/docs/types/iconify-json.html "IconifyJSON documentation") type and [metadata documentation](https://iconify.design/types/iconify-json-metadata.html).

Only icon sets that have info can be browsed. If you want to hide an icon set, do not set the info object when importing it.

## Simple example

This is a basic icon set, without categories or any extra metadata:

json
```
{
    "prefix": "mdi-light",
    "total": 267,
    "title": "Material Design Light",
    "uncategorized": [
        "account",
        "account-alert",
        "alarm",
        "alarm-plus",
        "alert",
        "alert-circle",
        "alert-octagon",
        "arrange-bring-forward",
        "arrange-bring-to-front",
        "arrange-send-backward",
        "arrange-send-to-back",
        "arrow-down",
        "arrow-down-circle",
        "arrow-left",
        "arrow-left-circle",
        "arrow-right",
        "arrow-right-circle",
        "arrow-up",
        "arrow-up-circle",

        "view-dashboard",
        "view-module",
        "volume",
        "volume-minus",
        "volume-mute",
        "volume-off",
        "volume-plus",
        "wallet",
        "wifi",
        "xml"
    ]
}
```

Actual API response is a lot bigger. Example was reduced.

## Categories example

Icon set in example below:

- uses categories to sort icons (categories can be combined with uncategorized from example above, so check both properties to get all icons).
- has hidden icons.
- has aliases.
- has [theme suffixes](https://iconify.design/types/iconify-json-metadata.html).

json
```
{
    "prefix": "line-md",
    "total": 395,
    "title": "Material Line Icons",
    "categories": {
        "Account": [
            "account",
            "account-add",
            "account-alert",
            "account-delete",
            "account-remove",
            "account-small"
        ],
        "Alerts": [
            "alert",
            "alert-circle",
            "alert-circle-twotone",
            "alert-twotone",
            "bell",
            "bell-twotone",
            "question",
            "question-circle",
            "question-circle-twotone"
        ],
        "Food and Drink": [
            "beer",
            "beer-alt-filled",
            "beer-alt-filled-loop",
            "beer-alt-twotone",
            "beer-alt-twotone-loop",
            "beer-filled",
            "beer-loop",
            "beer-twotone",
            "beer-twotone-loop",
            "coffee",
            "coffee-arrow",
            "coffee-arrow-filled",
            "coffee-arrow-twotone",
            "coffee-filled",
            "coffee-half-empty-twotone-loop",
            "coffee-loop",
            "coffee-twotone",
            "coffee-twotone-loop"
        ]
    },
    "hidden": ["iconify2"],
    "aliases": {
        "beer-alt-solid": "beer-alt-filled",
        "beer-alt-solid-loop": "beer-alt-filled-loop",
        "beer-solid": "beer-filled",
        "check-list-3-solid": "check-list-3-filled",
        "grid-3-solid": "grid-3-filled",
        "list-3-solid": "list-3-filled"
    },
    "suffixes": {
        "": "Outline Animation",
        "out": "Erase Animation",
        "loop": "Looping Animation",
        "transition": "Transition Between Icons"
    }
}
```

Actual API response is a lot bigger. Example was reduced.

### Error response

If an icon set is not found or cannot be browsed, server returns 404 HTTP error.

If browsing icons is disabled, route is not handled, server returns 404 HTTP error.

## Type

Type for API response:

ts
```
import type { IconifyInfo, IconifyJSON } from '@iconify/types';

export interface APIv2CollectionResponse {
    // Icon set prefix
    prefix: string;

    // Number of icons (duplicate of info?.total)
    total: number;

    // Icon set title, if available (duplicate of info?.name)
    title?: string;

    // Icon set info
    info?: IconifyInfo;

    // List of icons without categories
    uncategorized?: string[];

    // List of icons, sorted by category
    categories?: Record<string, string[]>;

    // List of hidden icons
    hidden?: string[];

    // List of aliases, key = alias, value = parent icon
    aliases?: Record<string, string>;

    // Characters, key = character, value = icon name
    chars?: Record<string, string>;

    // Themes
    themes?: IconifyJSON['themes'];
    prefixes?: IconifyJSON['prefixes'];
    suffixes?: IconifyJSON['suffixes'];
 }
```

[Page 238](https://iconify.design/docs/api/search.html "Current Page.")

## Searching icons

You can search icons using /search API query.

## Query

API query is /search.

Required parameter:

- query, string. Search query. Case insensitive.

Optional parameters:

- limit, number. Search results limit.
- start, number. Start index of result. See below.
- prefix, string. Icon set prefix if you want to get result only for one icon set.
- prefixes, string. Comma separated list of icon set prefixes. You can use partial prefixes that end with "-", such as "mdi-" matches "mdi-light".
- category, string. Limit search to icon sets from specific category.

### Limit and start

If your UI uses pagination, please consider saving API resources by not sending unnecessary search queries.

You can use the following logic:

- Set limit to number of icons that fit in first 2 pages.
- If numer of icons in result matches limit, it means there are more icons to show.
- If there are more icons to show, when visitor clicks second page, retrieve the rest of results by setting limit to 999. You can also set start to number of icons retrieved in first query, but that doesn't change much because search function on server can't just resume from old state, so it checks all icons anyway.

### Changing limit

There are limits on what you can set limit property to:

- Minimum value: 32.
- Default value, used if property is not set: 64.
- Maximum value: 999.

You can change limits in API code in src/http/responses/search.ts.

## Response

Response is a simple object with the following properties:

- icons, string\[\] - list of icons. Each icon name includes icon set prefix + name: "mdi-light:home"
- total, number - number of results. Same length of icons property.
- limit, number - results limit set by search. If matches total, there are more results available.
- start, number - index of first result.
- collections, Record<string,[IconifyInfo](https://iconify.design/docs/types/iconify-info.html "IconifyInfo documentation") > - info blocks for icon sets used in results.
- request - copy of request parameters. All values in this object are string, as they are passed to query.

## Examples

json
```
{
    "icons": [
        "material-symbols:add-home",
        "material-symbols:add-home-outline",
        "material-symbols:add-home-outline-rounded",
        "material-symbols:add-home-rounded",
        "material-symbols:add-home-work",
        "material-symbols:add-home-work-outline",
        "material-symbols:add-home-work-outline-rounded",
        "material-symbols:add-home-work-rounded",
        "material-symbols:add-to-home-screen",
        "material-symbols:add-to-home-screen-outline",
        "material-symbols:add-to-home-screen-outline-rounded",
        "material-symbols:add-to-home-screen-outline-sharp",
        "material-symbols:add-to-home-screen-rounded",
        "material-symbols:add-to-home-screen-sharp",
        "material-symbols:broadcast-on-home",
        "material-symbols:broadcast-on-home-outline",
        "material-symbols:broadcast-on-home-outline-rounded",
        "material-symbols:broadcast-on-home-outline-sharp",
        "material-symbols:broadcast-on-home-rounded",
        "material-symbols:broadcast-on-home-sharp",
        "material-symbols:digital-out-of-home",
        "material-symbols:emergency-home",
        "material-symbols:emergency-home-outline",
        "material-symbols:emergency-home-outline-rounded",
        "material-symbols:emergency-home-rounded",
        "material-symbols:garage-home",
        "material-symbols:garage-home-outline",
        "material-symbols:home",
        "material-symbols:home-app-logo",
        "material-symbols:home-iot-device",
        "material-symbols:home-iot-device-outline",
        "material-symbols:home-max",
        "material-symbols:home-max-dots",
        "material-symbols:home-max-dots-outline",
        "material-symbols:home-max-outline",
        "material-symbols:home-max-outline-rounded",
        "material-symbols:home-max-rounded",
        "material-symbols:home-mini",
        "material-symbols:home-mini-outline",
        "material-symbols:home-outline",
        "material-symbols:home-outline-rounded",
        "material-symbols:home-pin",
        "material-symbols:home-repair-service",
        "material-symbols:home-repair-service-outline",
        "material-symbols:home-repair-service-outline-rounded",
        "material-symbols:home-repair-service-outline-sharp",
        "material-symbols:home-repair-service-rounded",
        "material-symbols:home-repair-service-sharp",
        "material-symbols:home-rounded",
        "material-symbols:home-speaker",
        "material-symbols:home-speaker-outline",
        "material-symbols:home-storage",
        "material-symbols:home-storage-outline",
        "material-symbols:home-storage-outline-rounded",
        "material-symbols:home-storage-outline-sharp",
        "material-symbols:home-storage-rounded",
        "material-symbols:home-storage-sharp",
        "material-symbols:home-work",
        "material-symbols:home-work-outline",
        "material-symbols:home-work-outline-rounded",
        "material-symbols:home-work-rounded",
        "material-symbols:in-home-mode",
        "material-symbols:location-home",
        "ic:baseline-add-home"
    ],
    "total": 64,
    "limit": 64,
    "start": 0,
    "collections": {
        "material-symbols": {
            "name": "Material Symbols",
            "total": 8413,
            "author": {
                "name": "Google",
                "url": "https://github.com/google/material-design-icons"
            },
            "license": {
                "title": "Apache 2.0",
                "spdx": "Apache-2.0",
                "url": "https://github.com/google/material-design-icons/blob/master/LICENSE"
            },
            "samples": ["downloading", "privacy-tip", "filter-drama-outline"],
            "height": 24,
            "category": "General",
            "palette": false
        },
        "ic": {
            "name": "Google Material Icons",
            "total": 10955,
            "version": "1.0.32",
            "author": {
                "name": "Material Design Authors",
                "url": "https://github.com/material-icons/material-icons"
            },
            "license": {
                "title": "Apache 2.0",
                "spdx": "Apache-2.0",
                "url": "https://github.com/material-icons/material-icons/blob/master/LICENSE"
            },
            "samples": [
                "baseline-notifications-active",
                "outline-person-outline",
                "twotone-videocam-off"
            ],
            "height": 24,
            "category": "General",
            "palette": false
        }
    },
    "request": {
        "query": "home",
        "pretty": "1"
    }
}
```

json
```
{
    "icons": [
        "ph:arrows-horizontal",
        "ph:arrows-horizontal-bold",
        "ph:arrows-horizontal-duotone",
        "ph:arrows-horizontal-fill",
        "ph:arrows-horizontal-light",
        "ph:arrows-horizontal-thin",
        "carbon:arrows-horizontal",
        "tabler:arrows-horizontal",
        "pixelarticons:arrows-horizontal",
        "humbleicons:arrows-horizontal",
        "nimbus:arrows-horizontal",
        "line-md:arrows-horizontal",
        "line-md:arrows-horizontal-alt"
    ],
    "total": 13,
    "limit": 999,
    "start": 0,
    "collections": {
        "material-symbols": {
            "name": "Material Symbols",
            "total": 8413,
            "author": {
                "name": "Google",
                "url": "https://github.com/google/material-design-icons"
            },
            "license": {
                "title": "Apache 2.0",
                "spdx": "Apache-2.0",
                "url": "https://github.com/google/material-design-icons/blob/master/LICENSE"
            },
            "samples": ["downloading", "privacy-tip", "filter-drama-outline"],
            "height": 24,
            "category": "General",
            "palette": false
        },
        "ic": {
            "name": "Google Material Icons",
            "total": 10955,
            "version": "1.0.32",
            "author": {
                "name": "Material Design Authors",
                "url": "https://github.com/material-icons/material-icons"
            },
            "license": {
                "title": "Apache 2.0",
                "spdx": "Apache-2.0",
                "url": "https://github.com/material-icons/material-icons/blob/master/LICENSE"
            },
            "samples": [
                "baseline-notifications-active",
                "outline-person-outline",
                "twotone-videocam-off"
            ],
            "height": 24,
            "category": "General",
            "palette": false
        },
        "mdi": {
            "name": "Material Design Icons",
            "total": 7134,
            "author": {
                "name": "Austin Andrews",
                "url": "https://github.com/Templarian/MaterialDesign"
            },
            "license": {
                "title": "Apache 2.0",
                "spdx": "Apache-2.0",
                "url": "https://github.com/Templarian/MaterialDesign/blob/master/LICENSE"
            },
            "samples": ["account-check", "bell-alert-outline", "calendar-edit"],
            "height": 24,
            "category": "General",
            "palette": false
        },
        "ph": {
            "name": "Phosphor",
            "total": 6282,
            "version": "1.4.2",
            "author": {
                "name": "Phosphor Icons",
                "url": "https://github.com/phosphor-icons/phosphor-icons"
            },
            "license": {
                "title": "MIT",
                "spdx": "MIT",
                "url": "https://github.com/phosphor-icons/phosphor-icons/blob/master/LICENSE"
            },
            "samples": [
                "folder-notch-open-duotone",
                "check-square-offset-thin",
                "pencil-line-fill"
            ],
            "height": 24,
            "category": "General",
            "palette": false
        },
        "carbon": {
            "name": "Carbon",
            "total": 1859,
            "version": "11.10.0",
            "author": {
                "name": "IBM",
                "url": "https://github.com/carbon-design-system/carbon/tree/main/packages/icons"
            },
            "license": {
                "title": "Apache 2.0",
                "spdx": "Apache-2.0"
            },
            "samples": ["user-certification", "humidity", "edit-off"],
            "height": 32,
            "displayHeight": 16,
            "category": "General",
            "palette": false
        },
        "bi": {
            "name": "Bootstrap Icons",
            "total": 1851,
            "version": "1.9.1",
            "author": {
                "name": "The Bootstrap Authors",
                "url": "https://github.com/twbs/icons"
            },
            "license": {
                "title": "MIT",
                "spdx": "MIT",
                "url": "https://github.com/twbs/icons/blob/main/LICENSE.md"
            },
            "samples": ["graph-up", "card-image", "code-slash"],
            "height": 16,
            "category": "General",
            "palette": false
        },
        "tabler": {
            "name": "Tabler Icons",
            "total": 2925,
            "version": "1.109.0",
            "author": {
                "name": "Paweł Kuna",
                "url": "https://github.com/tabler/tabler-icons"
            },
            "license": {
                "title": "MIT",
                "spdx": "MIT",
                "url": "https://github.com/tabler/tabler-icons/blob/master/LICENSE"
            },
            "samples": ["alien", "device-desktop", "photo"],
            "height": 24,
            "category": "General",
            "palette": false
        },
        "uil": {
            "name": "Unicons",
            "total": 1206,
            "version": "4.0.1",
            "author": {
                "name": "Iconscout",
                "url": "https://github.com/Iconscout/unicons"
            },
            "license": {
                "title": "Apache 2.0",
                "spdx": "Apache-2.0",
                "url": "https://github.com/Iconscout/unicons/blob/master/LICENSE"
            },
            "samples": ["arrow-circle-right", "chat-bubble-user", "edit-alt"],
            "height": 24,
            "category": "General",
            "palette": false
        },
        "clarity": {
            "name": "Clarity",
            "total": 1103,
            "author": {
                "name": "VMware",
                "url": "https://github.com/vmware/clarity"
            },
            "license": {
                "title": "MIT",
                "spdx": "MIT",
                "url": "https://github.com/vmware/clarity-assets/blob/master/LICENSE"
            },
            "samples": [
                "help-outline-badged",
                "heart-broken-solid",
                "shield-outline-alerted"
            ],
            "height": 36,
            "displayHeight": 18,
            "category": "General",
            "palette": false
        },
        "majesticons": {
            "name": "Majesticons",
            "total": 760,
            "version": "2.1.2",
            "author": {
                "name": "Gerrit Halfmann",
                "url": "https://github.com/halfmage/majesticons"
            },
            "license": {
                "title": "MIT",
                "spdx": "MIT",
                "url": "https://github.com/halfmage/majesticons/blob/main/LICENSE"
            },
            "samples": ["chats-line", "home", "edit-pen-4-line"],
            "height": 24,
            "category": "General",
            "palette": false
        },
        "ant-design": {
            "name": "Ant Design Icons",
            "total": 789,
            "version": "4.2.1",
            "author": {
                "name": "HeskeyBaozi",
                "url": "https://github.com/ant-design/ant-design-icons"
            },
            "license": {
                "title": "MIT",
                "spdx": "MIT",
                "url": "https://github.com/ant-design/ant-design-icons/blob/master/LICENSE"
            },
            "samples": ["pushpin-filled", "pie-chart-outlined", "shopping-twotone"],
            "height": 16,
            "category": "General",
            "palette": false
        },
        "gg": {
            "name": "css.gg",
            "total": 704,
            "version": "2.0.0",
            "author": {
                "name": "Astrit",
                "url": "https://github.com/astrit/css.gg"
            },
            "license": {
                "title": "MIT",
                "spdx": "MIT",
                "url": "https://github.com/astrit/css.gg/blob/master/LICENSE"
            },
            "samples": ["align-left", "server", "overflow"],
            "height": 24,
            "category": "General",
            "palette": false
        },
        "pixelarticons": {
            "name": "Pixelarticons",
            "total": 480,
            "version": "1.7.0",
            "author": {
                "name": "Gerrit Halfmann",
                "url": "https://github.com/halfmage/pixelarticons"
            },
            "license": {
                "title": "MIT",
                "spdx": "MIT",
                "url": "https://github.com/halfmage/pixelarticons/blob/master/LICENSE"
            },
            "samples": ["drag-and-drop", "arrows-horizontal", "heart"],
            "height": 24,
            "category": "General",
            "palette": false
        },
        "humbleicons": {
            "name": "Humbleicons",
            "total": 235,
            "version": "1.9.0",
            "author": {
                "name": "Jiří Zralý",
                "url": "https://github.com/zraly/humbleicons"
            },
            "license": {
                "title": "MIT",
                "spdx": "MIT",
                "url": "https://github.com/zraly/humbleicons/blob/master/license"
            },
            "samples": ["aid", "droplet", "rss"],
            "height": 24,
            "category": "General",
            "palette": false
        },
        "uim": {
            "name": "Unicons Monochrome",
            "total": 296,
            "version": "4.0.1",
            "author": {
                "name": "Iconscout",
                "url": "https://github.com/Iconscout/unicons"
            },
            "license": {
                "title": "Apache 2.0",
                "spdx": "Apache-2.0",
                "url": "https://github.com/Iconscout/unicons/blob/master/LICENSE"
            },
            "samples": ["airplay", "circle-layer", "lock-access"],
            "height": 24,
            "category": "General",
            "palette": false
        },
        "uit": {
            "name": "Unicons Thin Line",
            "total": 214,
            "version": "4.0.1",
            "author": {
                "name": "Iconscout",
                "url": "https://github.com/Iconscout/unicons"
            },
            "license": {
                "title": "Apache 2.0",
                "spdx": "Apache-2.0",
                "url": "https://github.com/Iconscout/unicons/blob/master/LICENSE"
            },
            "samples": ["circuit", "favorite", "toggle-on"],
            "height": 24,
            "category": "General",
            "palette": false
        },
        "uis": {
            "name": "Unicons Solid",
            "total": 189,
            "version": "4.0.1",
            "author": {
                "name": "Iconscout",
                "url": "https://github.com/Iconscout/unicons"
            },
            "license": {
                "title": "Apache 2.0",
                "spdx": "Apache-2.0",
                "url": "https://github.com/Iconscout/unicons/blob/master/LICENSE"
            },
            "samples": ["analysis", "check", "user-md"],
            "height": 24,
            "category": "General",
            "palette": false
        },
        "fluent": {
            "name": "Fluent UI System Icons",
            "total": 11814,
            "version": "1.1.179",
            "author": {
                "name": "Microsoft Corporation",
                "url": "https://github.com/microsoft/fluentui-system-icons"
            },
            "license": {
                "title": "MIT",
                "spdx": "MIT",
                "url": "https://github.com/microsoft/fluentui-system-icons/blob/master/LICENSE"
            },
            "samples": [
                "zoom-out-24-filled",
                "drink-coffee-24-regular",
                "photo-filter-24-regular"
            ],
            "displayHeight": 24,
            "category": "General",
            "palette": false
        },
        "icon-park-outline": {
            "name": "IconPark Outline",
            "total": 2658,
            "version": "1.4.2",
            "author": {
                "name": "ByteDance",
                "url": "https://github.com/bytedance/IconPark"
            },
            "license": {
                "title": "Apache 2.0",
                "spdx": "Apache-2.0",
                "url": "https://github.com/bytedance/IconPark/blob/master/LICENSE"
            },
            "samples": ["add-one", "english-mustache", "basketball-clothes"],
            "height": 24,
            "category": "General",
            "palette": false
        },
        "icon-park-solid": {
            "name": "IconPark Solid",
            "total": 1965,
            "version": "1.4.2",
            "author": {
                "name": "ByteDance",
                "url": "https://github.com/bytedance/IconPark"
            },
            "license": {
                "title": "Apache 2.0",
                "spdx": "Apache-2.0",
                "url": "https://github.com/bytedance/IconPark/blob/master/LICENSE"
            },
            "samples": ["add-one", "english-mustache", "basketball-clothes"],
            "height": 24,
            "category": "General",
            "palette": false
        },
        "icon-park-twotone": {
            "name": "IconPark TwoTone",
            "total": 1944,
            "version": "1.4.2",
            "author": {
                "name": "ByteDance",
                "url": "https://github.com/bytedance/IconPark"
            },
            "license": {
                "title": "Apache 2.0",
                "spdx": "Apache-2.0",
                "url": "https://github.com/bytedance/IconPark/blob/master/LICENSE"
            },
            "samples": ["add-one", "english-mustache", "basketball-clothes"],
            "height": 24,
            "category": "General",
            "palette": false
        },
        "icon-park": {
            "name": "IconPark",
            "total": 2658,
            "version": "1.4.2",
            "author": {
                "name": "ByteDance",
                "url": "https://github.com/bytedance/IconPark"
            },
            "license": {
                "title": "Apache 2.0",
                "spdx": "Apache-2.0",
                "url": "https://github.com/bytedance/IconPark/blob/master/LICENSE"
            },
            "samples": ["add-one", "english-mustache", "basketball-clothes"],
            "height": 24,
            "category": "General",
            "palette": true
        },
        "jam": {
            "name": "Jam Icons",
            "total": 940,
            "author": {
                "name": "Michael Amprimo",
                "url": "https://github.com/michaelampr/jam"
            },
            "license": {
                "title": "MIT",
                "spdx": "MIT",
                "url": "https://github.com/michaelampr/jam/blob/master/LICENSE"
            },
            "samples": ["chevrons-square-up-right", "luggage-f", "rubber"],
            "height": 24,
            "category": "General",
            "palette": false
        },
        "heroicons": {
            "name": "HeroIcons",
            "total": 876,
            "version": "2.0.13",
            "author": {
                "name": "Refactoring UI Inc",
                "url": "https://github.com/tailwindlabs/heroicons"
            },
            "license": {
                "title": "MIT",
                "spdx": "MIT",
                "url": "https://github.com/tailwindlabs/heroicons/blob/master/LICENSE"
            },
            "samples": ["camera", "building-library", "receipt-refund"],
            "height": [24, 20],
            "category": "General",
            "palette": false
        },
        "fa6-solid": {
            "name": "Font Awesome Solid",
            "total": 1388,
            "version": "6.2.0",
            "author": {
                "name": "Dave Gandy",
                "url": "https://github.com/FortAwesome/Font-Awesome"
            },
            "license": {
                "title": "CC BY 4.0",
                "spdx": "CC-BY-4.0",
                "url": "https://creativecommons.org/licenses/by/4.0/"
            },
            "samples": ["location-pin", "gem", "folder"],
            "height": 32,
            "displayHeight": 16,
            "category": "General",
            "palette": false
        },
        "nimbus": {
            "name": "Nimbus",
            "total": 140,
            "version": "0.2.9",
            "author": {
                "name": "Linkedstore S.A.",
                "url": "https://github.com/TiendaNube/nimbus-icons"
            },
            "license": {
                "title": "MIT",
                "spdx": "MIT",
                "url": "https://github.com/TiendaNube/nimbus-icons/blob/develop/LICENSE"
            },
            "samples": ["barcode", "mail", "calendar"],
            "height": 16,
            "category": "General",
            "palette": false
        },
        "line-md": {
            "name": "Material Line Icons",
            "total": 395,
            "version": "0.2.7",
            "author": {
                "name": "Vjacheslav Trushkin",
                "url": "https://github.com/cyberalien/line-md"
            },
            "license": {
                "title": "MIT",
                "spdx": "MIT",
                "url": "https://github.com/cyberalien/line-md/blob/master/license.txt"
            },
            "samples": [
                "loading-twotone-loop",
                "beer-alt-twotone-loop",
                "image-twotone"
            ],
            "height": 24,
            "category": "Animated Icons",
            "palette": false
        },
        "openmoji": {
            "name": "OpenMoji",
            "total": 4064,
            "author": {
                "name": "OpenMoji",
                "url": "https://github.com/hfg-gmuend/openmoji"
            },
            "license": {
                "title": "CC BY-SA 4.0",
                "spdx": "CC-BY-SA-4.0",
                "url": "https://creativecommons.org/licenses/by-sa/4.0/"
            },
            "samples": ["bicycle", "bow-and-arrow", "full-moon-face"],
            "height": 18,
            "category": "Emoji",
            "palette": true
        },
        "twemoji": {
            "name": "Twitter Emoji",
            "total": 3668,
            "author": {
                "name": "Twitter",
                "url": "https://github.com/twitter/twemoji"
            },
            "license": {
                "title": "CC BY 4.0",
                "spdx": "CC-BY-4.0",
                "url": "https://creativecommons.org/licenses/by/4.0/"
            },
            "samples": ["anguished-face", "duck", "crossed-swords"],
            "height": 36,
            "displayHeight": 18,
            "category": "Emoji",
            "palette": true
        },
        "noto": {
            "name": "Noto Emoji",
            "total": 3449,
            "author": {
                "name": "Google Inc",
                "url": "https://github.com/googlefonts/noto-emoji"
            },
            "license": {
                "title": "Apache 2.0",
                "spdx": "Apache-2.0",
                "url": "https://github.com/googlefonts/noto-emoji/blob/main/LICENSE"
            },
            "samples": ["beaming-face-with-smiling-eyes", "computer-mouse", "dove"],
            "height": 16,
            "category": "Emoji",
            "palette": true
        },
        "fluent-emoji": {
            "name": "Fluent Emoji",
            "total": 2980,
            "author": {
                "name": "Microsoft Corporation",
                "url": "https://github.com/microsoft/fluentui-emoji"
            },
            "license": {
                "title": "MIT",
                "spdx": "MIT",
                "url": "https://github.com/microsoft/fluentui-emoji/blob/main/LICENSE"
            },
            "samples": ["avocado", "ticket", "yin-yang"],
            "height": 32,
            "displayHeight": 24,
            "category": "Emoji",
            "palette": true
        },
        "fluent-emoji-flat": {
            "name": "Fluent Emoji Flat",
            "total": 2980,
            "author": {
                "name": "Microsoft Corporation",
                "url": "https://github.com/microsoft/fluentui-emoji"
            },
            "license": {
                "title": "MIT",
                "spdx": "MIT",
                "url": "https://github.com/microsoft/fluentui-emoji/blob/main/LICENSE"
            },
            "samples": ["avocado", "ticket", "yin-yang"],
            "height": 32,
            "displayHeight": 24,
            "category": "Emoji",
            "palette": true
        },
        "fluent-emoji-high-contrast": {
            "name": "Fluent Emoji High Contrast",
            "total": 1545,
            "author": {
                "name": "Microsoft Corporation",
                "url": "https://github.com/microsoft/fluentui-emoji"
            },
            "license": {
                "title": "MIT",
                "spdx": "MIT",
                "url": "https://github.com/microsoft/fluentui-emoji/blob/main/LICENSE"
            },
            "samples": ["avocado", "ticket", "yin-yang"],
            "height": 32,
            "displayHeight": 24,
            "category": "Emoji",
            "palette": false
        },
        "noto-v1": {
            "name": "Noto Emoji (v1)",
            "total": 2162,
            "author": {
                "name": "Google Inc",
                "url": "https://github.com/googlefonts/noto-emoji"
            },
            "license": {
                "title": "Apache 2.0",
                "spdx": "Apache-2.0",
                "url": "https://github.com/googlefonts/noto-emoji/blob/main/LICENSE"
            },
            "samples": ["face-with-open-mouth", "no-littering", "scissors"],
            "height": 16,
            "category": "Emoji",
            "palette": true
        },
        "emojione": {
            "name": "Emoji One (Colored)",
            "total": 1834,
            "version": "2.3.0",
            "author": {
                "name": "Emoji One",
                "url": "https://github.com/EmojiTwo/emojitwo"
            },
            "license": {
                "title": "CC BY 4.0",
                "spdx": "CC-BY-4.0",
                "url": "https://creativecommons.org/licenses/by/4.0/"
            },
            "samples": [
                "anxious-face-with-sweat",
                "cloud-with-snow",
                "studio-microphone"
            ],
            "height": 32,
            "displayHeight": 16,
            "category": "Emoji",
            "palette": true
        },
        "emojione-monotone": {
            "name": "Emoji One (Monotone)",
            "total": 1403,
            "version": "2.2.7",
            "author": {
                "name": "Emoji One",
                "url": "https://github.com/EmojiTwo/emojitwo"
            },
            "license": {
                "title": "CC BY 4.0",
                "spdx": "CC-BY-4.0",
                "url": "https://creativecommons.org/licenses/by/4.0/"
            },
            "samples": ["face-with-tongue", "envelope", "frog-face"],
            "height": 32,
            "displayHeight": 16,
            "category": "Emoji",
            "palette": false
        },
        "emojione-v1": {
            "name": "Emoji One (v1)",
            "total": 1262,
            "version": "1.5.2",
            "author": {
                "name": "Emoji One",
                "url": "https://github.com/joypixels/emojione-legacy"
            },
            "license": {
                "title": "CC BY-SA 4.0",
                "spdx": "CC-BY-SA-4.0",
                "url": "https://creativecommons.org/licenses/by-sa/4.0/"
            },
            "samples": ["face-savoring-food", "panda-face", "artist-palette"],
            "height": 32,
            "displayHeight": 16,
            "category": "Emoji",
            "palette": true
        },
        "game-icons": {
            "name": "Game Icons",
            "total": 4046,
            "author": {
                "name": "GameIcons",
                "url": "https://github.com/game-icons/icons"
            },
            "license": {
                "title": "CC BY 3.0",
                "spdx": "CC-BY-3.0",
                "url": "https://github.com/game-icons/icons/blob/master/license.txt"
            },
            "samples": ["diamond-trophy", "thrown-spear", "rank-3"],
            "height": 32,
            "displayHeight": 16,
            "category": "Thematic",
            "palette": false
        },
        "la": {
            "name": "Line Awesome",
            "total": 1544,
            "version": "1.2.1",
            "author": {
                "name": "Icons8",
                "url": "https://github.com/icons8/line-awesome"
            },
            "license": {
                "title": "Apache 2.0",
                "spdx": "Apache-2.0",
                "url": "https://www.apache.org/licenses/LICENSE-2.0"
            },
            "samples": ["archive-solid", "female-solid", "check-circle"],
            "category": "Archive / Unmaintained",
            "palette": false
        },
        "entypo": {
            "name": "Entypo+",
            "total": 321,
            "author": {
                "name": "Daniel Bruce",
                "url": "https://github.com/chancancode/entypo-plus"
            },
            "license": {
                "title": "CC BY-SA 4.0",
                "spdx": "CC-BY-SA-4.0",
                "url": "https://creativecommons.org/licenses/by-sa/4.0/"
            },
            "samples": ["bell", "image", "erase"],
            "height": 20,
            "category": "Archive / Unmaintained",
            "palette": false
        },
        "foundation": {
            "name": "Foundation",
            "total": 283,
            "version": "3.0.0",
            "author": {
                "name": "Zurb",
                "url": "https://github.com/zurb/foundation-icon-fonts"
            },
            "license": {
                "title": "MIT",
                "spdx": "MIT"
            },
            "samples": ["graph-trend", "indent-more", "lock"],
            "height": 20,
            "category": "Archive / Unmaintained",
            "palette": false
        },
        "icons8": {
            "name": "Icons8 Windows 10 Icons",
            "total": 234,
            "version": "1.0.0",
            "author": {
                "name": "Icons8",
                "url": "https://github.com/icons8/windows-10-icons"
            },
            "license": {
                "title": "MIT",
                "spdx": "MIT"
            },
            "samples": ["checked", "create-new", "group"],
            "category": "Archive / Unmaintained",
            "palette": false
        },
        "heroicons-outline": {
            "name": "HeroIcons v1 Outline",
            "total": 230,
            "version": "1.0.6",
            "author": {
                "name": "Refactoring UI Inc",
                "url": "https://github.com/tailwindlabs/heroicons"
            },
            "license": {
                "title": "MIT",
                "spdx": "MIT",
                "url": "https://github.com/tailwindlabs/heroicons/blob/master/LICENSE"
            },
            "samples": ["color-swatch", "library", "receipt-refund"],
            "height": 24,
            "category": "Archive / Unmaintained",
            "palette": false
        },
        "heroicons-solid": {
            "name": "HeroIcons v1 Solid",
            "total": 230,
            "version": "1.0.6",
            "author": {
                "name": "Refactoring UI Inc",
                "url": "https://github.com/tailwindlabs/heroicons"
            },
            "license": {
                "title": "MIT",
                "spdx": "MIT",
                "url": "https://github.com/tailwindlabs/heroicons/blob/master/LICENSE"
            },
            "samples": ["color-swatch", "library", "receipt-refund"],
            "height": 20,
            "category": "Archive / Unmaintained",
            "palette": false
        },
        "fa-solid": {
            "name": "Font Awesome 5 Solid",
            "total": 1001,
            "version": "5.15.4",
            "author": {
                "name": "Dave Gandy",
                "url": "https://github.com/FortAwesome/Font-Awesome"
            },
            "license": {
                "title": "CC BY 4.0",
                "spdx": "CC-BY-4.0",
                "url": "https://creativecommons.org/licenses/by/4.0/"
            },
            "samples": ["search-plus", "paste", "comment-dots"],
            "height": 32,
            "displayHeight": 16,
            "category": "Archive / Unmaintained",
            "palette": false
        }
    },
    "request": {
        "query": "arrows-horizontal",
        "pretty": "1",
        "limit": "999"
    }
}
```

### Error response

If no matches found, search returns object with no icons:

json
```
{
  "icons": [],
  "total": 0,
  "limit": 64,
  "start": 0,
  "collections": {},
  "request": {
    "query": "zzzz",
    "pretty": "1"
  }
}
```

If query is invalid, such as missing query parameter, server returns 400 HTTP error.

If search engine is disabled, /search route is not handled, server returns 404 HTTP error.

## Type

Type for API response:

ts
```
import type { IconifyInfo } from "@iconify/types";

export interface APIv2SearchResponse {
  // List of icons, including prefixes
  icons: string[];

  // Number of results. If same as \`limit\`, more results are available
  total: number;

  // Number of results shown
  limit: number;

  // Index of first result
  start: number;

  // Info about icon sets
  collections: Record<string, IconifyInfo>;

  // Copy of request, values are string
  request: Record<keyof APIv2SearchParams, string>;
 }
```

[Page 239](https://iconify.design/docs/api/keywords.html "Current Page.")

## Icon keywords

API query /keywords is intended to be used for suggesting search queries.

## Query

API query is /keywords.

There are two variations of this query, depending on passed parameters.

You must set one of the following parameters:

- prefix, string. Keyword prefix. API returns all keywords that start with requested keyword.
- keyword, keyword. Partial keyword. API returns all keywords that start or end with requested keyword.

If you set both prefix and keyword parameters, keyword parameter will be ignored.

### Keyword

This is a very basic function. It can handle only one keyword, not multiple keywords.

Keyword requirements:

- Can contain only letters "a" - "z", numbers and "-".
- If it contains "-", only last part after "-" is checked, the rest is ignored.
- Must be at least 2 characters long.

## Response

Response is an object, which contains all properties passed in query and the following properties:

- invalid, boolean. Set to true if keyword is invalid.
- exists, boolean. Set to true if keyword exists as full keyword (with nothing or "-" before and after it in icon name).
- matches, \[type\]string\[\]\`. List of matches.

## Examples

json
```
{
    "prefix": "hom",
    "pretty": "1",
    "exists": false,
    "matches": [
        "home",
        "home2",
        "home3",
        "homee",
        "homify",
        "homewav",
        "homebrew",
        "homestay",
        "homebridge",
        "homeadvisor",
        "homeassistant",
        "homeassistantcommunitystore"
    ]
}
```

json
```
{
    "keyword": "home",
    "pretty": "1",
    "exists": true,
    "matches": [
        "home2",
        "home3",
        "homee",
        "homewav",
        "homebrew",
        "homestay",
        "homebridge",
        "homeadvisor",
        "homeassistant",
        "homeassistantcommunitystore",
        "esphome",
        "ourhome",
        "eufyhome",
        "googlehome",
        "petsathome",
        "vectorifydahome"
    ]
}
```

### Error response

If no matches found or keyword is too short, correct response is returns with matches object being empty:

json
```
{
    "keyword": "qwerty",
    "exists": false,
    "matches": []
}
```

If keyword is invalid, response includes invalid property set to true:

json
```
{
    "keyword": "_",
    "invalid": true,
    "exists": false,
    "matches": []
}
```

If search engine is disabled, /keywords route is not handled, server returns 404 HTTP error.

## Type

Type for API response:

ts
```
/**
 * Parameters for \`/keywords\` query
 *
 * One of \`prefix\` or \`keyword\` parameters must be set
 */
export interface APIv3KeywordsPrefixQuery {
    // Prefix to test: matches for 'foo' include 'foobar', but not 'barfoo'
    prefix: string;
 }

export interface APIv3KeywordsFullQuery {
    // Keyword to test: matches for 'foo' include 'foobar' and 'barfoo'
    keyword: string;
 }

export type APIv3KeywordsQuery =
    | APIv3KeywordsPrefixQuery
    | APIv3KeywordsFullQuery;

/**
 * Response for /keywords query
 *
 * Includes request + response
 */
export type APIv3KeywordsResponse = APIv3KeywordsQuery & {
    // Set to true if keyword is invalid
    invalid?: true;

    // True if partial keyword exists as is
    exists: boolean;

    // Keywords that contain partial keyword
    matches: string[];
 };
```

[Page 240](https://iconify.design/docs/api/version.html "Current Page.")

## API version query

API query /version shows:

- API version.
- Which server you are connected to, if STATUS\_REGION environment variable is set.

## Region

Purpose of this query is to be able to tell which server you are connected to, but without exposing actual location of server, which can help debug error. This is used in networks when many servers are running.

For example, public Iconify API servers are running multiple servers, placed in various locations all over the world. DNS is configured to redirect visitor to the closest server using AWS Route53 latency routing. This guarantees smallest possible response time. See [building budged CDN article](https://iconify.design/docs/cdn.html) for details.

If something goes wrong, it would be nice to know which server is causing problems, but without exposing actual IP address of server and /version query solves that.

## Query

API query is /version.

There are no parameters.

## Response

Response plain text, showing version number.

## Examples

Basic response:

```
Iconify API version 3.0.0-beta.1
```

Response with STATUS\_REGION=DE:

```
Iconify API version 3.0.0-beta.1 (DE)
```

## Configuration

In [Node.js version of API](https://iconify.design/docs/hosting-js/) you can configure result of this API query.

Query can be enabled or disabled using environment variable ENABLE\_VERSION. Possible values: true or false:

```
ENABLE_VERSION=false
```

You can also set it in src/config/app.ts in enableVersion property, then rebuild API.

Region value can be set using STATUS\_REGION environment variable. Value is a string:

```
STATUS_REGION=API1
```

You can also set it in src/config/app.ts in statusRegion property, then rebuild API.

[Page 241](https://iconify.design/docs/api/hosting.html "Current Page.")

## Hosting Iconify API

This article explains how to host Iconify on your server, so your website does not rely on Iconify public API servers.

[Iconify API](https://iconify.design/docs/) software is available as Node.js script.

## Django Iconify

In addition to Iconify API mentioned above, there is a community created alternative for Django users: [django-iconify](https://pypi.org/project/django-iconify/).

See [django-iconify project page](https://pypi.org/project/django-iconify/) for configuration options and usage.

## Source code

Everything you need is available at [Iconify GitHub repositories](https://github.com/iconify):

- [Iconify API](https://github.com/iconify/api)
- [Open source icon sets](https://github.com/iconify/icon-sets)

## Node.js API

See [Iconify API: Node.js](https://iconify.design/docs/hosting-js/) for installation and configuration instructions.

## API network

Iconify public API is hosted on multiple servers that form custom CDN. They are located in different parts of the world, and visitors are always redirected to the closest server.

How does CDN help? By connecting visitors to the closest server, latency is greatly reduced:

- Visitors from US are connected to one of the servers located on different sides of the US.
- Visitors from Europe are connected to server in the UK or server in Germany.
- For visitors from Asia, there are servers in Singapore and Japan.
- For visitors from Oceania, there is a server in Australia.

Additional servers may be added in other regions when needed.

How else does it help? Redundancy. Downtime happens. If one server has issues, you can quickly disable it and visitors will be routed to a different server. There are tools to automate it, such as Route 53 health checks.

Would you like to set up your own CDN for Iconify API? See [setting up custom CDN tutorial](https://iconify.design/docs/cdn.html).

For added security, Iconify public API also CloudFlare service. However, that does not change anything. Instead of connecting visitor to the closest server, CDN is used to connect CloudFlare edge server to the closest API. Iconify API still greatly benefits from latency reduction offered by a custom CDN.

[Page 242](https://iconify.design/docs/api/hosting-js/ "Current Page.")

## Hosting Iconify API

This documentation is for the Node.js version of [Iconify API](https://iconify.design/).

To install API, first clone or download Iconify API from GitHub: [https://github.com/iconify/api](https://github.com/iconify/api).

## How to use it

First, you need to install NPM dependencies and run build script:

```
npm install
 npm run build
```

Then you can start server:

```
npm run start
```

By default, server will:

- Automatically load the latest icons from [@iconify/json](https://iconify.design/docs/icons/all.html).
- Serve data on port 3000.

You can customise API to:

- Serve custom icon sets, loaded from various sources.
- Run on a different port.
- Disable search engine if you do not need it, reducing memory usage.

## Port and HTTPS

It is recommended that you do not run API on port 80. Server can handle pretty much anything, but it is still not as good as a dedicated solution such as nginx.

Run API on obscure port, hidden from the outside world with firewall rules, use nginx as reverse proxy.

HTTPS is not supported. It is a very resource intensive process, better handled by a dedicated solution such as nginx. Use nginx to run as HTTP and HTTPS server, forward queries to API HTTP server on hidden port such as default port 3000.

## Configuration

There are several ways to change configuration:

- Editing files in src/config/, then rebuilding script. This is required for some advanced options, such as using API with custom icons.
- Using environment variables, such as PORT=3100 npm run start.
- Using.env file to store environment variables.

See [Iconify API configuration](https://iconify.design/docs/config.html) for details.

## Starting server

To start server, run

```
npm run start
```

### PM2

To make sure API runs without interruption, use [pm2](https://github.com/Unitech/PM2/) or similar Node.js process manager to run application.

It will automatically restart API if something goes wrong and will automatically start API if the server is restarted. Sometimes host server might restart for whatever reason, this will make sure the API is always running.

[Page 243](https://iconify.design/docs/api/hosting-js/config.html "Current Page.")

## Iconify API configuration

This tutorial is a part of [Iconify API installation instructions](https://iconify.design/docs/) for Node.js. This part of the tutorial explains API configuration options.

There are several ways to change configuration:

- Editing files in src/config/, then rebuilding script. This is required for some advanced options, such as using API with custom icons.
- Using environment variables, such as PORT=3100 npm run start.
- Using.env file to store environment variables.

If your API is already running, after changing configuration, you must restart the API. Configuration cannot be reloaded without downtime.

## Env options

Options that can be changed with environment variables and their default values (you can find all of them in src/config/app.ts):

- HOST=0.0.0.0: IP address or hostname HTTP server listens on.
- PORT=3000: port HTTP server listens on.
- REDIRECT\_INDEX=https://iconify.design/: redirect for / route. API does not serve any pages, so index page redirects to the main website.
- STATUS\_REGION=: custom text to add to [/version](https://iconify.design/version.html) route response. Iconify API is run on network of servers, the visitor is routed to the closest server. It is used to tell which server user is connected to.
- CACHE\_ROOT\_DIR=cache: cache directory, relative to app directory, without trailing "/".
- ENABLE\_VERSION=true: enables [/version](https://iconify.design/version.html) route that shows API version and value of STATUS\_REGION. Disable it if you are using API only to serve icon data.
- ENABLE\_ICON\_LISTS=true: enables [/collections](https://iconify.design/collections.html) route that lists icon sets and /collection?prefix=whatever route to get a list of icons. Used by icon pickers. Disable it if you are using API only to serve icon data.
- ENABLE\_SEARCH\_ENGINE=true: enables [/search](https://iconify.design/search.html) route. Requires ENABLE\_ICON\_LISTS=true.
- ALLOW\_FILTER\_ICONS\_BY\_STYLE=true: allows searching for icons based on fill or stroke, such as adding style=fill to search query. This feature uses a bit of memory, so it can be disabled. Requires ENABLE\_SEARCH\_ENGINE=true.

## Updating icons

Icons are automatically updated when the server starts.

In addition to that, API can update icon sets without restarting the server.

To enable automatic update, you must set APP\_UPDATE\_SECRET environment variable. Without it, update will not work.

- ALLOW\_UPDATE=true: enables /update route.
- UPDATE\_REQUIRED\_PARAM=secret: key from the secret key/value pair. Cannot be empty.
- APP\_UPDATE\_SECRET=: value from the secret key/value pair. Cannot be empty.
- UPDATE\_THROTTLE=60: number of seconds to wait before running update.

To trigger icon sets update, open /update?foo=bar, where foo is value of UPDATE\_REQUIRED\_PARAM, bar is value of APP\_UPDATE\_SECRET.

Update will not be triggered immediately, it will be run after UPDATE\_THROTTLE seconds. This is done to prevent multiple checks when update is triggered several times in a row by something like GitHub hooks.

If update is triggered while an update process is already running (as in, the source was checked for update, but download is still in progress), another update check will be run after currently running update ends.

Response to /update route is always the same, regardless of outcome. This is done to make it impossible to try to guess the key/value pair or even see if the route is enabled. To see the actual result, you need to check the console. Successful request and update process will be logged.

## HTTP headers

By default, server sends the following HTTP headers:

- Various CORS headers, allowing access from anywhere.
- Cache headers to cache responses for 604800 seconds (7 days).

See [how to change HTTP headers in API](https://iconify.design/docs/headers.html) for more details.

## Memory management

API does not store all loaded icons in memory. Instead, it splits icon sets into smaller chunks, stores them in cache and loads those chunks from cache when needed. After loading a chunk from cache, it is stored in memory for a while. This way, the most used icons are in memory, rarely used icons are not using memory.

There are two configuration variables that deal with that:

- splitIconSetConfig in src/config/app.ts that manages splitting big icon sets in smaller chunks.
- storageConfig in src/config/app.ts that manages cache.

All properties in those config objects can be changed via environment variables. Convert property to underscore-separated upper case, add "SPLIT\_" prefix for splitIconSetConfig, "STORAGE\_" prefix for storageConfig.

Config values that you might want to change, as environment variables:

- STORAGE\_CACHE\_DIR={cache}/storage: directory where cache is stored, relative to app directory, without trailing "/". Use "{cache}" to point to root cache directory set in CACHE\_ROOT\_DIR variable.
- STORAGE\_MAX\_COUNT=100: maximum number of stored items in memory. Reduce number if memory usage is too high. Set to 0 to disable.
- STORAGE\_TIMER=60000: timer to check for expired items.

If you want to always keep icon data in memory, set SPLIT\_CHUNK\_SIZE=0 and STORAGE\_MAX\_COUNT=0. This is useful to make responses as fast as possible if your API instance does not serve hundreds of thousands of icons.

[Page 244](https://iconify.design/docs/api/hosting-js/headers.html "Current Page.")

## HTTP headers in API

This tutorial is a part of [Iconify API installation instructions](https://iconify.design/docs/) for Node.js. This part of the tutorial explains how to change HTTP headers that API server sends to visitors.

By default, server sends the following HTTP headers:

- Various CORS headers, allowing access from anywhere.
- Cache headers to cache responses for 604800 seconds (7 days).

To change headers, edit httpHeaders variable in src/config/app.ts, then rebuild script:

If you prefer to use reverse proxy to send all extra headers, remove all unnecessary headers in the file mentioned above and change the configuration in reverse proxy.

## Configuring CORS in Apache

If you are using Apache as reverse proxy, you can disable CORS in API and enable it in Apache.

To enable CORS in Apache, add this to Apache configuration:

httpd.conf
```
Header always set Access-Control-Allow-Origin "*"
Header always set Access-Control-Allow-Methods "GET, OPTIONS"
Header always set Access-Control-Allow-Headers "Origin, X-Requested-With, Content-Type, Accept, Accept-Encoding"
Header always set Access-Control-Max-Age "86400"
Header always set Cross-Origin-Resource-Policy "cross-origin"
```

## Configuring CORS in NGINX

If you are using NGINX as a reverse proxy, you can disable CORS in API and enable it in NGINX.

To enable CORS in NGINX, add this to NGINX configuration under http -> server -> location:

nginx.conf
```
if ($request_method = 'POST') {
   add_header 'Access-Control-Allow-Origin' '*';
   add_header 'Access-Control-Allow-Methods' 'GET, POST, OPTIONS';
   add_header 'Access-Control-Allow-Headers' 'DNT,User-Agent,X-Requested-With,If-Modified-Since,Cache-Control,Content-Type,Range';
   add_header 'Access-Control-Expose-Headers' 'Content-Length,Content-Range';
   add_header 'Cross-Origin-Resource-Policy' 'cross-origin';
 }
if ($request_method = 'GET') {
   add_header 'Access-Control-Allow-Origin' '*';
   add_header 'Access-Control-Allow-Methods' 'GET, POST, OPTIONS';
   add_header 'Access-Control-Allow-Headers' 'DNT,User-Agent,X-Requested-With,If-Modified-Since,Cache-Control,Content-Type,Range';
   add_header 'Access-Control-Expose-Headers' 'Content-Length,Content-Range';
   add_header 'Cross-Origin-Resource-Policy' 'cross-origin';
 }
```

[Page 245](https://iconify.design/docs/api/hosting-js/reverse-proxy.html "Current Page.")

## Reverse proxy for Iconify API

This tutorial is a part of [Iconify API installation instructions](https://iconify.design/docs/).

It explains how to configure reverse proxy for hosting Node.js version of [Iconify API](https://iconify.design/) in a custom hosting environment.

## Why is it needed?

What is reverse proxy and why is it needed?

Running Node.js applications on port 3000 without reverse proxy is fine for localhost development, but usually it is not fine for production.

In a production environment, you want stability and HTTPS support. That should be delegated to a reverse proxy. Reverse proxy allows you to add HTTPS support, add security features such as rate limiting.

Reverse proxy handles HTTP and HTTPS requests, forwards them to Node.js application and returns response to customer. It is useful if you want to:

- Run API on a different port, so you can host multiple websites on the same server instead of only hosting API.
- Handle HTTPS requests. Web server will handle all SSL stuff.
- Dealing with bad customers. You can use web server rules to block misbehaving customers and bots.
- Using API on subdirectory rather than a custom subdomain.

### CloudFlare

You can avoid this by using service like CloudFlare. It handles all HTTPS requests and deals with security stuff.

If you are using such service, you can run API on port 80 and forget about reverse proxy.

## Configuration

Before configuring reverse proxy, you need to make sure Iconify API runs on a port hidden from the outside world.

Default port is 3000. See [API configuration](https://iconify.design/docs/config.html) for details.

### Apache 2.4

This section explains how to create a reverse proxy with Apache 2.4.

In httpd.conf you need to uncomment these 2 lines to enable mod\_proxy:

httpd.conf
```
LoadModule proxy_module libexec/apache2/mod_proxy.so
LoadModule proxy_http_module libexec/apache2/mod_proxy_http.so
```

Then you can add mod\_proxy to virtual host like this:

httpd.conf
```
<VirtualHost *>
    ServerName api.yourdomain.com
    ProxyPass "/" "http://localhost:3000/"
    ProxyPassReverse "/" "http://localhost:3000/"
</VirtualHost>
```

This configuration will allow you to access API at http://api.yourdomain.com/.

Here is an alternative solution, that you can add to your existing VirtualHost directive that allows you to run API on subdirectory:

httpd.conf
```
<VirtualHost *>
    ServerName yourdomain.com
    ServerAdmin [email protected]
    DocumentRoot "/home/iconify/htdocs"
    ProxyPass "/api/" "http://localhost:3000/"
    ProxyPassReverse "/api/" "http://localhost:3000/"
</VirtualHost>
```

This solution will allow you to access API at http://yourdomain.com/api/.

### NGINX

This section explains how to create a reverse proxy with NGINX.

Open nginx.conf, find section with your domain. It is under http -> server -> location:

nginx.conf
```
http {
    # some stuff here
    server {
        listen 80;
        server_name api.yourdomain.com;

        # some stuff here
        location / {
            root   html;
            index  index.html index.htm;
        }
        # some stuff here
    }
    # some stuff here
 }
```

Replace contents of location with this:

nginx.conf
```
http {
    # some stuff here
    server {
        listen 80;
        server_name api.yourdomain.com;

        # some stuff here
        location / {
            proxy_pass http://127.0.0.1:3000;
            proxy_http_version 1.1;
            proxy_buffering on;
            proxy_buffers 16 1024k;
        }
        # some stuff here
    }
    # some stuff here
 }
```

You will need to do this change twice: once for HTTP server, once for HTTPS server. In your nginx.conf look for second server section with SSL settings that is configured to listen on port 443 and apply exactly the same changes.

This configuration will allow you to access API at http://api.yourdomain.com/.

If you want to host API in subdirectory, instead of editing the default location block, add custom location:

nginx.conf
```
http {
    # some stuff here
    server {
        listen 80;
        server_name yourdomain.com;

        # some stuff here
        location / {
            # some stuff here
        }
        location /api/ {
            proxy_pass http://127.0.0.1:3000;
            proxy_http_version 1.1;
            proxy_buffering on;
            proxy_buffers 16 1024k;
        }
        # some stuff here
    }
    # some stuff here
 }
```

This solution will allow you to access API at http://yourdomain.com/api/.

#### Resolving POST errors in NGINX

If you are using GitHub web hooks to synchronize icon sets, you might run into error 500. It is very likely to happen if you have fresh NGINX installation.

That error is likely to be caused by NGINX having wrong permissions. Run this to fix it:

```
sudo chmod +x /var/lib/nginx -R
```

[Page 246](https://iconify.design/docs/api/cdn.html "Current Page.")

## Custom budget CDN

This tutorial is a part of [Iconify API hosting instructions](https://iconify.design/docs/hosting.html).

What is CDN? CDN is short for content delivery network. It is a set of servers spread out across the globe that deliver content to a visitor as fast as possible. AnyCast DNS connects visitors to the closest server.

This tutorial is intended to be used if you are setting up your custom [Iconify API](https://iconify.design/docs/) and want to take advantage of CDN.

## Stateless CDN

This tutorial is intended for stateless CDN.

Stateless means every request does not depend on previous request, so if a visitor is connected to a different edge server than he visited before, it wouldn't make any difference.

Iconify API is stateless. It does not allow visitors to store anything, it does not track anything, it does not send any cookies. There is no central server, and each API server works separately from other servers.

## Setting up edge servers

First, you need to create multiple origin servers in various parts of the world.

All servers need to be configured to serve exactly the same data for exactly the same host name. You need to configure multiple identical servers. There are plenty of tools that can automate this process; however, they are not part of this tutorial.

For tutorial on how to set up hosting for Iconify API, see [hosting tutorial](https://iconify.design/docs/hosting.html).

## Route53

After setting up multiple servers, you want to direct users to the closest server.

Adding multiple "A" records to your domain won't achieve that. You need AnyCast DNS.

AnyCast DNS is expensive. Very expensive. What if you don't have thousands of dollars to spend? Good news is there is one alternative solution: Amazon's Route53 latency routing.

Route53 latency routing works by redirecting the visitor to the closest Amazon datacenter.

What if you are not hosting your websites at Amazon datacenters? You can host at datacenters not far from Amazon (same country or state), which is more than good enough to redirect visitors to the closest of your servers.

### Setting up Route53

- You need an AWS account. Sign up at [AWS main page](https://aws.amazon.com/).
- Go to [Route53 page](https://console.aws.amazon.com/route53/home?region=eu-central-1) (sign in if needed).
- Click "Hosted Zones" link, click on your domain or create a new zone.

Then you need to add records for each server you have in your CDN. Click "Create Record Set", enter subdomain name in "Name" field, enter IP address in "Value" field, in "Routing Policy" field select "Latency". That last part is very important: that makes it possible to redirect visitors to the closest server based on latency. Select the region closest to your server's physical location, enter something in "Set ID" field.

If you are running script on AWS service, instead of entering IP select click "Yes" for "Alias" option and select AWS instance.

![Adding a new record to Route53](https://iconify.design/assets/images/hosting/route53-new-record.png)

Click "Create" button to add that record.

Create several more records for your other servers. For each record enter the same subdomain, but different IP and a different region.

By the time you are finished, it should look like this:

![Route53 records](https://iconify.design/assets/images/hosting/route53-records.png)

Notice there are 3 records for "icons.simplesvg.com" pointing to different IP addresses with different region set up.

That's it. When visiting icons.simplesvg.com, user will be redirected to one of 3 IPs: 1.2.3.4, 2.3.4.5, 3.4.5.6 depending on which AWS datacenter is the closest. It is precise enough to create a budget custom CDN.

## Iconify API

This method is used to host Iconify API, hosted at api.iconify.design.

[Page 247](https://iconify.design/docs/api/providers.html "Current Page.")

## Iconify API providers

If you are publishing icons, you can host your own Iconify API server that includes only your icons and give access to it to other users. Iconify icon components can retrieve icon data from multiple independent Iconify API servers.

How is it done?

Public API

@my-icons

@icons8

mdi-light:home

@my-icons:line-24:home

@icons8:ios:home

## Provider in icon name

Icon names in Iconify icon components have 3 parts:

| @api-provider | : | icon-prefix | : | icon-name |
| --- | --- | --- | --- | --- |
| provider |  | prefix |  | name |

- provider points to API source. Starts with "@", can be empty (empty value is used for public Iconify API).
- prefix is name of icon set.
- name is name of icon.

All parts are separated by ":", provider is optional and can be skipped if empty.

Examples:

- @my-icons:line-24:home: icon is retrieved from provider "my-icons". Icon name for that provider is line-24:home.
- mdi-light:home: icon does not have provider, so provider is empty. Empty value is used for public Iconify API.

Provider naming rules are the same as for prefix and name, but with exception that it can be empty:

```
/^[a-z0-9]+(-[a-z0-9]+)*$/
```

That regular expression means name must start with character or number, followed by mix of characters, numbers and hyphen. Other characters are not allowed.

## Adding API provider

All icon components have function addAPIProvider(). For SVG framework it is Iconify.addAPIProvider(), for other components you need to import it from component.

Example for [React component](https://iconify.design/icon-components/react/):

js
```
import { addAPIProvider } from '@iconify/react';

addAPIProvider('local', {
    // Array of host names.
    // Mutliple hosts allow redundancy: if one host is down, component will query another host.
    resources: ['http://localhost:3000'],
 });
```

Function has 2 parameters:

- provider, string. Provider name. You can also overwrite configuration for default provider by using empty string.
- config, [APIConfig](https://iconify.design/docs/api/providers.html#api-config "APIConfig documentation"). API configuration.

For more details see [addAPIProvider documentation from SVG framework](https://iconify.design/icon-components/svg-framework/add-api-provider.html).

### IconifyProviders

Sometimes using function addAPIProvider() is not simple. For example, if you are using SVG framework that is placed at the end of file before </body>.

There is alternative solution: assigning API providers to global variable IconifyProviders before loading SVG framework. When SVG framework loads, it checks if variable exists and automatically imports all providers from it.

Format is simple: it is an object, where key is provider name, value is configuration. Example, which does the same as example above:

html
```
<script>
    IconifyProviders = {
        local: {
            resources: ['http://localhost:3000'],
        },
    };
</script>
<script src="https://code.iconify.design/3/3.1.1/iconify.min.js"></script>
```

Components also support it, but components are usually bundled, so you should be able to use addAPIProvider() instead of polluting global variables.

## Using API provider

After you add configuration for API provider, which is one simple function call, you can use icons from that API provider.

All you have to do is add provider to icon name. Provider in icon name must match first parameter to addAPIProvider():

html
```
<span class="iconify" data-icon="@icons8:ios-glyphs:color-dropper"></span>
```

jsx
```
import { addAPIProvider, Icon } from '@iconify/react';

addAPIProvider('local', {
    // Array of host names
    resources: ['http://localhost:3000'],
 });

// Demo using provider in icon name
export function renderHomeIcon() {
    return <Icon icon="@local:material-icons:home" />;
 }
```

## Authentication

Currently Iconify does not offer authentication options.

If you want to use API providers functionality to host premium icon sets or restrict access, you should add your own authentication logic to both API and clients. Doing that might be tricky due to lack of documentation for internal code, if you need any help, [open an issue at Iconify GitHub repository](https://github.com/iconify/iconify/issues).

It is on a roadmap for premium edition of Iconify API software, which should make hosting premium icon sets very easy. However, that functionality is far away due to lack of development resources. You can help by [sponsoring Iconify on GitHub](https://github.com/iconify/iconify) (click "Sponsor" button).

## API Config

Type [APIConfig](https://iconify.design/docs/api/providers.html#api-config "APIConfig documentation") passed to addAPIProvider(), is an object.

Properties:

- resources, string\[\]. List of host names, required. Must start with "https://" or "http://", should not contain path.
- path, string. Path to root directory. Default value is "/".
- rotate, number. Timeout before the next host is used, in milliseconds. Default value is 750.
- timeout, number. Timeout before the API query is considered failed, in milliseconds. Default value is 5000.

Examples:

js
```
import { addAPIProvider } from '@iconify/svelte';

// Override default API provider with Iconify API hosted at 'https://iconify.my-project.com'
addAPIProvider('', {
    resources: ['https://iconify.my-project.com'],
 });
```

html
```
<script>
    // Define global variable
    IconifyProviders = {
        // Empty prefix: overwrite default API provider configuration
        '': {
            // Use custom API first, use Iconify public API as backup
            resources: [
                'https://iconify.my-project.com',
                'https://api.iconify.design',
            ],
            // Wait for 1 second before switching API hosts
            rotate: 1000,
        },
    };
</script>
<script src="https://code.iconify.design/3/3.1.1/iconify.min.js"></script>
```

## Provider name

Provider name is specific to your code. It is used only to associate icon with API configuration. Actual API server has no effect on what you call provider.

That means you can change it to whatever you want. Make sure you are using the same provider id in all your code.

[Page 248](https://iconify.design/docs/api/config.html "Current Page.")

## Configuring custom Iconify API

This article explains who to configure [Iconify icon components](https://iconify.design/docs/icon-components/) to use custom API server.

All Iconify icon components can connect to multiple Iconify API servers. It is done via [API providers](https://iconify.design/docs/providers.html).

Public API

@my-icons

@icons8

mdi-light:home

@my-icons:line-24:home

@icons8:ios:home

If you are hosting Iconify API server, there are 2 ways to use your icons:

- Replace public Iconify API with your API.
- Use your icons as an alternative icons source by using API provider.

As far as code is concerned, both choices are actually almost identical. The only difference is in first option provider id is empty string "", so you are overwriting existing configuration instead of adding new one.

Your users can do whatever they want: overwrite default API provider or add new API provider. They can use whatever provider id they want for it, as long as they use the same provider id in icon names.

## Example

For example, you have set up your Iconify API server at https://iconify.myproject.tld.

One of icon sets you host has prefix material-icons and it has icon home.

How can your users configure it?

### Overwriting default API

Users can overwrite the default API provider like this:

js
```
import { addAPIProvider } from '@iconify/react';

addAPIProvider('', {
    resources: ['https://iconify.myproject.tld'],
 });
```

then in components use your icon like this:

js
```
import React from 'react';
import { Icon } from '@iconify/react';

function renderHomeIcon() {
    return <Icon icon="material-icons:home" />;
 }
```

### Using custom ID

Users can also set any id for your API:

js
```
import { addAPIProvider } from '@iconify/react';

addAPIProvider('awesome-icons', {
    resources: ['https://iconify.myproject.tld'],
 });
```

then in components use your icon like this:

js
```
import React from 'react';
import { Icon } from '@iconify/react';

function renderHomeIcon() {
    return <Icon icon="@awesome-icons:material-icons:home" />;
 }
```

Whatever your users choose, it is up to them. API server does not know what ID users use in icon names and cannot change it.

So one user can overwrite public Iconify API configuration, another user can set ID to awesome-icons, another user can set ID to more-icons and so on.

### Using IconifyProviders

Instead of using addAPIProvider(), users can use global variable IconifyProviders to set configuration.

html
```
<script>
    // Define global variable
    IconifyProviders = {
        // For overwriting public API
        '': {
            resources: ['https://iconify.myproject.tld'],
        },

        // For creating alternative API provider
        // 'awesome-icons': {
        //     resources: ['https://iconify.myproject.tld'],
        // },
    };
</script>
<script src="/assets/bundle.min.js"></script>
```

This example assumes that /assets/bundle.min.js is a bundle that contains all components that use icons and Iconify component.

Similar example for the SVG framework:

html
```
<head>
    <script>
        // Define global variable
        IconifyProviders = {
            // For overwriting public API
            // '': {
            //     resources: ['https://iconify.myproject.tld'],
            // },

            // For creating alternative API provider
            'awesome-icons': {
                resources: ['https://iconify.myproject.tld'],
            },
        };
    </script>
    <script src="https://code.iconify.design/3/3.1.1/iconify.min.js"></script>
</head>
<body>
    <span class="iconify" data-icon="@awesome-icons:material-icons:home"></span>
</body>
```

For more information about API providers, see [API providers documentation](https://iconify.design/docs/providers.html).

[Page 249](https://iconify.design/docs/articles/ "Current Page.")

## Iconify blog

Blog below contains major updates, migration guides and helpful articles related to Iconify project.

## Iconify stuff

Articles related to Iconify project that are too long for documentation:

- [How icons are validated and cleaned up in Iconify](https://iconify.design/docs/cleaning-up-icons/).
- [How add an icon set to Iconify](https://iconify.design/docs/add-icon-set/).

## Animated icons

How to work with animated SVG:

- [SVG animations level 2 spec: common issues and solutions](https://iconify.design/docs/svg-animation-issues/).

## Migration guides

Migration guides for major releases:

- [Iconify icon components April 2025 migration guide](https://iconify.design/docs/migration/icon-v3.html).
- [Iconify plugin for Figma 2024 update](https://iconify.design/docs/design/figma/update-2024.html).

[Page 250](https://iconify.design/docs/articles/index.html "Current Page.")

## Iconify blog

Blog below contains major updates, migration guides and helpful articles related to Iconify project.

## Iconify stuff

Articles related to Iconify project that are too long for documentation:

- [How icons are validated and cleaned up in Iconify](https://iconify.design/docs/cleaning-up-icons/).
- [How add an icon set to Iconify](https://iconify.design/docs/add-icon-set/).

## Animated icons

How to work with animated SVG:

- [SVG animations level 2 spec: common issues and solutions](https://iconify.design/docs/svg-animation-issues/).

## Migration guides

Migration guides for major releases:

- [Iconify icon components April 2025 migration guide](https://iconify.design/docs/migration/icon-v3.html).
- [Iconify plugin for Figma 2024 update](https://iconify.design/docs/design/figma/update-2024.html).