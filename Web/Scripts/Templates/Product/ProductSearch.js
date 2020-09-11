var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    }
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
// SQL2X Generated code based on a SQL Server Schema
// SQL2X Version: 1.0
// http://sql2x.org/
// Generated Date: 8/12/2020 7:51:06 AM
// From Machine: DESKTOP-517I8BU
// Template: sql2x.CrudeTypeScriptGenerator.OverallDesignTypeScriptTine
var SQL2XTemplateCrudeTableDurian;
(function (SQL2XTemplateCrudeTableDurian) {
    '   use strict';
    // client on load
    window.onload = function () {
        var contentElement = document.getElementById('content');
        var dashboard = new DurianTiles(contentElement);
        dashboard.start();
    };
    // class
    var DurianTiles = /** @class */ (function () {
        function DurianTiles(element) {
            // init tiles
            DurianTiles.tiles = new Array();
        }
        // clear canvas
        DurianTiles.clearCanvas = function (fillStyle) {
            // get client elements
            var canvas = document.getElementById('myCanvas');
            var context = canvas.getContext('2d');
            context.beginPath();
            context.fillStyle = fillStyle;
            context.fillRect(0, 0, canvas.width, canvas.height);
            context.stroke();
        };
        DurianTiles.prototype.start = function () {
            // http://stackoverflow.com/questions/21093570/force-page-zoom-at-100-with-js
            var scale = 'scale(1.0)';
            document.body.style.zoom = '1.0';
            document.body.style.webkitTransform = scale; // Chrome, Opera, Safari
            //document.body.style.msTransform = scale;      // IE 9
            document.body.style.transform = scale; // General
            // resize canvas to hold all products
            this.resizeCanvas(Tile.tileFontSize() + 30);
            DurianTiles.clearCanvas('white');
            // get client elements
            var canvas = document.getElementById('myCanvas');
            var context = canvas.getContext('2d');
            var line = 0;
            var header = new Tile('Durians', 2, line, '', products.length, Tile.tileFontSize() + 30, 15, 2, 5);
            // header
            DurianTiles.tiles.push(header);
            // remaining products
            var lastTile;
            for (var i = 0; i < products.length; i++) {
                line++;
                lastTile =
                    new Tile(products[i].ProductName, 40, line, products[i].ProductId, products.length, Tile.tileFontSize() + 30, 15, 2, 7);
                DurianTiles.tiles.push(lastTile);
            }
            // resize canvas to last tile
            if (lastTile)
                canvas.height = lastTile.tileTop + lastTile.tileHeight + 15;
            // draw chapter index
            this.drawNormal();
            // handle click event
            canvas.addEventListener('click', this.canvasClick, false);
            // resize
            var thisThat = this;
            window.addEventListener('resize', function () {
                // resize canvas
                thisThat.resizeCanvas(Tile.tileFontSize() + 30);
                // clear canvas
                DurianTiles.clearCanvas('white');
                // draw chapter index
                thisThat.drawNormal();
            }, false);
            // check mouse pointer style
            document.onmousemove = function (e) {
                // default style
                canvas.style.cursor = 'auto';
                if (DurianTiles.tiles) {
                    for (var _i = 0, _a = DurianTiles.tiles; _i < _a.length; _i++) {
                        var tile = _a[_i];
                        // check whole tile area
                        if (tile.hitTest(e.offsetX, e.offsetY)) {
                            canvas.style.cursor = 'pointer';
                            break;
                        }
                    }
                }
            };
        };
        // check if we are living in a mobile phone
        DurianTiles.prototype.isMobile = function () {
            var isMobileForSure = false;
            // detectmobilebrowsers.com
            (function (a) {
                if (/(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|mobile.+firefox|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows ce|xda|xiino|android|ipad|playbook|silk/i.test(a) || /1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-/i.test(a.substr(0, 4)))
                    isMobileForSure = true;
            })(navigator.userAgent || navigator.vendor);
            return isMobileForSure;
        };
        // resize canvas based on window size
        DurianTiles.prototype.resizeCanvas = function (left) {
            // get client elements
            var canvas = document.getElementById('myCanvas');
            if (!this.isMobile()) {
                canvas.width = window.innerWidth * 0.8;
            }
            else {
                canvas.width = window.innerWidth;
            }
        };
        // check click event
        DurianTiles.prototype.canvasClick = function (event) {
            var canvas = document.getElementById('myCanvas');
            var context = canvas.getContext('2d');
            if (DurianTiles.tiles) {
                for (var _i = 0, _a = DurianTiles.tiles; _i < _a.length; _i++) {
                    var tile = _a[_i];
                    // check whole tile area
                    if (tile.hitTest(event.offsetX, event.offsetY)) {
                        if (tile.url != '') {
                            if (event.offsetX > tile.editLink.linkLeft) {
                                // indicate that the tile link was clicked
                                tile.editLink.frame(tile.lineWidth, true);
                                // reset the color after a short delay
                                var resetTile = tile;
                                setTimeout(function () {
                                    resetTile.draw(context);
                                }, 500);
                                // go to edits
                                window.location.href = tile.editLink.linkUrl + tile.url;
                            }
                            else if (event.offsetX > tile.detailLink.linkLeft) {
                                // indicate that the tile link was clicked
                                tile.detailLink.frame(tile.lineWidth, true);
                                // reset the color after a short delay
                                var resetTile = tile;
                                setTimeout(function () {
                                    resetTile.draw(context);
                                }, 500);
                                // go to detail
                                window.location.href = tile.detailLink.linkUrl + tile.url;
                            }
                            else {
                                // indicate that the tile link was clicked
                                tile.frame(tile.backgroundColor, 2, true);
                                // reset the color after a short delay
                                var resetTile = tile;
                                setTimeout(function () {
                                    resetTile.draw(context);
                                }, 500);
                                // go to details
                                window.location.href = tile.detailLink.linkUrl + tile.url;
                            }
                        }
                        else {
                            // navigate to tile's main page
                            try {
                                var contentElement = document.getElementById('content');
                                var dashboard = new DurianTiles(contentElement);
                                dashboard.start();
                            }
                            catch (Error) {
                                //alert(Error.message);
                            }
                        }
                    }
                    else {
                        // remove if not hit
                        tile.draw(context);
                    }
                }
            }
        };
        // draw tiles in normal size
        DurianTiles.prototype.drawNormal = function () {
            // get client elements
            var canvas = document.getElementById('myCanvas');
            var context = canvas.getContext('2d');
            // draw tiles
            for (var _i = 0, _a = DurianTiles.tiles; _i < _a.length; _i++) {
                var tile = _a[_i];
                tile.draw(context);
            }
        };
        return DurianTiles;
    }());
    var Link = /** @class */ (function () {
        function Link() {
        }
        Link.prototype.measure = function (boxLeft, boxTop, boxWidth, boxHeight, position) {
            this.linkBorder = boxHeight * 0.1;
            this.linkWidth = (boxWidth * 0.1) - this.linkBorder;
            this.linkHeight = boxHeight - (this.linkBorder * 2);
            this.linkLeft = boxLeft +
                boxWidth -
                ((this.linkBorder + this.linkWidth + this.linkBorder) * position) -
                this.linkBorder;
            this.linkTop = boxTop + this.linkBorder;
        };
        // draw frame
        Link.prototype.draw = function (font, text, top) {
            var canvas = document.getElementById('myCanvas');
            var context = canvas.getContext('2d');
            // draw link boxes
            context.beginPath();
            context.lineWidth = 2;
            context.strokeStyle = 'black';
            context.fillStyle = 'darkgreen';
            context.shadowColor = 'darkgray';
            context.shadowBlur = 20;
            context.shadowOffsetX = 0;
            context.shadowOffsetY = 0;
            context.fillStyle = 'darkgreen';
            context.fillRect(this.linkLeft, this.linkTop, this.linkWidth, this.linkHeight);
            context.fillStyle = 'white';
            context.font = font;
            context.fillText(text, this.linkLeft + (this.linkWidth / 2) - (context.measureText(text).width / 2), top);
        };
        // draw frame
        Link.prototype.frame = function (lineWidth, showDash) {
            var canvas = document.getElementById('myCanvas');
            var context = canvas.getContext('2d');
            var dashList = [5]; // Create a dot/dash sequence
            context.beginPath();
            context.lineWidth = lineWidth;
            context.strokeStyle = showDash ? 'white' : 'black';
            context.fillStyle = showDash ? 'white' : 'black';
            context.shadowColor = showDash ? 'white' : 'black';
            context.shadowBlur = 0;
            context.shadowOffsetX = 0;
            if (showDash)
                context.setLineDash(dashList);
            else
                context.setLineDash([]);
            context.rect(this.linkLeft, this.linkTop, this.linkWidth, this.linkHeight);
            context.stroke();
        };
        return Link;
    }());
    var LinkPicture = /** @class */ (function (_super) {
        __extends(LinkPicture, _super);
        function LinkPicture() {
            return _super !== null && _super.apply(this, arguments) || this;
        }
        // draw frame
        LinkPicture.prototype.draw = function (font, text, top) {
            var canvas = document.getElementById('myCanvas');
            var context = canvas.getContext('2d');
            // draw link boxes
            context.beginPath();
            context.lineWidth = 2;
            context.strokeStyle = 'black';
            context.fillStyle = 'darkgray';
            context.shadowColor = 'darkgray';
            context.shadowBlur = 20;
            context.shadowOffsetX = 0;
            context.shadowOffsetY = 0;
            context.fillStyle = 'darkgray';
            context.fillRect(this.linkLeft, this.linkTop, this.linkWidth, this.linkHeight);
            context.fillStyle = 'white';
            context.font = font;
            //context.fillText(
            //text,
            //this.linkLeft + (this.linkWidth / 2) - (context.measureText(text).width / 2),
            //top
            //);
            var image = document.getElementById('product');
            //const image = document.getElementById('product') as HTMLImageElement;
            if (image != null) {
                context.drawImage(image, this.linkLeft + 1, this.linkTop + 1, this.linkWidth - 2, this.linkHeight - 2);
            }
        };
        return LinkPicture;
    }(Link));
    // represents everything needed inside one tile
    var Tile = /** @class */ (function () {
        function Tile(name, tileLeft, tileTop, url, tileCount, tileHeight, tileBorder, textReposLeft, tileSpaceVertical) {
            this.name = name;
            this.tileLeft = tileLeft;
            this.tileTop = tileTop;
            this.url = url;
            this.tileCount = tileCount;
            this.tileHeight = tileHeight;
            this.tileBorder = tileBorder;
            this.textReposLeft = textReposLeft;
            this.tileSpaceVertical = tileSpaceVertical;
            this.backgroundColor = 'white';
            this.textColor = 'black';
            this.lineWidth = 1;
            this.textLeft = 0;
            this.editLink = new Link();
            this.detailLink = new Link();
            this.pictureLink = new LinkPicture();
            this.tileTop = tileSpaceVertical + ((this.tileHeight + tileSpaceVertical) * this.tileTop);
            this.textLeft = this.tileLeft + this.textReposLeft + (this.tileBorder * 1.5);
        }
        Tile.prototype.tileWidth = function () {
            // get client elements
            var canvas = document.getElementById('myCanvas');
            return canvas.width - this.tileLeft - this.tileBorder - this.tileBorder;
        };
        Tile.tileFontSize = function () {
            return 14;
        };
        Tile.prototype.tileFont = function () {
            return Tile.tileFontSize() + 'px Arial';
        };
        // text
        Tile.prototype.textTop = function (text) {
            var canvas = document.getElementById('myCanvas');
            var context = canvas.getContext('2d');
            return this.tileTop + (this.tileHeight / 2) + (Tile.tileFontSize() / 2);
        };
        // draws the tile
        Tile.prototype.draw = function (context) {
            // fixed stuff
            this.tileFrame(context);
            // gradient box
            var boxLeft = this.tileLeft;
            var boxTop = this.tileTop;
            var boxWidth = this.tileWidth();
            var boxHeight = this.tileHeight;
            context.beginPath();
            context.lineWidth = this.lineWidth;
            context.strokeStyle = this.backgroundColor;
            if (this.url == '') {
                context.fillStyle = 'rgb(4, 115, 8)';
            }
            else {
                context.fillStyle = 'rgb(23, 141, 39)';
            }
            context.shadowColor = 'gray';
            context.shadowBlur = 10;
            context.shadowOffsetX = 3;
            context.fillRect(boxLeft, boxTop, boxWidth, boxHeight);
            context.stroke();
            if (this.url != '') {
                // edit link
                this.editLink.measure(boxLeft, boxTop, boxWidth, boxHeight, 1);
                this.editLink.linkUrl = 'http://NorSolutionPim.azurewebsites.net/controller/action?id=';
                this.editLink.draw(this.tileFont(), 'E', this.textTop(this.name));
                context.stroke();
                // detail link
                this.detailLink.measure(boxLeft, boxTop, boxWidth, boxHeight, 2);
                this.detailLink.linkUrl = 'http://NorSolutionPim.azurewebsites.net/controller/action?id=';
                this.detailLink.draw(this.tileFont(), 'D', this.textTop(this.name));
                // picture link
                this.pictureLink.measure(boxLeft, boxTop, boxWidth, boxHeight, 3);
                this.pictureLink
                    .linkUrl = '../images/efo/1082853_thumb_300x300.png?';
                //this.pictureLink.draw(this.tileFont(), 'P', this.textTop(this.name));
            }
            // chapter header
            context.beginPath();
            context.font = this.tileFont();
            context.strokeStyle = this.backgroundColor;
            context.fillStyle = this.backgroundColor;
            context.shadowBlur = 10;
            context.shadowOffsetX = 3;
            // cap text until it fits inside the tile
            var name = this.name;
            while (context.measureText(name).width > (this.detailLink.linkLeft - this.textLeft - this.tileBorder) &&
                name.length > 2) {
                name = name.substr(0, name.length - 1);
            }
            context.fillText(name, this.textLeft, this.textTop(name));
            context.stroke();
        };
        // draw frame
        Tile.prototype.frame = function (strokeStyle, lineWidth, showDash) {
            var canvas = document.getElementById('myCanvas');
            var context = canvas.getContext('2d');
            var dashList = [5]; // dot/dash sequence
            context.beginPath();
            context.lineWidth = lineWidth;
            context.strokeStyle = strokeStyle;
            context.fillStyle = strokeStyle;
            context.shadowColor = strokeStyle;
            context.shadowBlur = 0;
            context.shadowOffsetX = 0;
            if (showDash)
                context.setLineDash(dashList);
            else
                context.setLineDash([]);
            context.rect(this.tileLeft, this.tileTop, this.tileWidth(), this.tileHeight);
            context.stroke();
        };
        Tile.prototype.tileFrame = function (context) {
            context.beginPath();
            context.lineWidth = this.lineWidth;
            context.strokeStyle = this.backgroundColor;
            context.fillStyle = this.backgroundColor;
            context.shadowColor = 'gray';
            context.shadowBlur = 10;
            context.shadowOffsetX = 3;
            context.fillRect(this.tileLeft, this.tileTop, this.tileWidth(), this.tileHeight);
            context.stroke();
        };
        // check if coordinates are inside tile boundaries
        Tile.prototype.hitTest = function (clientX, clientY) {
            if (clientX < this.tileLeft || clientX > this.tileLeft + this.tileWidth())
                return false;
            if (clientY < this.tileTop || clientY > this.tileTop + this.tileHeight)
                return false;
            return true;
        };
        return Tile;
    }());
})(SQL2XTemplateCrudeTableDurian || (SQL2XTemplateCrudeTableDurian = {}));
//# sourceMappingURL=ProductSearch.js.map