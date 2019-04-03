# DDBLSharp
Divine Discord Bot List API in C#

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

