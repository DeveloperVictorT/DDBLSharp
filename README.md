# DDBLSharp
Divine Discord Bot List API in C#

This is not the official wrapper for DDBLSharp
Find the release version at https://github.com/DivineDiscordBotList/DDBLSharp

```
Authorization: "yes"
Ratelimit: 1 minute
Parameters:
BotId (long)
Token (string)
ServerCount (int)
```


Example Usage:

```
var ddbl = new DDBL()
{
  BotId = BOT ID HERE,
  Token = "TOKEN HERE"
};

ddbl.PostStats(SERVER COUNT HERE);
```

