 ADR 0001: Use Markdown for Project Documentation

Status

Accepted

Context

The ColdChain project requires shared documentation that can be easily created, reviewed, and maintained by all team members. The documentation must be stored in the GitHub repository and support version control and collaboration.

Possible formats include Microsoft Word documents, PDF files, and Markdown files. Word and PDF are convenient for formatted documents but are less suitable for reviewing small changes directly in GitHub.

Decision

The team decided to use Markdown (`.md`) as the standard format for project documentation.

All documentation files will be stored in the `docs/` directory. Architecture Decision Records (ADRs) will be stored in `docs/adr/` and named using sequential numbers, for example `0001-use-markdown-for-docs.md`.

Each ADR must contain the following sections: Title, Status, Context, Decision, and Consequences.

Consequences

Positive consequences:
- Documentation is readable directly on GitHub.
- Changes can be tracked through Git commits and pull requests.
- All team members can edit documentation using a text editor.
- Markdown provides consistent formatting across project documents.

Negative consequences:
- Team members must know basic Markdown syntax.
- Complex page layouts and advanced formatting are more limited than in word processors.
