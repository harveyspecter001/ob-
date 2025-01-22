using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information
{
	// Token: 0x02000D6A RID: 3434
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceFactsErrorEvent : IMessage<AllianceFactsErrorEvent>, IMessage, IEquatable<AllianceFactsErrorEvent>, IDeepCloneable<AllianceFactsErrorEvent>, IBufferMessage
	{
		// Token: 0x17001EBB RID: 7867
		// (get) Token: 0x0600A574 RID: 42356 RVA: 0x002908F4 File Offset: 0x0028EAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AllianceFactsErrorEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EBC RID: 7868
		// (get) Token: 0x0600A575 RID: 42357 RVA: 0x00290904 File Offset: 0x0028EB04
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

		// Token: 0x17001EBD RID: 7869
		// (get) Token: 0x0600A576 RID: 42358 RVA: 0x00290914 File Offset: 0x0028EB14
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

		// Token: 0x0600A577 RID: 42359 RVA: 0x00290924 File Offset: 0x0028EB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFactsErrorEvent()
		{
		}

		// Token: 0x0600A578 RID: 42360 RVA: 0x00290934 File Offset: 0x0028EB34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFactsErrorEvent(AllianceFactsErrorEvent other)
		{
		}

		// Token: 0x0600A579 RID: 42361 RVA: 0x00290944 File Offset: 0x0028EB44
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFactsErrorEvent Clone()
		{
			return null;
		}

		// Token: 0x17001EBE RID: 7870
		// (get) Token: 0x0600A57A RID: 42362 RVA: 0x00290954 File Offset: 0x0028EB54
		// (set) Token: 0x0600A57B RID: 42363 RVA: 0x00290964 File Offset: 0x0028EB64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string AllianceUuid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600A57C RID: 42364 RVA: 0x00290974 File Offset: 0x0028EB74
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A57D RID: 42365 RVA: 0x00290984 File Offset: 0x0028EB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceFactsErrorEvent other)
		{
			return true;
		}

		// Token: 0x0600A57E RID: 42366 RVA: 0x00290994 File Offset: 0x0028EB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A57F RID: 42367 RVA: 0x002909A4 File Offset: 0x0028EBA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A580 RID: 42368 RVA: 0x002909B4 File Offset: 0x0028EBB4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A581 RID: 42369 RVA: 0x002909C4 File Offset: 0x0028EBC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A582 RID: 42370 RVA: 0x002909D4 File Offset: 0x0028EBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A583 RID: 42371 RVA: 0x002909E4 File Offset: 0x0028EBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceFactsErrorEvent other)
		{
		}

		// Token: 0x0600A584 RID: 42372 RVA: 0x002909F4 File Offset: 0x0028EBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A585 RID: 42373 RVA: 0x00290A04 File Offset: 0x0028EC04
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A586 RID: 42374 RVA: 0x00290A14 File Offset: 0x0028EC14
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceFactsErrorEvent()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b83b2acd599549429d401345bd5187dd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AllianceFactsErrorEvent._parser = new MessageParser<AllianceFactsErrorEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 4;
			}
		}

		// Token: 0x0600A587 RID: 42375 RVA: 0x00290AE0 File Offset: 0x0028ECE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool R0icIiJkkcIlpTaBFM9G()
		{
			return true;
		}

		// Token: 0x0600A588 RID: 42376 RVA: 0x00290AE8 File Offset: 0x0028ECE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceFactsErrorEvent wO242jJklhj2ht5LUxAF()
		{
			return null;
		}

		// Token: 0x04003CFE RID: 15614
		private static readonly MessageParser<AllianceFactsErrorEvent> _parser;

		// Token: 0x04003CFF RID: 15615
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D00 RID: 15616
		public const int AllianceUuidFieldNumber = 1;

		// Token: 0x04003D01 RID: 15617
		private string allianceUuid_;

		// Token: 0x04003D02 RID: 15618
		private static AllianceFactsErrorEvent fFeoIFJkI3KFSJGWALWT;
	}
}
