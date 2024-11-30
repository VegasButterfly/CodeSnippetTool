# **Code Snippet Tool**


The Code Snippet Tool is a Windows Forms application designed to help developers manage, analyze, and translate code snippets efficiently. This tool integrates with OpenAI's APIs to provide AI-driven analysis.



**Features**

- Code Snippet Management: Add, update, and save code snippets with metadata like language and description.
- AI-Powered Code Analysis: Analyze your code snippets using OpenAI's advanced models to determine their purpose or functionality.
- User authentication with password salting and hashing. Context searching. Multi-relational modelling for future functionality.
- SQLite Database Integration: Persist your data securely using SQLite for offline access.
  
---

**Installation**

1. Download the CodeSnippetTool.zip
2. Extract the downloaded zip file to your chosen location.
3. Locate and run (double-left-click) the “CodeSnippetTool.exe” executable file.

---

## **How to Use**



**Logon**

1. There are two users currently loaded into this system upon the first run.

> Username: Admin

> Password: Admin123\*

> Username: Demo

> Password: Demo123\*

2. Enter Username and Password into the logon screen.
3. This will open the main screen.
4. On the logon screen, there are two hyperlinks in the bottom right corner. These will open a new browser window or tab (depending on your system default behavior and browser) to the associated websites.

---

**Main screen**

1. The main screen will initially show a grid with two preloaded sample snippets. 
2. Navigation items on this screen are;
    -  Tab interface above the display grid with Snippets, Users or Settings.
    -  A search input box and search button are used for context searching. This search bar will search the saved code snippets Names and Descriptions for the input text.
    -  A program exit button which closes the application.
    -  An “Add Snippet” button which will take you to the “Snippet Form” which allows entry of a new code snippet into the system.
    -  A “Load Selected Snippet” button which will load a selected code snippet and open the “Snippet Form”.
    -  A “Refresh/List All” button which refreshes the data grid. The grid will refresh itself if changes are made or if searching. This button is included if you wish to refresh and list all snippets after using the search.
      
---

**Snippet Management**

1. Open the Snippet Form by clicking on the “Add Snippet” or selecting a snippet in the main data grid and clicking on “Load Selected Snippet”.
2. This will open either a new “Snippet Form” or the one for the associated snippet. 
3. Fill in the details for the snippet:
    - Name: Give your snippet a meaningful title.
    - Description: Add a brief description of the snippet.
    - Language: Choose the programming language from the dropdown.
    - Code: Paste your code snippet in the text box.
4. Click Save to save the snippet.

**AI Analysis**

1. Enter the code snippet text and select the language.
2. Click the Analyze button.
3. The tool will call the OpenAI API and populate the analysis in the AnalysisText field.

**Note: The analysis is not saved automatically. Use the Save button to persist it.**

---

**Dependencies**

- **SQLite**: For local data persistence.
- **OpenAI API**: For AI-driven analysis.
- **Windows Forms**: For the user interface.
- **.NET Framework**: Targeting Windows environments.
  
---

**License**

This project is licensed under the MIT License.

---

**Contact**

For issues or inquiries:

- Email: [aamoretti3000@limestone.edu](mailto:aamoretti3000@limestone.edu) or [alexandriadianaroberts@gmail.com](mailto:alexandriadianaroberts@gmail.com)
- GitHub: [VegasButterfly](https://github.com/VegasButterfly)
