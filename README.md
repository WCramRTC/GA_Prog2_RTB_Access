# GA_Prog2_RTB_Access

![Final Result](Images/Final_Result.png)

---
This assignment to get comfortable working with the Editor control. This control is a large textbox for long messages ( like a paragraph or essay )

## Step 1
1. Create a new Maui project
2. Clear template code on MainPage.xaml and MainPage.xaml.cs
3. Add Git, commit, and push your repo online

## Step 2 - Add a Label and an Editor window

1. Add a label.
    1. Change it's Text attribute to "Display Box"
2. Add an Editor `<Editor />`
    2. Set the following attribute
    - x:Name="editDisplay" - This Gives our editor a name of editDisplay
    - IsEnabled="False" <!--- This prevents people from writing in the editor. We are using this editor to just show information.
    

```xml

   <Label 
        Text="Display Box"   
        />
    <Editor 
        x:Name="editDisplay"
        IsEnabled="False"
        />
```

---
```xml
    <!-- Editor, Label, Button, Entry -->
    <Label 
        Text="Display Box"   
        />
    <Editor 
        x:Name="editDisplay"
        IsEnabled="False"
        />
    <Label
        Text="User Input - Short Message" 
        />
    <Entry 
        x:Name="entDisplayMessage"       
        />
    <Button
        Text="Display Short Message from Entry"
        x:Name="btnDisplayShortMessage"
        Clicked="btnDisplayShortMessage_Clicked" />
    <Button
        Text="Append Short Message from Entry"
        x:Name="btnAppendShortMessage"
        Clicked="btnAppendShortMessage_Clicked" />

    <Label 
        Text="User Input - Editor (Long Message)"
        />
    <Editor 
        x:Name="editUserLongMessage"
                
        />
    <Button
        Text="Append Long Message From Editor"
        x:Name="btnAppendLongMessage"
        Clicked="btnAppendLongMessage_Clicked" />
    <Button
        Text="Clear both Editors"
        x:Name="btnClear"
        Clicked="btnClear_Clicked" />

```

```csharp
    // This display short message click event should replace the text in the editor
    private void btnDisplayShortMessage_Clicked(object sender, EventArgs e)
    {
        string displayMessage = entDisplayMessage.Text;

        editDisplay.Text = displayMessage;
    }

    // The Append short Message event should append the text ( append )
    private void btnAppendShortMessage_Clicked(object sender, EventArgs e)
    {
        string displayMessage = entDisplayMessage.Text;

        editDisplay.Text += displayMessage;
    }

    // This will append the message from our editor ( for long messages )
    private void btnAppendLongMessage_Clicked(object sender, EventArgs e)
    {
        string longMessageToAppend = editUserLongMessage.Text;

        editDisplay.Text += longMessageToAppend;
    }

    // Clear - Clears all text inputs. Both Editors and the Entry
    private void btnClear_Clicked(object sender, EventArgs e)
    {
        entDisplayMessage.Text = "";
        editDisplay.Text = "";
        editUserLongMessage.Text = "";
    }

```

--- 

### 1. Label - "Display Box"
Control Type: Label

Purpose: Displays static text as a heading for an Editor control.

### 2. Editor - editDisplay
Control Type: Editor

Attributes:
`x:Name="editDisplay"` - Identifier for referencing in code.

`IsEnabled="False"` - Not editable, for display only.
### 3. Label - "User Input - Short Message"

Control Type: Label

Purpose: Serves as an instruction or heading for the Entry field.

### 4. Entry - entDisplayMessage

Control Type: Entry

Attributes:
`x:Name="entDisplayMessage"` - Identifier for input field.

### 5. Button - "Display Short Message from Entry"

Control Type: Button

Attributes:

Text="Display Short Message from Entry" - Display text.

`x:Name="btnDisplayShortMessage"` - Button identifier.

Clicked="btnDisplayShortMessage_Clicked" - Event handler for click.

Behavior: Displays text from entDisplayMessage in editDisplay upon click.

### 6. Button - "Append Short Message from Entry"

Attributes: Similar to the previous button but for appending text.

### 7. Label - "User Input - Editor (Long Message)"

Control Type: Label

### 8. Editor - editUserLongMessage

Control Type: Editor

Attributes:

`x:Name="editUserLongMessage"` - Identifier for the editor.

### 9. Button - "Append Long Message From Editor"

Behavior: Appends text from editUserLongMessage to editDisplay.

### 10. Button - "Clear both Editors"

Behavior: Clears text from both editDisplay and editUserLongMessage.

**Summary**

The layout includes text input fields (Entry and Editor) and Buttons for actions based on the input.

Labels provide user guidance.

Functionality like appending text or clearing fields is defined in the event handlers in the code-behind file.
