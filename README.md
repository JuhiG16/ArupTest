## ArupTest
Emphasis is on the overall design & testing. UI appearances not critical.
Given a small list of positions and candidates, produce an ASP.NET MVC API that allows searching of candidates to match a given position, and a small JavaScript / HTML client to talk to facilitate the search.
Positions stored as a collection. A position has a list of desirable skills and candidates have a list of skills. The best candidate for a position is the one with the most matching attributes. Skills are not weighted. Skills could be treated as a collection of strings for simplicity.
Data may be static and read only, but should be served up to the MVC controllers as repository classes using dependency injection / inversion of control.
Please unit test where possible.
