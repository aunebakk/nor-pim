"use strict";
var DashboardFirst;
(function (DashboardFirst) {
    var DashboardLibrary = /** @class */ (function () {
        function DashboardLibrary() {
        }
        // check if we are living in a mobile phone
        DashboardLibrary.isMobile = function () {
            return false;
        };
        DashboardLibrary.prototype.frame = function (strokeStyle, lineWidth, showDash, width, height) {
            var canvas = document.getElementById(canvasName);
            var context = canvas.getContext("2d");
            var dashList = [frameDashListCount]; // create a dot/dash sequence
            context.beginPath();
            context.lineWidth = lineWidth;
            context.strokeStyle = strokeStyle;
            context.fillStyle = strokeStyle;
            context.shadowColor = strokeStyle;
            context.shadowBlur = frameShadowBlurOff;
            context.shadowOffsetX = frameShadowOffsetOff;
            if (showDash) {
                context.setLineDash(dashList);
            }
            else {
                context.setLineDash([]);
            }
            context.rect(0, 0, width, height);
            context.stroke();
        };
        // calc tile size factor based on available canvas with
        DashboardLibrary.sizeFactor = function () {
            return 1;
        };
        // clear canvas
        DashboardLibrary.clearCanvas = function () {
            // get client elements
            var canvas = document.getElementById(canvasName);
            var context = canvas.getContext("2d");
            context.beginPath();
            context.fillStyle = canvasBackgroundColor;
            context.fillRect(0, 0, canvas.width, canvas.height);
            context.stroke();
        };
        // check if coordinates are inside tile boundaries
        DashboardLibrary.hitTestCanvas = function (clientX, clientY) {
            // get client elements
            var canvas = document.getElementById(canvasName);
            if (clientX < canvas.clientLeft || clientX > canvas.clientLeft + canvas.clientWidth / clientWidthHalfDivider) {
                return false;
            }
            if (clientY < canvas.clientTop || clientY > canvas.clientTop + canvas.clientHeight / clientWidthHalfDivider) {
                return false;
            }
            return true;
        };
        return DashboardLibrary;
    }());
    // represents everything needed inside one tile
    var Tile = /** @class */ (function () {
        function Tile(dashboardItemRcd, imageElement, name, left, top, offset, sizeFactor, stateMax, url, iconSizeMax, iconMaximize) {
            if (iconMaximize === void 0) { iconMaximize = true; }
            this.dashboardItemRcd = dashboardItemRcd;
            this.imageElement = imageElement;
            this.name = name;
            this.left = left;
            this.top = top;
            this.offset = offset;
            this.sizeFactor = sizeFactor;
            this.stateMax = stateMax;
            this.url = url;
            this.iconSizeMax = iconSizeMax;
            this.iconMaximize = iconMaximize;
            this.value = "";
        }
        Tile.prototype.width = function () { return tileWidth; };
        Tile.prototype.height = function () { return tileHeight; };
        Tile.prototype.infoLineOne = function () {
            if (this.iconSizeMax) {
                return this.name;
            }
            else if (this.value !== "0") {
                return this.value + " " + this.name;
            }
            else {
                return this.name;
            }
        };
        // tile coordinates
        Tile.prototype.relativeTileLeft = function () {
            return this.left + (this.offset * this.sizeFactor);
        };
        Tile.prototype.relativeTileTop = function () {
            return this.top * this.sizeFactor;
        };
        Tile.prototype.relativeTileWidth = function () {
            return this.width() * this.sizeFactor;
        };
        Tile.prototype.relativeTileHeight = function () {
            return this.height() * this.sizeFactor;
        };
        Tile.prototype.relativeTileBorder = function () {
            return 15 * this.sizeFactor;
        };
        // min/max icon coordinates
        Tile.prototype.relativeMinMaxLeft = function () {
            return this.left +
                (this.offset * this.sizeFactor) +
                (this.width() * this.sizeFactor) -
                (this.relativeTileBorder() * 2 * this.sizeFactor);
        };
        Tile.prototype.relativeMinMaxTop = function () {
            return this.top * this.sizeFactor + (this.relativeTileBorder() * this.sizeFactor);
        };
        Tile.prototype.relativeMinMaxWidth = function () {
            return this.relativeTileBorder() * this.sizeFactor;
        };
        Tile.prototype.relativeMinMaxHeight = function () {
            return this.relativeTileBorder() * this.sizeFactor;
        };
        // icon coordinates
        Tile.prototype.relativeIconLeft = function () {
            if (this.iconSizeMax) {
                return this.relativeTileLeft() + (10 * this.sizeFactor);
            }
            else {
                return this.relativeTileLeft() + (13 * this.sizeFactor);
            }
        };
        Tile.prototype.relativeIconTop = function () {
            if (this.iconSizeMax) {
                return this.relativeTileTop() + (15 * this.sizeFactor);
            }
            else {
                return this.relativeTileTop() + (1 * this.sizeFactor);
            }
        };
        Tile.prototype.relativeIconWidth = function () {
            if (this.iconSizeMax) {
                return this.relativeTileWidth() - this.relativeTileBorder() * 2;
            }
            else {
                return 50 * this.sizeFactor;
            }
        };
        Tile.prototype.relativeIconHeight = function () {
            if (this.iconSizeMax) {
                return this.relativeTileHeight() - this.relativeTileBorder() * 2;
            }
            else {
                return 50 * this.sizeFactor;
            }
        };
        // font
        Tile.prototype.relativeFontLargest = function () {
            return (24 * this.sizeFactor) + fontSuffix;
        };
        Tile.prototype.relativeFontLarge = function () {
            return (16 * this.sizeFactor) + fontSuffix;
        };
        Tile.prototype.relativeFontMedium = function () {
            return (8 * this.sizeFactor) + fontSuffix;
        };
        Tile.prototype.relativeFontSmall = function () {
            return (6 * this.sizeFactor) + fontSuffix;
        };
        // text
        Tile.prototype.relativeTextTop = function (row) {
            return this.relativeTileTop() + this.relativeTextTopBorder(row);
        };
        Tile.prototype.relativeTextLeft = function () {
            return this.relativeTileLeft() + (relativeTextBorder * this.sizeFactor);
        };
        Tile.prototype.relativeTextTopBorder = function (row) {
            return row * relativeTextHeight * this.sizeFactor;
        };
        Tile.prototype.relativeTileMargin = function () {
            return relativeTileMarginConstant * this.sizeFactor;
        };
        Tile.prototype.scaleBottom = function () {
            return this.relativeTileTop() +
                (this.relativeTileBorder() * this.sizeFactor) +
                this.relativeTileHeight() -
                this.relativeTileMargin();
        };
        Tile.prototype.tileFrame = function (context) {
            context.lineWidth = tileLineWidth;
            context.strokeStyle = tileBackgroundColor;
            context.fillStyle = tileBackgroundColor;
            context.shadowColor = frameShadowColor;
            context.shadowBlur = frameShadowBlur;
            context.shadowOffsetX = infoShadowOffsetXFactor; // this.sizeFactor * infoShadowOffsetXFactor;
            context.beginPath();
            context.fillRect(this.relativeTileLeft(), this.relativeTileTop(), this.relativeTileWidth(), this.relativeTileHeight());
        };
        Tile.prototype.tileFrameNoShadow = function (context) {
            context.lineWidth = tileLineWidth;
            context.strokeStyle = tileBackgroundColor;
            context.fillStyle = tileBackgroundColor;
            context.shadowColor = tileBackgroundColor;
            context.shadowBlur = frameShadowBlurOff;
            context.shadowOffsetX = frameShadowOffsetOff;
            context.beginPath();
            context.fillRect(this.relativeTileLeft(), this.relativeTileTop(), this.relativeTileWidth(), this.relativeTileHeight());
        };
        // draws the tile
        Tile.prototype.draw = function (context, factor) {
            this.sizeFactor = factor;
            // fixed stuff
            this.tileFrame(context);
            // icon
            if (this.imageElement.length !== 0) {
                var image = document.getElementById(this.imageElement);
                if (image !== null) {
                    context.drawImage(image, this.relativeIconLeft(), this.relativeIconTop(), this.relativeIconWidth(), this.relativeIconHeight());
                }
            }
            // header
            context.strokeStyle = tileTextColor;
            context.fillStyle = tileTextColor;
            context.shadowBlur = this.iconSizeMax ? 2 : 0;
            context.shadowOffsetX = this.sizeFactor;
            context.font = this.relativeFontLarge();
            context.fillText(this.infoLineOne(), this.relativeTextLeft(), this.relativeTextTop(this.iconSizeMax ? 2 : 9));
        };
        Tile.prototype.headerColumns = function (context, left, rowPosition) {
            // context.fillText("User Code", left + (20 * this.sizeFactor), rowPosition);
        };
        Tile.prototype.columns = function (context, row, left, rowPosition) {
            // context.fillText(users[row].DefaultUserCode, left + (20 * this.sizeFactor), rowPosition);
        };
        Tile.prototype.maxRows = function () {
            return 0;
        };
        // check if coordinates are inside tile boundaries
        Tile.prototype.hitTest = function (clientX, clientY) {
            if (clientX < this.relativeTileLeft() || clientX > this.relativeTileLeft() + this.relativeTileWidth()) {
                return false;
            }
            if (clientY < this.relativeTileTop() || clientY > this.relativeTileTop() + this.relativeTileHeight()) {
                return false;
            }
            return true;
        };
        // do help
        Tile.prototype.help = function (context) {
            ;
        };
        // do auto
        Tile.prototype.auto = function (context) {
            ;
        };
        // check if coordinates are inside tile's maximize icon boundaries
        Tile.prototype.hitTestMaximize = function (clientX, clientY) {
            // no hit if no maximize button :-)
            if (!this.iconMaximize) {
                return false;
            }
            // check tile boundaries
            var clickArea = 10;
            if (clientX < this.relativeMinMaxLeft() - clickArea ||
                clientX > this.relativeMinMaxLeft() + this.relativeMinMaxWidth() + clickArea) {
                return false;
            }
            if (clientY < this.relativeMinMaxTop() - clickArea ||
                clientY > this.relativeMinMaxTop() + this.relativeMinMaxHeight() + clickArea) {
                return false;
            }
            return true;
        };
        // draw frame
        Tile.prototype.frame = function (strokeStyle, lineWidth, showDash) {
            var canvas = document.getElementById(canvasName);
            var context = canvas.getContext("2d");
            var dashList = [frameDashListCount]; // create a dot/dash sequence
            context.beginPath();
            context.lineWidth = lineWidth;
            context.strokeStyle = strokeStyle;
            context.fillStyle = strokeStyle;
            context.shadowColor = strokeStyle;
            context.shadowBlur = frameShadowBlurOff;
            context.shadowOffsetX = frameShadowOffsetOff;
            if (showDash) {
                context.setLineDash(dashList);
            }
            else {
                context.setLineDash([]);
            }
            context.rect(this.left + (this.offset * this.sizeFactor) + 5, this.top * this.sizeFactor + 5, this.width() * this.sizeFactor - 10, this.height() * this.sizeFactor - 10);
            context.stroke();
        };
        // draw frame
        Tile.prototype.clear = function (strokeStyle) {
            var canvas = document.getElementById(canvasName);
            var context = canvas.getContext("2d");
            context.beginPath();
            context.lineWidth = 1;
            context.strokeStyle = strokeStyle;
            context.fillStyle = strokeStyle;
            context.shadowColor = strokeStyle;
            context.shadowBlur = frameShadowBlurOff;
            context.shadowOffsetX = frameShadowOffsetOff;
            context.setLineDash([]);
            context.fillRect(this.left + (this.offset * this.sizeFactor) - 5, this.top * this.sizeFactor - 5, this.width() * this.sizeFactor + 5, this.height() * this.sizeFactor + 5);
            context.stroke();
        };
        return Tile;
    }());
    // canvas for dashboard
    var Dashboard = /** @class */ (function () {
        function Dashboard() {
            Dashboard.stateMax = false;
            // init tiles
            Dashboard.tiles = new Array();
        }
        // resize canvas based on window size
        Dashboard.prototype.resizeCanvas = function () {
            // get client elements
            var canvas = document.getElementById(canvasName);
            if (tileWidthScaleRecalc) {
                canvas.width = window.innerWidth * tileWidthScale;
                canvas.height = window.innerHeight + (tileBorder * (tileCountHeight + 3));
            }
            else {
                var sizeFactor = canvas.width / (maxLeft + tileWidth + tileBorder);
                canvas.width = window.innerWidth / tileCountWidth;
                canvas.height = (((tileHeight + tileBorder) * tileCountHeight) + tileBorder * tileCountHeight) * sizeFactor;
            }
        };
        Dashboard.prototype.frame = function (strokeStyle, lineWidth, showDash, width, height) {
            var canvas = document.getElementById(canvasName);
            var context = canvas.getContext("2d");
            var dashList = [frameDashListCount]; // create a dot/dash sequence
            context.beginPath();
            context.lineWidth = lineWidth;
            context.strokeStyle = strokeStyle;
            context.fillStyle = strokeStyle;
            context.shadowColor = strokeStyle;
            context.shadowBlur = frameShadowBlurOff;
            context.shadowOffsetX = frameShadowOffsetOff;
            if (showDash) {
                context.setLineDash(dashList);
            }
            else {
                context.setLineDash([]);
            }
            context.rect(0, 0, width, height);
            context.stroke();
        };
        // clear canvas
        Dashboard.prototype.clearCanvas = function () {
            // get client elements
            var canvas = document.getElementById(canvasName);
            var context = canvas.getContext("2d");
            context.beginPath();
            context.fillStyle = canvasBackgroundColor;
            context.fillRect(0, 0, canvas.width, canvas.height);
            context.stroke();
        };
        Dashboard.prototype.start = function () {
            // get client elements
            var canvas = document.getElementById(canvasName);
            var sizeFactor = canvas.width / (maxLeft + tileWidth + tileBorder);
            // resize canvas
            this.resizeCanvas();
            this.clearCanvas();
            // add tiles
            try {
                Dashboard.tiles.push(new Tile("USER", "address-book", "Catalog", 6, 40, 0, sizeFactor, false, "../Dashboard/TemplateChapterIndex", // http
                true, false));
                Dashboard.tiles.push(new Tile("USER", "Klubok", "Product", 6, 40, 220, sizeFactor, false, "../ProductSearchByCategoryCodeLive/ProductSearchByCategoryCodeIndex?productCategoryCode=010903&onParent=true", // http
                true, false));
                Dashboard.tiles.push(new Tile("USER", "box", "Cart", 6, 260, 0, sizeFactor, false, "http://NorSolutionPimCore.azurewebsites.net/api/1/cartproductsearchservice/getcartproducttypescript", true, false));
                Dashboard.tiles.push(new Tile("USER", "apps", "Apps", 6, 260, 220, sizeFactor, false, "../install/publish.htm", // http
                true, false));
                Dashboard.tiles.push(new Tile("USER", "Text-edit", "About", 6, 480, 0, sizeFactor, false, "../home/about", // http
                true, false));
                Dashboard.tiles.push(new Tile("USER", "api", "API", 6, 480, 220, sizeFactor, false, "../home/API", // http
                true, false));
            }
            catch (Error) {
                alert(Error.message);
            }
            // handle clicks
            canvas.addEventListener("click", this.canvasClick, false);
            // event resize, orientation change
            var thisThat = this;
            var resize = function () {
                // resize canvas
                thisThat.resizeCanvas();
                // draw tiles
                thisThat.drawNormal();
            };
            // force redraw after all images are loaded
            window.onload = resize;
            window.onresize = resize;
            // check mouse pointer style
            document.onmousemove = function (e) {
                var canvas = document.getElementById(canvasName);
                // default style
                canvas.style.cursor = "auto";
                if (Dashboard.tiles) {
                    for (var _i = 0, _a = Dashboard.tiles; _i < _a.length; _i++) {
                        var tile = _a[_i];
                        // check maximize first as the next hit-test includes the whole tile
                        if (tile.hitTestMaximize(e.offsetX, e.offsetY)) {
                            canvas.style.cursor = "pointer";
                            // exit or the hit-test will continue for remaining tiles
                            break;
                        }
                        // check whole tile area
                        if (tile.hitTest(e.offsetX, e.offsetY)) {
                            canvas.style.cursor = "pointer";
                            break;
                        }
                    }
                }
            };
        };
        // draw tiles in normal size
        Dashboard.prototype.drawNormal = function () {
            // get client elements
            var canvas = document.getElementById(canvasName);
            var context = canvas.getContext("2d");
            var sizeFactorWidth = canvas.width / (maxLeft + tileWidth + tileBorder);
            var sizeFactorHeight = canvas.height / (maxTop + tileHeight + tileBorder);
            var newSizeFactor = sizeFactorWidth;
            // use height size factor if smaller
            if (sizeFactorHeight < newSizeFactor)
                newSizeFactor = sizeFactorHeight;
            // clear canvas
            context.beginPath();
            context.fillStyle = canvasBackgroundColor;
            context.fillRect(0, 0, canvas.width, canvas.height);
            context.stroke();
            // draw tiles
            for (var _i = 0, _a = Dashboard.tiles; _i < _a.length; _i++) {
                var tile = _a[_i];
                tile.draw(context, newSizeFactor);
            }
        };
        // maximize or normalize
        Dashboard.prototype.canvasClick = function (event) {
            var canvas = document.getElementById(canvasName);
            var context = canvas.getContext("2d");
            if (Dashboard.tiles) {
                for (var _i = 0, _a = Dashboard.tiles; _i < _a.length; _i++) {
                    var tile = _a[_i];
                    // check whole tile area
                    if (tile.hitTest(event.offsetX, event.offsetY)) {
                        // indicate that the tile was clicked
                        tile.frame(tileTextColor, frameLineWidthClick, true);
                        // reset the color after a short delay
                        var resetTile = tile;
                        setTimeout(function () {
                            resetTile.frame(tileBackgroundColor, frameLineWidthClear, false);
                        }, 1000);
                        // navigate to tile's main page
                        window.location.href = tile.url;
                    }
                    else {
                        // remove if not hit
                        tile.frame(tileBackgroundColor, frameLineWidthClear, false);
                    }
                }
            }
        };
        Dashboard.prototype.stop = function () {
            clearTimeout(this.timerToken);
        };
        return Dashboard;
    }());
    DashboardFirst.Dashboard = Dashboard;
})(DashboardFirst || (DashboardFirst = {}));
(function () {
    var dashboardFirst = new DashboardFirst.Dashboard();
    dashboardFirst.start();
})();
//# sourceMappingURL=dashboard.js.map