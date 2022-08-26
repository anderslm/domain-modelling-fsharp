# What is a domain?
    The domain is the area of business our applications works in - Our domain is childcare and early years education.
    It's important when talking about a domain in programming, that the terminalogy used is that of the domain.
    A childcare has children, prectitioners and sites. Children has names, ages and parents. Nowhere in our domain
    do we talk about strings, integers, bools, databases, graphql apis and such. Those are all technical details that
    has nothing to do with our domain.

# What is a domain model?
    It's a collection of types and functions written in the language of the domain. We also call it a DSL - Domain Specific Language.
    We use the domain model to express the use cases from the business.

# Scala and TypeScript has an extensive type system
    We can use that to model the business domain.
    Sum types (choice types), product types (records/case class), type alias' and function definitions.
    In the interest of not favouring anyone here, I'll show examples of this in F#

# How to discover the business model
    Talk to the business.
    We have children, daycares, parents and practitioners. Children, parents and practitioners have names and children also has ages (The age a child has decides which age-group whey belong to).
    Practitioners has the responsibility of each age-group in the site. The site consists of 3 different age groups - babies, toddlers and pre-school kids. Babies have naptimes and pre-school kids have learning goals.
    Children has parents and each parent has contact information in the form of a phone number, email and/or postal address.
    A children has an emergency contact in the form of a phone number.
    Children gets checked in to the daycare each morning and each afternoon they get checked out - the daycare uses this information to bill the parents for the time the children has spent in the daycare.
    Sometimes parents forget to checkin or checkout the children, so if a kid is checked out, without being checked in, we automatically check the child in the same times as the last check in. Same goes with the checkout.

# Complexity
    That is a lot of complexity. But it's essential complexity - it's the way the business operates. Our job is to minimize the accidental complexity.
    Accidental complexity is complexity introduced by our tech-stack, our infrastructure, bad domain modelling, our programming language and so on.
    Consider a calculator use case for division.
    Any two numbers, that are not 0, can be divided with each other.
    Typically our programming languages doesn't have a type for that and a developer might implement the division use case with the type `Integer`.
    But `Integer` can be 0, so now we have the accidental complexity of handling this odd case where something that wasn't supposed to happen, can happen.
    A good architecture makes sure to only allow a legal state - to make illegal states unrepresentable, so we don't have to handle it.
