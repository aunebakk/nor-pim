"use strict";
declare var dashboardItemRcd: string;
declare var dashboardIndicatorType: string;

declare var canvasName: string; //"myCanvas"; 

declare var tileWidthScale: number; //0.9;
declare var tileWidthScaleRecalc: boolean; //true; 
declare var tileCountWidth: number; // 2;
declare var tileCountHeight: number; // 2;

// number of dashes around tiles
declare var frameDashListCount: number; //5;

declare var frameLineWidthClick: number; //2;
declare var frameLineWidthClear: number; //5;

// frames shadow blur in 'off' state
declare var frameShadowBlurOff: number; //0;

// frames shadow offset in 'off' state
declare var frameShadowOffsetOff: number; //0;

// canvas background color, used for clearing canvas
declare var canvasBackgroundColor: string; //"white";

// used for dividing client width
declare var clientWidthHalfDivider: number; //2;

// tile coordinates
declare var relativeTileLeft: number; //1;
declare var relativeTileTop: number; //1;
declare var relativeTileWidth: number; //1;
declare var relativeTileHeight: number; //1;
declare var relativeTileBorder: number; //10;

// font suffix ( added after relative font size )
declare var fontSuffix: string; //"px Product Sans";
declare var fontSuffixBold: string; //"Bold";
declare var relativeTextHeight: number; //10;
declare var relativeTextBorder: number; //20;
declare var relativeTileMarginConstant: number; //56;

declare var frameShadowColor: string; //"gray";
declare var frameShadowBlur: number; //10;

declare var infoShadowColor: string; //"gray";
declare var infoShadowBlur: number; //10;
declare var infoShadowOffsetXFactor: number; //3;

declare var tileWidth: number; //200;
declare var tileHeight: number; //200;
declare var tileBorder: number; //20;
declare var tileBackgroundColor: string; //"white";
declare var tileTextColor: string; //"black";
declare var tileLineWidth: number; //1;

// bottom tile position
declare var maxTop: number; //260;

// find right(est) tile position
declare var maxLeft: number;  //220;

// check if we are living in a mobile phone
declare var isMobile: boolean; //false;

module DashboardFirst {

    class DashboardLibrary {
        // check if we are living in a mobile phone
        static isMobile(): boolean {
            return false;
        }

        frame(
            strokeStyle: any,
            lineWidth: number,
            showDash: boolean,
            width: number,
            height: number
        ): void {

            var canvas: HTMLCanvasElement = (document.getElementById(canvasName) as HTMLCanvasElement);
            var context: CanvasRenderingContext2D = canvas.getContext("2d");

            var dashList: number[] = [frameDashListCount]; // create a dot/dash sequence
            context.beginPath();
            context.lineWidth = lineWidth;
            context.strokeStyle = strokeStyle;
            context.fillStyle = strokeStyle;
            context.shadowColor = strokeStyle;
            context.shadowBlur = frameShadowBlurOff;
            context.shadowOffsetX = frameShadowOffsetOff;

            if (showDash) {
                context.setLineDash(dashList);
            } else {
                context.setLineDash([]);
            }

            context.rect(0, 0, width, height);
            context.stroke();
        }

        // calc tile size factor based on available canvas with
        static sizeFactor(): number {
            return 1;
        }

        // clear canvas
        static clearCanvas(): void {
            // get client elements
            var canvas: HTMLCanvasElement = (document.getElementById(canvasName) as HTMLCanvasElement);
            var context: CanvasRenderingContext2D = canvas.getContext("2d");

            context.beginPath();
            context.fillStyle = canvasBackgroundColor;
            context.fillRect(0, 0, canvas.width, canvas.height);
            context.stroke();
        }

        // check if coordinates are inside tile boundaries
        static hitTestCanvas(
            clientX: number,
            clientY: number
        ): boolean {

            // get client elements
            var canvas: HTMLCanvasElement = (document.getElementById(canvasName) as HTMLCanvasElement);

            if (clientX < canvas.clientLeft || clientX > canvas.clientLeft + canvas.clientWidth / clientWidthHalfDivider) {
                return false;
            }

            if (clientY < canvas.clientTop || clientY > canvas.clientTop + canvas.clientHeight / clientWidthHalfDivider) {
                return false;
            }

            return true;
        }
    }

