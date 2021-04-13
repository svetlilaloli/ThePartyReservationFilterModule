Console Application<br>
Exercises: Functional Programming
# ThePartyReservationFilterModule
You need to implement a filtering module to a party reservation software. First, to the Party Reservation Filter Module (PRFM for short) is __passed a list__ with invitations. Next the PRFM receives __a sequence of commands__ that specify whether you need to add or remove a given filter.


Each PRFM command is in the given format:


"__{command;filter type;filter parameter}__"


You can receive the following PRFM commands: 
- "__Add filter__"
- "__Remove filter__"
- "__Print__" 


The possible PRFM filter types are: 
- "__Starts with__"
- "__Ends with__"
- "__Length__"
- "__Contains__"


All PRFM filter parameters will be a string (or an integer only for the "__Length__" filter). Each command will be valid e.g. you won’t be asked to remove a non-existent filter. The input will __end__ with a "__Print__" command, after which you should print all the party-goers that are left after the filtration. See the examples below:
## Examples
Input|Output
-----|------
Peter Misha Slav<br>Add filter;Starts with;P<br>Add filter;Starts with;M<br>Print|Slav
Peter Misha John<br>Add filter;Starts with;P<br>Add filter;Starts with;M<br>Remove filter;Starts with;M<br>Print|Misha John
