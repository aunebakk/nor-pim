// SQL2X Generated code based on a SQL Server Schema
// SQL2X Version: 1.0
// http://sql2x.org/
// Generated Date: 8/12/2020 7:49:22 AM
// From Machine: DESKTOP-517I8BU
// Filename: TemplateCartProduct.json
// MethodName: sql2x.CrudeTypeScriptGenerator.DesignVestreVikenDurian
// Template Style: WithDurianByTypeScript
// Documentation:
//   Typescript for durians
module DesignVestreVikenDurian {
    "use strict";

    // durian table
    type GetCartProductType = {
        FirstName: string,
        MiddleName: string,
        LastName: string,
        ClientNationalityRcd: string,
        ClientGenderRcd: string,
        ClientTitleRcd: string,
        ClientTypeRcd: string,
        ClientId: string,
        ProductName: string,
        ProductStateRcd: string,
        ProductId: string,
        FinancialCurrencyTypeRcd: string,
        FinancialCurrencyAgainstFinancialCurrencyTypeRcd: string,
        FinancialCurrencyTypeCode: string,
        FinancialCurrencyTypeName: string,
        FinancialCurrencyId: string,
        Amount: string,
        CartProductStateRcd: string,
        ImageBlobFilename: string,
        UserId: string,
        DefaultUserName: string,
        DateTime: string,
        CartProductId: string,
        SessionIdentificator: string
    };

    // from html page
    declare var cartProductList: GetCartProductType[];
    
    // client on load / entry point
    window.onload = () => {
        var contentElement: any = document.getElementById("content");
        var durianGrid: GetCartProductTileList = new GetCartProductTileList(contentElement);

        for (var i: number = 0; i < cartProductList.length; i++) {
        }
    
        durianGrid.start();
    };

    // main Durian class
    class GetCartProductTileList {
        // tiles
        static header: Tile;
        static tiles: Array<Tile>;
        static tileListHeight: number = 0;

        // maximized state
        static maximized: boolean = false;
        static maximizedTile: Tile;
        static maximizedScrollY: number = 0;

        // references
        static referenceCountLink: Link;

        constructor(
            element: HTMLElement
        ) {
            // init tiles
            GetCartProductTileList.tiles = new Array<Tile>();

            // not maximized state
            GetCartProductTileList.maximized = false;
            GetCartProductTileList.maximizedTile = null;
            GetCartProductTileList.maximizedScrollY = 0;

            // references
            GetCartProductTileList.referenceCountLink = new Link();
        }

        // clear canvas
        static clearCanvas(
            fillStyle: string
        ): void {
            // get client elements
            let canvas: HTMLCanvasElement = (<HTMLCanvasElement>document.getElementById("myCanvas"));
            let context: CanvasRenderingContext2D = canvas.getContext("2d");

            context.beginPath();
            context.fillStyle = fillStyle;
            context.fillRect(0, 0, canvas.width, canvas.height);
            context.stroke();
        }

