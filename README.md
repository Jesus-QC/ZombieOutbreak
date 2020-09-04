# ZombieOutbreak
 In a configurable certain time a configurable numbre of zombies spawn in 049 chamber

# Installation
Download the .dll file of the latest release and place it inside the Exiled Plugins folder

# Configs
```yaml
ZombieOutbreak:
# Is the plugin enabled?
  is_enabled: true
  # ZombieOutage broadcast (Keep it empty for disabling it)
  entry_broadcast: <color=#F54646><b>A Zombie Outbreak</b></color>
  # ZombieOutage cassie (Keep it empty for disabling it)
  entry_cassie: SCP 0 0 8 has a breach of containment . AllRemaining
  # How much have health have a zombie of an outbreak
  zombies_h_p: 400
  # MaxNumber of Zombies in an outbreak
  max_zombies: 8
  # Probability of a zombie outbreak happening
  spawn_probability: 100
  # Minimun time for the first zombie outbreak from round start (Putting this in 2 or lower could break the plugin)
  min_time_first_spawn: 120
  # Maximun time for the first zombie outbreak
  max_time_first_spawn: 170
  # Minimun time between zombie outbreaks (Putting this in 2 or lower could break the plugin)
  min_time_between_outbreak: 180
  # Maximun time between zombie outbreaks
  max_time_between_outbreak: 600
```
