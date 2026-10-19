# Baobab Ridge Wildlife Rehabilitation Centre

A C# Windows Forms desktop application developed for the PRG282 project to manage animal patient records, monitor rehabilitation progress, and export facility summary reports for the Baobab Ridge Wildlife Rehabilitation Centre.

## Overview

The application gives rehabilitation staff and caretakers a simple interface to track admitted wildlife patients. All records are stored locally in a text file (`animals.txt`), allowing staff to view, search, add, update, and delete patient records without needing an external database server. The system also calculates facility-wide statistics and exports them to a `summary.txt` file.

## Features

- **Record Management (CRUD)**:
  - **View Records**: Displays all admitted animals in a `DataGridView` table showing ID, Name, Species, Age, Recovery Score, Status, and Housing Unit.
  - **Add Animal**: Register new rescues with validation for unique IDs, required text fields, and valid numerical ranges.
  - **Search**: Search for any animal by ID. The matched animal is selected in the table, its details are loaded into the form fields, and the form switches into edit mode.
  - **Update**: Edit details (name, species, age, recovery score) of an existing animal and save changes back to the text file.
  - **Delete**: Remove a selected animal record from both the table and the file.
  - **Clear Fields**: Quickly reset inputs back to default state and return to add mode.

- **Automated Health & Housing Classification**:
  Classifies an animal's status and housing unit based on their recovery score:
  - **1 – 50**: Critical | Intensive Care Unit (ICU)
  - **51 – 79**: Stable | General Ward
  - **80 – 100**: Ready for Release | Pre-Release Enclosure

- **Summary Report Generator**:
  - Computes total animal count, average patient age, average recovery score, and breakdowns by status (Critical, Serious, Stable, Recovering, Release-Ready).
  - Displays statistics directly in the interface.
  - Generates and overwrites a formatted `summary.txt` report in the application's base directory with a timestamp.

- **Error Handling & Input Validation**:
  - Validates numeric inputs for age (0–100) and recovery scores (0–100).
  - Prevents duplicate animal IDs.
  - Catches corrupted or improperly formatted lines when reading `animals.txt`.
  - Handles file I/O exceptions, file lock issues, and permission errors with descriptive message boxes.

## Data Format

Animal records are persisted in `animals.txt` using pipe-delimited (`|`) values:

AnimalID|Name|Species|Age|RecoveryScore|Status|HousingUnit

Example records:

WR-0001|Thabo|African Penguin|4|85|Release-Ready|Pre-Release Camp

WR-0002|Naledi|Serval|3|62|Recovering|Outdoor Enclosure

WR-0003|Zola|Cape Vulture|12|19|Critical|Intensive Care Unit

The generated `summary.txt` report contains:
- Facility header and generation timestamp
- Total animal count
- Average age and recovery score
- Tally of animals per status category

### Running the Application

1. Clone or download this repository.
2. Open `BoababRidgeWildlife.sln` in Visual Studio 2022.
3. Make sure the solution build configuration is set to `Debug` (or `Release`) and target `Any CPU`.
4. Press `F5` or click **Start** to run the program.
