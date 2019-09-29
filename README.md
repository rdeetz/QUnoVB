# QUnoVB

An Uno-like card game implemented rapid application development style.

## Requirements

* .NET Framework v4.8
* Visual Studio 2019 (I use the Community edition)

## How To Play

This is a very basic (get it?) implementation of a Windows desktop 
application. Hopefully it's pretty straightforward to use the 
graphical user interface to play the game in a WYSIWYG fashion.

I tried to pay attention to detail, so you can play completely with 
the keyboard: press `Enter` to play the selected card; press `space` 
to draw a card.

## Developer Notes

The program depends on a DLL in the `lib` folder. This DLL is the game "engine" 
and targets the .NET Standard v2 APIs. The code for this engine is currently 
hosted elsewhere but may move to GitHub in the future.

Also this is Visual Basic, so no judgement.
