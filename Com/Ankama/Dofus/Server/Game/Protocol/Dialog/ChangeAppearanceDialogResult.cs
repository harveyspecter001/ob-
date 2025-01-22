using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Dialog
{
	// Token: 0x020007EA RID: 2026
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChangeAppearanceDialogResult : IMessage<ChangeAppearanceDialogResult>, IMessage, IEquatable<ChangeAppearanceDialogResult>, IDeepCloneable<ChangeAppearanceDialogResult>, IBufferMessage
	{
		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x060062EF RID: 25327 RVA: 0x00223AE0 File Offset: 0x00221CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChangeAppearanceDialogResult> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x060062F0 RID: 25328 RVA: 0x00223AF0 File Offset: 0x00221CF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x060062F1 RID: 25329 RVA: 0x00223B00 File Offset: 0x00221D00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060062F2 RID: 25330 RVA: 0x00223B10 File Offset: 0x00221D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChangeAppearanceDialogResult()
		{
		}

		// Token: 0x060062F3 RID: 25331 RVA: 0x00223B20 File Offset: 0x00221D20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChangeAppearanceDialogResult(ChangeAppearanceDialogResult other)
		{
		}

		// Token: 0x060062F4 RID: 25332 RVA: 0x00223B30 File Offset: 0x00221D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChangeAppearanceDialogResult Clone()
		{
			return null;
		}

		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x060062F5 RID: 25333 RVA: 0x00223B40 File Offset: 0x00221D40
		// (set) Token: 0x060062F6 RID: 25334 RVA: 0x00223B50 File Offset: 0x00221D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Success
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060062F7 RID: 25335 RVA: 0x00223B60 File Offset: 0x00221D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060062F8 RID: 25336 RVA: 0x00223B70 File Offset: 0x00221D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChangeAppearanceDialogResult other)
		{
			return true;
		}

		// Token: 0x060062F9 RID: 25337 RVA: 0x00223B80 File Offset: 0x00221D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060062FA RID: 25338 RVA: 0x00223B90 File Offset: 0x00221D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060062FB RID: 25339 RVA: 0x00223BA0 File Offset: 0x00221DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060062FC RID: 25340 RVA: 0x00223BB0 File Offset: 0x00221DB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060062FD RID: 25341 RVA: 0x00223BC0 File Offset: 0x00221DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060062FE RID: 25342 RVA: 0x00223BD0 File Offset: 0x00221DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChangeAppearanceDialogResult other)
		{
		}

		// Token: 0x060062FF RID: 25343 RVA: 0x00223BE0 File Offset: 0x00221DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006300 RID: 25344 RVA: 0x00223BF0 File Offset: 0x00221DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006301 RID: 25345 RVA: 0x00223C00 File Offset: 0x00221E00
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChangeAppearanceDialogResult()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_578e41bde06c472a89a6c93b9b6f4e04 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a5ef992013574e4fbe94e55a1c82d97b == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				ChangeAppearanceDialogResult._parser = new MessageParser<ChangeAppearanceDialogResult>(() => null);
				num2 = 2;
			}
		}

		// Token: 0x06006302 RID: 25346 RVA: 0x00223CE4 File Offset: 0x00221EE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MU3Dy8OFZj0FOELdlac1()
		{
			return true;
		}

		// Token: 0x06006303 RID: 25347 RVA: 0x00223CEC File Offset: 0x00221EEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChangeAppearanceDialogResult OAtnkjOFqG1UGPFOO294()
		{
			return null;
		}

		// Token: 0x040022C4 RID: 8900
		private static readonly MessageParser<ChangeAppearanceDialogResult> _parser;

		// Token: 0x040022C5 RID: 8901
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022C6 RID: 8902
		public const int SuccessFieldNumber = 1;

		// Token: 0x040022C7 RID: 8903
		private bool success_;

		// Token: 0x040022C8 RID: 8904
		private static ChangeAppearanceDialogResult J3jc1uOF8UxjBdoVVGZc;
	}
}
