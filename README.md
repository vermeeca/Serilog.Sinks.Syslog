A syslog Sink for Serilog. H/T to the [NLog implementation](https://github.com/graffen/NLog.Targets.Syslog), from which this project is based.

[![Build status](https://ci.appveyor.com/api/projects/status/m0ddfuej6doeun97?svg=true)](https://ci.appveyor.com/project/vermeeca/serilog-sinks-syslog)

## Configuration

```CSharp
Log.Logger = new LoggerConfiguration()
    .WriteTo.Syslog("localhost", 514)
    .CreateLogger();
```

### Options
Only two options are required: `syslogserver` and `port`.

Two others are optional:
* `batchsize` : The default batch size of messages that the serilog sink should send.
* `batchPeriodInSeconds` : The interval (in seconds) after which the sink should flush.