    // represents everything needed inside one tile
    class Tile {
        value: string = "";

        constructor(
            protected dashboardItemRcd: string,
            public imageElement: string,
            public name: string,
            public left: number,
            public top: number,
            public offset: number,
            public sizeFactor: number,
            public stateMax: boolean,
            public url: string,
            public iconSizeMax?: boolean,
            public iconMaximize: boolean = true 
        ) {
        }

        width(): number { return tileWidth; }

        height(): number { return tileHeight; }

        infoLineOne(): string {
            if (this.iconSizeMax) {
                return this.name;
            } else if (this.value !== "0") {
                return this.value + " " + this.name;
            } else {
                return this.name;
            }
        }

        // tile coordinates
        relativeTileLeft(): number {
            return this.left + (this.offset * this.sizeFactor);
        }

        relativeTileTop(): number {
            return this.top * this.sizeFactor;
        }

        relativeTileWidth(): number {
            return this.width() * this.sizeFactor;
        }

        relativeTileHeight(): number {
            return this.height() * this.sizeFactor;
        }

        relativeTileBorder(): number {
            return 15 * this.sizeFactor;
        }

        // min/max icon coordinates
        relativeMinMaxLeft(): number {
            return this.left +
                (this.offset * this.sizeFactor) +
                (this.width() * this.sizeFactor) -
                (this.relativeTileBorder() * 2 * this.sizeFactor);
        }

        relativeMinMaxTop(): number {
            return this.top * this.sizeFactor + (this.relativeTileBorder() * this.sizeFactor);
        }

        relativeMinMaxWidth(): number {
            return this.relativeTileBorder() * this.sizeFactor;
        }

        relativeMinMaxHeight(): number {
            return this.relativeTileBorder() * this.sizeFactor;
        }

        // icon coordinates
        relativeIconLeft(): number {
            if (this.iconSizeMax) {
                return this.relativeTileLeft() + (10 * this.sizeFactor);
            } else {
                return this.relativeTileLeft() + (13 * this.sizeFactor);
            }
        }

        relativeIconTop(): number {
            if (this.iconSizeMax) {
                return this.relativeTileTop() + (15 * this.sizeFactor);
            } else {
                return this.relativeTileTop() + (1 * this.sizeFactor);
            }
        }

        relativeIconWidth(): number {
            if (this.iconSizeMax) {
                return this.relativeTileWidth() - this.relativeTileBorder() * 2;
            } else {
                return 50 * this.sizeFactor;
            }
        }

        relativeIconHeight(): number {
            if (this.iconSizeMax) {
                return this.relativeTileHeight() - this.relativeTileBorder() * 2;
            } else {
                return 50 * this.sizeFactor;
            }
        }

        // font
        relativeFontLargest(): string {
            return (24 * this.sizeFactor) + fontSuffix;
        }

        relativeFontLarge(): string {
            return (16 * this.sizeFactor) + fontSuffix;
        }

        relativeFontMedium(): string {
            return (8 * this.sizeFactor) + fontSuffix;
        }

        relativeFontSmall(): string {
            return (6 * this.sizeFactor) + fontSuffix;
        }

        // text
        relativeTextTop(row: number): number {
            return this.relativeTileTop() + this.relativeTextTopBorder(row);
        }

        relativeTextLeft(): number {
            return this.relativeTileLeft() + (relativeTextBorder * this.sizeFactor);
        }

        relativeTextTopBorder(row: number): number {
            return row * relativeTextHeight * this.sizeFactor;
        }

        relativeTileMargin(): number {
            return relativeTileMarginConstant * this.sizeFactor;
        }

        scaleBottom(): number {
            return this.relativeTileTop() +
                (this.relativeTileBorder() * this.sizeFactor) +
                this.relativeTileHeight() -
                this.relativeTileMargin();
        }

