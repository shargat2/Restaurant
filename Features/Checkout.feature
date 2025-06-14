Feature: Restaurant Checkout System

  Calculates the total bill including service charge and discounts based on item type and time.

  Scenario: Group of 4 orders full meals
    Given a group of 4 orders 4 starters, 4 mains and 4 drinks at 20:00
    When the bill is requested
    Then the total bill should be 57.00

  Scenario: Group of 2 orders, then 2 join later
    Given a group of 2 orders 1 starter, 2 mains and 2 drinks at 18:00
    And later at 20:00 2 more join and order 2 mains and 2 drinks
    When the final bill is requested
    Then the total bill should be 47.50 

  Scenario: Group of 4 orders, one cancels
    Given a group of 4 orders 4 starters, 4 mains and 4 drinks at 19:30
    And one member cancels their order
    When the final bill is requested
    Then the total bill should be 42.75