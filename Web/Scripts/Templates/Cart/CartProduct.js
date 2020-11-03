// SQL2X Generated code based on a SQL Server Schema
// SQL2X Version: 1.0
// http://sql2x.org/
// Generated Date: 11/3/2020 1:34:54 PM
// From Machine: DESKTOP-9A2DH39
// Filename: TemplateCartProduct.json
// MethodName: sql2x.CrudeTypeScriptGenerator.DesignVestreVikenDurian
// Template Style: WithDurianByTypeScript
// Documentation:
//   Typescript for durians
var DesignVestreVikenDurian;
(function (DesignVestreVikenDurian) {
    "use strict";
    // client on load / entry point
    window.onload = function () {
        var contentElement = document.getElementById("content");
        var durianGrid = new GetCartProductTileList(contentElement);
        for (var i = 0; i < cartProductList.length; i++) {
        }
        durianGrid.start();
    };
    // main Durian class
    var GetCartProductTileList = /** @class */ (function () {
        function GetCartProductTileList(element) {
            // init tiles
            GetCartProductTileList.tiles = new Array();
            // not maximized state
            GetCartProductTileList.maximized = false;
            GetCartProductTileList.maximizedTile = null;
            GetCartProductTileList.maximizedScrollY = 0;
            // references
            GetCartProductTileList.referenceCountLink = new Link();
        }
        // clear canvas
        GetCartProductTileList.clearCanvas = function (fillStyle) {
            // get client elements
            var canvas = document.getElementById("myCanvas");
            var context = canvas.getContext("2d");
            context.beginPath();
            context.fillStyle = fillStyle;
            context.fillRect(0, 0, canvas.width, canvas.height);
            context.stroke();
        };
        GetCartProductTileList.prototype.start = function () {
            var scale = "scale(1.0)";
            document.body.style.zoom = "1.0";
            document.body.style.webkitTransform = scale; // for Chrome, Opera, Safari
            document.body.style.transform = scale; // general
            // resize canvas to hold all cartProductList
            GetCartProductTileList.resizeCanvas();
            GetCartProductTileList.clearCanvas("white"); // overallColors.backGround
            // get client elements
            var canvas = document.getElementById("myCanvas");
            // header text
            var headerText = "Selected";
            // header tile
            var line = 0;
            GetCartProductTileList.header =
                new Tile(headerText, // name
                2, // tileLeft
                line, // tileTop
                "", // suffix of url
                cartProductList.length, // tileCount
                48, // tileHeight
                15, // tileBorder
                2, // textReposLeft
                5, // tileSpaceVertical
                16, // tileFontSize
                "rgb(24, 101, 29)", // overallColors.foreGround
                null, // entity null triggers header columns
                null // entity widths
                );
            GetCartProductTileList.tiles.push(GetCartProductTileList.header);
            // calc column widths 
            var context = canvas.getContext("2d");
            context.font = "14px Arial"; // tileFontSize
            var cartProductListWidths = new Array(17);
            cartProductListWidths[0] = context.measureText("Product Name").width;
            cartProductListWidths[1] = context.measureText("Financial Currency Type Code").width;
            cartProductListWidths[2] = context.measureText("Financial Currency Type Name").width;
            cartProductListWidths[3] = context.measureText("Image Blob Filename").width;
            cartProductListWidths[4] = context.measureText("Default User Name").width;
            cartProductListWidths[5] = context.measureText("Date Time").width;
            cartProductListWidths[6] = context.measureText("Session Identificator").width;
            cartProductListWidths[7] = 0;
            for (var i = 0; i < cartProductList.length; i++) {
                // Product Name
                if ((context.measureText(cartProductList[i].ProductName).width > cartProductListWidths[0])
                    && (context.measureText(cartProductList[i].ProductName).width < window.innerWidth * 0.9))
                    cartProductListWidths[0] = context.measureText(cartProductList[i].ProductName).width;
                // Financial Currency Type Code
                if ((context.measureText(cartProductList[i].FinancialCurrencyTypeCode).width > cartProductListWidths[1])
                    && (context.measureText(cartProductList[i].FinancialCurrencyTypeCode).width < window.innerWidth * 0.9))
                    cartProductListWidths[1] = context.measureText(cartProductList[i].FinancialCurrencyTypeCode).width;
                // Financial Currency Type Name
                if ((context.measureText(cartProductList[i].FinancialCurrencyTypeName).width > cartProductListWidths[2])
                    && (context.measureText(cartProductList[i].FinancialCurrencyTypeName).width < window.innerWidth * 0.9))
                    cartProductListWidths[2] = context.measureText(cartProductList[i].FinancialCurrencyTypeName).width;
                // Image Blob Filename
                if ((context.measureText(cartProductList[i].ImageBlobFilename).width > cartProductListWidths[3])
                    && (context.measureText(cartProductList[i].ImageBlobFilename).width < window.innerWidth * 0.9))
                    cartProductListWidths[3] = context.measureText(cartProductList[i].ImageBlobFilename).width;
                // Default User Name
                if ((context.measureText(cartProductList[i].DefaultUserName).width > cartProductListWidths[4])
                    && (context.measureText(cartProductList[i].DefaultUserName).width < window.innerWidth * 0.9))
                    cartProductListWidths[4] = context.measureText(cartProductList[i].DefaultUserName).width;
                // Date Time
                if ((context.measureText(cartProductList[i].DateTime).width > cartProductListWidths[5])
                    && (context.measureText(cartProductList[i].DateTime).width < window.innerWidth * 0.9))
                    cartProductListWidths[5] = context.measureText(cartProductList[i].DateTime).width;
                // Session Identificator
                if ((context.measureText(cartProductList[i].SessionIdentificator).width > cartProductListWidths[6])
                    && (context.measureText(cartProductList[i].SessionIdentificator).width < window.innerWidth * 0.9))
                    cartProductListWidths[6] = context.measureText(cartProductList[i].SessionIdentificator).width;
            }
            // grid rows for GetCartProduct
            var lastTile;
            line++;
            // header columns
            lastTile =
                new Tile("", // name
                40, // tileLeft
                line, // tileTop
                "", // suffix of url
                cartProductList.length, // tileCount
                45, // tileHeight
                15, // tileBorder
                2, // textReposLeft
                7, // tileSpaceVertical
                14, // tileFontSize
                "rgb(24, 101, 29)", // overallColors.foreGround
                null, // entity null triggers header columns
                cartProductListWidths // entity widths
                );
            GetCartProductTileList.tiles.push(lastTile);
            for (var i = 0; i < cartProductList.length; i++) {
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
                    cartProductList[i].CartProductId, // most significant key from durian
                    cartProductList.length, // tileCount
                    45, // tileHeight
                    15, // tileBorder
                    2, // textReposLeft
                    7, // tileSpaceVertical
                    14, // tileFontSize
                    newColor, // fillStyle
                    cartProductList[i], // entity
                    cartProductListWidths // entity widths
                    );
                GetCartProductTileList.tiles.push(lastTile);
            }
            // resize canvas to last tile
            if (lastTile) {
                canvas.height = lastTile.tileTop + lastTile.tileHeight + 15;
                GetCartProductTileList.tileListHeight = canvas.height;
            }
            // init state
            history.scrollRestoration = "manual";
            // previous state
            window.addEventListener("popstate", function (event) {
                GetCartProductTileList.checkState(event.state);
            });
            GetCartProductTileList.checkState("");
            // handle click event
            canvas.addEventListener("click", this.canvasClick, false);
            // handle resize event
            window.addEventListener("resize", function () {
                // resize canvas
                GetCartProductTileList.resizeCanvas();
                // draw GetCartProduct index according to visual state
                if (GetCartProductTileList.maximized
                    && GetCartProductTileList.maximizedTile != null) {
                    // draw maximized
                    GetCartProductTileList.maximizedTile.drawMaximized();
                    var context_1 = canvas.getContext("2d");
                    GetCartProductTileList.header.draw(context_1);
                }
                else {
                    // draw normal
                    GetCartProductTileList.drawNormal();
                }
            }, false);
            // check mouse pointer style for tiles
            canvas.onmousemove = function (e) {
                canvas.style.cursor = "auto"; // default style
                if (GetCartProductTileList.tiles) {
                    for (var _i = 0, _a = GetCartProductTileList.tiles; _i < _a.length; _i++) {
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
        GetCartProductTileList.getValue = function (parameters, getParameter) {
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
        GetCartProductTileList.checkState = function (state) {
            if (state == null)
                state = "";
            // get scroll position
            var numberPartScrollY = GetCartProductTileList.getValue(state, "scrollY={");
            // if not maximized, or failed to find entity ...
            GetCartProductTileList.maximizedTile = null;
            if (state.indexOf("#viewState=maximized") != -1) {
                for (var i = 0; i < GetCartProductTileList.tiles.length; i++) {
                    if (GetCartProductTileList.tiles[i].getCartProduct != null) {
                        if (!isNaN(Number(numberPartScrollY))) {
                            GetCartProductTileList.maximizedScrollY = Number(numberPartScrollY);
                        }
                        GetCartProductTileList.maximizedTile = GetCartProductTileList.tiles[i];
                        GetCartProductTileList.maximizedTile.drawMaximized();
                        // remember view state as maximized, primary key and scroll position 
                        state = "viewState=maximized";
                        break;
                    }
                }
            }
            // ... then draw a grid
            if (GetCartProductTileList.maximizedTile == null) {
                GetCartProductTileList.drawNormal();
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
        GetCartProductTileList.isMobile = function () {
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
        GetCartProductTileList.resizeCanvas = function () {
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
        GetCartProductTileList.prototype.canvasClick = function (event) {
            if (GetCartProductTileList.maximized) {
                var canvas = document.getElementById("myCanvas");
                var context = canvas.getContext("2d");
                GetCartProductTileList.drawNormal();
                GetCartProductTileList.maximized = false;
                GetCartProductTileList.maximizedTile = null;
                window.scrollTo(0, GetCartProductTileList.maximizedScrollY);
                // remember view state grid
                history.replaceState("viewState=grid", "test");
            }
            else {
                if (GetCartProductTileList.tiles) {
                    var canvas = document.getElementById("myCanvas");
                    var context = canvas.getContext("2d");
                    for (var _i = 0, _a = GetCartProductTileList.tiles; _i < _a.length; _i++) {
                        var tile = _a[_i];
                        // check whole tile area
                        if (tile.hitTest(event.offsetX, event.offsetY)) {
                            if (tile.name == "") { // check for not header
                                // action links
                                if (event.offsetX > tile.unOrderLink.linkLeft) {
                                    // indicate that the tile link was clicked
                                    tile.unOrderLink.frame(context, tile.lineWidth, true);
                                    // go to url
                                    window.location.href = tile.unOrderLink.linkUrl + tile.url;
                                }
                                else if (tile.getCartProduct != null) {
                                    // indicate that the tile link was clicked
                                    tile.frame(context, tile.backgroundColor, 2, true);
                                    // remember current scroll 
                                    GetCartProductTileList.maximizedScrollY = window.scrollY;
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
        GetCartProductTileList.drawNormal = function () {
            // get client elements
            var canvas = document.getElementById("myCanvas");
            var context = canvas.getContext("2d");
            // set vertical size
            if (GetCartProductTileList.tileListHeight != 0) {
                canvas.height = GetCartProductTileList.tileListHeight;
            }
            // clear canvas
            // this means we are drawing on a "clear" canvas, and background colors will shine through
            // GetCartProductTileList.clearCanvas("white");  // overallColors.backGround
            // draw tiles
            for (var _i = 0, _a = GetCartProductTileList.tiles; _i < _a.length; _i++) {
                var tile = _a[_i];
                tile.draw(context);
            }
        };
        GetCartProductTileList.tileListHeight = 0;
        // maximized state
        GetCartProductTileList.maximized = false;
        GetCartProductTileList.maximizedScrollY = 0;
        return GetCartProductTileList;
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
        function Tile(name, tileLeft, tileTop, url, tileCount, tileHeight, tileBorder, textReposLeft, tileSpaceVertical, tileFontSize, fillStyle, getCartProduct, cartProductListWidths) {
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
            this.getCartProduct = getCartProduct;
            this.cartProductListWidths = cartProductListWidths;
            this.backgroundColor = "white"; // overallColors.backGround
            this.textColor = "white"; // overallColors.linkText
            this.lineWidth = 1;
            this.textLeft = 0;
            // action links
            this.unOrderLink = new Link();
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
            var onlyCalc = this.getCartProduct == null;
            // Un Order
            this.unOrderLink.measure(boxLeft, boxTop, boxWidth, boxHeight, 1);
            this.unOrderLink.linkUrl = "../Product/UnOrder?cartProductId=";
            if (!onlyCalc)
                this.unOrderLink.draw(context, this.tileFontSize + "px Arial", "U", this.textTop(this.name));
            lastActionLinkLeft = this.unOrderLink.linkLeft;
            if (!onlyCalc)
                context.stroke();
            // tile text
            context.beginPath();
            if (this.getCartProduct == null)
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
            if (this.cartProductListWidths == null) {
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
            text = this.getCartProduct == null ? "Product Name" : this.getCartProduct.ProductName;
            while (context.measureText(text).width > lastActionLinkLeft - leftPos
                && text.length > 2) {
                text = text.substr(0, text.length - 1);
            }
            context.fillText(text, leftPos, this.textTop(name));
            leftPos += this.cartProductListWidths[0] + 20;
            // Financial Currency Type Code
            text = this.getCartProduct == null ? "Financial Currency Type Code" : (this.getCartProduct.FinancialCurrencyTypeCode === null ? "" : this.getCartProduct.FinancialCurrencyTypeCode);
            if (leftPos < lastActionLinkLeft - this.cartProductListWidths[1]) {
                context.fillText(text, leftPos, this.textTop(name));
            }
            leftPos += this.cartProductListWidths[1] + 20;
            // Financial Currency Type Name
            text = this.getCartProduct == null ? "Financial Currency Type Name" : (this.getCartProduct.FinancialCurrencyTypeName === null ? "" : this.getCartProduct.FinancialCurrencyTypeName);
            if (leftPos < lastActionLinkLeft - this.cartProductListWidths[2]) {
                context.fillText(text, leftPos, this.textTop(name));
            }
            leftPos += this.cartProductListWidths[2] + 20;
            // Image Blob Filename
            text = this.getCartProduct == null ? "Image Blob Filename" : (this.getCartProduct.ImageBlobFilename === null ? "" : this.getCartProduct.ImageBlobFilename);
            if (leftPos < lastActionLinkLeft - this.cartProductListWidths[3]) {
                context.fillText(text, leftPos, this.textTop(name));
            }
            leftPos += this.cartProductListWidths[3] + 20;
            // Default User Name
            text = this.getCartProduct == null ? "Default User Name" : (this.getCartProduct.DefaultUserName === null ? "" : this.getCartProduct.DefaultUserName);
            if (leftPos < lastActionLinkLeft - this.cartProductListWidths[4]) {
                context.fillText(text, leftPos, this.textTop(name));
            }
            leftPos += this.cartProductListWidths[4] + 20;
            // Date Time
            text = this.getCartProduct == null ? "Date Time" : (this.getCartProduct.DateTime === null ? "" : this.getCartProduct.DateTime);
            if (leftPos < lastActionLinkLeft - this.cartProductListWidths[5]) {
                context.fillText(text, leftPos, this.textTop(name));
            }
            leftPos += this.cartProductListWidths[5] + 20;
            // Session Identificator
            text = this.getCartProduct == null ? "Session Identificator" : (this.getCartProduct.SessionIdentificator === null ? "" : this.getCartProduct.SessionIdentificator);
            if (leftPos < lastActionLinkLeft - this.cartProductListWidths[6]) {
                context.fillText(text, leftPos, this.textTop(name));
            }
            leftPos += this.cartProductListWidths[6] + 20;
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
            GetCartProductTileList.maximized = true;
            GetCartProductTileList.maximizedTile = this;
            // draw header
            window.scrollTo(0, 0);
            GetCartProductTileList.resizeCanvas();
            GetCartProductTileList.header.draw(context);
            // resize canvas to fit all columns 
            canvas.height = 300 + 15;
            // clear background
            context.beginPath();
            context.fillStyle = "rgb(24, 101, 29)"; // overallColors.foreGround
            context.fillRect(0, 0, canvas.width - this.tileBorder, canvas.height);
            context.stroke();
            // first line ( from main tile )
            context.beginPath();
            context.font = this.tileFontSize * 1.2 + "px Arial";
            context.fillStyle = "white"; // overallColors.text
            context.fillText("Get Cart Product", 10, window.scrollY + 30);
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
            var textProductNameValue = this.getCartProduct.ProductName.toString();
            while (context.measureText(textProductName).width + context.measureText(textProductNameValue).width > this.tileWidth() - 40
                && textProductNameValue.length > 2) {
                textProductNameValue = textProductNameValue.substr(0, textProductNameValue.length - 1);
            }
            context.fillText(textProductNameValue, context.measureText(textProductName).width + 20, window.scrollY + 66);
            // Financial Currency Type Code ( column name first, then value )
            context.fillStyle = "white"; // overallColors.text 
            var textFinancialCurrencyTypeCode = "Financial Currency Type Code: ";
            while (context.measureText(textFinancialCurrencyTypeCode).width > this.tileWidth() - 40
                && textFinancialCurrencyTypeCode.length > 2) {
                textFinancialCurrencyTypeCode = textFinancialCurrencyTypeCode.substr(0, textFinancialCurrencyTypeCode.length - 1);
            }
            context.fillText(textFinancialCurrencyTypeCode, 20, window.scrollY + 96);
            // column value
            context.fillStyle = "rgb(240, 240, 0)"; // overallColors.textColumnValue 
            var textFinancialCurrencyTypeCodeValue = this.getCartProduct.FinancialCurrencyTypeCode.toString();
            while (context.measureText(textFinancialCurrencyTypeCode).width + context.measureText(textFinancialCurrencyTypeCodeValue).width > this.tileWidth() - 40
                && textFinancialCurrencyTypeCodeValue.length > 2) {
                textFinancialCurrencyTypeCodeValue = textFinancialCurrencyTypeCodeValue.substr(0, textFinancialCurrencyTypeCodeValue.length - 1);
            }
            context.fillText(textFinancialCurrencyTypeCodeValue, context.measureText(textFinancialCurrencyTypeCode).width + 20, window.scrollY + 96);
            // Financial Currency Type Name ( column name first, then value )
            context.fillStyle = "rgb(211, 211, 211)"; // overallColors.textAlternate 
            var textFinancialCurrencyTypeName = "Financial Currency Type Name: ";
            while (context.measureText(textFinancialCurrencyTypeName).width > this.tileWidth() - 40
                && textFinancialCurrencyTypeName.length > 2) {
                textFinancialCurrencyTypeName = textFinancialCurrencyTypeName.substr(0, textFinancialCurrencyTypeName.length - 1);
            }
            context.fillText(textFinancialCurrencyTypeName, 20, window.scrollY + 126);
            // column value
            context.fillStyle = "rgb(240, 240, 0)"; // overallColors.textColumnValue 
            var textFinancialCurrencyTypeNameValue = this.getCartProduct.FinancialCurrencyTypeName.toString();
            while (context.measureText(textFinancialCurrencyTypeName).width + context.measureText(textFinancialCurrencyTypeNameValue).width > this.tileWidth() - 40
                && textFinancialCurrencyTypeNameValue.length > 2) {
                textFinancialCurrencyTypeNameValue = textFinancialCurrencyTypeNameValue.substr(0, textFinancialCurrencyTypeNameValue.length - 1);
            }
            context.fillText(textFinancialCurrencyTypeNameValue, context.measureText(textFinancialCurrencyTypeName).width + 20, window.scrollY + 126);
            // Image Blob Filename ( column name first, then value )
            context.fillStyle = "white"; // overallColors.text 
            var textImageBlobFilename = "Image Blob Filename: ";
            while (context.measureText(textImageBlobFilename).width > this.tileWidth() - 40
                && textImageBlobFilename.length > 2) {
                textImageBlobFilename = textImageBlobFilename.substr(0, textImageBlobFilename.length - 1);
            }
            context.fillText(textImageBlobFilename, 20, window.scrollY + 156);
            // column value
            context.fillStyle = "rgb(240, 240, 0)"; // overallColors.textColumnValue 
            var textImageBlobFilenameValue = this.getCartProduct.ImageBlobFilename.toString();
            while (context.measureText(textImageBlobFilename).width + context.measureText(textImageBlobFilenameValue).width > this.tileWidth() - 40
                && textImageBlobFilenameValue.length > 2) {
                textImageBlobFilenameValue = textImageBlobFilenameValue.substr(0, textImageBlobFilenameValue.length - 1);
            }
            context.fillText(textImageBlobFilenameValue, context.measureText(textImageBlobFilename).width + 20, window.scrollY + 156);
            // Default User Name ( column name first, then value )
            context.fillStyle = "rgb(211, 211, 211)"; // overallColors.textAlternate 
            var textDefaultUserName = "Default User Name: ";
            while (context.measureText(textDefaultUserName).width > this.tileWidth() - 40
                && textDefaultUserName.length > 2) {
                textDefaultUserName = textDefaultUserName.substr(0, textDefaultUserName.length - 1);
            }
            context.fillText(textDefaultUserName, 20, window.scrollY + 186);
            // column value
            context.fillStyle = "rgb(240, 240, 0)"; // overallColors.textColumnValue 
            var textDefaultUserNameValue = this.getCartProduct.DefaultUserName.toString();
            while (context.measureText(textDefaultUserName).width + context.measureText(textDefaultUserNameValue).width > this.tileWidth() - 40
                && textDefaultUserNameValue.length > 2) {
                textDefaultUserNameValue = textDefaultUserNameValue.substr(0, textDefaultUserNameValue.length - 1);
            }
            context.fillText(textDefaultUserNameValue, context.measureText(textDefaultUserName).width + 20, window.scrollY + 186);
            // Date Time ( column name first, then value )
            context.fillStyle = "white"; // overallColors.text 
            var textDateTime = "Date Time: ";
            while (context.measureText(textDateTime).width > this.tileWidth() - 40
                && textDateTime.length > 2) {
                textDateTime = textDateTime.substr(0, textDateTime.length - 1);
            }
            context.fillText(textDateTime, 20, window.scrollY + 216);
            // column value
            context.fillStyle = "rgb(240, 240, 0)"; // overallColors.textColumnValue 
            var textDateTimeValue = this.getCartProduct.DateTime.toString();
            while (context.measureText(textDateTime).width + context.measureText(textDateTimeValue).width > this.tileWidth() - 40
                && textDateTimeValue.length > 2) {
                textDateTimeValue = textDateTimeValue.substr(0, textDateTimeValue.length - 1);
            }
            context.fillText(textDateTimeValue, context.measureText(textDateTime).width + 20, window.scrollY + 216);
            // Session Identificator ( column name first, then value )
            context.fillStyle = "rgb(211, 211, 211)"; // overallColors.textAlternate 
            var textSessionIdentificator = "Session Identificator: ";
            while (context.measureText(textSessionIdentificator).width > this.tileWidth() - 40
                && textSessionIdentificator.length > 2) {
                textSessionIdentificator = textSessionIdentificator.substr(0, textSessionIdentificator.length - 1);
            }
            context.fillText(textSessionIdentificator, 20, window.scrollY + 246);
            // column value
            context.fillStyle = "rgb(240, 240, 0)"; // overallColors.textColumnValue 
            var textSessionIdentificatorValue = this.getCartProduct.SessionIdentificator.toString();
            while (context.measureText(textSessionIdentificator).width + context.measureText(textSessionIdentificatorValue).width > this.tileWidth() - 40
                && textSessionIdentificatorValue.length > 2) {
                textSessionIdentificatorValue = textSessionIdentificatorValue.substr(0, textSessionIdentificatorValue.length - 1);
            }
            context.fillText(textSessionIdentificatorValue, context.measureText(textSessionIdentificator).width + 20, window.scrollY + 246);
            context.stroke();
        };
        return Tile;
    }());
})(DesignVestreVikenDurian || (DesignVestreVikenDurian = {}));
//# sourceMappingURL=CartProduct.js.map