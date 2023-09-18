# About

Learn how to minimize and map CSS stylesheet files using a no frills Windows Forms project activated through a Visual Studio external tools menu item.


## Minification purpose

Minification dramatically improves site speed and accessibility, directly translating into a better user experience as this speeds up websites.

## CSS map purpose

CSS [map](https://en.wikipedia.org/wiki/MAP_(file_format)#:~:text=MAP%20file%20is%20for%20HTML,offsets%20from%20a%20starting%20point.) file is a JSON format file that connects the CSS file to its source files, further, it is often written in preprocessors (e.g., Less, Sass, Stylus, etc.), allowing for live debugging of the source files from the web browser. However, it is also known as a source map.

## Using Windows forms

By using a Forms project rather than a Visual Studio extension ensure continued functionality in later versions of Visual Studio plus the code is simple, easy to modify if a developer wants to change the current behavior.

## Requires

- [css-minify](https://www.npmjs.com/package/css-minify) installed as **npm install css-minify -g**
- [uglifycss](https://www.npmjs.com/package/uglifycss) installed as **npm install uglifycss -g**