        start(): void {
            const scale: string = "scale(1.0)";
            document.body.style.zoom = "1.0";
            document.body.style.webkitTransform = scale;   // for Chrome, Opera, Safari
            document.body.style.transform = scale;         // general

            // resize canvas to hold all cartProductList
            GetCartProductTileList.resizeCanvas();
            GetCartProductTileList.clearCanvas("rgb(255, 255, 255)");  // overallColors.backGround

            // get client elements
            let canvas: HTMLCanvasElement = (<HTMLCanvasElement>document.getElementById("myCanvas"));

            // header tile
            let line: number = 0;
            GetCartProductTileList.header = 
                new Tile(
                    "Cart Product",    // name
                    2,                 // tileLeft
                    line,              // tileTop
                    "",                // suffix of url
                    cartProductList.length, // tileCount
                    48,                // tileHeight
                    15,                // tileBorder
                    2,                 // textReposLeft
                    5,                 // tileSpaceVertical
                    16,                // tileFontSize
                    "rgb(24, 101, 29)", // overallColors.foreGround
                    null,              // entity null triggers header columns
                    null               // entity widths
                );

            GetCartProductTileList.tiles.push(GetCartProductTileList.header);

            // calc column widths 
            let context: CanvasRenderingContext2D = canvas.getContext("2d");
            context.font = "bold 16px Arial";   // tileFontSize
            let cartProductListWidths: number[] = new Array(24);
            cartProductListWidths[0] = context.measureText("First Name").width;
            cartProductListWidths[1] = context.measureText("Middle Name").width;
            cartProductListWidths[2] = context.measureText("Last Name").width;
            cartProductListWidths[3] = context.measureText("Product Name").width;
            cartProductListWidths[4] = context.measureText("Financial Currency Type Code").width;
            cartProductListWidths[5] = context.measureText("Financial Currency Type Name").width;
            cartProductListWidths[6] = context.measureText("Image Blob Filename").width;
            cartProductListWidths[7] = context.measureText("Default User Name").width;
            cartProductListWidths[8] = context.measureText("Date Time").width;
            cartProductListWidths[9] = context.measureText("Session Identificator").width;
            cartProductListWidths[10] = 0;

            for (let i: number = 0; i < cartProductList.length; i++) {

              // First Name
              if ((context.measureText(cartProductList[i].FirstName).width > cartProductListWidths[0])
                  &&  (context.measureText(cartProductList[i].FirstName).width < window.innerWidth * 0.9))
                    cartProductListWidths[0] = context.measureText(cartProductList[i].FirstName).width;

              // Middle Name
              if ((context.measureText(cartProductList[i].MiddleName).width > cartProductListWidths[1])
                  &&  (context.measureText(cartProductList[i].MiddleName).width < window.innerWidth * 0.9))
                    cartProductListWidths[1] = context.measureText(cartProductList[i].MiddleName).width;

              // Last Name
              if ((context.measureText(cartProductList[i].LastName).width > cartProductListWidths[2])
                  &&  (context.measureText(cartProductList[i].LastName).width < window.innerWidth * 0.9))
                    cartProductListWidths[2] = context.measureText(cartProductList[i].LastName).width;

              // Product Name
              if ((context.measureText(cartProductList[i].ProductName).width > cartProductListWidths[3])
                  &&  (context.measureText(cartProductList[i].ProductName).width < window.innerWidth * 0.9))
                    cartProductListWidths[3] = context.measureText(cartProductList[i].ProductName).width;

              // Financial Currency Type Code
              if ((context.measureText(cartProductList[i].FinancialCurrencyTypeCode).width > cartProductListWidths[4])
                  &&  (context.measureText(cartProductList[i].FinancialCurrencyTypeCode).width < window.innerWidth * 0.9))
                    cartProductListWidths[4] = context.measureText(cartProductList[i].FinancialCurrencyTypeCode).width;

              // Financial Currency Type Name
              if ((context.measureText(cartProductList[i].FinancialCurrencyTypeName).width > cartProductListWidths[5])
                  &&  (context.measureText(cartProductList[i].FinancialCurrencyTypeName).width < window.innerWidth * 0.9))
                    cartProductListWidths[5] = context.measureText(cartProductList[i].FinancialCurrencyTypeName).width;

              // Image Blob Filename
              if ((context.measureText(cartProductList[i].ImageBlobFilename).width > cartProductListWidths[6])
                  &&  (context.measureText(cartProductList[i].ImageBlobFilename).width < window.innerWidth * 0.9))
                    cartProductListWidths[6] = context.measureText(cartProductList[i].ImageBlobFilename).width;

              // Default User Name
              if ((context.measureText(cartProductList[i].DefaultUserName).width > cartProductListWidths[7])
                  &&  (context.measureText(cartProductList[i].DefaultUserName).width < window.innerWidth * 0.9))
                    cartProductListWidths[7] = context.measureText(cartProductList[i].DefaultUserName).width;

              // Date Time
              if ((context.measureText(cartProductList[i].DateTime).width > cartProductListWidths[8])
                  &&  (context.measureText(cartProductList[i].DateTime).width < window.innerWidth * 0.9))
                    cartProductListWidths[8] = context.measureText(cartProductList[i].DateTime).width;

              // Session Identificator
              if ((context.measureText(cartProductList[i].SessionIdentificator).width > cartProductListWidths[9])
                  &&  (context.measureText(cartProductList[i].SessionIdentificator).width < window.innerWidth * 0.9))
                    cartProductListWidths[9] = context.measureText(cartProductList[i].SessionIdentificator).width;
            }

            // grid rows for GetCartProduct
            let lastTile: Tile;

            // header columns
            lastTile =
                new Tile(
                    "",                  // name
                    40,                  // tileLeft
                    line,                // tileTop
                    "",                  // suffix of url
                    cartProductList.length, // tileCount
                    45,                  // tileHeight
                    15,                  // tileBorder
                    2,                   // textReposLeft
                    7,                   // tileSpaceVertical
                    14,                  // tileFontSize
                    "rgb(24, 101, 29)",  // overallColors.foreGround
                    null,                // entity null triggers header columns
                    cartProductListWidths   // entity widths
                );

            GetCartProductTileList.tiles.push(lastTile);

            for (let i: number = 0; i < cartProductList.length; i++) {
                line++;

                // alternate color
                let newColor:string = "rgb(24, 101, 29)"; // overallColors.foreGround
                if (i % 2 === 0) {
                    newColor = "rgb(4, 115, 8)";  // overallColors.foreGroundAlternate
                }

                lastTile =
                    new Tile(
                        "",       // name
                        40,       // tileLeft
                        line,     // tileTop
                        cartProductList[i].CartProductId,       // most significant key from durian
                        cartProductList.length,           // tileCount
                        45,       // tileHeight
                        15,       // tileBorder
                        2,        // textReposLeft
                        7,        // tileSpaceVertical
                        14,       // tileFontSize
                        newColor, // fillStyle
                        cartProductList[i],     // entity
                        cartProductListWidths   // entity widths
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
            canvas.addEventListener(
                    "click", 
                    this.canvasClick, 
                    false
                );

            // handle resize event
            window.addEventListener(
                    "resize",
                    function (): void {
                            // resize canvas
                            GetCartProductTileList.resizeCanvas();

                            // draw GetCartProduct index according to visual state
                            if (GetCartProductTileList.maximized
                                && GetCartProductTileList.maximizedTile != null) {

                                // draw maximized
                                GetCartProductTileList.maximizedTile.drawMaximized();
                                let context: CanvasRenderingContext2D = canvas.getContext("2d");
                                GetCartProductTileList.header.draw(context);
                            } else {

                                // draw normal
                                GetCartProductTileList.drawNormal();
                            }
                        },
                    false
                );

            // check mouse pointer style for tiles
            canvas.onmousemove = function (e: any): void {
                canvas.style.cursor = "auto";   // default style

                if (GetCartProductTileList.tiles) {
                    for (let tile of GetCartProductTileList.tiles) {
                        if (tile.hitTest(e.offsetX, e.offsetY)) {
                            canvas.style.cursor = "pointer";
                            break;
                        }
                    }
                }
            };

        }

        // state
        static getValue(
            parameters: string,
            getParameter: string
        ):string {
            let numberPart: string = "";

            if (parameters == null)
                return "";

            if (parameters.indexOf(getParameter) != -1) {
                numberPart =
                    parameters.substr(
                    parameters.indexOf(getParameter)
                    + getParameter.length
                    );

                if (numberPart.indexOf("}") != -1)
                    numberPart = numberPart.substr(0, numberPart.indexOf("}"));
            }

            return numberPart;
        }

        static checkState(state: string) {
            if (state == null)
                state = "";

            // get scroll position
            var numberPartScrollY: string = GetCartProductTileList.getValue(state, "scrollY={");

            // if not maximized, or failed to find entity ...
            GetCartProductTileList.maximizedTile = null;
            if (state.indexOf("#viewState=maximized") != -1) {
                for (let i: number = 0; i < GetCartProductTileList.tiles.length; i++) {
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
            history.replaceState(
                state,
                "test"
            );
        }

        // check if we are living in a mobile phone
        static isMobile(): boolean {
            let isMobileForSure: boolean = false;

            // detectmobilebrowsers.com
            (function(a: any): void {
                if (
                    /(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|mobile.+firefox|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows ce|xda|xiino/i.test(a) || /1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-/i.test(a.substr(0, 4))) { isMobileForSure = true; }
            })(navigator.userAgent || navigator.vendor);

            return isMobileForSure;
        }

        // resize canvas based on window size
        static resizeCanvas(): void {            
            // canvas for tiles set to window width for mobile, 80% for web
            let canvas: HTMLCanvasElement = (<HTMLCanvasElement>document.getElementById("myCanvas"));
            if (!this.isMobile()) {
                canvas.width = window.innerWidth * 0.8;
            } else {
                canvas.width = window.innerWidth;
            }
        }

        // check click event
        canvasClick(
            event: any
        ): void {
            if (GetCartProductTileList.maximized) {
                let canvas: HTMLCanvasElement = (<HTMLCanvasElement>document.getElementById("myCanvas"));
                let context: CanvasRenderingContext2D = canvas.getContext("2d");

                GetCartProductTileList.drawNormal();
                GetCartProductTileList.maximized = false;
                GetCartProductTileList.maximizedTile = null;
                window.scrollTo(0, GetCartProductTileList.maximizedScrollY);

                // remember view state grid
                history.replaceState(
                    "viewState=grid",
                    "test"
                );

            } else {
                if (GetCartProductTileList.tiles) {
                    let canvas: HTMLCanvasElement = (<HTMLCanvasElement>document.getElementById("myCanvas"));
                    let context: CanvasRenderingContext2D = canvas.getContext("2d");

                    for (let tile of GetCartProductTileList.tiles) {
                        // check whole tile area
                        if (tile.hitTest(event.offsetX, event.offsetY)) {
                            if (tile.name == "") { // check for not header
                                
                                // action links
                                if (event.offsetX > tile.unOrderLink.linkLeft) {

                                    // indicate that the tile link was clicked
                                    tile.unOrderLink.frame(context, tile.lineWidth, true);

                                    // go to url
                                    window.location.href = tile.unOrderLink.linkUrl + tile.url;

                                } else if (tile.getCartProduct != null) {  
                                    // indicate that the tile link was clicked
                                    tile.frame(context, tile.backgroundColor, 2, true);
                                    
                                    // remember current scroll 
                                    GetCartProductTileList.maximizedScrollY = window.scrollY;
                                    
                                    // show all details
                                    tile.drawMaximized();
                                    
                                    // remember view state as maximized, primary key and scroll position 
                                    history.replaceState( 
                                        "viewState=maximized",
                                        "test"
                                        );
                                }
                            }
                        }
                    }
                }
            }
        }

        // draw tiles in normal size
        static drawNormal(): void {
            // get client elements
            let canvas: HTMLCanvasElement = (<HTMLCanvasElement>document.getElementById("myCanvas"));
            let context: CanvasRenderingContext2D = canvas.getContext("2d");

            // set vertical size
            if (GetCartProductTileList.tileListHeight != 0) {
                canvas.height = GetCartProductTileList.tileListHeight;
            }

            // clear canvas
            GetCartProductTileList.clearCanvas("rgb(255, 255, 255)");  // overallColors.backGround

            // draw tiles
            for ( let tile of GetCartProductTileList.tiles) {
                tile.draw(context);
            }
        }
    }

    class Link {
        linkWidth: number;
        linkBorder: number;
        linkLeft: number;
        linkTop: number;
        linkHeight: number;
        linkUrl: string;

        measure(
            boxLeft: number,
            boxTop: number,
            boxWidth: number,
            boxHeight: number,
            position: number
        ): void {
            // calculate link size
            this.linkBorder = boxHeight * 0.1;
            this.linkWidth = (boxWidth * 0.1) - this.linkBorder; // (boxWidth * 0.15);
            this.linkHeight = boxHeight - (this.linkBorder * 2);
            this.linkLeft = boxLeft +
                boxWidth -
                ((this.linkBorder + this.linkWidth + this.linkBorder) * position) -
                this.linkBorder;
            this.linkTop = boxTop + this.linkBorder;
        }

        // draw link rectangles
        draw(
            context: CanvasRenderingContext2D,
            font: string,
            text: string,
            top: number
        ): void {
            context.beginPath();
            context.lineWidth = 2;
            context.strokeStyle = "rgb(255, 255, 255)"; // overallColors.text
            context.fillStyle = "rgb(0, 128, 0)"; // overallColors.link
            context.shadowColor = "rgb(128, 128, 128)"; // overallColors.shadow
            context.shadowBlur = 0;
            context.shadowOffsetX = 0;
            context.shadowOffsetY = 0;

            context.fillRect(
                this.linkLeft,
                this.linkTop,
                this.linkWidth,
                this.linkHeight
            );
            context.fillStyle = "rgb(255, 255, 255)"; // overallColors.linkText
            context.font = font;

            // cap text of last column until it fits inside the tile
            while (
                context.measureText(text).width > this.linkWidth
                && text.length > 2
            ) {
                text = text.substr(0, text.length - 1);
            }

            context.fillText(
                text,
                this.linkLeft + (this.linkWidth / 2) - (context.measureText(text).width / 2),
                top
            );
        }

        // draw frame
        frame(
            context: CanvasRenderingContext2D,
            lineWidth: number,
            showDash: boolean
        ): void {
            const dashList: number[] = [5]; // create a dot/dash sequence
            context.beginPath();
            context.lineWidth = lineWidth;
            context.strokeStyle = showDash ? "rgb(255, 255, 255)" : "rgb(128, 128, 128)";   // overallColors.backGround / overallColors.shadow
            context.fillStyle = showDash ? "rgb(255, 255, 255)" : "rgb(128, 128, 128))";    // overallColors.backGround / overallColors.shadow
            context.shadowColor = showDash ? "rgb(255, 255, 255)" : "rgb(128, 128, 128))";  // overallColors.backGround / overallColors.shadow
            context.shadowBlur = 0;
            context.shadowOffsetX = 0;
            context.shadowOffsetY = 0;

            if (showDash) {
                context.setLineDash(dashList);
            } else {
                context.setLineDash([]);
            }

            context.rect(
                this.linkLeft,
                this.linkTop,
                this.linkWidth,
                this.linkHeight
            );

            context.stroke();
        }
    }

    // represents everything needed inside one tile
    class Tile {
        backgroundColor = "rgb(255, 255, 255)";  // overallColors.backGround
        textColor = "rgb(255, 255, 255)";  // overallColors.linkText
        lineWidth = 1;
        textLeft = 0;

        // action links
        unOrderLink: Link;

        constructor(
            public name: string,
            public tileLeft: number,
            public tileTop: number,
            public url: string,
            public tileCount: number,
            public tileHeight: number,
            public tileBorder: number,
            public textReposLeft: number,
            public tileSpaceVertical: number,
            public tileFontSize: number,
            public fillStyle: string,
            public getCartProduct: GetCartProductType,
            public cartProductListWidths: number[]
        ) {

            // action links
            this.unOrderLink = new Link();

            // alignments
            this.tileTop = tileSpaceVertical + ((this.tileHeight + tileSpaceVertical) * this.tileTop);
            this.textLeft = this.tileLeft + this.textReposLeft + (this.tileBorder * 1.5);
        }

        // calculate width of tile
        tileWidth(): number {
            let canvas: HTMLCanvasElement = (<HTMLCanvasElement>document.getElementById("myCanvas"));
            return canvas.width - this.tileLeft - this.tileBorder - this.tileBorder;
        }

        // calculate top position of text
        textTop(text: string): number {
            return this.tileTop + (this.tileHeight / 2) + (this.tileFontSize / 2);
        }

        // draws the tile
        draw(
            context: CanvasRenderingContext2D
        ): void {
            // fixed elements
            this.tileFrame(context);

            // save box measurements
            const boxLeft: number = this.tileLeft;
            const boxTop: number = this.tileTop;
            const boxWidth: number = this.tileWidth();
            const boxHeight: number = this.tileHeight;

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

            context.fillRect(
                boxLeft,
                boxTop,
                boxWidth,
                boxHeight
            );
            context.stroke();

            // action links
            let lastActionLinkLeft:number = boxWidth - boxLeft;

            if (this.getCartProduct != null) {  

                // Un Order
                this.unOrderLink.measure(boxLeft, boxTop, boxWidth, boxHeight, 1);
                this.unOrderLink.linkUrl = "../Product/UnOrder?cartProductId=";
                this.unOrderLink.draw(context, this.tileFontSize + "px Arial", "U", this.textTop(this.name));
                lastActionLinkLeft = this.unOrderLink.linkLeft;
                context.stroke();
            }

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
            let leftPos: number = this.textLeft;

            // no widths means this is the header, exit
            if (this.cartProductListWidths == null) {
                context.stroke();
                return;
            }

            // First Name
            if (leftPos < lastActionLinkLeft - this.cartProductListWidths[0]) {

                // cap text of last column until it fits inside the tile
                let text: string = this.getCartProduct == null ? "First Name" : this.getCartProduct.FirstName;
                while (
                    context.measureText(text).width > this.cartProductListWidths[0]
                    && text.length > 2
                ) {
                    text = text.substr(0, text.length - 1);
                }

                context.fillText(
                    text,
                    leftPos,
                    this.textTop(name)
                );
            }
            leftPos += this.cartProductListWidths[0];

            // Middle Name
            if (leftPos < lastActionLinkLeft - this.cartProductListWidths[1]) {

                // cap text of last column until it fits inside the tile
                let text: string = this.getCartProduct == null ? "Middle Name" : this.getCartProduct.MiddleName;
                while (
                    context.measureText(text).width > this.cartProductListWidths[1]
                    && text.length > 2
                ) {
                    text = text.substr(0, text.length - 1);
                }

                context.fillText(
                    text,
                    leftPos,
                    this.textTop(name)
                );
            }
            leftPos += this.cartProductListWidths[1];

            // Last Name
            if (leftPos < lastActionLinkLeft - this.cartProductListWidths[2]) {

                // cap text of last column until it fits inside the tile
                let text: string = this.getCartProduct == null ? "Last Name" : this.getCartProduct.LastName;
                while (
                    context.measureText(text).width > this.cartProductListWidths[2]
                    && text.length > 2
                ) {
                    text = text.substr(0, text.length - 1);
                }

                context.fillText(
                    text,
                    leftPos,
                    this.textTop(name)
                );
            }
            leftPos += this.cartProductListWidths[2];

            // Product Name
            if (leftPos < lastActionLinkLeft - this.cartProductListWidths[3]) {

                // cap text of last column until it fits inside the tile
                let text: string = this.getCartProduct == null ? "Product Name" : this.getCartProduct.ProductName;
                while (
                    context.measureText(text).width > this.cartProductListWidths[3]
                    && text.length > 2
                ) {
                    text = text.substr(0, text.length - 1);
                }

                context.fillText(
                    text,
                    leftPos,
                    this.textTop(name)
                );
            }
            leftPos += this.cartProductListWidths[3];

            // Financial Currency Type Code
            if (leftPos < lastActionLinkLeft - this.cartProductListWidths[4]) {

                // cap text of last column until it fits inside the tile
                let text: string = this.getCartProduct == null ? "Financial Currency Type Code" : this.getCartProduct.FinancialCurrencyTypeCode;
                while (
                    context.measureText(text).width > this.cartProductListWidths[4]
                    && text.length > 2
                ) {
                    text = text.substr(0, text.length - 1);
                }

                context.fillText(
                    text,
                    leftPos,
                    this.textTop(name)
                );
            }
            leftPos += this.cartProductListWidths[4];

            // Financial Currency Type Name
            if (leftPos < lastActionLinkLeft - this.cartProductListWidths[5]) {

                // cap text of last column until it fits inside the tile
                let text: string = this.getCartProduct == null ? "Financial Currency Type Name" : this.getCartProduct.FinancialCurrencyTypeName;
                while (
                    context.measureText(text).width > this.cartProductListWidths[5]
                    && text.length > 2
                ) {
                    text = text.substr(0, text.length - 1);
                }

                context.fillText(
                    text,
                    leftPos,
                    this.textTop(name)
                );
            }
            leftPos += this.cartProductListWidths[5];

            // Image Blob Filename
            if (leftPos < lastActionLinkLeft - this.cartProductListWidths[6]) {

                // cap text of last column until it fits inside the tile
                let text: string = this.getCartProduct == null ? "Image Blob Filename" : this.getCartProduct.ImageBlobFilename;
                while (
                    context.measureText(text).width > this.cartProductListWidths[6]
                    && text.length > 2
                ) {
                    text = text.substr(0, text.length - 1);
                }

                context.fillText(
                    text,
                    leftPos,
                    this.textTop(name)
                );
            }
            leftPos += this.cartProductListWidths[6];

            // Default User Name
            if (leftPos < lastActionLinkLeft - this.cartProductListWidths[7]) {

                // cap text of last column until it fits inside the tile
                let text: string = this.getCartProduct == null ? "Default User Name" : this.getCartProduct.DefaultUserName;
                while (
                    context.measureText(text).width > this.cartProductListWidths[7]
                    && text.length > 2
                ) {
                    text = text.substr(0, text.length - 1);
                }

                context.fillText(
                    text,
                    leftPos,
                    this.textTop(name)
                );
            }
            leftPos += this.cartProductListWidths[7];

            // Date Time
            if (leftPos < lastActionLinkLeft - this.cartProductListWidths[8]) {

                // cap text of last column until it fits inside the tile
                let text: string = this.getCartProduct == null ? "Date Time" : this.getCartProduct.DateTime;
                while (
                    context.measureText(text).width > this.cartProductListWidths[8]
                    && text.length > 2
                ) {
                    text = text.substr(0, text.length - 1);
                }

                context.fillText(
                    text,
                    leftPos,
                    this.textTop(name)
                );
            }
            leftPos += this.cartProductListWidths[8];

            // Session Identificator
            if (leftPos < lastActionLinkLeft - this.cartProductListWidths[9]) {

                // cap text of last column until it fits inside the tile
                let text: string = this.getCartProduct == null ? "Session Identificator" : this.getCartProduct.SessionIdentificator;
                while (
                    context.measureText(text).width > this.cartProductListWidths[9]
                    && text.length > 2
                ) {
                    text = text.substr(0, text.length - 1);
                }

                context.fillText(
                    text,
                    leftPos,
                    this.textTop(name)
                );
            }
            leftPos += this.cartProductListWidths[9];

            context.stroke();
        }


        // frame
        frame(
            context: CanvasRenderingContext2D,
            strokeStyle: any,
            lineWidth: number,
            showDash: boolean
        ): void {
            const dashList: number[] = [5]; // dot/dash sequence
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
            } else {
                context.setLineDash([]);
            }

            context.rect(
                this.tileLeft,
                this.tileTop,
                this.tileWidth(),
                this.tileHeight
            );

            context.stroke();
        }

        tileFrame(
            context: CanvasRenderingContext2D
        ): void {

            context.beginPath();
            context.lineWidth = this.lineWidth;
            context.strokeStyle = this.backgroundColor;
            context.fillStyle = this.backgroundColor;

            context.shadowColor = "rgb(128, 128, 128)"; // overallColors.shadow
            context.shadowBlur = 0;
            context.shadowOffsetX = 0;
            context.shadowOffsetY = 0;

            context.fillRect(
                this.tileLeft,
                this.tileTop,
                this.tileWidth(),
                this.tileHeight
            );
            context.stroke();
        }

        // check if coordinates are inside tile boundaries
        hitTest(
            clientX: number,
            clientY: number
        ): boolean {

            if (clientX < this.tileLeft || clientX > this.tileLeft + this.tileWidth()) {
                return false;
            }

            if (clientY < this.tileTop || clientY > this.tileTop + this.tileHeight) {
                return false;
            }

            return true;
        }

        // draw maximized
        drawMaximized(): void {
            // get client elements
            let canvas: HTMLCanvasElement = (<HTMLCanvasElement>document.getElementById("myCanvas"));
            let context: CanvasRenderingContext2D = canvas.getContext ( "2d" );

            GetCartProductTileList.maximized = true;
            GetCartProductTileList.maximizedTile = this;

            // draw header
            window.scrollTo(0, 0);
            GetCartProductTileList.resizeCanvas();
            GetCartProductTileList.header.draw(context);

            // resize canvas to fit all columns 
            canvas.height = 390 + 15;

            // clear background
            context.beginPath ();
            context.fillStyle = "rgb(24, 101, 29)"; // overallColors.foreGround
            context.fillRect(
                0,
                0,
                canvas.width - this.tileBorder,
                canvas.height
                );
            context.stroke ();

            // first line ( from main tile )
            context.beginPath ();
            context.font = this.tileFontSize * 1.2 + "px Arial";
            context.fillStyle = "rgb(255, 255, 255)"; // overallColors.text
            context.fillText (
                "Get Cart Product",
                10,
                window.scrollY + 30
            );

            // all displayable columns from table
            context.font = this.tileFontSize * 1.1 + "px Arial";

            // First Name ( column name first, then value )
            context.fillStyle = "rgb(211, 211, 211)"; // overallColors.textAlternate 

            let textFirstName:string = "First Name: ";
            while (
                context.measureText(textFirstName).width > this.tileWidth() - 40
                && textFirstName.length > 2
            ) {
                textFirstName = textFirstName.substr(0, textFirstName.length - 1);
            }
            
            context.fillText(
                textFirstName,
                20,
                window.scrollY + 66
            );

            // column value
            context.fillStyle = "rgb(240, 240, 0)"; // overallColors.textColumnValue 
            let textFirstNameValue:string = this.getCartProduct.FirstName.toString();
            while (
                context.measureText(textFirstName).width + context.measureText(textFirstNameValue).width > this.tileWidth() - 40
                && textFirstNameValue.length > 2
            ) {
                textFirstNameValue = textFirstNameValue.substr(0, textFirstNameValue.length - 1);
            }
            
            context.fillText(
                textFirstNameValue,
                context.measureText(textFirstName).width + 20,
                window.scrollY + 66
            );

            // Middle Name ( column name first, then value )
            context.fillStyle = "rgb(255, 255, 255)"; // overallColors.text 

            let textMiddleName:string = "Middle Name: ";
            while (
                context.measureText(textMiddleName).width > this.tileWidth() - 40
                && textMiddleName.length > 2
            ) {
                textMiddleName = textMiddleName.substr(0, textMiddleName.length - 1);
            }
            
            context.fillText(
                textMiddleName,
                20,
                window.scrollY + 96
            );

            // column value
            context.fillStyle = "rgb(240, 240, 0)"; // overallColors.textColumnValue 
            let textMiddleNameValue:string = this.getCartProduct.MiddleName.toString();
            while (
                context.measureText(textMiddleName).width + context.measureText(textMiddleNameValue).width > this.tileWidth() - 40
                && textMiddleNameValue.length > 2
            ) {
                textMiddleNameValue = textMiddleNameValue.substr(0, textMiddleNameValue.length - 1);
            }
            
            context.fillText(
                textMiddleNameValue,
                context.measureText(textMiddleName).width + 20,
                window.scrollY + 96
            );

            // Last Name ( column name first, then value )
            context.fillStyle = "rgb(211, 211, 211)"; // overallColors.textAlternate 

            let textLastName:string = "Last Name: ";
            while (
                context.measureText(textLastName).width > this.tileWidth() - 40
                && textLastName.length > 2
            ) {
                textLastName = textLastName.substr(0, textLastName.length - 1);
            }
            
            context.fillText(
                textLastName,
                20,
                window.scrollY + 126
            );

            // column value
            context.fillStyle = "rgb(240, 240, 0)"; // overallColors.textColumnValue 
            let textLastNameValue:string = this.getCartProduct.LastName.toString();
            while (
                context.measureText(textLastName).width + context.measureText(textLastNameValue).width > this.tileWidth() - 40
                && textLastNameValue.length > 2
            ) {
                textLastNameValue = textLastNameValue.substr(0, textLastNameValue.length - 1);
            }
            
            context.fillText(
                textLastNameValue,
                context.measureText(textLastName).width + 20,
                window.scrollY + 126
            );

            // Product Name ( column name first, then value )
            context.fillStyle = "rgb(255, 255, 255)"; // overallColors.text 

            let textProductName:string = "Product Name: ";
            while (
                context.measureText(textProductName).width > this.tileWidth() - 40
                && textProductName.length > 2
            ) {
                textProductName = textProductName.substr(0, textProductName.length - 1);
            }
            
            context.fillText(
                textProductName,
                20,
                window.scrollY + 156
            );

            // column value
            context.fillStyle = "rgb(240, 240, 0)"; // overallColors.textColumnValue 
            let textProductNameValue:string = this.getCartProduct.ProductName.toString();
            while (
                context.measureText(textProductName).width + context.measureText(textProductNameValue).width > this.tileWidth() - 40
                && textProductNameValue.length > 2
            ) {
                textProductNameValue = textProductNameValue.substr(0, textProductNameValue.length - 1);
            }
            
            context.fillText(
                textProductNameValue,
                context.measureText(textProductName).width + 20,
                window.scrollY + 156
            );

            // Financial Currency Type Code ( column name first, then value )
            context.fillStyle = "rgb(211, 211, 211)"; // overallColors.textAlternate 

            let textFinancialCurrencyTypeCode:string = "Financial Currency Type Code: ";
            while (
                context.measureText(textFinancialCurrencyTypeCode).width > this.tileWidth() - 40
                && textFinancialCurrencyTypeCode.length > 2
            ) {
                textFinancialCurrencyTypeCode = textFinancialCurrencyTypeCode.substr(0, textFinancialCurrencyTypeCode.length - 1);
            }
            
            context.fillText(
                textFinancialCurrencyTypeCode,
                20,
                window.scrollY + 186
            );

            // column value
            context.fillStyle = "rgb(240, 240, 0)"; // overallColors.textColumnValue 
            let textFinancialCurrencyTypeCodeValue:string = this.getCartProduct.FinancialCurrencyTypeCode.toString();
            while (
                context.measureText(textFinancialCurrencyTypeCode).width + context.measureText(textFinancialCurrencyTypeCodeValue).width > this.tileWidth() - 40
                && textFinancialCurrencyTypeCodeValue.length > 2
            ) {
                textFinancialCurrencyTypeCodeValue = textFinancialCurrencyTypeCodeValue.substr(0, textFinancialCurrencyTypeCodeValue.length - 1);
            }
            
            context.fillText(
                textFinancialCurrencyTypeCodeValue,
                context.measureText(textFinancialCurrencyTypeCode).width + 20,
                window.scrollY + 186
            );

            // Financial Currency Type Name ( column name first, then value )
            context.fillStyle = "rgb(255, 255, 255)"; // overallColors.text 

            let textFinancialCurrencyTypeName:string = "Financial Currency Type Name: ";
            while (
                context.measureText(textFinancialCurrencyTypeName).width > this.tileWidth() - 40
                && textFinancialCurrencyTypeName.length > 2
            ) {
                textFinancialCurrencyTypeName = textFinancialCurrencyTypeName.substr(0, textFinancialCurrencyTypeName.length - 1);
            }
            
            context.fillText(
                textFinancialCurrencyTypeName,
                20,
                window.scrollY + 216
            );

            // column value
            context.fillStyle = "rgb(240, 240, 0)"; // overallColors.textColumnValue 
            let textFinancialCurrencyTypeNameValue:string = this.getCartProduct.FinancialCurrencyTypeName.toString();
            while (
                context.measureText(textFinancialCurrencyTypeName).width + context.measureText(textFinancialCurrencyTypeNameValue).width > this.tileWidth() - 40
                && textFinancialCurrencyTypeNameValue.length > 2
            ) {
                textFinancialCurrencyTypeNameValue = textFinancialCurrencyTypeNameValue.substr(0, textFinancialCurrencyTypeNameValue.length - 1);
            }
            
            context.fillText(
                textFinancialCurrencyTypeNameValue,
                context.measureText(textFinancialCurrencyTypeName).width + 20,
                window.scrollY + 216
            );

            // Image Blob Filename ( column name first, then value )
            context.fillStyle = "rgb(211, 211, 211)"; // overallColors.textAlternate 

            let textImageBlobFilename:string = "Image Blob Filename: ";
            while (
                context.measureText(textImageBlobFilename).width > this.tileWidth() - 40
                && textImageBlobFilename.length > 2
            ) {
                textImageBlobFilename = textImageBlobFilename.substr(0, textImageBlobFilename.length - 1);
            }
            
            context.fillText(
                textImageBlobFilename,
                20,
                window.scrollY + 246
            );

            // column value
            context.fillStyle = "rgb(240, 240, 0)"; // overallColors.textColumnValue 
            let textImageBlobFilenameValue:string = this.getCartProduct.ImageBlobFilename.toString();
            while (
                context.measureText(textImageBlobFilename).width + context.measureText(textImageBlobFilenameValue).width > this.tileWidth() - 40
                && textImageBlobFilenameValue.length > 2
            ) {
                textImageBlobFilenameValue = textImageBlobFilenameValue.substr(0, textImageBlobFilenameValue.length - 1);
            }
            
            context.fillText(
                textImageBlobFilenameValue,
                context.measureText(textImageBlobFilename).width + 20,
                window.scrollY + 246
            );

            // Default User Name ( column name first, then value )
            context.fillStyle = "rgb(255, 255, 255)"; // overallColors.text 

            let textDefaultUserName:string = "Default User Name: ";
            while (
                context.measureText(textDefaultUserName).width > this.tileWidth() - 40
                && textDefaultUserName.length > 2
            ) {
                textDefaultUserName = textDefaultUserName.substr(0, textDefaultUserName.length - 1);
            }
            
            context.fillText(
                textDefaultUserName,
                20,
                window.scrollY + 276
            );

            // column value
            context.fillStyle = "rgb(240, 240, 0)"; // overallColors.textColumnValue 
            let textDefaultUserNameValue:string = this.getCartProduct.DefaultUserName.toString();
            while (
                context.measureText(textDefaultUserName).width + context.measureText(textDefaultUserNameValue).width > this.tileWidth() - 40
                && textDefaultUserNameValue.length > 2
            ) {
                textDefaultUserNameValue = textDefaultUserNameValue.substr(0, textDefaultUserNameValue.length - 1);
            }
            
            context.fillText(
                textDefaultUserNameValue,
                context.measureText(textDefaultUserName).width + 20,
                window.scrollY + 276
            );

            // Date Time ( column name first, then value )
            context.fillStyle = "rgb(211, 211, 211)"; // overallColors.textAlternate 

            let textDateTime:string = "Date Time: ";
            while (
                context.measureText(textDateTime).width > this.tileWidth() - 40
                && textDateTime.length > 2
            ) {
                textDateTime = textDateTime.substr(0, textDateTime.length - 1);
            }
            
            context.fillText(
                textDateTime,
                20,
                window.scrollY + 306
            );

            // column value
            context.fillStyle = "rgb(240, 240, 0)"; // overallColors.textColumnValue 
            let textDateTimeValue:string = this.getCartProduct.DateTime.toString();
            while (
                context.measureText(textDateTime).width + context.measureText(textDateTimeValue).width > this.tileWidth() - 40
                && textDateTimeValue.length > 2
            ) {
                textDateTimeValue = textDateTimeValue.substr(0, textDateTimeValue.length - 1);
            }
            
            context.fillText(
                textDateTimeValue,
                context.measureText(textDateTime).width + 20,
                window.scrollY + 306
            );

            // Session Identificator ( column name first, then value )
            context.fillStyle = "rgb(255, 255, 255)"; // overallColors.text 

            let textSessionIdentificator:string = "Session Identificator: ";
            while (
                context.measureText(textSessionIdentificator).width > this.tileWidth() - 40
                && textSessionIdentificator.length > 2
            ) {
                textSessionIdentificator = textSessionIdentificator.substr(0, textSessionIdentificator.length - 1);
            }
            
            context.fillText(
                textSessionIdentificator,
                20,
                window.scrollY + 336
            );

            // column value
            context.fillStyle = "rgb(240, 240, 0)"; // overallColors.textColumnValue 
            let textSessionIdentificatorValue:string = this.getCartProduct.SessionIdentificator.toString();
            while (
                context.measureText(textSessionIdentificator).width + context.measureText(textSessionIdentificatorValue).width > this.tileWidth() - 40
                && textSessionIdentificatorValue.length > 2
            ) {
                textSessionIdentificatorValue = textSessionIdentificatorValue.substr(0, textSessionIdentificatorValue.length - 1);
            }
            
            context.fillText(
                textSessionIdentificatorValue,
                context.measureText(textSessionIdentificator).width + 20,
                window.scrollY + 336
            );

            context.stroke ();

        }
    }
}
