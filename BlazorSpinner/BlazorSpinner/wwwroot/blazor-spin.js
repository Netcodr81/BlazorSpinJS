import { Spinner } from './spin.js'

export class BlazorSpin {

    constructor() {  }

    spinner = {}
    isSpining = false;

    opts = {
        lines: 13, // The number of lines to draw
        length: 20, // The length of each line
        width: 10, // The line thickness
        radius: 45, // The radius of the inner circle
        scale: 1, // Scales overall size of the spinner
        corners: 1, // Corner roundness (0..1)
        speed: 1, // Rounds per second
        rotate: 0, // The rotation offset
        animation: 'spinner-line-fade-quick', // The CSS animation name for the lines
        direction: 1, // 1: clockwise, -1: counterclockwise
        color: '#000000', // CSS color or array of colors
        fadeColor: 'transparent', // CSS color or array of colors
        top: '50%', // Top position relative to parent
        left: '50%', // Left position relative to parent
        shadow: '0 0 1px transparent', // Box-shadow for the lines
        zIndex: 2000000000, // The z-index (defaults to 2e9)
        className: 'spinner', // The CSS class to assign to the spinner
        position: 'absolute', // Element positioning
    };

    Spin(target, options) {

        this.UpdateOptions(options);
        let spinTarget = document.getElementById(target);

        if (this.isSpining) {
            this.Stop();
            this.spinner = new Spinner(this.opts).spin(spinTarget);
        }
        else {
            this.spinner = new Spinner(this.opts).spin(spinTarget);
        }

        this.isSpining = true;
    };

    Stop() {     
        this.spinner.stop();
        this.isSpining = false;
    };

    UpdateOptions(options) {
        this.opts.lines = options.lines;
        this.opts.length = options.length;
        this.opts.width = options.width;
        this.opts.radius = options.radius;
        this.opts.scale = options.scale;
        this.opts.corners = options.corners;
        this.opts.speed = options.speed;
        this.opts.rotate = options.rotate;
        this.opts.animation = options.animation;
        this.opts.direction = options.direction;
        this.opts.color = options.color;
        this.opts.fadeColor = options.fadeColor;
        this.opts.top = options.top;
        this.opts.left = options.left;
        this.opts.shadow = options.shadow;
        this.opts.zIndex = options.zIndex;
        this.opts.className = options.className;
        this.opts.position = options.position;
    }
}

export let DefaultSpinner;

export function Initialize(options) {

    DefaultSpinner = new BlazorSpin(options);
}


