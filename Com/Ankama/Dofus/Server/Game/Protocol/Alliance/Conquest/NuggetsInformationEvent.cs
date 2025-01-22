using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest
{
	// Token: 0x02000DAB RID: 3499
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NuggetsInformationEvent : IMessage<NuggetsInformationEvent>, IMessage, IEquatable<NuggetsInformationEvent>, IDeepCloneable<NuggetsInformationEvent>, IBufferMessage
	{
		// Token: 0x17001F47 RID: 8007
		// (get) Token: 0x0600A8A5 RID: 43173 RVA: 0x00295744 File Offset: 0x00293944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NuggetsInformationEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F48 RID: 8008
		// (get) Token: 0x0600A8A6 RID: 43174 RVA: 0x00295754 File Offset: 0x00293954
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

		// Token: 0x17001F49 RID: 8009
		// (get) Token: 0x0600A8A7 RID: 43175 RVA: 0x00295764 File Offset: 0x00293964
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

		// Token: 0x0600A8A8 RID: 43176 RVA: 0x00295774 File Offset: 0x00293974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NuggetsInformationEvent()
		{
		}

		// Token: 0x0600A8A9 RID: 43177 RVA: 0x00295784 File Offset: 0x00293984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NuggetsInformationEvent(NuggetsInformationEvent other)
		{
		}

		// Token: 0x0600A8AA RID: 43178 RVA: 0x00295794 File Offset: 0x00293994
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NuggetsInformationEvent Clone()
		{
			return null;
		}

		// Token: 0x17001F4A RID: 8010
		// (get) Token: 0x0600A8AB RID: 43179 RVA: 0x002957A4 File Offset: 0x002939A4
		// (set) Token: 0x0600A8AC RID: 43180 RVA: 0x002957B4 File Offset: 0x002939B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int NuggetsQuantity
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

		// Token: 0x0600A8AD RID: 43181 RVA: 0x002957C4 File Offset: 0x002939C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A8AE RID: 43182 RVA: 0x002957D4 File Offset: 0x002939D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(NuggetsInformationEvent other)
		{
			return true;
		}

		// Token: 0x0600A8AF RID: 43183 RVA: 0x002957E4 File Offset: 0x002939E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A8B0 RID: 43184 RVA: 0x002957F4 File Offset: 0x002939F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A8B1 RID: 43185 RVA: 0x00295804 File Offset: 0x00293A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A8B2 RID: 43186 RVA: 0x00295814 File Offset: 0x00293A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A8B3 RID: 43187 RVA: 0x00295824 File Offset: 0x00293A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A8B4 RID: 43188 RVA: 0x00295834 File Offset: 0x00293A34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(NuggetsInformationEvent other)
		{
		}

		// Token: 0x0600A8B5 RID: 43189 RVA: 0x00295844 File Offset: 0x00293A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A8B6 RID: 43190 RVA: 0x00295854 File Offset: 0x00293A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A8B7 RID: 43191 RVA: 0x00295864 File Offset: 0x00293A64
		[MethodImpl(MethodImplOptions.NoInlining)]
		static NuggetsInformationEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				NuggetsInformationEvent._parser = new MessageParser<NuggetsInformationEvent>(() => null);
				num2 = 2;
			}
		}

		// Token: 0x0600A8B8 RID: 43192 RVA: 0x00295930 File Offset: 0x00293B30
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool c4lISfJl7UeiLv5jVjy4()
		{
			return true;
		}

		// Token: 0x0600A8B9 RID: 43193 RVA: 0x00295938 File Offset: 0x00293B38
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static NuggetsInformationEvent s6Ir1FJlTbj7KcQrpoMQ()
		{
			return null;
		}

		// Token: 0x04003E04 RID: 15876
		private static readonly MessageParser<NuggetsInformationEvent> _parser;

		// Token: 0x04003E05 RID: 15877
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E06 RID: 15878
		public const int NuggetsQuantityFieldNumber = 1;

		// Token: 0x04003E07 RID: 15879
		private int nuggetsQuantity_;

		// Token: 0x04003E08 RID: 15880
		internal static NuggetsInformationEvent pAJd5fJlQSRgYP4MQIR8;
	}
}
