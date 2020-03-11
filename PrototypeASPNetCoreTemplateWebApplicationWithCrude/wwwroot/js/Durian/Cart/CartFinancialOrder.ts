// SQL2X Generated code based on a SQL Server Schema
// SQL2X Version: 1.0
// http://sql2x.org/
// Generated Date: 3/11/2020 10:17:27 PM
// Template: sql2x.CrudeTypeScriptGenerator.DesignHagtorn
module SQL2XTemplateCrudeTableGetCartProduct {
    "use strict";

    type GetFinancialOrderType = {
        firstName: string,
        middleName: string,
        lastName: string,
        imageBlobFilename: string,
        defaultUserName: string,
        financialCurrencyTypeName: string,
        financialOrderSourceName: string,
        userId: string,
        dateTime: string,
        comment: string,
        financialCurrencyTypeRcd: string,
        financialCurrencyAgainstFinancialCurrencyTypeRcd: string,
        financialCurrencyTypeCode: string,
        financialCurrencyId: string,
        financialOrderSourceRcd: string,
        clientId: string,
        financialOrderId: string,
        locationAddressId: string
    };

    // declaration
    declare var getFinancialOrderList: GetFinancialOrderType[];

    const colorHeader: string = "rgb(20, 101, 29)";
    const colorTile: string = "rgb(20, 101, 29)";
    const colorTileAlternate: string = "rgb(4, 115, 8)";

    // client on load
    window.onload = () => {
        var contentElement: any = document.getElementById("content");
        var dashboard: GetFinancialOrderTileList = new GetFinancialOrderTileList(contentElement);
        dashboard.start();
    };

    // class
    class GetFinancialOrderTileList {
        static tiles: Array<Tile>;
        static maximized: boolean = false;
        static tileListHeight: number = 0;

        constructor(
            element: HTMLElement
        ) {
            // init tiles
            GetFinancialOrderTileList.tiles = new Array<Tile>();
            GetFinancialOrderTileList.maximized = false;
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

            // resize canvas to hold all getFinancialOrderList
            this.resizeCanvas(45);
            GetFinancialOrderTileList.clearCanvas("white");

            // get client elements
            let canvas: HTMLCanvasElement = (<HTMLCanvasElement>document.getElementById("myCanvas"));

            // header tile
            let line: number = 0;
            const header: Tile = new Tile(
                "Financial Orders",
                2,
                line,
                "",
                getFinancialOrderList.length,
                48,
                15,
                2,
                5,
                16,
                colorHeader,
                null
            );

            GetFinancialOrderTileList.tiles.push(header);

            // remaining getFinancialOrderList
            let lastTile: Tile;

            for (let i: number = 0; i < getFinancialOrderList.length; i++) {
                line++;

                // alternate color
                let newColor:string = colorTile;
                if (i % 2 === 0) {
                    newColor = colorTileAlternate;
                }

                lastTile =
                    new Tile(
                             getFinancialOrderList [i].firstName
                          + " " + getFinancialOrderList [i].middleName
                          + " " + getFinancialOrderList [i].lastName
                          + " " + getFinancialOrderList [i].imageBlobFilename
                          + " " + getFinancialOrderList [i].defaultUserName
                          + " " + getFinancialOrderList [i].dateTime
                        ,40,
                        line,
                        getFinancialOrderList [i].financialOrderId,
                        getFinancialOrderList.length,
                        45,
                        15,
                        2,
                        7,
                        14,
                        newColor,
                        getFinancialOrderList[i]
                    );

                GetFinancialOrderTileList.tiles.push(lastTile);
            }

            // resize canvas to last tile
            if (lastTile) {
                canvas.height = lastTile.tileTop + lastTile.tileHeight + 15;
                GetFinancialOrderTileList.tileListHeight = canvas.height;
            }

            // draw chapter index
            GetFinancialOrderTileList.drawNormal();

            // handle click event
            canvas.addEventListener("click", this.canvasClick, false);

            // resize
            const thisThat: GetFinancialOrderTileList = this;
            window.addEventListener("resize",
                function (): void {
                    // resize canvas
                    thisThat.resizeCanvas(45);

                    // draw chapter index
                    GetFinancialOrderTileList.drawNormal();
                },
                false);

            // check mouse pointer style
            document.onmousemove = function (e: any): void {

                // default style
                canvas.style.cursor = "auto";

                if (GetFinancialOrderTileList.tiles) {
                    for (let tile of GetFinancialOrderTileList.tiles) {
                        // check whole tile area
                        if (tile.hitTest(e.offsetX, e.offsetY)) {
                            canvas.style.cursor = "pointer";
                            break;
                        }
                    }
                }
            };
        }

