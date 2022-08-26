namespace Library

open System

module Daycare =
    type Name = Name of string

    type Age = Age of int

    type Naptime = { 
        from: DateTime
        ``to``: DateTime 
    }

    type Naptimes = Naptimes of Naptime Set

    type LearningGoal = {
        description: string
        goal: string
    }

    type LearningGoals = LearningGoals of LearningGoal Set

    type AgeGroup = 
        | Babies of Naptimes 
        | Toddlers 
        | PreSchoolKids of LearningGoals

    type DecideAgeGroup = Age -> AgeGroup

    type Parent = { name: Name }

    // We only allow for a single or two parents (Poly families are not supported)
    type Parents = Parents of Parent * Parent option

    type Child = { 
        name: Name
        age: Age 
        parents: Parents
    }

    type Children = Children of Child Set

    type Practitioner = {
        name: Name
        ageGroup: AgeGroup
    }

    type CheckinResult =
        | CheckedIn
        | ForgottenCheckout of DateTime
    
    type CheckoutResult =
        | CheckedOut
        | ForgottenCheckin of DateTime

    type Checkin = Child -> DateTime -> CheckinResult

    type Checkout = Child -> DateTime -> CheckoutResult

    type GetLastCheckout = Child -> DateTime

    type GetLastCheckin = Child -> DateTime

    let createAgeGroup: DecideAgeGroup = function | _ -> Toddlers  
