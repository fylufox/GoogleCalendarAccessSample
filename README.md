# GoogleCalendarAccessSample
## Overview
A sample of access to google calendar.  

## Enviroment
Framework : netcore 3.1  

## Usage
download dll [her](https://github.com/fylufox/GoogleCalendarAccessSample/releases). (later date)  
Register a dll to the project.  
add code.
``` c#
using GoogleCalendarAccess;
```
Authentication Information to access the Google API in the project.  
Available authentication information.  
- OAuth2.0 Client ID  
- Service Account's key  

## Reference
### Class
There are three class, GoogleCalendar,Serviceaccount and Myaccount.  
To use the Auth2.0 client ID, use Myaccount class.  
To use the Service Acoount, use Serviceaccount class. 
If you use the Serviceaccount class, be sure to specify the calendar ID.
If you want to use any other credentials, inherit the GoogleCalendar class, override the Authenticate method, and store the CalendarService in the local variable _service.  
The Myaccount and Serviceaccount classes inherit from the GoogleCalendar class.

### Struct
- ReadingRequest  
  Property of the GetEventList Method.  
  | name | type | note |
  | ---- | ---- | ---- |
  | calendar_id | string | calling calendar id |
  | enable_filter | bool | Filter by date |
  | start_filter | datetime | Filter start date |
  | end_filter | datetime | Filter end date |
  | number_of_event | int | Maximum number of calls <br> max 2500 |
- CalendarEvent
  Abbreviated event.  
  | name | type | note |
  | ---- | ---- | ---- |
  | summary | string | Event Title |
  | id | string | Event ID |
  | dateonly | bool | All day setting |
  | start | datetime | start time |
  | end | datetime | end time |
  | color | string | Event color id | 
  | description | string | Event description |
  | location | string | Event location |
- Calendarlist
  Calendar list Response.  
  | name | type | note |
  | ---- | ---- | ---- |
  | summary | string | Calendar name |
  | id | string | Calendar id |

### Enumeration
- Access
  OAuth 2.0 Scopes
  about the scope of OAuth2.0, click [her](https://developers.google.com/identity/protocols/oauth2/).  
  | Name | Note |
  | -- | -- |
  | FULLACCESS | All permissions for the calendar. <br> https://www.googleapis.com/auth/calendar |
  | READONLY | Read permissions for the calendar. <br>  https://www.googleapis.com/auth/calendar.readonly |

### Method
#### Constructor
GoogleAPI Authentication.  
- paramater
  | name | type | note |
  | -- | -- | -- |
  | app_name | string | Application name to register Google. |
  | scorp | Access | OAuth 2.0 scope. |
  | jsonpath | string | Path for credential file. |
#### GetEventList
Get a list if events.  
- paramater
  | name | type | note |
  | -- | -- | -- |
  | reading_request | ReadingRequest | Properties. |
- Response
  CalendarEvent[]  
  Obtained Events.  
#### ReadEvent
Geting detailed event information from an event ID.  
- paramater
  | name | type | note |
  | -- | -- | -- |
  | event_id | string | ID of the event to be get. |
  | (option) |
  | calendar_id | string | Calendar ID of the event to be get. |
- Response
  Google.Apis.Calendar.v3.data.Event  
  Obttained Events.  
#### AddCalendarEvent
Add a new event to your calendar.  
- paramater
  | name | type | note |
  | -- | -- | -- |
  | add_item | CalendarEvent | Event to be added. |
  | (option) |
  | calendar_id | Calendar ID of insertion destination. |
- Response
  CalendarEvent  
  Event to be added.  
#### UpdateEvent
Update the content of event.  
- paramater
  | name | type | note |
  | -- | -- | -- |
  | event_id | string | event ID to update the content. |
  | new_event | CalendarEvent | contents of update. |
  | (option) |
  | calendar_id | Calendar ID of update destination. |
- Response
  No response.  
#### DeleteEvent
Delete the spocified event.  
- paramater
  | name | type | note |
  | -- | -- | -- |
  | event_id | string | event ID to be deleted. |
  | (option) |
  | calendar_id | Calendar ID of delete destination. |
- Response
  No response.  
### Myaccount class Method
#### ReAuthenticate
Delete access token and re-authenticate.  
#### GetColorList
Get the color definitions for chalendars and events.  
- Response
  string[,]
  Returns the color definition as a 2D array of [Background,Foreground].  
  The index of the first dimension the array is the color ID.  

## Author
fylufox

## License
under [MIT license](https://en.wikipedia.org/wiki/MIT_License).
