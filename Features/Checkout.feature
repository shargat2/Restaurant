Feature: Restaurant Checkout System

  Calculates the total bill including service charge and discounts based on item type and time.

  Scenario: Group of 4 orders full meals after 19
    Given a group of 4 orders 4 starters, 4 mains and 4 drinks at 20:00
    When the bill is requested
    Then the total bill should be 58.40

Scenario: Group of 4 orders full meals before 19
    Given a group of 4 orders 4 starters, 4 mains and 4 drinks at 17:00
    When the bill is requested
    Then the total bill should be 55.40

  Scenario: Group of 2 orders, then 2 join later
    Given a group of 2 orders 1 starters, 2 mains and 2 drinks at 18:00
    When the intermediate bill is requested
    Then the intermediate bill at step 1 should be 23.30
    Then later at 20:00 2 more join and order 2 mains and 2 drinks
    When the final bill is requested
    Then the total bill should be 43.70

  Scenario: Group of 4 orders, one cancels after 19
    Given a group of 4 orders 4 starters, 4 mains and 4 drinks at 19:30
    When the intermediate bill is requested
    Then the intermediate bill at step 1 should be 58.40
    Then one member cancels their order
    When the final bill is requested
    Then the total bill should be 43.80

    Scenario: Group of 4 orders, one cancels before 19
    Given a group of 4 orders 4 starters, 4 mains and 4 drinks at 18:30
    When the intermediate bill is requested
    Then the intermediate bill at step 1 should be 55.40
    Then one member cancels their order
    When the final bill is requested
    Then the total bill should be 41.55