# Background

  The [West Side RPG Server](http://westsideteam.net) had just restarted and a lot of new players had joined. During that time, a player had made a tool for [West Side](http://westsideteam.net). The tool was basically an alarm clock, synced with the in-game clock. The purpose was to alert the user that a specific time was about to come in the game. The only problem was its accuracy. The users had to input the time themselves, since the developer could not figure out how to fetch the time from the game.
  
  
  I suggested him to try and add that feature, and gave him the memory address where the time was stored. That time, I was busy with improving [Evolve CP Calculator](http://hackesta.org/projects/?id=6) and couldn't help him.
  
  After about a month, when I had nothing to do, I saw that forum post again, and thought to do something about it. It took me around an hour and a half to figure out how to fetch the time. I had never read process memory before and it was a completely new experience for me. I think this can be used for all SA-MP servers, but I haven't tried it yet.

# Tutorial
  * ### getHour()
      #### Returns an int with the in-game hour
  * ### getMinute()
      #### Returns an int with the in-game minute

# Usage
  
```csharp
 using WSTimeFetch;
string gameTime = TimeFetch.getHour().ToString() + ":" + TimeFetch.getMinute().ToString();
```

# Notes
* ### The time doesn't tick on its own, it just gets the value from memory
* ### If the game window is not focused, the time values in memory don't get updated, which inturn will not allow the time you get from this library to update
