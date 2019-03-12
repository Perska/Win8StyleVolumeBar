# Win8StyleVolumeBar
This program adds a volume bar to your acreen that appears when the volume is changed, and disappears after a while.

It was made to look like the volume bar that appears on Windows 8 and above.

The sole reason this exiats is because I dualboot Windows 7 and Windows 8.1, and I wanted a volumebar for Win7.  
I tried looking for one, but none of them had exact numbers. So I made my own.

## Usage
To start the program, simply run `Win8StyleVolumeBar.exe`. By default, the volume bar is maroon (R: 128, G: 0, B: 0), but this can be changed by specifying a color as an argument in the following format:
- bits 0-7: Blue
- bits 8-15: Green
- bits 16-23: Red

Example: To change the color to cornflower blue (R: 100, B: 149, G: 237), use `6591981` as the parameter (it has to be in decimal!):  
`Win8StyleVolumeBar.exe 6591981`

## Launching at startup
You can simply create a shortcut (with parameters if needed) to the executable and add it to your Startup folder.

### things that need to be fixed
- [ ] remove potentially bad code
- [ ] stop using a +100 KB library just to use one function of it to get the volume
- [ ] make it possible to use three params when specifying a custom color
- [ ] make it possible to use hexadecimal when specifying a color

### more things
This uses the [AudioSwitcher API](https://github.com/xenolightning/AudioSwitcher).
