

CCS tip to align two box elements next to eachother:

```css
main {
    float: left;
    position: fixed;
    right: 55%;
}

aside {
    float: right;
    position: fixed;
    left: 55%;
}
```

Use <iframe> to embed content from othe websites.

Add "!important" to selector only if really necessary.


position: static;
=> This is the standard value.

position: relative:
=> the element will be positioned relative to the static position.

position: absolute;
=> the element will be positioned relative to the nearest positioned parent. NOT the viewport.

position: fixed;
=> the element will be placed relative to the entire viewport.
=> viewport = the entire page that is visible on the screen. (depends on screen size)

z-index property
=> 3rd axis, behind or ahead of other elements