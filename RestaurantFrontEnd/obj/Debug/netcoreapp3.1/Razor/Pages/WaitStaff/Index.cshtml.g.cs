#pragma checksum "/Users/alife/Other/CS420Project/RestaurantFrontEnd/Pages/WaitStaff/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cd27890466359b51f611e06818c6d71959f3494"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RestaurantFrontEnd.Pages.WaitStaff.Pages_WaitStaff_Index), @"mvc.1.0.razor-page", @"/Pages/WaitStaff/Index.cshtml")]
namespace RestaurantFrontEnd.Pages.WaitStaff
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/alife/Other/CS420Project/RestaurantFrontEnd/Pages/_ViewImports.cshtml"
using RestaurantFrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cd27890466359b51f611e06818c6d71959f3494", @"/Pages/WaitStaff/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d604ee56b1ee77fb7b5cd928741852730b0660c4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_WaitStaff_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    .tableNumberStyle {
        width: 3rem;
    }

    h3, form {
        width: 100%;
    }
</style>
<h1 style=""margin-bottom:3rem;"">Waitstaff</h1>
<div class=""row"">
    <div class=""col-5"">
        <!-- Place orders -->
        <div class=""row"">
            <h3>Order Form</h3>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cd27890466359b51f611e06818c6d71959f34944692", async() => {
                WriteLiteral(@"
                <div class=""form-group"">
                    <label for=""tableNumber"">Table Number</label>
                    <input type=""number"" class=""form-control"" id=""tableNumber"" placeholder=""Table Number"">
                </div>
                <div class=""form-group"">
                    <label for=""orderType"">Drink or Food</label>
                    <select onchange=""menuChange()""  class=""custom-select"" id=""orderType"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cd27890466359b51f611e06818c6d71959f34945426", async() => {
                    WriteLiteral("Choose...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cd27890466359b51f611e06818c6d71959f34946978", async() => {
                    WriteLiteral("Drink");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cd27890466359b51f611e06818c6d71959f34948206", async() => {
                    WriteLiteral("Food");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                </div>
                <div class=""form-group"">
                    <div id=""orderEntry"">
                        <label for=""order"">Order</label>
                        <select class=""custom-select orderItem order"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cd27890466359b51f611e06818c6d71959f34949709", async() => {
                    WriteLiteral("Choose Order Type First");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        </select>\n                    </div>\n                </div>\n                <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <button id=""addButton"" onclick=""addEmptyItem()"" class=""btn btn-secondary"">Add Order Item</button>
        </div>
        <!-- Seated Tables -->
        <div class=""row"">
            <h3>Seated Tables</h3>
            <table class=""table table-striped"">
                <thead class=""thead-dark"">
                    <tr>
                        <th scope=""col"">Table Number</th>
                        <th scope=""col"">Guests</th>
                        <th scope=""col"">Remove</th>
                    </tr>
                </thead>
                <tbody id=""availableTableTableBody"">
                    <tr>
                        <th scope=""row"">23</th>
                        <td>4</td>
                        <td onclick=""deleteTableRow(this)""><button type=""button"" class=""btn btn-danger"">X</button></td>
                    </tr>
                    <tr>
                        <th scope=""row"">24</th>
                        <td>2</td>
                        <td onclick=""deleteTableRow(this)""><bu");
            WriteLiteral(@"tton type=""button"" class=""btn btn-danger"">X</button></td>
                    </tr>
                    <tr>
                        <th scope=""row"">26</th>
                        <td>8</td>
                        <td onclick=""deleteTableRow(this)""><button type=""button"" class=""btn btn-danger"">X</button></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
    <div class=""col-2""></div>
    <div class=""col-5"">
        <!-- Drinks ready -->
        <div class=""row"">
            <h3>Drinks Ready</h3>
            <table class=""table table-striped"">
                <thead class=""thead-dark"">
                    <tr>
                        <th scope=""col"">Table Number</th>
                        <th scope=""col"">Drinks</th>
                        <th scope=""col"">Remove</th>
                    </tr>
                </thead>
                <tbody id=""drinkTableBody"">
                    <tr>
                        <th scope=""row"">23</th>
                        ");
            WriteLiteral(@"<td>
                            <p value=""2"">Coke</p>
                        </td>
                        <td onclick=""deleteDrinkRow(this)""><button type=""button"" class=""btn btn-danger"">X</button></td>
                    </tr>
                    <tr>
                        <th scope=""row"">24</th>
                        <td>
                            <p value=""2"">Lemonade</p>
                        </td>
                        <td onclick=""deleteDrinkRow(this)""><button type=""button"" class=""btn btn-danger"">X</button></td>
                    </tr>
                    <tr>
                        <th scope=""row"">26</th>
                        <td>
                            <p value=""2"">Sweet Tea</p>
                            <p value=""2"">Lemonade</p>
                        </td>
                        <td onclick=""deleteDrinkRow(this)""><button type=""button"" class=""btn btn-danger"">X</button></td>
                    </tr>
                </tbody>
            </table>
        </div>
        <!-- ");
            WriteLiteral(@"Foods ready -->
        <div class=""row"">
            <h3>Food Ready</h3>
            <table class=""table table-striped"">
                <thead class=""thead-dark"">
                    <tr>
                        <th scope=""col"">Table Number</th>
                        <th scope=""col"">Food</th>
                        <th scope=""col"">Remove</th>
                    </tr>
                </thead>
                <tbody id=""foodTableBody"">
                    <tr>
                        <th scope=""row"">23</th>
                        <td>
                            <p value=""16"">Chicken Alfredo</p>
                        </td>
                        <td onclick=""deleteFoodRow(this)""><button type=""button"" class=""btn btn-danger"">X</button></td>
                    </tr>
                    <tr>
                        <th scope=""row"">24</th>
                        <td>
                            <p value=""18"">Steak Alfredo</p>
                        </td>
                        <td onclick=""deleteFoodRo");
            WriteLiteral(@"w(this)""><button type=""button"" class=""btn btn-danger"">X</button></td>
                    </tr>
                    <tr>
                        <th scope=""row"">26</th>
                        <td>
                            <p value=""15"">Eggplant Parmigiana</p>
                            <p value=""16"">Asiago Tortelloni Alfredo with Grilled Chicken</p>
                        </td>
                        <td onclick=""deleteFoodRow(this)""><button type=""button"" class=""btn btn-danger"">X</button></td>
                    </tr>
                </tbody>
            </table>
        </div>

    </div>
</div>

<!-- Common scripts -->
<script>
    function sleep(ms) {
        return new Promise(resolve => setTimeout(resolve, ms));
    }

    function getRandomInt(max) {
        return Math.floor(Math.random() * Math.floor(max));
    }
</script>

<!-- Menu Scripts -->
<script>
    //console.log(orderType.value); // 0, 1, or 2

    function menuItem(item, price) {
        let menu = document.getElementById(""orderEntr");
            WriteLiteral(@"y"");
        menu = menu.children[menu.children.length - 1];
        let newInput = document.createElement(""option"");
        let node = document.createTextNode(item);
        newInput.value = price.toString();
        newInput.appendChild(node);
        menu.appendChild(newInput);
    }

    function menuChange() {
        let orderType = document.getElementById(""orderType"");
        let menu = document.getElementById(""orderEntry"");
        menu = menu.children[menu.children.length - 1];

        while (menu.childNodes.length > 0) {
            menu.removeChild(menu.childNodes[0])
        }

        if (orderType.value == ""0"") {
            menuItem(""Choose Order Type First"", 0);
        } else if (orderType.value == ""1"") {
            menuItem(""Coke"", 2);
            menuItem(""Diet Coke"", 2);
            menuItem(""Orange"", 2);
            menuItem(""Dr Pepper"", 2);
            menuItem(""Lemonade"", 2);
            menuItem(""Sweet Tea"", 2);
            menuItem(""Unsweet Tea"", 2);
        } else if (orderType.v");
            WriteLiteral(@"alue == ""2"") {
            menuItem(""Chicken Alfredo"", 16);
            menuItem(""Steak Alfredo"", 18);
            menuItem(""Seafood Alfredo"", 18);
            menuItem(""Eggplant Parmigiana"", 15);
            menuItem(""Asiago Tortelloni Alfredo with Grilled Chicken"", 16);
            menuItem(""Five Cheese Ziti al Forno"", 15);
            menuItem(""Chicken and Gnocci Soup"", 14);
        }
    };
</script>

<!-- Order scripts -->
<script>
    const form = document.getElementById('form');
    form.addEventListener('submit', newOrder);

    function addEmptyItem() {
        let order = document.getElementById(""orderEntry"");
        let newInput = document.createElement(""select"");
        newInput.classList.add(""custom-select"");
        newInput.classList.add(""orderItem"");
        newInput.classList.add(""order"");
        let node = document.createTextNode(""Coke"");
        newInput.appendChild(node);
        order.appendChild(newInput);
        menuChange();
    }

    function newOrder(event) {
        event.preve");
            WriteLiteral(@"ntDefault();

        // get the form elements
        let tableBox = document.getElementById(""tableNumber""); let orderBox = document.getElementById(""orderEntry""); let typeOfOrderBox = document.getElementById(""orderType"");

        // get the values of the form elements
        let tableNumber = tableBox.value; let typeOfOrder = typeOfOrderBox.value; let orderItems = [[]];
        for (var i = 1; i < orderBox.children.length; i++) {
            orderItems[0].push([orderBox.children[i].selectedOptions[0].text, orderBox.children[i].selectedOptions[0].value]);
        } // orderBox[0].children[0].value

        // remove values from boxes after getting the values
        while (orderBox.children.length > 1) {
            if (orderBox.childNodes[0].nodeName != ""LABEL"") {
                orderBox.removeChild(orderBox.childNodes[0]);
            } else if (orderBox.childNodes[0].nodeName == ""LABEL"") {
                orderBox.removeChild(orderBox.childNodes[1]);
            }
        }
        tableBox.value = """"; ");
            WriteLiteral(@"typeOfOrderBox.selectedIndex = 0;
        addEmptyItem();

        // post the order to Bartender or Kitchen api
        if (typeOfOrder == ""1"") {
            var xhr = new XMLHttpRequest();
            xhr.open(""POST"", ""https://localhost:44449/api/Source/HaveDrinkOrder"", true);
            xhr.setRequestHeader('Content-Type', 'application/json');
            xhr.send(JSON.stringify({ ""orderNumber"": getRandomInt(");
#nullable restore
#line 257 "/Users/alife/Other/CS420Project/RestaurantFrontEnd/Pages/WaitStaff/Index.cshtml"
                                                             Write(Int16.MaxValue);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"), ""tableNumber"": parseInt(tableNumber), ""drink"": orderItems, ""timeStamp"": new Date().toISOString() }));
        } else {
            var xhr = new XMLHttpRequest();
            xhr.open(""POST"", ""https://localhost:44449/api/Source/HaveFoodOrder"", true);
            xhr.setRequestHeader('Content-Type', 'application/json');
            xhr.send(JSON.stringify({ ""orderNumber"": getRandomInt(");
#nullable restore
#line 262 "/Users/alife/Other/CS420Project/RestaurantFrontEnd/Pages/WaitStaff/Index.cshtml"
                                                             Write(Int16.MaxValue);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"), ""tableNumber"": parseInt(tableNumber), ""food"": orderItems, ""timeStamp"": new Date().toISOString() }));
        }
    };
</script>

<!-- Scripts for Tables -->
<script>
    async function getAvailableTables() {
        let timer = 3;
        while (true) {
            var xhr = new XMLHttpRequest();
            xhr.open(""GET"", ""https://localhost:44449/api/Source/TableSeated"", true);
            var jsonResponse
            xhr.onreadystatechange = function () {
                if (xhr.readyState == 4) {
                    if (xhr.status == 200) {
                        var data = xhr.responseText;
                        jsonResponse = JSON.parse(data);

                        if (jsonResponse !== ""False"") {
                            jsonResponse = JSON.parse(jsonResponse);

                            var tableNumber = jsonResponse.TableNumber;
                            var guests = jsonResponse.Guests;

                            var newRowText = `
                                                <th");
            WriteLiteral(@" scope=""row"">${tableNumber}</th>
                                                <td>${guests}</td>
                                                <td onclick=""deleteTableRow(this)""><button type=""button"" class=""btn btn-danger"">X</button></td>
                                             `

                            var list = document.getElementById(""availableTableTableBody"");
                            var newRow = list.insertRow(list.rows.length);
                            newRow.innerHTML = newRowText;
                            if (timer >= .5) {
                                timer -= .25;
                            }
                        } else {
                            if (timer < 5) {
                                timer += .25;
                            }
                        }
                    }
                }
            };

            xhr.send(null);

            await sleep(timer * 1000);
        }
    }

    function deleteTableRow(x) {
        var list = document.ge");
            WriteLiteral(@"tElementById(""availableTableTableBody"");
        var row = x.parentElement;
        list.deleteRow(row.rowIndex - 1);
    }

    getAvailableTables()
</script>

<!-- Scripts for Drinks -->
<script>
    async function getDrinks() {
        let timer = 3;
        while (true) {
            var xhr = new XMLHttpRequest();
            xhr.open(""GET"", ""https://localhost:44449/api/Source/DrinkReady"", true);
            var jsonResponse
            xhr.onreadystatechange = function () {
                if (xhr.readyState == 4) {
                    if (xhr.status == 200) {
                        var data = xhr.responseText;
                        jsonResponse = JSON.parse(data);

                        if (jsonResponse !== ""False"") {
                            jsonResponse = JSON.parse(jsonResponse);

                            var tableNumber = jsonResponse.TableNumber;
                            var drink = jsonResponse.Drink;

                            var newRowText = `
                                  ");
            WriteLiteral(@"              <th scope=""row"">${tableNumber}</th>
                                                <td>
                                             `
                            for (var i = 0; i < drink.length; i++) {
                                drinkName = drink[i][0];
                                drinkPrice = drink[i][1];
                                newRowText += `
                                                        <p value=""${drinkPrice}"">${drinkName}</p>
                                             `
                            }


                            newRowText += `
                                                </td>
                                                <td onclick=""deleteDrinkRow(this)""><button type=""button"" class=""btn btn-danger"">X</button></td>
                                             `

                            var list = document.getElementById(""drinkTableBody"");
                            var newRow = list.insertRow(list.rows.length);
                  ");
            WriteLiteral(@"          newRow.innerHTML = newRowText;
                            if (timer >= .5) {
                                timer -= .25;
                            }
                        } else {
                            if (timer < 5) {
                                timer += .25;
                            }
                        }
                    }
                }
            };

            xhr.send(null);

            await sleep(timer * 1000);
        }
    }

    function deleteDrinkRow(x) {
        var list = document.getElementById(""drinkTableBody"");
        var row = x.parentElement;

        list.deleteRow(row.rowIndex - 1);
    }

    getDrinks()
</script>

<!-- Scripts for Foods -->
<script>
    async function getFoods() {
        let timer = 3;
        while (true) {
            var xhr = new XMLHttpRequest();
            xhr.open(""GET"", ""https://localhost:44449/api/Source/FoodReady"", true);
            var jsonResponse
            xhr.onreadystatechange = function () {
           ");
            WriteLiteral(@"     if (xhr.readyState == 4) {
                    if (xhr.status == 200) {
                        var data = xhr.responseText;
                        jsonResponse = JSON.parse(data);

                        if (jsonResponse !== ""False"") {
                            jsonResponse = JSON.parse(jsonResponse);

                            var tableNumber = jsonResponse.TableNumber;
                            var food = jsonResponse.Food;

                            var newRowText = `
                                                <th scope=""row"">${tableNumber}</th>
                                                <td>
                                             `
                            for (var i = 0; i < food.length; i++) {
                                foodName = food[i][0];
                                foodPrice = food[i][1];
                                newRowText +=`
                                                        <p value=""${foodPrice}"">${foodName}</p>
                          ");
            WriteLiteral(@"                   `
                            }


                            newRowText +=    `
                                                </td>
                                                <td onclick=""deleteFoodRow(this)""><button type=""button"" class=""btn btn-danger"">X</button></td>
                                             `

                            var list = document.getElementById(""foodTableBody"");
                            var newRow = list.insertRow(list.rows.length);
                            newRow.innerHTML = newRowText;
                            if (timer >= .5) {
                                timer -= .25;
                            }
                        } else {
                            if (timer < 5) {
                                timer += .25;
                            }
                        }
                    }
                }
            };

            xhr.send(null);

            await sleep(timer * 1000);
        }
    }

    function deleteF");
            WriteLiteral("oodRow(x) {\n        var list = document.getElementById(\"foodTableBody\");\n        var row = x.parentElement;\n\n        list.deleteRow(row.rowIndex - 1);\n    }\n\n    getFoods()\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestaurantFrontEnd.Pages.WaitStaff.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RestaurantFrontEnd.Pages.WaitStaff.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RestaurantFrontEnd.Pages.WaitStaff.IndexModel>)PageContext?.ViewData;
        public RestaurantFrontEnd.Pages.WaitStaff.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
