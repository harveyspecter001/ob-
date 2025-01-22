using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social
{
	// Token: 0x0200013D RID: 317
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpouseStatusEvent : IMessage<SpouseStatusEvent>, IMessage, IEquatable<SpouseStatusEvent>, IDeepCloneable<SpouseStatusEvent>, IBufferMessage
	{
		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x0019BB84 File Offset: 0x00199D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpouseStatusEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x0019BB94 File Offset: 0x00199D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x0019BBA4 File Offset: 0x00199DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x0019BBB4 File Offset: 0x00199DB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpouseStatusEvent()
		{
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x0019BBC4 File Offset: 0x00199DC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpouseStatusEvent(SpouseStatusEvent other)
		{
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x0019BBD4 File Offset: 0x00199DD4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpouseStatusEvent Clone()
		{
			return null;
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x0019BBE4 File Offset: 0x00199DE4
		// (set) Token: 0x06000E6A RID: 3690 RVA: 0x0019BBF4 File Offset: 0x00199DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasSpouse
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

		// Token: 0x06000E6B RID: 3691 RVA: 0x0019BC04 File Offset: 0x00199E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x0019BC14 File Offset: 0x00199E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SpouseStatusEvent other)
		{
			return true;
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x0019BC24 File Offset: 0x00199E24
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x0019BC34 File Offset: 0x00199E34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x0019BC44 File Offset: 0x00199E44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x0019BC54 File Offset: 0x00199E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x0019BC64 File Offset: 0x00199E64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x0019BC74 File Offset: 0x00199E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SpouseStatusEvent other)
		{
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x0019BC84 File Offset: 0x00199E84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x0019BC94 File Offset: 0x00199E94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x0019BCA4 File Offset: 0x00199EA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SpouseStatusEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1f987a8b4f2f425eae606b8fdc16abe7 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				SpouseStatusEvent._parser = new MessageParser<SpouseStatusEvent>(() => null);
				num2 = 3;
			}
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x0019BD70 File Offset: 0x00199F70
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool U223ssOUBr4fUnTGKqLb()
		{
			return true;
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x0019BD78 File Offset: 0x00199F78
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SpouseStatusEvent o2FutKOUeaEPqXftIKB2()
		{
			return null;
		}

		// Token: 0x04000542 RID: 1346
		private static readonly MessageParser<SpouseStatusEvent> _parser;

		// Token: 0x04000543 RID: 1347
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000544 RID: 1348
		public const int HasSpouseFieldNumber = 1;

		// Token: 0x04000545 RID: 1349
		private bool hasSpouse_;

		// Token: 0x04000546 RID: 1350
		internal static SpouseStatusEvent zqPsxrOUAJ9bu3LCXNJQ;
	}
}
