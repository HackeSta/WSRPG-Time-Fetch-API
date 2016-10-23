# WSRPG-Time-Fetch-API
Library for fetching in-game time from [SA-MP](sa-mp.com) Server [West-Side RPG](http://westsideteam.net)

## What is this?
You can use this simple dll to fetch ingame time from [SA-MP](sa-mp.com) server's. I made this for [West-Side RPG](http://westsideteam.net) but it can work on other servers as well. Try it and tell me.

## Functions

###### getHour()
Returns an int with the in-game hour

###### getMinute()
Returns an int with the in-game minute

## Usage
```csharp
using WSTimeFetch;

string gameTime = TimeFetch.getHour().ToString() + ":" + TimeFetch.getMinute().ToString();
```
*Timer based usage can be found in WSTimeFetch-Test*

## Notes
* **The time doesn't tick on its own, it just gets the value from memory**
* **If the game window is not focused, the time values in memory don't get updated, which inturn will not allow the time you get from this library to update**
