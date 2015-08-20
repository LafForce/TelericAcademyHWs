/* Task Description */
/* 
 *	Create a module for working with books
 *	The module must provide the following functionalities:
 *	Add a new book to category
 *	Each book has unique title, author and ISBN
 *	It must return the newly created book with assigned ID
 *	If the category is missing, it must be automatically created
 *	List all books
 *	Books are sorted by ID
 *	This can be done by author, by category or all
 *	List all categories
 *	Categories are sorted by ID
 *	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
 *	When adding a book/category, the ID is generated automatically
 *	Add validation everywhere, where possible
 *	Book title and category name must be between 2 and 100 characters, including letters, digits and special
 *	characters ('!', ',', '.', etc)
 *	Author is any non-empty string
 *	Unique params are Book title and Book ISBN
 *	Book ISBN is an unique code that contains either 10 or 13 digits
 *	If something is not valid - throw Error
 */
function solve() {
    var library = (function () {
                var books = [];
                var categories = [];

                function addBook(title, ISBN, author, cathegory) {

                    var regexISBNchk = /^(\d{10}?)$|^(\d{13}?)$/;

                    if (addBook.arguments.length != 4) {
                        throw Error('An argument is missing!');
                    }
                    if (title.length > 100 || title.length < 2) {
                        throw Error('Name is too short or long!')
                    }
                    if (category.length > 100 || category.length < 2) {
                        throw Error('Category is too short or long!')
                    }
                    if (!regexISBNchk.test(ISBN)) {
                        throw Error('ISBN is not right!');
                    }
                    for (var obj in books) {
                        if (obj.title == title) {
                            throw Error('Such a book already exists!');
                        }
                    }
                    if (!(author.length > 0)) {
                        throw Error('There must be an author!');
                    }
                    if (!(category.indexOf(categories) > -1)) {
                        category.ID = categories.length + 1;
                        categories.push(category);
                    }

                    cathegory = {
                        title: cathegory,
                        ID: cathegory.ID
                    }

                    book = {
                        title: title,
                        author: author,
                        ISBN: ISBN
                    }

                    books.push(book);
                    book.ID = books.length + 2;
                    return book;
                }


                function listBooks() {
                    return books;
                }

                function listCategories() {
                    return categories;
                }

                return {
                    books: {
                        list: listBooks,
                        add: addBook
                    },
                    categories: {
                        list: listCategories
                    }
                };
            }
            ()
        )
        ;
    return library;
}
module.exports = solve;
