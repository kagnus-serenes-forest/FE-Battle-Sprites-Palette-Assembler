Kagnus' Fire Emblem battle sprite palette assembler for GBAFE games

-----------
How to use:
-----------

This program is a complement to BwdYeti's FE Recolor.

This program DOESN'T EDIT the colors, IT COMPRESSES the palettes so they can be inserted into a ROM.

After clicking "Copy hex to clipboard" in FE Recolor, choose which palette you want
to import in the palettes tab and click "Import from clipboard".
Repeat this until you imported every palette you wanted.

You can choose a default palette if you don't want to import every palette.
The default palette is the Player's palette unless you change it.

If the default palette was not imported, unset palettes will use any imported palette
in the following priority order: Player, Enemy, NPC, Player4 link arena, Player1 link arena.

Then, you can choose whether to replace/add an entry in the ROM you chose,
to compress the palette into a file at a specific offset
(at your own risk, no check is done to make sure you don't overwrite other data)
or to export the compressed palette to the clipboard.

---------
Versions:
---------

v2.0: Second release: // need a better name
- Palette entry choice
- Palette length checking
- Repointing when needed
- Palette extraction

v1.0: Initial release:
- Palette importing
- Palette compression to clipboard
- Palette compression to a file at a given offset
- Choice of which index to set
- Default index for unset palette indexes

--------------------------
Plans for future releases:
--------------------------

- Import palettes from FE Recolor's image data
- Customize palette entries list
- Append extracted palette to FE Recolor's image data
- Extract palette as image

------------
Legal stuff:
------------

This program uses parts of Nintenlord's source code, so all of Nintenlord's work
can be freely distributed and modified as long as the following conditions are met:

-Origin of Nintenlord's work is not misinterpreted (in other words, credits are given etc.).
-Re-modification is made as easy as possible (include source code etc.).
-Modifying Nintenlord's work makes it better than it was before.
-No money is made by anyone except Nintenlord.
-You can use them in your hacks as much as you want, just remember to give credit.


These conditions are still valid for my code, i.e.:

-Origin of my work is not misinterpreted (in other words, credits are given etc.).
-Re-modification is made as easy as possible (include source code etc.).
-Modifying my work makes it better than it was before.
-No money is made by anyone. (Not sure about this one, I need a confirmation.)
-You can use them in your hacks as much as you want, just remember to give credit.

--------
Credits:
--------

- BwdYeti, for FE Recolor
- Nintendlord, for making his programs and libraries and releasing them as free software
- Anyone who uses this program, gives feedback or contributes in any other way.
- Me, Kagnus, for making this.
