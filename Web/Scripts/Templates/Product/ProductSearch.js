// SQL2X Generated code based on a SQL Server Schema
// SQL2X Version: 1.0
// http://sql2x.org/
// Generated Date: 12/12/2020 5:14:24 AM
// From Machine: DESKTOP-LSRVP12
// Filename: ProductSearch.json
// MethodName: sql2x.CrudeTypeScriptGenerator.DesignVestreVikenDurian
// Template Style: DotNetFrameworkWithDurianByTypeScript
// Documentation:
//   Typescript for durians
var DesignVestreVikenDurian;
(function (DesignVestreVikenDurian) {
    "use strict";
    // client on load / entry point
    window.onload = function () {
        var contentElement = document.getElementById("content");
        var durianGrid = new ProductSearchByCategoryTileList(contentElement);
        for (var i = 0; i < productList.length; i++) {
        }
        durianGrid.start();
    };
    // main Durian class
    var ProductSearchByCategoryTileList = /** @class */ (function () {
        function ProductSearchByCategoryTileList(element) {
            // init tiles
            ProductSearchByCategoryTileList.tiles = new Array();
            // not maximized state
            ProductSearchByCategoryTileList.maximized = false;
            ProductSearchByCategoryTileList.maximizedTile = null;
            ProductSearchByCategoryTileList.maximizedScrollY = 0;
            // references
            ProductSearchByCategoryTileList.referenceCountLink = new Link();
        }
        // clear canvas
        ProductSearchByCategoryTileList.clearCanvas = function (fillStyle) {
            // get client elements
            var canvas = document.getElementById("myCanvas");
            var context = canvas.getContext("2d");
            context.beginPath();
            context.fillStyle = fillStyle;
            context.fillRect(0, 0, canvas.width, canvas.height);
            context.stroke();
        };
        ProductSearchByCategoryTileList.prototype.start = function () {
            var scale = "scale(1.0)";
            document.body.style.zoom = "1.0";
            document.body.style.webkitTransform = scale; // for Chrome, Opera, Safari
            document.body.style.transform = scale; // general
            // resize canvas to hold all productList
            ProductSearchByCategoryTileList.resizeCanvas();
            ProductSearchByCategoryTileList.clearCanvas("white"); // overallColors.backGround
            // get client elements
            var canvas = document.getElementById("myCanvas");
            // header text
            var headerText = "Product Search";
            // header tile
            var line = 0;
            ProductSearchByCategoryTileList.header =
                new Tile(headerText, // name
                2, // tileLeft
                line, // tileTop
                "", // suffix of url
                productList.length, // tileCount
                48, // tileHeight
                15, // tileBorder
                2, // textReposLeft
                5, // tileSpaceVertical
                16, // tileFontSize
                "rgb(24, 101, 29)", // overallColors.foreGround
                null, // entity null triggers header columns
                null // entity widths
                );
            ProductSearchByCategoryTileList.tiles.push(ProductSearchByCategoryTileList.header);
            // calc column widths 
            var context = canvas.getContext("2d");
            context.font = "14px Arial"; // tileFontSize
            var productListWidths = new Array(8);
            productListWidths[0] = context.measureText("Name").width;
            productListWidths[1] = context.measureText("Identifier").width;
            productListWidths[2] = context.measureText("Value").width;
            productListWidths[3] = context.measureText("Info Value").width;
            productListWidths[4] = context.measureText("Image Type Name").width;
            productListWidths[5] = context.measureText("Image").width;
            productListWidths[6] = 0;
            for (var i = 0; i < productList.length; i++) {
                // Product Name
                if ((context.measureText(productList[i].ProductName).width > productListWidths[0])
                    && (context.measureText(productList[i].ProductName).width < window.innerWidth * 0.9))
                    productListWidths[0] = context.measureText(productList[i].ProductName).width;
                // Identifier
                if ((context.measureText(productList[i].Identifier).width > productListWidths[1])
                    && (context.measureText(productList[i].Identifier).width < window.innerWidth * 0.9))
                    productListWidths[1] = context.measureText(productList[i].Identifier).width;
                // Value
                if ((context.measureText(productList[i].Value).width > productListWidths[2])
                    && (context.measureText(productList[i].Value).width < window.innerWidth * 0.9))
                    productListWidths[2] = context.measureText(productList[i].Value).width;
                // Product Info Value
                if ((context.measureText(productList[i].ProductInfoValue).width > productListWidths[3])
                    && (context.measureText(productList[i].ProductInfoValue).width < window.innerWidth * 0.9))
                    productListWidths[3] = context.measureText(productList[i].ProductInfoValue).width;
                // Product Image Type Name
                if ((context.measureText(productList[i].ProductImageTypeName).width > productListWidths[4])
                    && (context.measureText(productList[i].ProductImageTypeName).width < window.innerWidth * 0.9))
                    productListWidths[4] = context.measureText(productList[i].ProductImageTypeName).width;
                // Image
                if ((context.measureText(productList[i].Image).width > productListWidths[5])
                    && (context.measureText(productList[i].Image).width < window.innerWidth * 0.9))
                    productListWidths[5] = context.measureText(productList[i].Image).width;
            }
            // grid rows for ProductSearchByCategory
            var lastTile;
            line++;
            // header columns
            lastTile =
                new Tile("", // name
                40, // tileLeft
                line, // tileTop
                "", // suffix of url
                productList.length, // tileCount
                45, // tileHeight
                15, // tileBorder
                2, // textReposLeft
                7, // tileSpaceVertical
                14, // tileFontSize
                "rgb(24, 101, 29)", // overallColors.foreGround
                null, // entity null triggers header columns
                productListWidths // entity widths
                );
            ProductSearchByCategoryTileList.tiles.push(lastTile);
            for (var i = 0; i < productList.length; i++) {
                line++;
                // alternate color
                var newColor = "rgb(24, 101, 29)"; // overallColors.foreGround
                if (i % 2 === 0) {
                    newColor = "rgb(4, 115, 8)"; // overallColors.foreGroundAlternate
                }
                lastTile =
                    new Tile("", // name
                    40, // tileLeft
                    line, // tileTop
                    productList[i].ProductId, // most significant key from durian
                    productList.length, // tileCount
                    45, // tileHeight
                    15, // tileBorder
                    2, // textReposLeft
                    7, // tileSpaceVertical
                    14, // tileFontSize
                    newColor, // fillStyle
                    productList[i], // entity
                    productListWidths // entity widths
                    );
                ProductSearchByCategoryTileList.tiles.push(lastTile);
            }
            // resize canvas to last tile
            if (lastTile) {
                canvas.height = lastTile.tileTop + lastTile.tileHeight + 15;
                ProductSearchByCategoryTileList.tileListHeight = canvas.height;
            }
            // init state
            history.scrollRestoration = "manual";
            // previous state
            window.addEventListener("popstate", function (event) {
                ProductSearchByCategoryTileList.checkState(event.state);
            });
            ProductSearchByCategoryTileList.checkState("");
            // handle click event
            canvas.addEventListener("click", this.canvasClick, false);
            // handle resize event
            window.addEventListener("resize", function () {
                // resize canvas
                ProductSearchByCategoryTileList.resizeCanvas();
                // draw ProductSearchByCategory index according to visual state
                if (ProductSearchByCategoryTileList.maximized
                    && ProductSearchByCategoryTileList.maximizedTile != null) {
                    // draw maximized
                    ProductSearchByCategoryTileList.maximizedTile.drawMaximized();
                    var context_1 = canvas.getContext("2d");
                    ProductSearchByCategoryTileList.header.draw(context_1);
                }
                else {
                    // draw normal
                    ProductSearchByCategoryTileList.drawNormal();
                }
            }, false);
            // check mouse pointer style for tiles
            canvas.onmousemove = function (e) {
                canvas.style.cursor = "auto"; // default style
                if (ProductSearchByCategoryTileList.tiles) {
                    for (var _i = 0, _a = ProductSearchByCategoryTileList.tiles; _i < _a.length; _i++) {
                        var tile = _a[_i];
                        if (tile.hitTest(e.offsetX, e.offsetY)) {
                            canvas.style.cursor = "pointer";
                            break;
                        }
                    }
                }
            };
        };
        // state
        ProductSearchByCategoryTileList.getValue = function (parameters, getParameter) {
            var numberPart = "";
            if (parameters == null)
                return "";
            if (parameters.indexOf(getParameter) != -1) {
                numberPart =
                    parameters.substr(parameters.indexOf(getParameter)
                        + getParameter.length);
                if (numberPart.indexOf("}") != -1)
                    numberPart = numberPart.substr(0, numberPart.indexOf("}"));
            }
            return numberPart;
        };
        ProductSearchByCategoryTileList.checkState = function (state) {
            if (state == null)
                state = "";
            // get scroll position
            var numberPartScrollY = ProductSearchByCategoryTileList.getValue(state, "scrollY={");
            // if not maximized, or failed to find entity ...
            ProductSearchByCategoryTileList.maximizedTile = null;
            if (state.indexOf("#viewState=maximized") != -1) {
                for (var i = 0; i < ProductSearchByCategoryTileList.tiles.length; i++) {
                    if (ProductSearchByCategoryTileList.tiles[i].productSearchByCategory != null) {
                        if (!isNaN(Number(numberPartScrollY))) {
                            ProductSearchByCategoryTileList.maximizedScrollY = Number(numberPartScrollY);
                        }
                        ProductSearchByCategoryTileList.maximizedTile = ProductSearchByCategoryTileList.tiles[i];
                        ProductSearchByCategoryTileList.maximizedTile.drawMaximized();
                        // remember view state as maximized, primary key and scroll position 
                        state = "viewState=maximized";
                        break;
                    }
                }
            }
            // ... then draw a grid
            if (ProductSearchByCategoryTileList.maximizedTile == null) {
                ProductSearchByCategoryTileList.drawNormal();
                // remember view state grid
                state = "viewState=grid";
                // scroll if applicable
                if (!isNaN(Number(numberPartScrollY)))
                    window.scrollTo(0, Number(numberPartScrollY));
            }
            // remember state
            history.replaceState(state, "test");
        };
        // check if we are living in a mobile phone
        ProductSearchByCategoryTileList.isMobile = function () {
            var isMobileForSure = false;
            // detectmobilebrowsers.com
            (function (a) {
                if (/(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|mobile.+firefox|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows ce|xda|xiino/i.test(a) || /1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-/i.test(a.substr(0, 4))) {
                    isMobileForSure = true;
                }
            })(navigator.userAgent || navigator.vendor);
            return isMobileForSure;
        };
        // resize canvas based on window size
        ProductSearchByCategoryTileList.resizeCanvas = function () {
            // canvas for tiles set to window width for mobile, 80% for web
            var canvas = document.getElementById("myCanvas");
            if (!this.isMobile()) {
                canvas.width = window.innerWidth * 0.8;
            }
            else {
                canvas.width = window.innerWidth;
            }
        };
        // check click event
        ProductSearchByCategoryTileList.prototype.canvasClick = function (event) {
            if (ProductSearchByCategoryTileList.maximized) {
                var canvas = document.getElementById("myCanvas");
                var context = canvas.getContext("2d");
                ProductSearchByCategoryTileList.drawNormal();
                ProductSearchByCategoryTileList.maximized = false;
                ProductSearchByCategoryTileList.maximizedTile = null;
                window.scrollTo(0, ProductSearchByCategoryTileList.maximizedScrollY);
                // remember view state grid
                history.replaceState("viewState=grid", "test");
            }
            else {
                if (ProductSearchByCategoryTileList.tiles) {
                    var canvas = document.getElementById("myCanvas");
                    var context = canvas.getContext("2d");
                    for (var _i = 0, _a = ProductSearchByCategoryTileList.tiles; _i < _a.length; _i++) {
                        var tile = _a[_i];
                        // check whole tile area
                        if (tile.hitTest(event.offsetX, event.offsetY)) {
                            if (tile.name == "") { // check for not header
                                // action links
                                if (event.offsetX > tile.detailsLink.linkLeft) {
                                    // indicate that the tile link was clicked
                                    tile.detailsLink.frame(context, tile.lineWidth, true);
                                    // go to url
                                    window.location.href = tile.detailsLink.linkUrl + tile.url;
                                }
                                else if (event.offsetX > tile.editLink.linkLeft) {
                                    // indicate that the tile link was clicked
                                    tile.editLink.frame(context, tile.lineWidth, true);
                                    // go to url
                                    window.location.href = tile.editLink.linkUrl + tile.url;
                                }
                                else if (event.offsetX > tile.selectLink.linkLeft) {
                                    // indicate that the tile link was clicked
                                    tile.selectLink.frame(context, tile.lineWidth, true);
                                    // go to url
                                    window.location.href = tile.selectLink.linkUrl + tile.url;
                                }
                                else if (tile.productSearchByCategory != null) {
                                    // indicate that the tile link was clicked
                                    tile.frame(context, tile.backgroundColor, 2, true);
                                    // remember current scroll 
                                    ProductSearchByCategoryTileList.maximizedScrollY = window.scrollY;
                                    // show all details
                                    tile.drawMaximized();
                                    // remember view state as maximized, primary key and scroll position 
                                    history.replaceState("viewState=maximized", "test");
                                }
                            }
                        }
                    }
                }
            }
        };
        // draw tiles in normal size
        ProductSearchByCategoryTileList.drawNormal = function () {
            // get client elements
            var canvas = document.getElementById("myCanvas");
            var context = canvas.getContext("2d");
            // set vertical size
            if (ProductSearchByCategoryTileList.tileListHeight != 0) {
                canvas.height = ProductSearchByCategoryTileList.tileListHeight;
            }
            // clear canvas
            // this means we are drawing on a "clear" canvas, and background colors will shine through
            // ProductSearchByCategoryTileList.clearCanvas("white");  // overallColors.backGround
            // draw tiles
            for (var _i = 0, _a = ProductSearchByCategoryTileList.tiles; _i < _a.length; _i++) {
                var tile = _a[_i];
                tile.draw(context);
            }
        };
        ProductSearchByCategoryTileList.tileListHeight = 0;
        // maximized state
        ProductSearchByCategoryTileList.maximized = false;
        ProductSearchByCategoryTileList.maximizedScrollY = 0;
        return ProductSearchByCategoryTileList;
    }());
    var Link = /** @class */ (function () {
        function Link() {
        }
        Link.prototype.measure = function (boxLeft, boxTop, boxWidth, boxHeight, position) {
            // calculate link size
            this.linkBorder = boxHeight * 0.1;
            this.linkWidth = (boxWidth * 0.1) - this.linkBorder; // (boxWidth * 0.15);
            this.linkHeight = boxHeight - (this.linkBorder * 2);
            this.linkLeft = boxLeft +
                boxWidth -
                ((this.linkBorder + this.linkWidth + this.linkBorder) * position) -
                this.linkBorder;
            this.linkTop = boxTop + this.linkBorder;
        };
        // draw link rectangles
        Link.prototype.draw = function (context, font, text, top) {
            context.beginPath();
            context.lineWidth = 2;
            context.strokeStyle = "white"; // overallColors.text
            context.fillStyle = "rgb(0, 128, 0)"; // overallColors.link
            context.shadowColor = "rgb(128, 128, 128)"; // overallColors.shadow
            context.shadowBlur = 0;
            context.shadowOffsetX = 0;
            context.shadowOffsetY = 0;
            context.fillRect(this.linkLeft, this.linkTop, this.linkWidth, this.linkHeight);
            context.fillStyle = "white"; // overallColors.linkText
            context.font = font;
            // cap text of last column until it fits inside the tile
            while (context.measureText(text).width > this.linkWidth
                && text.length > 2) {
                text = text.substr(0, text.length - 1);
            }
            context.fillText(text, this.linkLeft + (this.linkWidth / 2) - (context.measureText(text).width / 2), top);
        };
        // draw frame
        Link.prototype.frame = function (context, lineWidth, showDash) {
            var dashList = [5]; // create a dot/dash sequence
            context.beginPath();
            context.lineWidth = lineWidth;
            context.strokeStyle = showDash ? "white" : "rgb(128, 128, 128)"; // overallColors.backGround / overallColors.shadow
            context.fillStyle = showDash ? "white" : "rgb(128, 128, 128))"; // overallColors.backGround / overallColors.shadow
            context.shadowColor = showDash ? "white" : "rgb(128, 128, 128))"; // overallColors.backGround / overallColors.shadow
            context.shadowBlur = 0;
            context.shadowOffsetX = 0;
            context.shadowOffsetY = 0;
            if (showDash) {
                context.setLineDash(dashList);
            }
            else {
                context.setLineDash([]);
            }
            context.rect(this.linkLeft, this.linkTop, this.linkWidth, this.linkHeight);
            context.stroke();
        };
        return Link;
    }());
    // represents everything needed inside one tile
    var Tile = /** @class */ (function () {
        function Tile(name, tileLeft, tileTop, url, tileCount, tileHeight, tileBorder, textReposLeft, tileSpaceVertical, tileFontSize, fillStyle, productSearchByCategory, productListWidths) {
            this.name = name;
            this.tileLeft = tileLeft;
            this.tileTop = tileTop;
            this.url = url;
            this.tileCount = tileCount;
            this.tileHeight = tileHeight;
            this.tileBorder = tileBorder;
            this.textReposLeft = textReposLeft;
            this.tileSpaceVertical = tileSpaceVertical;
            this.tileFontSize = tileFontSize;
            this.fillStyle = fillStyle;
            this.productSearchByCategory = productSearchByCategory;
            this.productListWidths = productListWidths;
            this.backgroundColor = "white"; // overallColors.backGround
            this.textColor = "white"; // overallColors.linkText
            this.lineWidth = 1;
            this.textLeft = 0;
            // action links
            this.detailsLink = new Link();
            this.editLink = new Link();
            this.selectLink = new Link();
            // alignments
            this.tileTop = tileSpaceVertical + ((this.tileHeight + tileSpaceVertical) * this.tileTop);
            this.textLeft = this.tileLeft + this.textReposLeft + (this.tileBorder * 1.5);
        }
        // calculate width of tile
        Tile.prototype.tileWidth = function () {
            var canvas = document.getElementById("myCanvas");
            return canvas.width - this.tileLeft - this.tileBorder - this.tileBorder;
        };
        // calculate top position of text
        Tile.prototype.textTop = function (text) {
            return this.tileTop + (this.tileHeight / 2) + (this.tileFontSize / 2);
        };
        // draws the tile
        Tile.prototype.draw = function (context) {
            // tile frame based on background color of canvas"s parent
            var getBody = document.getElementsByTagName("body")[0];
            var property = window.getComputedStyle(getBody).getPropertyValue("background-color");
            if (property === "rgb(255, 255, 255)")
                this.tileFrame(context, "black");
            else
                this.tileFrame(context, "white");
            // save box measurements
            var boxLeft = this.tileLeft;
            var boxTop = this.tileTop;
            var boxWidth = this.tileWidth();
            var boxHeight = this.tileHeight;
            // draw rectangle
            context.beginPath();
            context.lineWidth = this.lineWidth;
            context.strokeStyle = this.backgroundColor;
            context.fillStyle = this.fillStyle;
            // no shadow, but included anyway
            context.shadowColor = "rgb(128, 128, 128)"; // overallColors.shadow
            context.shadowBlur = 0;
            context.shadowOffsetX = 0;
            context.shadowOffsetY = 0;
            context.fillRect(boxLeft, boxTop, boxWidth, boxHeight);
            context.stroke();
            // action links
            var lastActionLinkLeft = boxWidth - boxLeft;
            var onlyCalc = this.productSearchByCategory == null;
            // Details
            this.detailsLink.measure(boxLeft, boxTop, boxWidth, boxHeight, 1);
            this.detailsLink.linkUrl = "../Product/PIMDetails?productId=";
            if (!onlyCalc)
                this.detailsLink.draw(context, this.tileFontSize + "px Arial", "D", this.textTop(this.name));
            lastActionLinkLeft = this.detailsLink.linkLeft;
            // Edit
            this.editLink.measure(boxLeft, boxTop, boxWidth, boxHeight, 2);
            this.editLink.linkUrl = "../ProductMaintenance/ProductMaintenanceEdit?productId=";
            if (!onlyCalc)
                this.editLink.draw(context, this.tileFontSize + "px Arial", "E", this.textTop(this.name));
            lastActionLinkLeft = this.editLink.linkLeft;
            // Select
            this.selectLink.measure(boxLeft, boxTop, boxWidth, boxHeight, 3);
            this.selectLink.linkUrl = "../Product/Order?productId=";
            if (!onlyCalc)
                this.selectLink.draw(context, this.tileFontSize + "px Arial", "S", this.textTop(this.name));
            lastActionLinkLeft = this.selectLink.linkLeft;
            if (!onlyCalc)
                context.stroke();
            // tile text
            context.beginPath();
            if (this.productSearchByCategory == null)
                context.font = "bold " + this.tileFontSize + "px Arial";
            else
                context.font = this.tileFontSize + "px Arial";
            context.strokeStyle = this.textColor;
            context.fillStyle = this.textColor;
            // no shadow, but included anyway
            context.shadowColor = "rgb(128, 128, 128)"; // overallColors.shadow
            context.shadowBlur = 0;
            context.shadowOffsetX = 0;
            context.shadowOffsetY = 0;
            // row columns
            var leftPos = this.textLeft;
            var text;
            // no widths means this is the header, exit
            if (this.productListWidths == null) {
                // cap text of last column until it fits inside the tile
                text = this.name;
                while (context.measureText(text).width > lastActionLinkLeft - leftPos
                    && text.length > 2) {
                    text = text.substr(0, text.length - 1);
                }
                context.fillText(text, leftPos, this.textTop(name));
                context.stroke();
                return;
            }
            // Product Name
            // cap text of last column until it fits inside the tile
            text = this.productSearchByCategory == null ? "Name" : this.productSearchByCategory.ProductName;
            while (context.measureText(text).width > lastActionLinkLeft - leftPos
                && text.length > 2) {
                text = text.substr(0, text.length - 1);
            }
            context.fillText(text, leftPos, this.textTop(name));
            leftPos += this.productListWidths[0] + 20;
            // Identifier
            text = this.productSearchByCategory == null ? "Identifier" : (this.productSearchByCategory.Identifier === null ? "" : this.productSearchByCategory.Identifier);
            if (leftPos < lastActionLinkLeft - this.productListWidths[1]) {
                context.fillText(text, leftPos, this.textTop(name));
            }
            leftPos += this.productListWidths[1] + 20;
            // Value
            text = this.productSearchByCategory == null ? "Value" : (this.productSearchByCategory.Value === null ? "" : this.productSearchByCategory.Value);
            if (leftPos < lastActionLinkLeft - this.productListWidths[2]) {
                context.fillText(text, leftPos, this.textTop(name));
            }
            leftPos += this.productListWidths[2] + 20;
            // Product Info Value
            text = this.productSearchByCategory == null ? "Info Value" : (this.productSearchByCategory.ProductInfoValue === null ? "" : this.productSearchByCategory.ProductInfoValue);
            if (leftPos < lastActionLinkLeft - this.productListWidths[3]) {
                context.fillText(text, leftPos, this.textTop(name));
            }
            leftPos += this.productListWidths[3] + 20;
            // Product Image Type Name
            text = this.productSearchByCategory == null ? "Image Type Name" : (this.productSearchByCategory.ProductImageTypeName === null ? "" : this.productSearchByCategory.ProductImageTypeName);
            if (leftPos < lastActionLinkLeft - this.productListWidths[4]) {
                context.fillText(text, leftPos, this.textTop(name));
            }
            leftPos += this.productListWidths[4] + 20;
            // Image
            text = this.productSearchByCategory == null ? "Image" : (this.productSearchByCategory.Image === null ? "" : this.productSearchByCategory.Image);
            if (leftPos < lastActionLinkLeft - this.productListWidths[5]) {
                context.fillText(text, leftPos, this.textTop(name));
            }
            leftPos += this.productListWidths[5] + 20;
            context.stroke();
        };
        // frame
        Tile.prototype.frame = function (context, strokeStyle, lineWidth, showDash) {
            var dashList = [5]; // dot/dash sequence
            context.beginPath();
            context.lineWidth = lineWidth;
            context.strokeStyle = strokeStyle;
            context.fillStyle = strokeStyle;
            context.shadowColor = strokeStyle;
            context.shadowBlur = 0;
            context.shadowOffsetX = 0;
            context.shadowOffsetY = 0;
            if (showDash) {
                context.setLineDash(dashList);
            }
            else {
                context.setLineDash([]);
            }
            context.rect(this.tileLeft, this.tileTop, this.tileWidth(), this.tileHeight);
            context.stroke();
        };
        Tile.prototype.tileFrame = function (context, color) {
            context.beginPath();
            context.lineWidth = this.lineWidth;
            context.strokeStyle = color;
            context.fillStyle = color;
            context.shadowColor = "rgb(128, 128, 128)"; // overallColors.shadow
            context.shadowBlur = 0;
            context.shadowOffsetX = 0;
            context.shadowOffsetY = 0;
            context.fillRect(this.tileLeft - 1, this.tileTop - 1, this.tileWidth() + 2, this.tileHeight + 2);
            context.stroke();
        };
        // check if coordinates are inside tile boundaries
        Tile.prototype.hitTest = function (clientX, clientY) {
            if (clientX < this.tileLeft || clientX > this.tileLeft + this.tileWidth()) {
                return false;
            }
            if (clientY < this.tileTop || clientY > this.tileTop + this.tileHeight) {
                return false;
            }
            return true;
        };
        // draw maximized
        Tile.prototype.drawMaximized = function () {
            // get client elements
            var canvas = document.getElementById("myCanvas");
            var context = canvas.getContext("2d");
            ProductSearchByCategoryTileList.maximized = true;
            ProductSearchByCategoryTileList.maximizedTile = this;
            // draw header
            window.scrollTo(0, 0);
            ProductSearchByCategoryTileList.resizeCanvas();
            ProductSearchByCategoryTileList.header.draw(context);
            // resize canvas to fit all columns 
            canvas.height = 270 + 15;
            // clear background
            context.beginPath();
            context.fillStyle = "rgb(24, 101, 29)"; // overallColors.foreGround
            context.fillRect(0, 0, canvas.width - this.tileBorder, canvas.height);
            context.stroke();
            // first line ( from main tile )
            context.beginPath();
            context.font = this.tileFontSize * 1.2 + "px Arial";
            context.fillStyle = "white"; // overallColors.text
            context.fillText("Product Search By Category", 10, window.scrollY + 30);
            // all displayable columns from table
            context.font = this.tileFontSize * 1.1 + "px Arial";
            // Product Name ( column name first, then value )
            context.fillStyle = "rgb(211, 211, 211)"; // overallColors.textAlternate 
            var textProductName = "Product Name: ";
            while (context.measureText(textProductName).width > this.tileWidth() - 40
                && textProductName.length > 2) {
                textProductName = textProductName.substr(0, textProductName.length - 1);
            }
            context.fillText(textProductName, 20, window.scrollY + 66);
            // column value
            context.fillStyle = "rgb(240, 240, 0)"; // overallColors.textColumnValue 
            var textProductNameValue = this.productSearchByCategory.ProductName.toString();
            while (context.measureText(textProductName).width + context.measureText(textProductNameValue).width > this.tileWidth() - 40
                && textProductNameValue.length > 2) {
                textProductNameValue = textProductNameValue.substr(0, textProductNameValue.length - 1);
            }
            context.fillText(textProductNameValue, context.measureText(textProductName).width + 20, window.scrollY + 66);
            // Identifier ( column name first, then value )
            context.fillStyle = "white"; // overallColors.text 
            var textIdentifier = "Identifier: ";
            while (context.measureText(textIdentifier).width > this.tileWidth() - 40
                && textIdentifier.length > 2) {
                textIdentifier = textIdentifier.substr(0, textIdentifier.length - 1);
            }
            context.fillText(textIdentifier, 20, window.scrollY + 96);
            // column value
            context.fillStyle = "rgb(240, 240, 0)"; // overallColors.textColumnValue 
            var textIdentifierValue = this.productSearchByCategory.Identifier.toString();
            while (context.measureText(textIdentifier).width + context.measureText(textIdentifierValue).width > this.tileWidth() - 40
                && textIdentifierValue.length > 2) {
                textIdentifierValue = textIdentifierValue.substr(0, textIdentifierValue.length - 1);
            }
            context.fillText(textIdentifierValue, context.measureText(textIdentifier).width + 20, window.scrollY + 96);
            // Value ( column name first, then value )
            context.fillStyle = "rgb(211, 211, 211)"; // overallColors.textAlternate 
            var textValue = "Value: ";
            while (context.measureText(textValue).width > this.tileWidth() - 40
                && textValue.length > 2) {
                textValue = textValue.substr(0, textValue.length - 1);
            }
            context.fillText(textValue, 20, window.scrollY + 126);
            // column value
            context.fillStyle = "rgb(240, 240, 0)"; // overallColors.textColumnValue 
            var textValueValue = this.productSearchByCategory.Value.toString();
            while (context.measureText(textValue).width + context.measureText(textValueValue).width > this.tileWidth() - 40
                && textValueValue.length > 2) {
                textValueValue = textValueValue.substr(0, textValueValue.length - 1);
            }
            context.fillText(textValueValue, context.measureText(textValue).width + 20, window.scrollY + 126);
            // Product Info Value ( column name first, then value )
            context.fillStyle = "white"; // overallColors.text 
            var textProductInfoValue = "Product Info Value: ";
            while (context.measureText(textProductInfoValue).width > this.tileWidth() - 40
                && textProductInfoValue.length > 2) {
                textProductInfoValue = textProductInfoValue.substr(0, textProductInfoValue.length - 1);
            }
            context.fillText(textProductInfoValue, 20, window.scrollY + 156);
            // column value
            context.fillStyle = "rgb(240, 240, 0)"; // overallColors.textColumnValue 
            var textProductInfoValueValue = this.productSearchByCategory.ProductInfoValue.toString();
            while (context.measureText(textProductInfoValue).width + context.measureText(textProductInfoValueValue).width > this.tileWidth() - 40
                && textProductInfoValueValue.length > 2) {
                textProductInfoValueValue = textProductInfoValueValue.substr(0, textProductInfoValueValue.length - 1);
            }
            context.fillText(textProductInfoValueValue, context.measureText(textProductInfoValue).width + 20, window.scrollY + 156);
            // Product Image Type Name ( column name first, then value )
            context.fillStyle = "rgb(211, 211, 211)"; // overallColors.textAlternate 
            var textProductImageTypeName = "Product Image Type Name: ";
            while (context.measureText(textProductImageTypeName).width > this.tileWidth() - 40
                && textProductImageTypeName.length > 2) {
                textProductImageTypeName = textProductImageTypeName.substr(0, textProductImageTypeName.length - 1);
            }
            context.fillText(textProductImageTypeName, 20, window.scrollY + 186);
            // column value
            context.fillStyle = "rgb(240, 240, 0)"; // overallColors.textColumnValue 
            var textProductImageTypeNameValue = this.productSearchByCategory.ProductImageTypeName.toString();
            while (context.measureText(textProductImageTypeName).width + context.measureText(textProductImageTypeNameValue).width > this.tileWidth() - 40
                && textProductImageTypeNameValue.length > 2) {
                textProductImageTypeNameValue = textProductImageTypeNameValue.substr(0, textProductImageTypeNameValue.length - 1);
            }
            context.fillText(textProductImageTypeNameValue, context.measureText(textProductImageTypeName).width + 20, window.scrollY + 186);
            // Image ( column name first, then value )
            context.fillStyle = "white"; // overallColors.text 
            var textImage = "Image: ";
            while (context.measureText(textImage).width > this.tileWidth() - 40
                && textImage.length > 2) {
                textImage = textImage.substr(0, textImage.length - 1);
            }
            context.fillText(textImage, 20, window.scrollY + 216);
            // column value
            context.fillStyle = "rgb(240, 240, 0)"; // overallColors.textColumnValue 
            var textImageValue = this.productSearchByCategory.Image.toString();
            while (context.measureText(textImage).width + context.measureText(textImageValue).width > this.tileWidth() - 40
                && textImageValue.length > 2) {
                textImageValue = textImageValue.substr(0, textImageValue.length - 1);
            }
            context.fillText(textImageValue, context.measureText(textImage).width + 20, window.scrollY + 216);
            context.stroke();
        };
        return Tile;
    }());
})(DesignVestreVikenDurian || (DesignVestreVikenDurian = {}));
//# sourceMappingURL=ProductSearch.js.map