        tileFrame(
            context: CanvasRenderingContext2D
        ): void {

            context.lineWidth = tileLineWidth;
            context.strokeStyle = tileBackgroundColor;
            context.fillStyle = tileBackgroundColor;
            context.shadowColor = frameShadowColor;
            context.shadowBlur = frameShadowBlur;
            context.shadowOffsetX = infoShadowOffsetXFactor; // this.sizeFactor * infoShadowOffsetXFactor;
            context.beginPath();
            context.fillRect(
                this.relativeTileLeft(),
                this.relativeTileTop(),
                this.relativeTileWidth(),
                this.relativeTileHeight()
            );
        }

        tileFrameNoShadow(
            context: CanvasRenderingContext2D
        ): any {

            context.lineWidth = tileLineWidth;
            context.strokeStyle = tileBackgroundColor;
            context.fillStyle = tileBackgroundColor;
            context.shadowColor = tileBackgroundColor;
            context.shadowBlur = frameShadowBlurOff;
            context.shadowOffsetX = frameShadowOffsetOff;
            context.beginPath();
            context.fillRect(
                this.relativeTileLeft(),
                this.relativeTileTop(),
                this.relativeTileWidth(),
                this.relativeTileHeight()
            );
        }

        // draws the tile
        draw(
            context: CanvasRenderingContext2D,
            factor: number
        ): any {

            this.sizeFactor = factor;

            // fixed stuff
            this.tileFrame(context);

            // icon
            if (this.imageElement.length !== 0) {
                var image: HTMLImageElement = document.getElementById(this.imageElement) as HTMLImageElement;
                if (image !== null) {
                    context.drawImage(
                        image,
                        this.relativeIconLeft(),
                        this.relativeIconTop(),
                        this.relativeIconWidth(),
                        this.relativeIconHeight()
                    );
                }
            }

            // header
            context.strokeStyle = tileTextColor;
            context.fillStyle = tileTextColor;
            context.shadowBlur = this.iconSizeMax ? 2 : 0;
            context.shadowOffsetX = this.sizeFactor;
            context.font = this.relativeFontLarge();

            context.fillText(
                this.infoLineOne(),
                this.relativeTextLeft(),
                this.relativeTextTop(this.iconSizeMax ? 2 : 9)
            );
        }

        headerColumns(
            context: CanvasRenderingContext2D,
            left: number,
            rowPosition: number
        ): any {
            // context.fillText("User Code", left + (20 * this.sizeFactor), rowPosition);
        }

        columns(
            context: CanvasRenderingContext2D,
            row: number,
            left: number,
            rowPosition: number
        ): any {
            // context.fillText(users[row].DefaultUserCode, left + (20 * this.sizeFactor), rowPosition);
        }

        maxRows(): number {
            return 0;
        }

        // check if coordinates are inside tile boundaries
        hitTest(
            clientX: number,
            clientY: number
        ): boolean {

            if (clientX < this.relativeTileLeft() || clientX > this.relativeTileLeft() + this.relativeTileWidth()) {
                return false;
            }

            if (clientY < this.relativeTileTop() || clientY > this.relativeTileTop() + this.relativeTileHeight()) {
                return false;
            }

            return true;
        }

        // do help
        help(
            context: CanvasRenderingContext2D
        ): any {
            ;
        }

        // do auto
        auto(
            context: CanvasRenderingContext2D
        ): any {
            ;
        }

        // check if coordinates are inside tile's maximize icon boundaries
        hitTestMaximize(
            clientX: number,
            clientY: number
        ): boolean {

            // no hit if no maximize button :-)
            if (!this.iconMaximize) {
                return false;
            }

            // check tile boundaries
            var clickArea: number = 10;

            if (clientX < this.relativeMinMaxLeft() - clickArea ||
                clientX > this.relativeMinMaxLeft() + this.relativeMinMaxWidth() + clickArea) {
                return false;
            }

            if (clientY < this.relativeMinMaxTop() - clickArea ||
                clientY > this.relativeMinMaxTop() + this.relativeMinMaxHeight() + clickArea) {
                return false;
            }

            return true;
        }

