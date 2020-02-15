//
// refs
//
// http://www.typescriptlang.org/Handbook#basic-types-array
// https://mapicons.mapsmarker.com/
// https://www.iconfinder.com/search/?q=airline
// https://stackoverflow.com/questions/20823767/welcome-screen-before-website-loads-click-to-enter-splash-screen
//
// client on load
window.onload = function () {
    var contentElement = document.getElementById("content");
    var splash = new Splash(contentElement);
    splash.start();
};
// canvas for Splash
var Splash = /** @class */ (function () {
    function Splash(element) {
        this.element = element;
    }
    // resize canvas based on window size
    Splash.prototype.resizeCanvas = function () {
        // get client elements
        var canvas = document.getElementById('myCanvas');
        canvas.width = window.innerWidth;
        canvas.height = window.innerHeight;
    };
    Splash.prototype.start = function () {
        // get client elements
        var canvas = document.getElementById('myCanvas');
        var context = canvas.getContext('2d');
        // resize canvas
        this.resizeCanvas();
        this.drawNormal();
        //// resize
        //let thisThat = this;
        //window.addEventListener('resize', function () {
        //    // resize canvas
        //    // get client elements
        //    let canvas: HTMLCanvasElement = (<HTMLCanvasElement>document.getElementById('myCanvas'));
        //    canvas.width = window.innerWidth;
        //    canvas.height = window.innerHeight;
        //}, false);
    };
    // draw tiles in normal size
    Splash.prototype.drawNormal = function () {
        // get client elements
        var canvas = document.getElementById('myCanvas');
        var context = canvas.getContext('2d');
        // clear canvas
        //context.beginPath();
        //context.fillStyle = '#888888';
        //context.fillRect(0, 0, canvas.width, canvas.height);
        //context.stroke();
        if (!sessionStorage.getItem('splashShown') || sessionStorage.getItem('splashShown') === null) {
            setTimeout(function () {
                Splash.drawLogo(100);
            }, 5);
            setTimeout(function () {
                window.location.href = 'http://NorSolutionPim.azurewebsites.net/home/index';
            }, 2000);
        }
        else {
            window.location.href = 'http://NorSolutionPim.azurewebsites.net/home/index';
        }
        sessionStorage.setItem('splashShown', "true");
    };
    Splash.drawLogo = function (size) {
        // logo
        var logoText = "Nor-Pim";
        // get client elements
        var canvas = document.getElementById('myCanvas');
        var context = canvas.getContext('2d');
        context.beginPath();
        context.font = size + "px Segoe UI";
        context.strokeStyle = "white";
        context.fillStyle = "white";
        context.shadowColor = "black";
        context.shadowBlur = 15;
        context.shadowOffsetX = 4;
        context.fillText(logoText, (canvas.width / 2) - (context.measureText(logoText).width / 2), (canvas.height / 2));
        var timer = 0;
        context.stroke();
        size = size + 2;
        clearTimeout(timer);
        if (size < 200) {
            timer = setTimeout(function () {
                Splash.drawLogo(size);
            }, 10);
        } //else {
        //    setTimeout(function (): void {
        //        // go to norpim desktop
        //        window.location.href = 'http://NorSolutionPim.azurewebsites.net/home/index';
        //        //window.location.href = '/home/index';
        //    }, 500
        //    );
        //}
    };
    return Splash;
}());
//# sourceMappingURL=splash.js.map