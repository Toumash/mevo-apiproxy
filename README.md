# Mevo Bike Api Proxy

This program downloads current mevo bikes rental places, and shows only the available ones.  


## Requirements

Google chrome installed
chromedriver.exe downloaded into build folder. It needs to match your version.  
I'm providing you a Chrome 75  
List of Google Chrome Drivers available from Google is [here](http://chromedriver.chromium.org/downloads)

## How to run?


```
PS C:\repo\mevo.dashboard\mevo.apiproxy> dotnet run
Starting ChromeDriver 75.0.3770.90 (a6dcaf7e3ec6f70a194cc25e8149475c6590e025-refs/branch-heads/3770@{#1003}) on port 1994
Only local connections are allowed.
Please protect ports used by ChromeDriver and related test frameworks to prevent access by malicious code.

DevTools listening on ws://127.0.0.1:1997/devtools/browser/5f48489a-b285-4203-ac2a-a80a9f19a1cb
[0622/152437.195:INFO:CONSOLE(2)] "JQMIGRATE: Migrate is installed, version 1.4.1", source: https://rowermevo.pl/wp-includes/js/jquery/jquery-migrate.min.js?ver=1.4.1 (2)
[0622/152438.219:INFO:CONSOLE(382)] "zoomed", source: https://rowermevo.pl/wp-content/themes/okitheme/assets/map.osm.js?ver=1.0.580.30306600%201561209877 (382)
[{"bike_numbers":["600091"],"bike":false,"lat":54.374549665,"lng":18.627224058333},{"bike_numbers":["98262"],"bike":false,"lat":54.389476115,"lng":18.59372332},{"bike_numbers":["98482"],"bike":false,"lat":54.40189596,"lng":18.576254213333},{"bike_numbers":["98327","98326","98209","98144"],"bike":false,"lat":54.355335863333,"lng":18.528275468333},{"bike_numbers":["98152"],"bike":false,"lat":54.322749656667,
...(cut for brevity)
```

## Development ideas

- Bikes dashboard (to find bikes faster)
- Bikes location prediction and following (each bike has unique ID)