        // draw frame
        frame(
            strokeStyle: any,
            lineWidth: number,
            showDash: boolean
        ): void {

            var canvas: HTMLCanvasElement = (document.getElementById(canvasName) as HTMLCanvasElement);
            var context: CanvasRenderingContext2D = canvas.getContext("2d");

            var dashList: number[] = [frameDashListCount]; // create a dot/dash sequence
            context.beginPath();
            context.lineWidth = lineWidth;
            context.strokeStyle = strokeStyle;
            context.fillStyle = strokeStyle;
            context.shadowColor = strokeStyle;
            context.shadowBlur = frameShadowBlurOff;
            context.shadowOffsetX = frameShadowOffsetOff;

            if (showDash) {
                context.setLineDash(dashList);
            } else {
                context.setLineDash([]);
            }

            context.rect(
                this.left + (this.offset * this.sizeFactor) + 5,
                this.top * this.sizeFactor + 5,
                this.width() * this.sizeFactor - 10,
                this.height() * this.sizeFactor - 10
            );

            context.stroke();
        }

        // draw frame
        clear(
            strokeStyle: any
        ): void {

            var canvas: HTMLCanvasElement = (document.getElementById(canvasName) as HTMLCanvasElement);
            var context: CanvasRenderingContext2D = canvas.getContext("2d");

            context.beginPath();
            context.lineWidth = 1;
            context.strokeStyle = strokeStyle;
            context.fillStyle = strokeStyle;
            context.shadowColor = strokeStyle;
            context.shadowBlur = frameShadowBlurOff;
            context.shadowOffsetX = frameShadowOffsetOff;
            context.setLineDash([]);

            context.fillRect(
                this.left + (this.offset * this.sizeFactor) - 5,
                this.top * this.sizeFactor - 5,
                this.width() * this.sizeFactor + 5,
                this.height() * this.sizeFactor + 5
            );

            context.stroke();
        }
    }

    // canvas for dashboard
    export class Dashboard {
        private timerToken: number;
        static tiles: Array<Tile>;
        static stateMax: boolean;
        static stateMaxTile: Tile;

        constructor(
        ) {
            Dashboard.stateMax = false;

            // init tiles
            Dashboard.tiles = new Array<Tile>();
        }

        // resize canvas based on window size
        resizeCanvas(): void {
            // get client elements
            let canvas: HTMLCanvasElement = (document.getElementById(canvasName) as HTMLCanvasElement);

            if (tileWidthScaleRecalc) {
                canvas.width = window.innerWidth * tileWidthScale;
                canvas.height = window.innerHeight + (tileBorder * (tileCountHeight + 3));
            } else {
                let sizeFactor: number = canvas.width / (maxLeft + tileWidth + tileBorder);
                canvas.width = window.innerWidth / tileCountWidth;
                canvas.height = (((tileHeight + tileBorder) * tileCountHeight) + tileBorder * tileCountHeight) * sizeFactor;
            }
        }

        frame(
            strokeStyle: any,
            lineWidth: number,
            showDash: boolean,
            width: number,
            height: number
        ): any {

            var canvas: HTMLCanvasElement = (document.getElementById(canvasName) as HTMLCanvasElement);
            var context: CanvasRenderingContext2D = canvas.getContext("2d");

            var dashList: number[] = [frameDashListCount]; // create a dot/dash sequence
            context.beginPath();
            context.lineWidth = lineWidth;
            context.strokeStyle = strokeStyle;
            context.fillStyle = strokeStyle;
            context.shadowColor = strokeStyle;
            context.shadowBlur = frameShadowBlurOff;
            context.shadowOffsetX = frameShadowOffsetOff;

            if (showDash) {
                context.setLineDash(dashList);
            } else {
                context.setLineDash([]);
            }

            context.rect(0, 0, width, height);
            context.stroke();
        }

        // clear canvas
        clearCanvas(): void {
            // get client elements
            var canvas: HTMLCanvasElement = (document.getElementById(canvasName) as HTMLCanvasElement);
            var context: CanvasRenderingContext2D = canvas.getContext("2d");

            context.beginPath();
            context.fillStyle = canvasBackgroundColor;
            context.fillRect(0, 0, canvas.width, canvas.height);
            context.stroke();
        }

