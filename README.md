# Comentsys.Assets.FluentEmoji

**Comentsys.Assets.FluentEmoji** is an **Asset Resource** in **.NET Standard** for the **Flat** style of **Fluent Emoji** created by **Microsoft** available from [github.com/microsoft/fluentui-emoji](https://github.com/microsoft/fluentui-emoji) including **Metadata** with links to **3D** and **Animated**, where available, style of **Fluent Emoji** that can be used with an **Image Resource** and uses **Comentsys.Toolkit**.

## Change Log

### Version 2.0.0

- Add Fluent Emoji Metadata with Image / Animated Emoji and Update for New / Fixed Emoji

### Version 1.1.0

- Update for Comentsys.Toolkit and Emoji Fixes

### Version 1.0.0

- Initial Release

## FlatFluentEmoji

`FlatFluentEmoji` represents **Emoji** designed by **Microsoft** which is a collection of familiar, friendly, and modern emoji with the **Flat** style used here in **SVG** format. 

You can also supply an **Array** of **Colours** or a single **Colour** to customise the **Emoji** by replacing **Colours** used in the **Asset** to the various **Methods** to `Get` an **Asset Resource**.

### Examples

![Flat Fluent Emoji](https://raw.githubusercontent.com/Comentsys/Comentsys.Assets.FluentEmoji/refs/heads/main/Assets/flatfluentemoji.png)

### Get(type, sources, targets)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `type` | `Comentsys.Assets.FluentEmoji.FluentEmojiType`<br>Fluent Emoji Type |
| `sources` | `System.Drawing.Color[]?`<br>Source Colours |
| `targets` | `System.Drawing.Color[]?`<br>Target Colours |

#### Returns

Asset Resource

### Get(type, source, target)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `type` | `Comentsys.Assets.FluentEmoji.FluentEmojiType`<br>Fluent Emoji Type |
| `source` | `System.Drawing.Color?`<br>Source Colour |
| `target` | `System.Drawing.Color?`<br>Target Colour |

#### Returns

Asset Resource

### Get(type)

Get Asset Resource

| Name | Description |
| ---- | ----------- |
| `type` | `Comentsys.Assets.FluentEmoji.FluentEmojiType`<br>Fluent Emoji Type |

#### Returns

Asset Resource

## AnimatedFluentEmoji

`AnimatedFluentEmoji` represents **Emoji** designed by **Microsoft** which is an **Animated** collection of familiar, friendly, and modern emoji linked here in animated **PNG** format. Not all **Emoji** are **Animated** but there are  **735** that can be used and can use `ListAnimatedEmoji` to get an **Array** of `FluentEmojiType` that are available. You can then use **Methods** to `Get` them as an **Image Resource** exposed from `AnimatedEmoji` links in the **Metadata** stored online by **Microsoft** on **GitHub**.

### Examples

![Animated Fluent Emoji](https://raw.githubusercontent.com/Comentsys/Comentsys.Assets.FluentEmoji/refs/heads/main/Assets/animatedfluentemoji.png)

> `ImageFluentEmoji` are **Animated** but are shown here as a static **Example**

### Get(client, type)

Get Image Resource

| Name | Description |
| ---- | ----------- |
| `client` | `System.Net.Http.HttpClient`<br>Http Client |
| `type` | `Comentsys.Assets.FluentEmoji.FluentEmojiType`<br>Fluent Emoji Type |

#### Returns

Image Resource

### Get(type)

Get Image Resource

| Name | Description |
| ---- | ----------- |
| `type` | `Comentsys.Assets.FluentEmoji.FluentEmojiType`<br>Fluent Emoji Type |

#### Returns

Image Resource

### ListAnimatedEmoji

List Animated Emoji

#### Returns

Array of Fluent Emoji Type

## ImageFluentEmoji

`ImageFluentEmoji` represents **Emoji** designed by **Microsoft** which is a collection of familiar, friendly, and modern emoji with the **3D** style linked here in **PNG** format and then use **Methods** to `Get` as an **Image Resource** exposed from `ImageEmoji` links in the **Metadata** stored online by **Microsoft** on **GitHub**.

### Examples

![Image Fluent Emoji](https://raw.githubusercontent.com/Comentsys/Comentsys.Assets.FluentEmoji/refs/heads/main/Assets/imagefluentemoji.png)

### Get(client, type)

Get Image Resource

| Name | Description |
| ---- | ----------- |
| `client` | `System.Net.Http.HttpClient`<br>Http Client |
| `type` | `Comentsys.Assets.FluentEmoji.FluentEmojiType`<br>Fluent Emoji Type |

### Get(type)

Get Image Resource

| Name | Description |
| ---- | ----------- |
| `type` | `Comentsys.Assets.FluentEmoji.FluentEmojiType`<br>Fluent Emoji Type |

#### Returns

Image Resource

#### Returns

Image Resource

## FluentEmojiData

`FluentEmojiData` represents **Metadata** for **Emoji**

### FluentEmojiType

Fluent Emoji Type

### Name

Common Locale Data Repository Name

### Glyph

Glyph

### Unicode

Unicode

### Group

Group

### Keywords

Keywords

### Emoticons

Emoticons

### ImageEmoji

Image Emoji Link

### AnimatedEmoji

Animated Emoji Link

### HasAnimatedEmoji

Has Animated Emoji?

## FluentEmojiMeta

`FluentEmojiMeta` includes **Metadata** for all **Emoji** that you can `List` including by an **Array** of `FluentEmojiType` or `Get` any **Metadata** by `FluentEmojiType`.

### Data

Fluunt Emoji Data

#### Returns

Fluent Emoji Data

### List(types)

List Fluent Emoji Data

| Name | Description |
| ---- | ----------- |
| `types` | `Comentsys.Assets.FluentEmoji.FluentEmojiType[]`<br>Fluent Emoji Types |

#### Returns

Array of Fluent Emoji Data

### Get(type)

Get Fluent Emoji Data

| Name | Description |
| ---- | ----------- |
| `type` | `Comentsys.Assets.FluentEmoji.FluentEmojiType`<br>Fluent Emoji Type |

#### Returns

Fluent Emoji Data

## FluentEmojiType

`FluentEmojiType` supports **1,595** different **Emoji** as well as `None`.

```
None
FirstPlaceMedal
SecondPlaceMedal
ThirdPlaceMedal
AButtonBloodType
AbButtonBloodType
Abacus
Accordion
AdhesiveBandage
AdmissionTickets
AerialTramway
Airplane
AirplaneArrival
AirplaneDeparture
AlarmClock
Alembic
Alien
AlienMonster
Ambulance
AmericanFootball
Amphora
AnatomicalHeart
Anchor
AngerSymbol
AngryFace
AngryFaceWithHorns
AnguishedFace
Ant
AntennaBars
AnxiousFaceWithSweat
Aquarius
Aries
ArticulatedLorry
Artist
ArtistPalette
AstonishedFace
Astronaut
AtmSign
AtomSymbol
AutoRickshaw
Automobile
Avocado
Axe
BButtonBloodType
Baby
BabyAngel
BabyBottle
BabyChick
BabySymbol
BackArrow
BackhandIndexPointingDown
BackhandIndexPointingLeft
BackhandIndexPointingRight
BackhandIndexPointingUp
Backpack
Bacon
Badger
Badminton
Bagel
BaggageClaim
BaguetteBread
BalanceScale
BalletShoes
Balloon
BallotBoxWithBallot
Banana
Banjo
Bank
BarChart
BarberPole
Baseball
Basket
Basketball
Bat
Bathtub
Battery
BeachWithUmbrella
BeamingFaceWithSmilingEyes
Beans
Bear
BeatingHeart
Beaver
Bed
BeerMug
Beetle
Bell
BellPepper
BellWithSlash
BellhopBell
BentoBox
BeverageBox
Bicycle
Bikini
BilledCap
Biohazard
Bird
BirthdayCake
Bison
BitingLip
BlackCat
BlackCircle
BlackFlag
BlackHeart
BlackLargeSquare
BlackMediumSquare
BlackMediumSmallSquare
BlackNib
BlackSmallSquare
BlackSquareButton
Blackbird
Blossom
Blowfish
BlueBook
BlueCircle
BlueHeart
BlueSquare
Blueberries
Boar
Bomb
Bone
Bookmark
BookmarkTabs
Books
Boomerang
BottleWithPoppingCork
Bouquet
BowAndArrow
BowlWithSpoon
Bowling
BoxingGlove
Boy
Brain
Bread
BreastFeeding
Brick
BridgeAtNight
Briefcase
Briefs
BrightButton
Broccoli
BrokenChain
BrokenHeart
Broom
BrownCircle
BrownHeart
BrownMushroom
BrownSquare
BubbleTea
Bubbles
Bucket
Bug
BuildingConstruction
BulletTrain
Bullseye
Burrito
Bus
BusStop
BustInSilhouette
BustsInSilhouette
Butter
Butterfly
Cactus
Calendar
CallMeHand
Camel
Camera
CameraWithFlash
Camping
Cancer
Candle
Candy
CannedFood
Canoe
Capricorn
CardFileBox
CardIndex
CardIndexDividers
CarouselHorse
CarpStreamer
CarpentrySaw
Carrot
Castle
Cat
CatFace
CatWithTearsOfJoy
CatWithWrySmile
Chains
Chair
ChartDecreasing
ChartIncreasing
ChartIncreasingWithYen
CheckBoxWithCheck
CheckMark
CheckMarkButton
CheeseWedge
ChequeredFlag
Cherries
CherryBlossom
ChessPawn
Chestnut
Chicken
Child
ChildrenCrossing
Chipmunk
ChocolateBar
Chopsticks
ChristmasTree
Church
Cigarette
Cinema
CircledM
CircusTent
Cityscape
CityscapeAtDusk
ClButton
Clamp
ClapperBoard
ClappingHands
ClassicalBuilding
ClinkingBeerMugs
ClinkingGlasses
Clipboard
ClockwiseVerticalArrows
ClosedBook
ClosedMailboxWithLoweredFlag
ClosedMailboxWithRaisedFlag
ClosedUmbrella
Cloud
CloudWithLightning
CloudWithLightningAndRain
CloudWithRain
CloudWithSnow
ClownFace
ClubSuit
ClutchBag
Coat
Cockroach
CocktailGlass
Coconut
Coffin
Coin
ColdFace
Collision
Comet
Compass
ComputerDisk
ComputerMouse
ConfettiBall
ConfoundedFace
ConfusedFace
Construction
ConstructionWorker
ControlKnobs
ConvenienceStore
Cook
CookedRice
Cookie
Cooking
CoolButton
Copyright
Coral
CouchAndLamp
CounterClockwiseArrowsButton
Cow
CowFace
CowboyHatFace
Crab
Crayon
CreditCard
CrescentMoon
Cricket
CricketGame
Crocodile
Croissant
CrossMark
CrossMarkButton
CrossedFingers
CrossedFlags
CrossedSwords
Crown
Crutch
CryingCat
CryingFace
CrystalBall
Cucumber
CupWithStraw
Cupcake
CurlingStone
CurlyLoop
CurrencyExchange
CurryRice
Custard
Customs
CutOfMeat
Cyclone
Dagger
Dango
DashingAway
DeciduousTree
Deer
DeliveryTruck
DepartmentStore
DerelictHouse
Desert
DesertIsland
DesktopComputer
Detective
DiamondSuit
DiamondWithADot
DimButton
DisappointedFace
DisguisedFace
Divide
DivingMask
DiyaLamp
Dizzy
Dna
Dodo
Dog
DogFace
DollarBanknote
Dolphin
Donkey
Door
DottedLineFace
DottedSixPointedStar
DoubleCurlyLoop
DoubleExclamationMark
Doughnut
Dove
DownArrow
DownLeftArrow
DownRightArrow
DowncastFaceWithSweat
DownwardsButton
Dragon
DragonFace
Dress
DroolingFace
DropOfBlood
Droplet
Drum
Duck
Dumpling
Dvd
Email
Eagle
Ear
EarOfCorn
EarWithHearingAid
Egg
Eggplant
EightOclock
EightPointedStar
EightSpokedAsterisk
EightThirty
EjectButton
ElectricPlug
Elephant
Elevator
ElevenOclock
ElevenThirty
EmptyNest
EndArrow
Envelope
EnvelopeWithArrow
EuroBanknote
EvergreenTree
Ewe
ExclamationQuestionMark
ExplodingHead
ExpressionlessFace
Eye
EyeInSpeechBubble
Eyes
FaceBlowingAKiss
FaceExhaling
FaceHoldingBackTears
FaceInClouds
FaceSavoringFood
FaceScreamingInFear
FaceVomiting
FaceWithDiagonalMouth
FaceWithHandOverMouth
FaceWithHeadBandage
FaceWithMedicalMask
FaceWithMonocle
FaceWithOpenEyesAndHandOverMouth
FaceWithOpenMouth
FaceWithPeekingEye
FaceWithRaisedEyebrow
FaceWithRollingEyes
FaceWithSpiralEyes
FaceWithSteamFromNose
FaceWithSymbolsOnMouth
FaceWithTearsOfJoy
FaceWithThermometer
FaceWithTongue
FaceWithoutMouth
Factory
FactoryWorker
Falafel
FallenLeaf
Farmer
FastDownButton
FastReverseButton
FastUpButton
FastForwardButton
FaxMachine
FearfulFace
Feather
FemaleSign
FerrisWheel
Ferry
FieldHockey
FileCabinet
FileFolder
FilmFrames
FilmProjector
Fire
FireEngine
FireExtinguisher
Firecracker
Firefighter
Fireworks
FirstQuarterMoon
FirstQuarterMoonFace
Fish
FishCakeWithSwirl
FishingPole
FiveOclock
FiveThirty
FlagInHole
Flamingo
Flashlight
FlatShoe
Flatbread
FleurDeLis
FlexedBiceps
FloppyDisk
FlowerPlayingCards
FlushedFace
Flute
Fly
FlyingDisc
FlyingSaucer
Fog
Foggy
FoldedHands
FoldingHandFan
Fondue
Foot
Footprints
ForkAndKnife
ForkAndKnifeWithPlate
FortuneCookie
Fountain
FountainPen
FourLeafClover
FourOclock
FourThirty
Fox
FramedPicture
FreeButton
FrenchFries
FriedShrimp
Frog
FrontFacingBabyChick
FrowningFace
FrowningFaceWithOpenMouth
FuelPump
FullMoon
FullMoonFace
FuneralUrn
GameDie
Garlic
Gear
GemStone
Gemini
Ghost
GingerRoot
Giraffe
Girl
GlassOfMilk
Glasses
GlobeShowingAmericas
GlobeShowingAsiaAustralia
GlobeShowingEuropeAfrica
GlobeWithMeridians
Gloves
GlowingStar
GoalNet
Goat
Goblin
Goggles
Goose
Gorilla
GraduationCap
Grapes
GreenApple
GreenBook
GreenCircle
GreenHeart
GreenSalad
GreenSquare
GreyHeart
GrimacingFace
GrinningCat
GrinningCatWithSmilingEyes
GrinningFace
GrinningFaceWithBigEyes
GrinningFaceWithSmilingEyes
GrinningFaceWithSweat
GrinningSquintingFace
GrowingHeart
Guard
GuideDog
Guitar
HairPick
Hamburger
Hammer
HammerAndPick
HammerAndWrench
Hamsa
Hamster
HandWithFingersSplayed
HandWithIndexFingerAndThumbCrossed
Handbag
Handshake
HatchingChick
HeadShakingHorizontally
HeadShakingVertically
Headphone
Headstone
HealthWorker
HearNoEvilMonkey
HeartDecoration
HeartExclamation
HeartHands
HeartOnFire
HeartSuit
HeartWithArrow
HeartWithRibbon
HeavyDollarSign
HeavyEqualsSign
Hedgehog
Helicopter
Herb
Hibiscus
HighVoltage
HighHeeledShoe
HighSpeedTrain
HikingBoot
HinduTemple
Hippopotamus
Hole
HollowRedCircle
HoneyPot
Honeybee
Hook
HorizontalTrafficLight
Horse
HorseFace
HorseRacing
Hospital
HotBeverage
HotDog
HotFace
HotPepper
HotSprings
Hotel
HourglassDone
HourglassNotDone
House
HouseWithGarden
Houses
HuggingFace
HundredPoints
HushedFace
Hut
Hyacinth
Ice
IceCream
IceHockey
IceSkate
IdButton
IdentificationCard
InboxTray
IncomingEnvelope
IndexPointingAtTheViewer
IndexPointingUp
Infinity
Information
InputLatinLetters
InputLatinLowercase
InputLatinUppercase
InputNumbers
InputSymbols
JackOLantern
JapaneseAcceptableButton
JapaneseApplicationButton
JapaneseBargainButton
JapaneseCastle
JapaneseCongratulationsButton
JapaneseDiscountButton
JapaneseDolls
JapaneseFreeOfChargeButton
JapaneseHereButton
JapaneseMonthlyAmountButton
JapaneseNoVacancyButton
JapaneseNotFreeOfChargeButton
JapaneseOpenForBusinessButton
JapanesePassingGradeButton
JapanesePostOffice
JapaneseProhibitedButton
JapaneseReservedButton
JapaneseSecretButton
JapaneseServiceChargeButton
JapaneseSymbolForBeginner
JapaneseVacancyButton
Jar
Jeans
Jellyfish
Joker
Joystick
Judge
Kaaba
Kangaroo
Key
Keyboard
Keycap0
Keycap1
Keycap10
Keycap2
Keycap3
Keycap4
Keycap5
Keycap6
Keycap7
Keycap8
Keycap9
KeycapAsterisk
KeycapHashtag
Khanda
KickScooter
Kimono
KissMark
KissingCat
KissingFace
KissingFaceWithClosedEyes
KissingFaceWithSmilingEyes
KitchenKnife
Kite
KiwiFruit
KnockedOutFace
Knot
Koala
LabCoat
Label
Lacrosse
Ladder
LadyBeetle
Laptop
LargeBlueDiamond
LargeOrangeDiamond
LastQuarterMoon
LastQuarterMoonFace
LastTrackButton
LatinCross
LeafFlutteringInWind
LeafyGreen
Ledger
LeftArrow
LeftArrowCurvingRight
LeftLuggage
LeftSpeechBubble
LeftFacingFist
LeftRightArrow
LeftwardsHand
LeftwardsPushingHand
Leg
Lemon
Leo
Leopard
LevelSlider
Libra
LightBlueHeart
LightBulb
LightRail
Lime
Link
LinkedPaperclips
Lion
Lipstick
LitterInBinSign
Lizard
Llama
Lobster
Locked
LockedWithKey
LockedWithPen
Locomotive
Lollipop
LongDrum
LotionBottle
Lotus
LoudlyCryingFace
Loudspeaker
LoveHotel
LoveLetter
LoveYouGesture
LowBattery
Luggage
Lungs
LyingFace
MagicWand
Magnet
MagnifyingGlassTiltedLeft
MagnifyingGlassTiltedRight
MahjongRedDragon
MaleSign
Mammoth
Man
ManArtist
ManAstronaut
ManBald
ManBeard
ManBiking
ManBlondeHair
ManBouncingBall
ManBowing
ManCartwheeling
ManClimbing
ManConstructionWorker
ManCook
ManCurlyHair
ManDancing
ManDeaf
ManDetective
ManElf
ManFacepalming
ManFactoryWorker
ManFairy
ManFarmer
ManFeedingBaby
ManFirefighter
ManFrowning
ManGenie
ManGesturingNo
ManGesturingOk
ManGettingHaircut
ManGettingMassage
ManGolfing
ManGuard
ManHealthWorker
ManInLotusPosition
ManInManualWheelchair
ManInManualWheelchairFacingRight
ManInMotorizedWheelchair
ManInMotorizedWheelchairFacingRight
ManInSteamyRoom
ManInTuxedo
ManJudge
ManJuggling
ManKneeling
ManKneelingFacingRight
ManLiftingWeights
ManMage
ManMechanic
ManMerpeople
ManMountainBiking
ManOfficeWorker
ManPilot
ManPlayingHandball
ManPlayingWaterPolo
ManPoliceOfficer
ManPouting
ManRaisingHand
ManRedHair
ManRowingBoat
ManRunning
ManRunningFacingRight
ManScientist
ManShrugging
ManSinger
ManStanding
ManStudent
ManSuperhero
ManSupervillain
ManSurfing
ManSwimming
ManTeacher
ManTechnologist
ManTippingHand
ManVampire
ManWalking
ManWalkingFacingRight
ManWearingTurban
ManWhiteHair
ManWithBunnyEars
ManWithVeil
ManWithWhiteCane
ManWithWhiteCaneFacingRight
ManWrestling
ManZombie
Mango
MansShoe
MantelpieceClock
ManualWheelchair
MapOfJapan
MapleLeaf
Maracas
MartialArtsUniform
Mate
MeatOnBone
Mechanic
MechanicalArm
MechanicalLeg
MedicalSymbol
Megaphone
Melon
MeltingFace
Memo
MendingHeart
Menorah
MensRoom
Metro
Microbe
Microphone
Microscope
MiddleFinger
MilitaryHelmet
MilitaryMedal
MilkyWay
Minibus
Minus
Mirror
MirrorBall
Moai
MobilePhone
MobilePhoneOff
MobilePhoneWithArrow
MoneyBag
MoneyWithWings
MoneyMouthFace
Monkey
MonkeyFace
Monorail
MoonCake
MoonViewingCeremony
Moose
Mosque
Mosquito
MotorBoat
MotorScooter
Motorcycle
MotorizedWheelchair
Motorway
MountFuji
Mountain
MountainCableway
MountainRailway
Mouse
MouseFace
MouseTrap
Mouth
MovieCamera
MrsClaus
Multiply
Mushroom
MusicalKeyboard
MusicalNote
MusicalNotes
MusicalScore
MutedSpeaker
MxClaus
NailPolish
NameBadge
NationalPark
NauseatedFace
NazarAmulet
Necktie
NerdFace
NestWithEggs
NestingDolls
NeutralFace
NewButton
NewMoon
NewMoonFace
Newspaper
NextTrackButton
NgButton
NightWithStars
NineOclock
NineThirty
Ninja
NoBicycles
NoEntry
NoLittering
NoMobilePhones
NoOneUnderEighteen
NoPedestrians
NoSmoking
NonPotableWater
Nose
Notebook
NotebookWithDecorativeCover
NutAndBolt
OButtonBloodType
Octopus
Oden
OfficeBuilding
OfficeWorker
Ogre
OilDrum
OkButton
OkHand
OldKey
OldMan
OldWoman
OlderPerson
Olive
Om
OnExclamationMarkArrow
OncomingAutomobile
OncomingBus
OncomingFist
OncomingPoliceCar
OncomingTaxi
OneOclock
OnePieceSwimsuit
OneThirty
Onion
OpenBook
OpenFileFolder
OpenHands
OpenMailboxWithLoweredFlag
OpenMailboxWithRaisedFlag
Ophiuchus
OpticalDisk
OrangeBook
OrangeCircle
OrangeHeart
OrangeSquare
Orangutan
OrthodoxCross
Otter
OutboxTray
Owl
Ox
Oyster
PButton
Package
PageFacingUp
PageWithCurl
Pager
Paintbrush
PalmDownHand
PalmTree
PalmUpHand
PalmsUpTogether
Pancakes
Panda
Paperclip
Parachute
Parrot
PartAlternationMark
PartyPopper
PartyingFace
PassengerShip
PassportControl
PauseButton
PawPrints
PeaPod
PeaceSymbol
Peach
Peacock
Peanuts
Pear
Pen
Pencil
Penguin
PensiveFace
PeopleHugging
PerformingArts
PerseveringFace
Person
PersonBald
PersonBeard
PersonBiking
PersonBlondeHair
PersonBouncingBall
PersonBowing
PersonCartwheeling
PersonClimbing
PersonCurlyHair
PersonDeaf
PersonElf
PersonFacepalming
PersonFairy
PersonFeedingBaby
PersonFencing
PersonFrowning
PersonGenie
PersonGesturingNo
PersonGesturingOk
PersonGettingHaircut
PersonGettingMassage
PersonGolfing
PersonInBed
PersonInLotusPosition
PersonInManualWheelchair
PersonInManualWheelchairFacingRight
PersonInMotorizedWheelchair
PersonInMotorizedWheelchairFacingRight
PersonInSteamyRoom
PersonInSuitLevitating
PersonInTuxedo
PersonJuggling
PersonKneeling
PersonKneelingFacingRight
PersonLiftingWeights
PersonMage
PersonMerpeople
PersonMountainBiking
PersonPlayingHandball
PersonPlayingWaterPolo
PersonPouting
PersonRaisingHand
PersonRedHair
PersonRowingBoat
PersonRunning
PersonRunningFacingRight
PersonShrugging
PersonStanding
PersonSuperhero
PersonSupervillain
PersonSurfing
PersonSwimming
PersonTakingBath
PersonTippingHand
PersonVampire
PersonWalking
PersonWalkingFacingRight
PersonWearingTurban
PersonWhiteHair
PersonWithBunnyEars
PersonWithCrown
PersonWithSkullcap
PersonWithVeil
PersonWithWhiteCane
PersonWithWhiteCaneFacingRight
PersonWrestling
PersonZombie
PetriDish
PhoenixBird
Pick
PickupTruck
Pie
Pig
PigFace
PigNose
PileOfPoo
Pill
Pilot
PinchedFingers
PinchingHand
PineDecoration
Pineapple
PingPong
PinkHeart
PirateFlag
Pisces
Pizza
Pinata
Placard
PlaceOfWorship
PlayButton
PlayOrPauseButton
PlaygroundSlide
PleadingFace
Plunger
Plus
PolarBear
PoliceCar
PoliceCarLight
PoliceOfficer
Poodle
Pool8Ball
Popcorn
PostOffice
PostalHorn
Postbox
PotOfFood
PotableWater
Potato
PottedPlant
PoultryLeg
PoundBanknote
PouringLiquid
PoutingCat
PoutingFace
PrayerBeads
PregnantMan
PregnantPerson
PregnantWoman
Pretzel
Prince
Princess
Printer
Prohibited
PurpleCircle
PurpleHeart
PurpleSquare
Purse
Pushpin
PuzzlePiece
Rabbit
RabbitFace
Raccoon
RacingCar
Radio
RadioButton
Radioactive
RailwayCar
RailwayTrack
Rainbow
RainbowFlag
RaisedBackOfHand
RaisedFist
RaisedHand
RaisingHands
Ram
Rat
Razor
Receipt
RecordButton
RecyclingSymbol
RedApple
RedCircle
RedEnvelope
RedExclamationMark
RedHeart
RedPaperLantern
RedQuestionMark
RedSquare
RedTriangle
RedTrianglePointedDown
Registered
RelievedFace
ReminderRibbon
RepeatButton
RepeatSingleButton
RescueWorkersHelmet
Restroom
ReverseButton
RevolvingHearts
Rhinoceros
Ribbon
RiceBall
RiceCracker
RightAngerBubble
RightArrow
RightArrowCurvingDown
RightArrowCurvingLeft
RightArrowCurvingUp
RightFacingFist
RightwardsHand
RightwardsPushingHand
Ring
RingBuoy
RingedPlanet
RoastedSweetPotato
Robot
Rock
Rocket
RollOfPaper
RolledUpNewspaper
RollerCoaster
RollerSkate
RollingOnTheFloorLaughing
Rooster
Rose
Rosette
RoundPushpin
RugbyFootball
RunningShirt
RunningShoe
SadButRelievedFace
SafetyPin
SafetyVest
Sagittarius
Sailboat
Sake
Salt
SalutingFace
Sandwich
SantaClaus
Sari
Satellite
SatelliteAntenna
Sauropod
Saxophone
Scarf
School
Scientist
Scissors
Scorpio
Scorpion
Screwdriver
Scroll
Seal
Seat
SeeNoEvilMonkey
Seedling
Selfie
ServiceDog
SevenOclock
SevenThirty
SewingNeedle
ShakingFace
ShallowPanOfFood
Shamrock
Shark
ShavedIce
SheafOfRice
Shield
ShintoShrine
Ship
ShootingStar
ShoppingBags
ShoppingCart
Shortcake
Shorts
Shower
Shrimp
ShuffleTracksButton
ShushingFace
SignOfTheHorns
Singer
SixOclock
SixThirty
Skateboard
Skier
Skis
Skull
SkullAndCrossbones
Skunk
Sled
SleepingFace
SleepyFace
SlightlyFrowningFace
SlightlySmilingFace
SlotMachine
Sloth
SmallAirplane
SmallBlueDiamond
SmallOrangeDiamond
SmilingCatWithHeartEyes
SmilingFace
SmilingFaceWithHalo
SmilingFaceWithHeartEyes
SmilingFaceWithHearts
SmilingFaceWithHorns
SmilingFaceWithSmilingEyes
SmilingFaceWithSunglasses
SmilingFaceWithTear
SmirkingFace
Snail
Snake
SneezingFace
SnowCappedMountain
Snowboarder
Snowflake
Snowman
SnowmanWithoutSnow
Soap
SoccerBall
Socks
SoftIceCream
Softball
SoonArrow
SosButton
SpadeSuit
Spaghetti
Sparkle
Sparkler
Sparkles
SparklingHeart
SpeakNoEvilMonkey
SpeakerHighVolume
SpeakerLowVolume
SpeakerMediumVolume
SpeakingHead
SpeechBalloon
Speedboat
Spider
SpiderWeb
SpiralCalendar
SpiralNotepad
SpiralShell
Sponge
Spoon
SportUtilityVehicle
SportsMedal
SpoutingWhale
Squid
SquintingFaceWithTongue
Stadium
Star
StarAndCrescent
StarOfDavid
StarStruck
Station
StatueOfLiberty
SteamingBowl
Stethoscope
StopButton
StopSign
Stopwatch
StraightRuler
Strawberry
Student
StudioMicrophone
StuffedFlatbread
Sun
SunBehindCloud
SunBehindLargeCloud
SunBehindRainCloud
SunBehindSmallCloud
SunWithFace
Sunflower
Sunglasses
Sunrise
SunriseOverMountains
Sunset
Sushi
SuspensionRailway
Swan
SweatDroplets
Synagogue
Syringe
TRex
TShirt
Taco
TakeoutBox
Tamale
TanabataTree
Tangerine
Taurus
Taxi
Teacher
TeacupWithoutHandle
Teapot
TearOffCalendar
Technologist
TeddyBear
Telephone
TelephoneReceiver
Telescope
Television
TenOclock
TenThirty
Tennis
Tent
TestTube
Thermometer
ThinkingFace
ThongSandal
ThoughtBalloon
Thread
ThreeOclock
ThreeThirty
ThumbsDown
ThumbsUp
Ticket
Tiger
TigerFace
TimerClock
TiredFace
Toilet
TokyoTower
Tomato
Tongue
Toolbox
Tooth
Toothbrush
TopArrow
TopHat
Tornado
Trackball
Tractor
TradeMark
Train
Tram
TramCar
TransgenderFlag
TransgenderSymbol
TriangularFlag
TriangularRuler
TridentEmblem
Troll
Trolleybus
Trophy
TropicalDrink
TropicalFish
Trumpet
Tulip
TumblerGlass
Turkey
Turtle
TwelveOclock
TwelveThirty
TwoHearts
TwoOclock
TwoHumpCamel
TwoThirty
Umbrella
UmbrellaOnGround
UmbrellaWithRainDrops
UnamusedFace
Unicorn
Unlocked
UpArrow
UpExclamationMarkButton
UpDownArrow
UpLeftArrow
UpRightArrow
UpsideDownFace
UpwardsButton
VerticalTrafficLight
VibrationMode
VictoryHand
VideoCamera
VideoGame
Videocassette
Violin
Virgo
Volcano
Volleyball
VsButton
VulcanSalute
Waffle
WaningCrescentMoon
WaningGibbousMoon
Warning
Wastebasket
Watch
WaterBuffalo
WaterCloset
WaterPistol
WaterWave
Watermelon
WavingHand
WavyDash
WaxingCrescentMoon
WaxingGibbousMoon
WearyCat
WearyFace
Wedding
Whale
Wheel
WheelOfDharma
WheelchairSymbol
WhiteCane
WhiteCircle
WhiteExclamationMark
WhiteFlag
WhiteFlower
WhiteHeart
WhiteLargeSquare
WhiteMediumSquare
WhiteMediumSmallSquare
WhiteQuestionMark
WhiteSmallSquare
WhiteSquareButton
WiltedFlower
WindChime
WindFace
Window
WineGlass
Wing
WinkingFace
WinkingFaceWithTongue
Wireless
Wolf
Woman
WomanArtist
WomanAstronaut
WomanBald
WomanBeard
WomanBiking
WomanBlondeHair
WomanBouncingBall
WomanBowing
WomanCartwheeling
WomanClimbing
WomanConstructionWorker
WomanCook
WomanCurlyHair
WomanDancing
WomanDeaf
WomanDetective
WomanElf
WomanFacepalming
WomanFactoryWorker
WomanFairy
WomanFarmer
WomanFeedingBaby
WomanFirefighter
WomanFrowning
WomanGenie
WomanGesturingNo
WomanGesturingOk
WomanGettingHaircut
WomanGettingMassage
WomanGolfing
WomanGuard
WomanHealthWorker
WomanInLotusPosition
WomanInManualWheelchair
WomanInManualWheelchairFacingRight
WomanInMotorizedWheelchair
WomanInMotorizedWheelchairFacingRight
WomanInSteamyRoom
WomanInTuxedo
WomanJudge
WomanJuggling
WomanKneeling
WomanKneelingFacingRight
WomanLiftingWeights
WomanMage
WomanMechanic
WomanMerpeople
WomanMountainBiking
WomanOfficeWorker
WomanPilot
WomanPlayingHandball
WomanPlayingWaterPolo
WomanPoliceOfficer
WomanPouting
WomanRaisingHand
WomanRedHair
WomanRowingBoat
WomanRunning
WomanRunningFacingRight
WomanScientist
WomanShrugging
WomanSinger
WomanStanding
WomanStudent
WomanSuperhero
WomanSupervillain
WomanSurfing
WomanSwimming
WomanTeacher
WomanTechnologist
WomanTippingHand
WomanVampire
WomanWalking
WomanWalkingFacingRight
WomanWearingTurban
WomanWhiteHair
WomanWithBunnyEars
WomanWithHeadscarf
WomanWithVeil
WomanWithWhiteCane
WomanWithWhiteCaneFacingRight
WomanWrestling
WomanZombie
WomansBoot
WomansClothes
WomansHat
WomansSandal
WomensRoom
Wood
WoozyFace
WorldMap
Worm
WorriedFace
WrappedGift
Wrench
WritingHand
XRay
Yarn
YawningFace
YellowCircle
YellowHeart
YellowSquare
YenBanknote
YinYang
YoYo
ZanyFace
Zebra
ZipperMouthFace
Zzz
```

## Licences

```
The MIT License (MIT)

Copyright (c) 2022 Comentsys

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
of the Software, and to permit persons to whom the Software is furnished to do
so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

```
MIT License

Copyright (c) Microsoft Corporation

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE
```