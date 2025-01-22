using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange
{
	// Token: 0x02000723 RID: 1827
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeObjectModifiedInBagEvent : IMessage<ExchangeObjectModifiedInBagEvent>, IMessage, IEquatable<ExchangeObjectModifiedInBagEvent>, IDeepCloneable<ExchangeObjectModifiedInBagEvent>, IBufferMessage
	{
		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x06005976 RID: 22902 RVA: 0x00217728 File Offset: 0x00215928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeObjectModifiedInBagEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x06005977 RID: 22903 RVA: 0x00217738 File Offset: 0x00215938
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

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x06005978 RID: 22904 RVA: 0x00217748 File Offset: 0x00215948
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

		// Token: 0x06005979 RID: 22905 RVA: 0x00217758 File Offset: 0x00215958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectModifiedInBagEvent()
		{
		}

		// Token: 0x0600597A RID: 22906 RVA: 0x00217768 File Offset: 0x00215968
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectModifiedInBagEvent(ExchangeObjectModifiedInBagEvent other)
		{
		}

		// Token: 0x0600597B RID: 22907 RVA: 0x00217778 File Offset: 0x00215978
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExchangeObjectModifiedInBagEvent Clone()
		{
			return null;
		}

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x0600597C RID: 22908 RVA: 0x00217788 File Offset: 0x00215988
		// (set) Token: 0x0600597D RID: 22909 RVA: 0x00217798 File Offset: 0x00215998
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Remote
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

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x0600597E RID: 22910 RVA: 0x002177A8 File Offset: 0x002159A8
		// (set) Token: 0x0600597F RID: 22911 RVA: 0x002177B8 File Offset: 0x002159B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public ObjectItemInventory Object
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

		// Token: 0x06005980 RID: 22912 RVA: 0x002177C8 File Offset: 0x002159C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06005981 RID: 22913 RVA: 0x002177D8 File Offset: 0x002159D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ExchangeObjectModifiedInBagEvent other)
		{
			return true;
		}

		// Token: 0x06005982 RID: 22914 RVA: 0x002177E8 File Offset: 0x002159E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005983 RID: 22915 RVA: 0x002177F8 File Offset: 0x002159F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005984 RID: 22916 RVA: 0x00217808 File Offset: 0x00215A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06005985 RID: 22917 RVA: 0x00217818 File Offset: 0x00215A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06005986 RID: 22918 RVA: 0x00217828 File Offset: 0x00215A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06005987 RID: 22919 RVA: 0x00217838 File Offset: 0x00215A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ExchangeObjectModifiedInBagEvent other)
		{
		}

		// Token: 0x06005988 RID: 22920 RVA: 0x00217848 File Offset: 0x00215A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06005989 RID: 22921 RVA: 0x00217858 File Offset: 0x00215A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600598A RID: 22922 RVA: 0x00217868 File Offset: 0x00215A68
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ExchangeObjectModifiedInBagEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3a65ba0257d143fcafc38c637bf110f5 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_6b32edfb0eb5482ea7910c12559c9bb4 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					ExchangeObjectModifiedInBagEvent._parser = new MessageParser<ExchangeObjectModifiedInBagEvent>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600598B RID: 22923 RVA: 0x00217960 File Offset: 0x00215B60
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IOdE04Ou8dwegWMl9eIA()
		{
			return true;
		}

		// Token: 0x0600598C RID: 22924 RVA: 0x00217968 File Offset: 0x00215B68
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ExchangeObjectModifiedInBagEvent L3IctYOuZ6roDU56Pul8()
		{
			return null;
		}

		// Token: 0x04001F55 RID: 8021
		private static readonly MessageParser<ExchangeObjectModifiedInBagEvent> _parser;

		// Token: 0x04001F56 RID: 8022
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F57 RID: 8023
		public const int RemoteFieldNumber = 1;

		// Token: 0x04001F58 RID: 8024
		private bool remote_;

		// Token: 0x04001F59 RID: 8025
		public const int ObjectFieldNumber = 2;

		// Token: 0x04001F5A RID: 8026
		private ObjectItemInventory object_;

		// Token: 0x04001F5B RID: 8027
		private static ExchangeObjectModifiedInBagEvent xpwoPAOuu1dBYTLoCi4n;
	}
}
