# Discord Starter for iCue

Basically what it says. Very simple software that lets you start discord from
iCue.

## ok but y tho

Currently, Discord is started as `Update.exe` with the Windows parameters
`--processStart Discord.exe`. As of version v5.12.97, it will only start
processes directly without consideration for any parameterized shortcuts.

## ok but y not PowerShell

I had little success in running .cmd or .bat files in PowerShell to run
Discord, so I made this little thing. It isn't perfect, and it's missing a few
bells and whistles (such as error handling, redirecting output in case of
missing variables or files and so forth).

## License

[MIT](LICENSE.txt)
