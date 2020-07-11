# StoryBoard

/************************************************* Problem *************************************************
 * This version of the Storyboard contains arbitrary many notes (imagine it like putting sticky notes on the board).

 * Every note has a title, a text and a set of tags. E.g.
  	- title: "Test Traceplayer"
  	- text: "Implement a unit test for the class Traceplayer of the spark core framework."
  	- tags: {"unit test", "traceplayer", "testing", "spark core"}

 * Storyboard should enable us to search for notes by title, text and tags.
 * E.g.:
 *    searchByTitle("Test Traceplayer")
 *   	searchByTag({"testing", "unit test"})
 *   	searchByText("Implement a unit test for the class Traceplayer of the spark core framework.")

 

* For the sake of simplicity only an exact match should give results.