        start(): void {
            // get client elements
            let canvas: HTMLCanvasElement = (document.getElementById(canvasName) as HTMLCanvasElement);
            let sizeFactor: number = canvas.width / (maxLeft + tileWidth + tileBorder);

            // resize canvas
            this.resizeCanvas();
            this.clearCanvas();

            // add tiles
            try {
                Dashboard.tiles.push(
                    new Tile("USER", "address-book", "Catalog", 6, 40, 0, sizeFactor, false, "../Dashboard/TemplateChapterIndex",   // http
                        true, false));
                Dashboard.tiles.push(
                    new Tile("USER", "Klubok", "Product", 6, 40, 220, sizeFactor, false, "../ProductSearchByCategoryCodeLive/ProductSearchByCategoryCodeIndex?productCategoryCode=010903&onParent=true",    // http
                        true, false));

                Dashboard.tiles.push(
                    new Tile("USER", "box", "Cart", 6, 260, 0, sizeFactor, false, "http://localhost:5000/api/1/cartproductsearchservice/getcartproducttypescript",
                        true, false));
                Dashboard.tiles.push(
                    new Tile("USER", "apps", "Apps", 6, 260, 220, sizeFactor, false, "../install/publish.htm",  // http
                        true, false));

                Dashboard.tiles.push(
                    new Tile("USER", "Text-edit", "About", 6, 480, 0, sizeFactor, false, "../home/about",   // http
                        true, false));
                Dashboard.tiles.push(
                    new Tile("USER", "api", "API", 6, 480, 220, sizeFactor, false, "../home/API",   // http
                        true, false));
            } catch (Error) {
                alert(Error.message);
            }

            // handle clicks
            canvas.addEventListener("click", this.canvasClick, false);

            // event resize, orientation change
            let thisThat: Dashboard = this;
            var resize: any = function (): void {
                // resize canvas
                thisThat.resizeCanvas();

                // draw tiles
                thisThat.drawNormal();
            };

            // force redraw after all images are loaded
            window.onload = resize;

            window.onresize = resize;

            // check mouse pointer style
            document.onmousemove = function (e: any): void {

                let canvas: HTMLCanvasElement = (document.getElementById(canvasName) as HTMLCanvasElement);

                // default style
                canvas.style.cursor = "auto";

                if (Dashboard.tiles) {
                    for (let tile of Dashboard.tiles) {
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
        }

        // draw tiles in normal size
        drawNormal(): void {

            // get client elements
            var canvas: HTMLCanvasElement = (document.getElementById(canvasName) as HTMLCanvasElement);
            var context: CanvasRenderingContext2D = canvas.getContext("2d");

            let sizeFactorWidth: number = canvas.width / (maxLeft + tileWidth + tileBorder);
            let sizeFactorHeight: number = canvas.height / (maxTop + tileHeight + tileBorder);
            let newSizeFactor: number = sizeFactorWidth;

            // use height size factor if smaller
            if (sizeFactorHeight < newSizeFactor) newSizeFactor = sizeFactorHeight;

            // clear canvas
            context.beginPath();
            context.fillStyle = canvasBackgroundColor;
            context.fillRect(0, 0, canvas.width, canvas.height);
            context.stroke();

            // draw tiles
            for (let tile of Dashboard.tiles) {
                tile.draw(context, newSizeFactor);
            }
        }

        // maximize or normalize
        canvasClick(event: any): void {
            var canvas: HTMLCanvasElement = (document.getElementById(canvasName) as HTMLCanvasElement);
            var context: CanvasRenderingContext2D = canvas.getContext("2d");

            if (Dashboard.tiles) {
                for (let tile of Dashboard.tiles) {
                    // check whole tile area
                    if (tile.hitTest(event.offsetX, event.offsetY)) {
                        // indicate that the tile was clicked
                        tile.frame(tileTextColor, frameLineWidthClick, true);

                        // reset the color after a short delay
                        var resetTile: Tile = tile;
                        setTimeout(
                            function (): void {
                                resetTile.frame(tileBackgroundColor, frameLineWidthClear, false);
                            }, 1000);

                        // navigate to tile's main page
                        window.location.href = tile.url;
                    } else {
                        // remove if not hit
                        tile.frame(tileBackgroundColor, frameLineWidthClear, false);
                    }
                }
            }
        }

        stop(): void {
            clearTimeout(this.timerToken);
        }
    }
}

(() => {
    var dashboardFirst: DashboardFirst.Dashboard = new DashboardFirst.Dashboard();
    dashboardFirst.start();
})();
