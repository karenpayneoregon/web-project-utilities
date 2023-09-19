# Visual Studio minifier for CSS

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

## Usage

To minimize and create a map file, click the button, traverse to the file to work on and click open which then creates the two files. If Visual Studio is open to the same folder the update is immediate.

> **Note**
> Besides that this utility does for novice developers that are some good learning in the source code to learn from.

## CSS minify

In this application the map file is created in the same folder as the original file. Another option is to create the map file in another folder.

By removing **-o .** from the current code, using **css-minify -f filename** will have a new folder created **css-dist** and the **.min** file is placed in this folder.

To process an entire folder **css-minify -d sourcedir**. For this to work, follow what is done in current code, set the current folder using **Environment.CurrentDirectory**, otherwise css-minify will not process the intended folder.


## UglifyCSS

Although the [repository](https://github.com/fmarcia/uglifycss) is not actively being worked on, does not mean its not worth using. Consider forking the repository.

## Jetbrain 

If a developer does not using Visual Studio, these two IDE offer minimizing and creating map files.

### Rider

Offers [minifying CSS](https://www.jetbrains.com/help/rider/Compressing_CSS.html) and also, [minimize JavaScript](https://www.jetbrains.com/help/rider/Minifying_JavaScript.html).

**Note** interesting enough, Rider depends on UglifyJS in a [file watcher](https://www.jetbrains.com/help/rider/Minifying_JavaScript.html#ws_minifying_js_create_file_watcher).

### WebSorm

Offers [minimizing JavaScript](https://www.jetbrains.com/help/webstorm/minifying-javascript.html) and [minimizing CSS](https://www.jetbrains.com/help/webstorm/compressing-css.html).