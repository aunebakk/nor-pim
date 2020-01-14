//
// refs
//
// http://www.typescriptlang.org/Handbook#basic-types-array
// https://mapicons.mapsmarker.com/
// https://www.iconfinder.com/search/?q=airline
//
// client on load
window.onload = function () {
    var contentElement = document.getElementById("content");
    var dashboard = new DashboardWhiteboard(contentElement);
    dashboard.start();
};
// canvas for dashboard
var DashboardWhiteboard = /** @class */ (function () {
    function DashboardWhiteboard(element) {
        this.element = element;
    }
    // check if we are living in a mobile phone
    DashboardWhiteboard.isMobile = function () {
        var isMobileForSure = false;
        // detectmobilebrowsers.com
        (function (a) { if (/(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|mobile.+firefox|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows ce|xda|xiino/i.test(a) || /1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-/i.test(a.substr(0, 4)))
            isMobileForSure = true; })(navigator.userAgent || navigator.vendor);
        return isMobileForSure;
    };
    // resize canvas based on window size
    DashboardWhiteboard.prototype.resizeCanvas = function () {
        // get client elements
        var canvas = document.getElementById('myCanvas');
        canvas.width = window.innerWidth;
        canvas.height = window.innerHeight;
    };
    DashboardWhiteboard.prototype.frame = function (strokeStyle, lineWidth, showDash, width, height) {
        var canvas = document.getElementById('myCanvas');
        var context = canvas.getContext('2d');
        var dashList = [5]; // Create a dot/dash sequence
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
        context.rect(0, 0, width, height);
        context.stroke();
    };
    // calc tile size factor based on available canvas with
    DashboardWhiteboard.prototype.sizeFactor = function () {
        return 1;
    };
    DashboardWhiteboard.sizeFactor = function () {
        return 1;
    };
    DashboardWhiteboard.marker = function (context, x, y, strokeStyleNew, text) {
        var strokeStyleOld = context.strokeStyle;
        context.beginPath();
        context.strokeStyle = strokeStyleNew;
        context.arc(x, y, 45, 90, 270);
        context.stroke();
        context.beginPath();
        context.strokeStyle = strokeStyleNew;
        context.fillStyle = strokeStyleNew;
        context.fillText("1." + text + "(- -)", x - 50, y - 50);
        context.fillText("2." + text + "(+ -)", x + 50, y - 50);
        context.fillText("3." + text + "(- +)", x - 50, y + 50);
        context.fillText("4." + text + "(+ +)", x + 50, y + 50);
        context.fillText("(" + x + "," + y + ")", x, y);
        context.stroke();
        context.strokeStyle = strokeStyleOld;
    };
    // indicate four corners, and write the position as text
    DashboardWhiteboard.indicateFourCorners = function (canvas, context) {
        var x = canvas.clientLeft;
        var y = canvas.clientTop;
        var w = canvas.width; // clientWidth;
        var h = canvas.height; // clientHeight;
        // outer frame ( to get a line )
        context.beginPath();
        context.lineWidth = 1;
        context.strokeStyle = "black";
        context.fillStyle = "black";
        context.shadowColor = "black";
        context.fillRect(x, y, w, h);
        context.stroke();
        // inner frame ( to get a line )
        context.beginPath();
        context.lineWidth = 1;
        context.strokeStyle = "lightgray";
        context.fillStyle = "lightgray";
        context.shadowColor = "lightgray";
        context.fillRect(x + 2, y + 2, w - 4, h - 4);
        context.stroke();
        // coordinates
        context.beginPath();
        context.strokeStyle = "blue";
        context.fillStyle = "blue";
        context.shadowColor = "blue";
        context.fillText("canvas.leftTop[" + x + "," + y + "]", x + 15, y + 15);
        context.fillText("canvas.widthHeight:{" + canvas.width + "," + canvas.height + "}", x + 15, y + 35);
        context.fillText("canvas.scroll:{" + canvas.scrollWidth + "," + canvas.scrollHeight + "}", x + 15, y + 55);
        context.fillText("canvas.client:{" + canvas.clientWidth + "," + canvas.clientHeight + "}", x + 15, y + 75);
        context.fillText("[" + x + "," + (y + h) + "]", x + 15, y + h - 15);
        context.fillText("[" + (x + w / 1.5) + "," + (y + h) + "]", x + w / 1.5 + 50, y + h - 15);
        context.stroke();
        // circles
        this.marker(context, x, y, "red", "XY");
        this.marker(context, x, y + h, "green", "XYH");
        this.marker(context, x + w, y, "orange", "XWY");
        this.marker(context, x + w, y + h, "blue", "XWYH");
        this.marker(context, x + w / 2, y + h / 2, "black", "XWYH");
    };
    // clear canvas
    DashboardWhiteboard.prototype.clearCanvas = function () {
        // get client elements
        var canvas = document.getElementById('myCanvas');
        var context = canvas.getContext('2d');
        context.beginPath();
        context.fillStyle = "white";
        context.fillRect(0, 0, canvas.width, canvas.height);
        context.stroke();
    };
    DashboardWhiteboard.prototype.start = function () {
        // get client elements
        var canvas = document.getElementById('myCanvas');
        var context = canvas.getContext('2d');
        // resize canvas
        this.resizeCanvas();
        DashboardWhiteboard.indicateFourCorners(canvas, context);
        // resize
        var thisThat = this;
        window.addEventListener('resize', function () {
            // resize canvas
            // get client elements
            var canvas = document.getElementById('myCanvas');
            canvas.width = window.innerWidth;
            canvas.height = window.innerHeight;
        }, false);
        // draw chapter index
        //this.drawNormal(this.sizeFactor());
        // handle click event
        canvas.addEventListener('click', this.canvasClickIndicator, false);
    };
    // check if coordinates are inside tile boundaries
    DashboardWhiteboard.hitTestChapterIndex = function (clientX, clientY) {
        // get client elements
        var canvas = document.getElementById('myCanvas');
        var context = canvas.getContext('2d');
        if (clientX < canvas.clientLeft || clientX > canvas.clientLeft + canvas.clientWidth / 2)
            return 0;
        if (clientY < canvas.clientTop || clientY > canvas.clientTop + canvas.clientHeight / 2)
            return 0;
        return 1;
    };
    // indicate mouse position
    DashboardWhiteboard.prototype.canvasClickIndicator = function (event) {
        var canvas = document.getElementById('myCanvas');
        var context = canvas.getContext('2d');
        // clear canvas
        context.beginPath();
        context.fillStyle = "white";
        context.fillRect(event.offsetX, event.offsetY, 150, 40);
        // fill text
        context.fillStyle = "black";
        context.fillText("event.offset.X[" + event.offsetX + ",Y" + event.offsetY + "]", event.offsetX + 2, event.offsetY + 10);
        context.fillText("event.screen.X[" + event.screenX + ",Y" + event.screenY + "]", event.offsetX + 2, event.offsetY + 30);
        context.stroke();
    };
    // maximize or normalize
    DashboardWhiteboard.prototype.canvasClickOld = function (event) {
        var canvas = document.getElementById('myCanvas');
        var context = canvas.getContext('2d');
        // where is the mouse?
        var chapter = DashboardWhiteboard.hitTestChapterIndex(event.offsetX, event.offsetY);
        // clear canvas
        if (chapter == 0) {
            context.beginPath();
            context.fillStyle = "white";
            context.fillRect(100, 100, canvas.width - 100, canvas.height - 100);
            context.stroke();
        }
        else {
            context.beginPath();
            context.fillStyle = "darkgreen";
            context.fillRect(0, 0, canvas.width, canvas.height);
            context.stroke();
        }
    };
    // tile coordinates
    DashboardWhiteboard.prototype.relativeTileLeft = function () {
        return 1;
    };
    DashboardWhiteboard.prototype.relativeTileTop = function () {
        return 1;
    };
    DashboardWhiteboard.prototype.relativeTileWidth = function () {
        return 1;
    };
    DashboardWhiteboard.prototype.relativeTileHeight = function () {
        return 1;
    };
    DashboardWhiteboard.prototype.relativeTileBorder = function () {
        return 10;
    };
    // draw tiles in normal size
    DashboardWhiteboard.prototype.drawNormal = function (sizeFactor) {
        // get client elements
        var canvas = document.getElementById('myCanvas');
        var context = canvas.getContext('2d');
        // clear canvas
        context.beginPath();
        context.fillStyle = "white";
        context.fillRect(0, 0, canvas.width, canvas.height);
        context.stroke();
        var chapterCount = 60;
        var chapterHeight = 40;
        canvas.height = chapterCount * chapterHeight;
        // chapter header
        context.beginPath();
        context.font = (24 * this.sizeFactor()) + "px Segoe UI";
        context.strokeStyle = "black";
        context.fillStyle = "black";
        context.shadowColor = "black";
        context.shadowBlur = 5;
        context.shadowOffsetX = 4 * this.sizeFactor();
        for (var i = 1; i < chapterCount; i++) {
            var text = "0" + i;
            context.fillText(text.substr(text.length - 2, 2) + " - Kabler", 40, chapterHeight * i);
        }
        context.stroke();
    };
    DashboardWhiteboard.prototype.stop = function () {
        clearTimeout(this.timerToken);
    };
    return DashboardWhiteboard;
}());
//# sourceMappingURL=dashboardWhiteboard.js.map