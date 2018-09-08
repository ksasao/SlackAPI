# SlackAPI

This is a third party implementation of Slack's API written in C#. This supports their WebAPI aswell as their Real Time Messaging API.

Original source code was implemented by Inumedia.

See: https://github.com/Inumedia/SlackAPI

# About this repository

This repo has some changes as follows:

- Add Slack Real Time Messaging API example for C#
  - https://github.com/ksasao/SlackAPI/blob/master/RealtimeExample/Program.cs
- Support attachments propertiy, which is used by some service such as IFTTT
- Add RawMessage propertiy to get raw JSON data from Slack
