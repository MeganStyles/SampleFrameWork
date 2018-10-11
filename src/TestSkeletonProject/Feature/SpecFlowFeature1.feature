Feature: Edit blog's and posts

@Test
Scenario Outline: Add a new blog
	Given There is 'NumberOfBlogs' existing blog
	When Another url 'AddedBlogs' blogs are added
	Then There is 'FinalNumberOfBlogs' after

Examples: 
| NumberOfBlogs | AddedBlogs                        | FinalNumberOfBlogs |
| 1             | Megan's second awesome blog.co.nz | 2                  |
| 2             | Craigsblog.com                    | 3                  |