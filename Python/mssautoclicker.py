import pyautogui
import time
import keyboard

# Global variable to track the script state
script_active = False

# Function to toggle script state
def toggle_script():
    global script_active
    script_active = not script_active

# Get the current mouse position
original_position = pyautogui.position()

# Register the 'i' key to toggle the script
keyboard.add_hotkey('i', toggle_script)

while True:
    if script_active:
        # Press the Escape key
        pyautogui.press('esc')

        # Pause for a moment (adjust as needed)
        time.sleep(10)

        # Get the screen dimensions
        screen_width, screen_height = pyautogui.size()

        # Calculate the middle of the screen
        middle_x = screen_width // 2
        middle_y = screen_height // 2

        # Move the mouse to the middle of the screen and click
        pyautogui.moveTo(middle_x, middle_y)
        pyautogui.click()

        # Pause for a moment (adjust as needed)
        time.sleep(10)

        # Move the mouse back to the original position
        pyautogui.moveTo(original_position)

