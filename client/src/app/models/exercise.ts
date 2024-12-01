export interface Exercise {
    id: number;
    date: Date;
    isFinished: boolean;
    typeId: ExerciseType;
    details: WarmupDetails;
}

interface WarmupDetails {
    minutes: number;
}

enum ExerciseType {
    Warmup = 1,
    Running = 2,
    Jumping = 3,
    Strolling = 4,
    Pushups = 5,
}