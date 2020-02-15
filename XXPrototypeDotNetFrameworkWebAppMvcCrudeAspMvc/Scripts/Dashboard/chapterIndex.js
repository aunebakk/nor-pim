// (c) sql2x.org
"use strict";
var ChapterIndex;
(function (ChapterIndex) {
    // declaration
    // text of first chapter
    var mainChapterText = "EFO Basen ( from efo.no ) for ";
    // start productCategoryParentId
    var mainProductCategoryParentId = "";
    var htmlBackgroundColor = "white";
    // content name from HTML ("content")
    var htmlContentName = "content";
    // canvas name from HTML ("myCanvas")
    var htmlCanvasName = "myCanvas";
    // scale name from HTML (htmlScale(1.0))
    var htmlScale = "scale(1.0)";
    var htmlZoom = "1.0";
    var tileFillStyleMain = 'rgb(4, 115, 8)';
    var tileFillStyle = 'rgb(23, 141, 39)';
    var tileStrokeStyle = 'black';
    var tileFont = 'px Arial';
    var tileLineWidth = 2;
    var tileFontSize = 14;
    var tileBorder = 15;
    var tileHeight = 44;
    //var tileLink: string = '../ProductSearch/ProductSearchIndex?onParent=true&productCategoryId=';  // http
    var tileLink = '../ProductSearchByCategoryLive/ProductSearchByCategoryIndex?onParent=true&productCategoryId='; // http
    var tileClickTimeout = 100;
    var tileTextReposLeft = 2;
    var tileSpaceVertical = 7;
    var tileIndent = 40;
    var shadowColor = 'gray';
    var shadowBlur = 10;
    var shadowOffsetX = 3;
    // client on load
    window.onload = function () {
        var dashboard = new TemplateChapterIndex();
        dashboard.start();
    };
    // Template based class from sql2core
    var TemplateChapterIndex = /** @class */ (function () {
        function TemplateChapterIndex() {
        }
        // check if we are living in a mobile phone
        TemplateChapterIndex.isMobile = function () {
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
        TemplateChapterIndex.prototype.resizeCanvas = function () {
            // get client elements
            var canvas = document.getElementById("myCanvas");
            if (!TemplateChapterIndex.isMobile()) {
                canvas.width = window.innerWidth * (window.innerHeight / window.innerWidth);
            }
            else {
                canvas.width = window.innerWidth;
            }
        };
        TemplateChapterIndex.prototype.start = function () {
            document.body.style.zoom = htmlZoom;
            document.body.style.webkitTransform = htmlScale; // a Chrome, Opera, Safari
            document.body.style.transform = htmlScale; // general
            // get client elements
            var canvas = document.getElementById(htmlCanvasName);
            var context = canvas.getContext("2d");
            // resize canvas to hold all getFinancialOrderList
            this.resizeCanvas();
            // clear canvas
            context.beginPath();
            context.fillStyle = htmlBackgroundColor;
            context.fillRect(0, 0, canvas.width, canvas.height);
            context.stroke();
            this.draw('');
            // handle click event
            var dashboard1 = this;
            canvas.onclick =
                function (e) {
                    var canvas = document.getElementById('myCanvas');
                    var context = canvas.getContext('2d');
                    var _loop_1 = function (tile) {
                        rect = canvas.getBoundingClientRect();
                        x = e.clientX - rect.left;
                        y = e.clientY - rect.top;
                        // check tile area
                        if (tile.hitTest(x, y)) {
                            // indicate tile link was clicked
                            tile.frame(htmlBackgroundColor, tileLineWidth, true);
                            // reset the color after a short delay
                            var resetTile_1 = tile;
                            setTimeout(function () {
                                resetTile_1.draw();
                                if (tile.clickURL === "") {
                                    dashboard1.draw(tile.categoryFilter);
                                }
                                else {
                                    window.location.href = tile.clickURL;
                                }
                            }, tileClickTimeout);
                        }
                    };
                    var rect, x, y;
                    for (var _i = 0, _a = dashboard1.tiles; _i < _a.length; _i++) {
                        var tile = _a[_i];
                        _loop_1(tile);
                    }
                };
            // resize
            var dashboard2 = this;
            window.addEventListener("resize", function () {
                // resize canvas based on window size
                var canvas = document.getElementById(htmlCanvasName);
                dashboard2.resizeCanvas();
                // clear canvas
                var context = canvas.getContext("2d");
                context.beginPath();
                context.fillStyle = htmlBackgroundColor;
                context.fillRect(0, 0, canvas.width, canvas.height);
                context.stroke();
                // draw tiles
                for (var _i = 0, _a = dashboard2.tiles; _i < _a.length; _i++) {
                    var tile = _a[_i];
                    tile.draw();
                }
            }, false);
            // check mouse pointer style
            var dashboard3 = this;
            document.onmousemove =
                function (e) {
                    // default style
                    canvas.style.cursor = "auto";
                    if (dashboard3.tiles) {
                        for (var _i = 0, _a = dashboard3.tiles; _i < _a.length; _i++) {
                            var tile = _a[_i];
                            // check whole tile area
                            if (tile.hitTest(e.offsetX, e.offsetY)) {
                                canvas.style.cursor = "pointer";
                                break;
                            }
                        }
                    }
                };
        };
        TemplateChapterIndex.prototype.draw = function (categoryFilter) {
            // initialize chapter tiles
            delete this.tiles;
            this.tiles = new Array();
            var line = 0;
            var lastTileBottom = 0;
            var headTile = new Tile(mainChapterText + (TemplateChapterIndex.isMobile() ? "Phone" : "Web"), 0, line, "", "", productCategories.length, '');
            // header
            lastTileBottom = headTile.tileTop + tileHeight;
            this.tiles.push(headTile);
            // size canvas to header only
            var canvas = document.getElementById(htmlCanvasName);
            canvas.height = lastTileBottom;
            // add remaining chapters
            for (var i = 0; i < productCategories.length; i++) {
                var categoryCode = productCategories[i].ProductCategoryCode;
                var categoryCodeFirstTwo = categoryCode.substr(0, 2);
                var categoryCodeFirstFour = categoryCode.substr(0, 4);
                var categoryCodeLastFour = categoryCode.substr(2, 4);
                var categoryCodeLastTwo = categoryCode.substr(4, 2);
                var productCategoryId = '';
                // skip chapter if no name given
                if (productCategories[i].ProductCategoryName.length <= 10)
                    continue;
                if ((categoryFilter.length == 0) && (categoryCodeLastFour != '0000'))
                    continue;
                if ((categoryFilter.length == 2) && (categoryFilter != categoryCodeFirstTwo)
                    || ((categoryFilter.length == 2) && (categoryCodeLastTwo != '00')))
                    continue;
                if (categoryFilter.length == 4) {
                    productCategoryId = productCategories[i].ProductCategoryId;
                    if (categoryFilter != categoryCodeFirstFour)
                        continue;
                }
                line++;
                var tile = new Tile(productCategories[i].ProductCategoryName, tileIndent, line, categoryFilter.length === 0 ? categoryCodeFirstTwo : categoryFilter.length === 2 ? categoryCodeFirstFour : categoryFilter.length === 4 ? categoryCode : '', productCategoryId, productCategories.length, categoryFilter.length === 4 ? tileLink + productCategoryId : '');
                lastTileBottom = tile.tileTop + tileHeight;
                this.tiles.push(tile);
            }
            // resize canvas to last tile plus border
            canvas.height = lastTileBottom;
            // draw chapters
            for (var _i = 0, _a = this.tiles; _i < _a.length; _i++) {
                var tile = _a[_i];
                tile.draw();
            }
        };
        return TemplateChapterIndex;
    }());
    // represents everything needed inside one tile
    var Tile = /** @class */ (function () {
        function Tile(name, tileLeft, tileTop, categoryFilter, productCategoryParentId, tileCount, clickURL) {
            this.name = name;
            this.tileLeft = tileLeft;
            this.tileTop = tileTop;
            this.categoryFilter = categoryFilter;
            this.productCategoryParentId = productCategoryParentId;
            this.tileCount = tileCount;
            this.clickURL = clickURL;
            this.textLeft = 0;
            this.tileTop = tileSpaceVertical + ((tileHeight + tileSpaceVertical) * this.tileTop);
            this.textLeft = this.tileLeft + tileTextReposLeft + (tileBorder * 1.5);
        }
        Tile.prototype.tileWidth = function () {
            // get client elements
            var canvas = document.getElementById(htmlCanvasName);
            return canvas.width - this.tileLeft - tileBorder - tileBorder;
        };
        // draws the tile
        Tile.prototype.draw = function () {
            // get client elements
            var canvas = document.getElementById(htmlCanvasName);
            // clear canvas
            var context = canvas.getContext("2d");
            // fixed stuff
            this.frame(htmlBackgroundColor, tileLineWidth, false);
            // gradient box
            var boxLeft = this.tileLeft;
            var boxTop = this.tileTop;
            var boxWidth = this.tileWidth();
            var boxHeight = tileHeight;
            context.beginPath();
            context.lineWidth = tileLineWidth;
            context.strokeStyle = htmlBackgroundColor;
            if (this.categoryFilter === "") {
                context.fillStyle = tileFillStyleMain;
            }
            else {
                context.fillStyle = tileFillStyle;
            }
            context.shadowColor = shadowColor;
            context.shadowBlur = shadowBlur;
            context.shadowOffsetX = shadowOffsetX;
            context.fillRect(boxLeft, boxTop, boxWidth, boxHeight);
            context.stroke();
            // chapter header
            context.beginPath();
            context.font = tileFontSize + tileFont + (TemplateChapterIndex.isMobile() ? ' Bold' : '');
            context.strokeStyle = htmlBackgroundColor;
            context.fillStyle = htmlBackgroundColor;
            context.shadowBlur = shadowBlur;
            context.shadowOffsetX = shadowOffsetX;
            // cap text until it fits inside the tile
            var name = this.name;
            while (context.measureText(name).width > (this.tileWidth() - tileBorder - tileBorder) && name.length > 2) {
                name = name.substr(0, name.length - 1);
            }
            context.fillText(name, this.textLeft, this.tileTop + (tileHeight / 2) + (tileFontSize / 2));
            context.stroke();
        };
        // draw frame
        Tile.prototype.frame = function (tileStrokeStyle, tileLineWidth, showDash) {
            var canvas = document.getElementById(htmlCanvasName);
            var context = canvas.getContext("2d");
            // dot/dash sequence
            context.beginPath();
            context.lineWidth = tileLineWidth;
            context.strokeStyle = tileStrokeStyle;
            context.fillStyle = tileStrokeStyle;
            context.shadowColor = tileStrokeStyle;
            context.shadowBlur = 0;
            context.shadowOffsetX = 0;
            if (showDash) {
                var dashList = [5];
                context.setLineDash(dashList);
            }
            else {
                context.setLineDash([]);
            }
            context.rect(this.tileLeft, this.tileTop, this.tileWidth(), tileHeight);
            context.stroke();
        };
        // check if coordinates are inside tile boundaries
        Tile.prototype.hitTest = function (clientX, clientY) {
            if (clientX < this.tileLeft || clientX > this.tileLeft + this.tileWidth()) {
                return false;
            }
            if (clientY < this.tileTop || clientY > this.tileTop + tileHeight) {
                return false;
            }
            return true;
        };
        return Tile;
    }());
})(ChapterIndex || (ChapterIndex = {}));
//# sourceMappingURL=chapterIndex.js.map