Node-Api
========

An API for the node Software
Node becomes in his new version the possibility to create plugins. This need an API which will be this peace of code.

HowTo:

Create an file to ~/Node/plugins/YOUR_PLUGIN.cfg (ASCII/DOS)
How to use it: KEY=TEXT<endline> If you write an $<file> to TEXT the software will load the text from <file>,
If you write an $$<url> to TEXT the software will load the text from the URL <url>. It will be ignored if you write lower or
upper case at the keys. If you write an ~\ before an path to something it will be replaced with the path to the pluginfolder.
You can make commands with #. Note: the plugin.cfg file must be the only *.cfg file of the plugin!

The software will accept the following keys:
Icon: an 16x16 image which will be visible at the pluginmanager
Version: The vesion of the Plugin
MinVesion: The first of node version where the plugin is compatible
MaxVersion: The last Version where the plugin is compatible
Name: The Name of the plugin
Author: The author of the plugin
Info: more informatin about the plugin
Web: A website which will be visibele at the pluginmanager
DLL: The DLL where the content of the plugin is stored

for example: File: Exampleplugin\plugin.cfg

Name=Exampleplugin

Author=ExampleAuthor

Icon=~\Exampleplugin\icon.png#or *.jpg *.ico

Info=$~\Exampleplugin\info.txt

Web=http://www.example.com/

Version=1.0.0.0

MinVersion=1.0.2.0#the first public release of node with the new plugin system

MaxVerison=#can be left emty if the are no known

DLL=~\Exampleplugin\plugin.dll#the only thing which is important

We think it is better if the extra stuff of the plugin is stored in a folder because
it could be a huge mess if you have multiple plugins installed.


