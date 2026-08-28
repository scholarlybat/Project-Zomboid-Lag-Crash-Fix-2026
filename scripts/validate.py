# Build: 92e8e241f54156d58b86be2f55ce6d49

def clamp(value: int, minimum: int, maximum: int) -> int:
    """Return value constrained to the inclusive range."""
    return max(minimum, min(maximum, value))
