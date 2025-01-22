using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount
{
	// Token: 0x02000371 RID: 881
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MountSterilizedEvent : IMessage<MountSterilizedEvent>, IMessage, IEquatable<MountSterilizedEvent>, IDeepCloneable<MountSterilizedEvent>, IBufferMessage
	{
		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06002957 RID: 10583 RVA: 0x001C79D0 File Offset: 0x001C5BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MountSterilizedEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06002958 RID: 10584 RVA: 0x001C79E0 File Offset: 0x001C5BE0
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

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06002959 RID: 10585 RVA: 0x001C79F0 File Offset: 0x001C5BF0
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

		// Token: 0x0600295A RID: 10586 RVA: 0x001C7A00 File Offset: 0x001C5C00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountSterilizedEvent()
		{
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x001C7A10 File Offset: 0x001C5C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountSterilizedEvent(MountSterilizedEvent other)
		{
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x001C7A20 File Offset: 0x001C5C20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountSterilizedEvent Clone()
		{
			return null;
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x0600295D RID: 10589 RVA: 0x001C7A30 File Offset: 0x001C5C30
		// (set) Token: 0x0600295E RID: 10590 RVA: 0x001C7A40 File Offset: 0x001C5C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MountId
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

		// Token: 0x0600295F RID: 10591 RVA: 0x001C7A50 File Offset: 0x001C5C50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x001C7A60 File Offset: 0x001C5C60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MountSterilizedEvent other)
		{
			return true;
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x001C7A70 File Offset: 0x001C5C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x001C7A80 File Offset: 0x001C5C80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x001C7A90 File Offset: 0x001C5C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x001C7AA0 File Offset: 0x001C5CA0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x001C7AB0 File Offset: 0x001C5CB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x001C7AC0 File Offset: 0x001C5CC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MountSterilizedEvent other)
		{
		}

		// Token: 0x06002967 RID: 10599 RVA: 0x001C7AD0 File Offset: 0x001C5CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002968 RID: 10600 RVA: 0x001C7AE0 File Offset: 0x001C5CE0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x001C7AF0 File Offset: 0x001C5CF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MountSterilizedEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b5875490973242449a65803c917e0e70 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					MountSterilizedEvent._parser = new MessageParser<MountSterilizedEvent>(() => null);
					num2 = 3;
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x001C7BD4 File Offset: 0x001C5DD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yCs2LTOr3u2qOtos4BPX()
		{
			return true;
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x001C7BDC File Offset: 0x001C5DDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MountSterilizedEvent r1lSY7OrR6SMbD8Vuelu()
		{
			return null;
		}

		// Token: 0x04000EA5 RID: 3749
		private static readonly MessageParser<MountSterilizedEvent> _parser;

		// Token: 0x04000EA6 RID: 3750
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000EA7 RID: 3751
		public const int MountIdFieldNumber = 1;

		// Token: 0x04000EA8 RID: 3752
		private int mountId_;

		// Token: 0x04000EA9 RID: 3753
		private static MountSterilizedEvent cEMEeGOrevrWbSkRmrAR;
	}
}