        // check if we are living in a mobile phone
        isMobile(): boolean {
            let isMobileForSure: boolean = false;

            // detectmobilebrowsers.com
            (function(a: any): void {
                if (
                    /(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|mobile.+firefox|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows ce|xda|xiino/i.test(a) || /1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-/i.test(a.substr(0, 4))) { isMobileForSure = true; }
            })(navigator.userAgent || navigator.vendor);

            return isMobileForSure;
        }

        // resize canvas based on window size
        resizeCanvas(
            left: number
        ): void {
            // get client elements
            let canvas: HTMLCanvasElement = (<HTMLCanvasElement>document.getElementById("myCanvas"));

            if (!this.isMobile()) {
                canvas.width = window.innerWidth - (left * 0);
            } else {
                canvas.width = window.innerWidth;
            }
        }

        // check click event
        canvasClick(
            event: any
        ): void {
            if (GetFinancialOrderTileList.maximized) {
                GetFinancialOrderTileList.drawNormal();
                GetFinancialOrderTileList.maximized = false;
            } else {
                if (GetFinancialOrderTileList.tiles) {
                    for (let tile of GetFinancialOrderTileList.tiles) {
                        // check whole tile area
                        if (tile.hitTest(event.offsetX, event.offsetY)) {
                            if (tile.url !== "") {
                                if (event.offsetX > tile.detailLink.linkLeft) {
                                    // indicate that the tile link was clicked
                                    tile.detailLink.frame(tile.lineWidth, true);

                                    // show all info
                                    tile.drawDurian();

                                } else if (event.offsetX > tile.unOrderLink.linkLeft) {         
                                    // indicate that the tile link was clicked                  
                                    tile.unOrderLink.frame(tile.lineWidth, true);               
                                    
                                    // go to url                                                
                                    window.location.href = tile.unOrderLink.linkUrl + tile.url; 

                                } else {
                                    // indicate that the tile link was clicked
                                    tile.frame(tile.backgroundColor, 2, true);

                                    // show all info
                                    tile.drawDurian();
                                }
                            } else {
                                // navigate to tile"s main page
                                try {
                                    const contentElement: any = document.getElementById("content");
                                    const dashboard: GetFinancialOrderTileList = new GetFinancialOrderTileList(contentElement);
                                    dashboard.start();
                                } catch (Error) { ; }
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
            if (GetFinancialOrderTileList.tileListHeight != 0) {
                canvas.height = GetFinancialOrderTileList.tileListHeight;
            }

            // clear canvas
            GetFinancialOrderTileList.clearCanvas("white");

            // draw tiles
            for ( let tile of GetFinancialOrderTileList.tiles) {
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
            this.linkBorder = boxHeight * 0.1;
            this.linkWidth = (boxWidth * 0.1) - this.linkBorder;
            this.linkHeight = boxHeight - (this.linkBorder * 2);
            this.linkLeft = boxLeft +
                boxWidth -
                ((this.linkBorder + this.linkWidth + this.linkBorder) * position) -
                this.linkBorder;
            this.linkTop = boxTop + this.linkBorder;
        }

        // draw frame
        draw(
            font: string,
            text: string,
            top: number
        ): void {
            let canvas: HTMLCanvasElement = (<HTMLCanvasElement>document.getElementById("myCanvas"));
            let context: CanvasRenderingContext2D = canvas.getContext("2d");

            // draw link boxes
            context.beginPath();
            context.lineWidth = 2;
            context.strokeStyle = "black";
            context.fillStyle = "darkgreen";
            context.shadowColor = "darkgray";
            context.shadowBlur = 20;
            context.shadowOffsetX = 0;
            context.shadowOffsetY = 0;
            context.fillStyle = "darkgreen";
            context.fillRect(
                this.linkLeft,
                this.linkTop,
                this.linkWidth,
                this.linkHeight
            );
            context.fillStyle = "white";
            context.font = font;
            context.fillText(
                text,
                this.linkLeft + (this.linkWidth / 2) - (context.measureText(text).width / 2),
                top
            );
        }

        // draw frame
        frame(
            lineWidth: number,
            showDash: boolean
        ): void {
            let canvas: HTMLCanvasElement = (<HTMLCanvasElement>document.getElementById("myCanvas"));
            let context: CanvasRenderingContext2D = canvas.getContext("2d");

            const dashList: number[] = [5]; // create a dot/dash sequence
            context.beginPath();
            context.lineWidth = lineWidth;
            context.strokeStyle = showDash ? "white" : "black";
            context.fillStyle = showDash ? "white" : "black";
            context.shadowColor = showDash ? "white" : "black";
            context.shadowBlur = 0;
            context.shadowOffsetX = 0;

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
        backgroundColor = "white";
        textColor = "black";
        lineWidth = 1;
        textLeft = 0;

        detailLink: Link;
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
            private getFinancialOrder: GetFinancialOrderType
        ) {
            this.detailLink = new Link();
            this.unOrderLink = new Link();
            this.tileTop = tileSpaceVertical + ((this.tileHeight + tileSpaceVertical) * this.tileTop);
            this.textLeft = this.tileLeft + this.textReposLeft + (this.tileBorder * 1.5);
        }

        tileWidth(): number {
            // get client elements
            let canvas: HTMLCanvasElement = (<HTMLCanvasElement>document.getElementById("myCanvas"));
            return canvas.width - this.tileLeft - this.tileBorder - this.tileBorder;
        }

        // text
        textTop(text: string): number {
            return this.tileTop + (this.tileHeight / 2) + (this.tileFontSize / 2);
        }

        // draws the tile
        draw(
            context: CanvasRenderingContext2D
        ): void {
            // fixed stuff
            this.tileFrame(context);

            // gradient box
            const boxLeft: number = this.tileLeft;
            const boxTop: number = this.tileTop;
            const boxWidth: number = this.tileWidth();
            const boxHeight: number = this.tileHeight;
            context.beginPath();
            context.lineWidth = this.lineWidth;
            context.strokeStyle = this.backgroundColor;
            context.fillStyle = this.fillStyle;
            context.shadowColor = "gray";
            context.shadowBlur = 10;
            context.shadowOffsetX = 3;
            context.fillRect(
                boxLeft,
                boxTop,
                boxWidth,
                boxHeight
            );
            context.stroke();

            // empty url gets a detail link indicator
            if (this.url !== "") {
                // details
                this.detailLink.measure(boxLeft, boxTop, boxWidth, boxHeight, 1);
                this.detailLink.linkUrl = "http://NorSolutionPim.azurewebsites.net/controller/action?id=";
                this.detailLink.draw(this.tileFontSize + "px Arial", "D", this.textTop(this.name));
                context.stroke();

                // un Order                                                                                 
                this.unOrderLink.measure(boxLeft, boxTop, boxWidth, boxHeight, 2);                          
                this.unOrderLink.linkUrl = "http://NorSolutionPim.azurewebsites.net/controller/action?id=";
                this.unOrderLink.draw(this.tileFontSize + "px Arial", "U", this.textTop(this.name));        
                context.stroke();                                                                           
            }

            // chapter header
            context.beginPath();
            context.font = this.tileFontSize + "px Arial";
            context.strokeStyle = this.backgroundColor;
            context.fillStyle = this.backgroundColor;
            context.shadowBlur = 10;
            context.shadowOffsetX = 3;

            // cap text until it fits inside the tile
            let name: string = this.name;
            while (
                context.measureText(name).width > (this.unOrderLink.linkLeft - this.textLeft - this.tileBorder)
                && name.length > 2
            ) {
                name = name.substr(0, name.length - 1);
            }

            context.fillText(
                name,
                this.textLeft,
                this.textTop(name)
            );

            context.stroke();
        }

        // draw frame
        frame(
            strokeStyle: any,
            lineWidth: number,
            showDash: boolean
        ): void {
            let canvas: HTMLCanvasElement = (<HTMLCanvasElement>document.getElementById("myCanvas"));
            let context: CanvasRenderingContext2D = canvas.getContext("2d");

            const dashList: number[] = [5]; // dot/dash sequence
            context.beginPath();
            context.lineWidth = lineWidth;
            context.strokeStyle = strokeStyle;
            context.fillStyle = strokeStyle;
            context.shadowColor = strokeStyle;
            context.shadowBlur = 0;
            context.shadowOffsetX = 0;

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
            context.shadowColor = "gray";
            context.shadowBlur = 10;
            context.shadowOffsetX = 3;
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

        // draw maximized durian
        drawDurian(): void {
            // get client elements
            let canvas: HTMLCanvasElement = (<HTMLCanvasElement>document.getElementById("myCanvas"));
            let context: CanvasRenderingContext2D = canvas.getContext ( "2d" );

            // resize canvas to fit all columns 
            canvas.height = window.scrollY + 240 + 15;

            // clear background
            context.beginPath ();
            context.fillStyle = colorHeader;
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
            context.fillStyle = "white";
            context.fillText (
                this.name ,
                10 ,
                window.scrollY + 20
            );

            // all displayable columns from durian
            context.font = this.tileFontSize + "px Arial";
            context.fillStyle = "lightgray";
            context.fillText(
                "First Name: " + this.getFinancialOrder.firstName,
                20,
                window.scrollY + 40
            );
            context.fillStyle = "white";
            context.fillText(
                "Middle Name: " + this.getFinancialOrder.middleName,
                20,
                window.scrollY + 60
            );
            context.fillStyle = "lightgray";
            context.fillText(
                "Last Name: " + this.getFinancialOrder.lastName,
                20,
                window.scrollY + 80
            );
            context.fillStyle = "white";
            context.fillText(
                "Image Blob Filename: " + this.getFinancialOrder.imageBlobFilename,
                20,
                window.scrollY + 100
            );
            context.fillStyle = "lightgray";
            context.fillText(
                "Default User Name: " + this.getFinancialOrder.defaultUserName,
                20,
                window.scrollY + 120
            );
            context.fillStyle = "white";
            context.fillText(
                "Financial Currency Type Name: " + this.getFinancialOrder.financialCurrencyTypeName,
                20,
                window.scrollY + 140
            );
            context.fillStyle = "lightgray";
            context.fillText(
                "Financial Order Source Name: " + this.getFinancialOrder.financialOrderSourceName,
                20,
                window.scrollY + 160
            );
            context.fillStyle = "white";
            context.fillText(
                "Date Time: " + this.getFinancialOrder.dateTime,
                20,
                window.scrollY + 180
            );
            context.fillStyle = "lightgray";
            context.fillText(
                "Comment: " + this.getFinancialOrder.comment,
                20,
                window.scrollY + 200
            );
            context.fillStyle = "white";
            context.fillText(
                "Financial Currency Type Code: " + this.getFinancialOrder.financialCurrencyTypeCode,
                20,
                window.scrollY + 220
            );

            context.stroke ();

            GetFinancialOrderTileList.maximized = true;
        }
    }
}
