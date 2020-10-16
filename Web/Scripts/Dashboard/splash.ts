// client on load
window.onload = () => {
    var contentElement: any = document.getElementById("content");
    var splash = new Splash(contentElement);
    splash.start();
};

// canvas for Splash
class Splash {
    private element: HTMLElement;

    constructor(
        element: HTMLElement
    ) {

        this.element = element;
    }

    // resize canvas based on window size
    resizeCanvas() {
        // get client elements
        let canvas: HTMLCanvasElement = (<HTMLCanvasElement>document.getElementById('myCanvas'));

        canvas.width = window.innerWidth;
        canvas.height = window.innerHeight;
    }

    start() {
        // get client elements
        let canvas: HTMLCanvasElement = (<HTMLCanvasElement>document.getElementById('myCanvas'));
        let context: CanvasRenderingContext2D = canvas.getContext('2d');

        // resize canvas
        this.resizeCanvas();

        this.drawNormal();
    }

    // draw tiles in normal size
    drawNormal() {

        // get client elements
        let canvas: HTMLCanvasElement = (<HTMLCanvasElement>document.getElementById('myCanvas'));
        let context: CanvasRenderingContext2D = canvas.getContext('2d');

        //if (!sessionStorage.getItem('splashShown') || sessionStorage.getItem('splashShown') === null) {

            setTimeout(function (): void {
                Splash.drawLogo(100);
                }, 5
            );

            setTimeout(function (): void {
                window.location.href = 'http://NorSolutionPim.azurewebsites.net/home/index';
                }, 2000
            );

        //} else {
        //    window.location.href = 'http://NorSolutionPim.azurewebsites.net/home/index';
        //}

        sessionStorage.setItem('splashShown', "true");
    }

    static drawLogo(
        size: number
        ) {

        // logo
        let logoText: string = "Nor-Pim";

        // get client elements
        let canvas: HTMLCanvasElement = (<HTMLCanvasElement>document.getElementById('myCanvas'));
        let context: CanvasRenderingContext2D = canvas.getContext('2d');

        context.beginPath();
        context.font = size + "px Segoe UI";
        context.strokeStyle = "white";
        context.fillStyle = "white";
        context.shadowColor = "black";
        context.shadowBlur = 15;
        context.shadowOffsetX = 4;

        context.fillText(
            logoText,
            (canvas.width / 2) - (context.measureText(logoText).width / 2),
            (canvas.height / 2)
        );

        var timer: number = 0;

        context.stroke();

        size = size + 2;

        clearTimeout(timer);

        if (size < 200) {
            timer = setTimeout(function ():void {
                Splash.drawLogo(size);
            }, 10
            );
        }
    }
}
