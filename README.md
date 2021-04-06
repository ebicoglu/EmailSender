# EmailSender
A basic .NET5 Windows Forms application for testing purposes.

![Screenshot](https://user-images.githubusercontent.com/9526587/113730500-a04b0f80-9700-11eb-942a-1c51ebeb90bb.png)

Email Sender is using `System.Net.Mail` class.

The default settings are configured for Gmail.

You need to fill the configuration file `App.config` before sending email.

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <appSettings>

    <add key="Host" value="smtp.gmail.com"/>
    <add key="Port" value="587"/>
    <add key="FromEmail" value="your.email@gmail.com"/>
    <add key="FromDisplayName" value="John Doe"/>
    <add key="Password" value="ENTER-YOUR-PASSWORD"/>
    <add key="ToEmail" value="michael.jackson@sample.com"/>
    <add key="ToDisplayName" value="Michael Jackson"/>
    <add key="Subject" value="My subject"/>
    <add key="Body" value="This is a test email!"/>
    <add key="EnableSsl" value="True"/>
    <add key="IsBodyHtml" value="True"/>

  </appSettings>
</configuration>
```

