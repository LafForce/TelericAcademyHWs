/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

AddingElemrents

function () {
  return function (element, contents) {
    var root,
      div,
      container,
      i = 0,
      contentsLength = contents.length;

    if (!element || !contents || element === ' ' || contents[0] === ' ') {
      throw new Error('Any of the function params is missing');
    }

    if (contents.some(function (argument) {
      return typeof argument !== 'string' && typeof argument !== 'number';
    })) {
      throw Error("Any of the contents is neight `string` or `number`");
    }

    if (typeof element === 'string') {
      root = document.getElementById(element);
      if (root === null) {
        throw new Error('The provided id does not select anything (there is no element that has such an id)');
      }
    } else if (element instanceof HTMLElement) {
      root = element;
    } else {
      throw new Error('The provided first parameter is neither string or existing DOM element');
    }

    while (root.lastChild) {
      root.removeChild(root.lastChild);
    }
    container = document.createDocumentFragment();
    for (i; i < contentsLength; i++) {
      div = document.createElement('div');
      div.innerHTML = contents[i];
      container.appendChild(div);
    }
    root.appendChild(container);
  };
};