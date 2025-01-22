using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social
{
	// Token: 0x02000135 RID: 309
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetMoodRequest : IMessage<SetMoodRequest>, IMessage, IEquatable<SetMoodRequest>, IDeepCloneable<SetMoodRequest>, IBufferMessage
	{
		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000E0E RID: 3598 RVA: 0x0019B4FC File Offset: 0x001996FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetMoodRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000E0F RID: 3599 RVA: 0x0019B50C File Offset: 0x0019970C
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

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000E10 RID: 3600 RVA: 0x0019B51C File Offset: 0x0019971C
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

		// Token: 0x06000E11 RID: 3601 RVA: 0x0019B52C File Offset: 0x0019972C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SetMoodRequest()
		{
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x0019B53C File Offset: 0x0019973C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SetMoodRequest(SetMoodRequest other)
		{
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x0019B54C File Offset: 0x0019974C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SetMoodRequest Clone()
		{
			return null;
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x0019B55C File Offset: 0x0019975C
		// (set) Token: 0x06000E15 RID: 3605 RVA: 0x0019B56C File Offset: 0x0019976C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SmileyId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x0019B57C File Offset: 0x0019977C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x0019B58C File Offset: 0x0019978C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SetMoodRequest other)
		{
			return true;
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x0019B59C File Offset: 0x0019979C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x0019B5AC File Offset: 0x001997AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x0019B5BC File Offset: 0x001997BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x0019B5CC File Offset: 0x001997CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x0019B5DC File Offset: 0x001997DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x0019B5EC File Offset: 0x001997EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SetMoodRequest other)
		{
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x0019B5FC File Offset: 0x001997FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x0019B60C File Offset: 0x0019980C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x0019B61C File Offset: 0x0019981C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SetMoodRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					SetMoodRequest._parser = new MessageParser<SetMoodRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f6ff9e2a68c42fc98201e1b3e077000 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				break;
			}
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x0019B6E8 File Offset: 0x001998E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool hy1bQkOc85pXM9nZamON()
		{
			return true;
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x0019B6F0 File Offset: 0x001998F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SetMoodRequest SEJIEMOcZPaPjyT9RA5C()
		{
			return null;
		}

		// Token: 0x04000523 RID: 1315
		private static readonly MessageParser<SetMoodRequest> _parser;

		// Token: 0x04000524 RID: 1316
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000525 RID: 1317
		public const int SmileyIdFieldNumber = 1;

		// Token: 0x04000526 RID: 1318
		private int smileyId_;

		// Token: 0x04000527 RID: 1319
		internal static SetMoodRequest KPfYPOOcuqJUKN4btpyp;
	}
}
